using System;
using System.Collections.Generic;
using Project_Food_Ordering_System_2021_Prototype_1.Controllers;
using Project_Food_Ordering_System_2021_Prototype_1.Models;

namespace Project_Food_Ordering_System_2021_Prototype_1.Views.Client
{
    public partial class ClientPlacedOrders : System.Web.UI.Page
    {
        OrderPersistenceManager orderManager = new OrderPersistenceManager();
        OrderItemPersistenceManager orderItemManager = new OrderItemPersistenceManager();
        ItemPersistenceManager itemManager = new ItemPersistenceManager();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Student userTemp = (Student)Session["User"];

            GridView1.DataSource = orderManager.findStudentOrders(userTemp.User_ID);
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
            Student userTemp = (Student)Session["User"];

            List<Order> orders = orderManager.findStudentOrders(userTemp.User_ID);
            List<OrderItems> orderItems = orderItemManager.findOrderID(orders[GridView1.SelectedIndex].Order_Id);

            foreach (OrderItems i in orderItems)
            {
                Item tempItem = itemManager.findItemID(i.Item_ID);
                
                List<string> temp = new List<string>();
                temp.Add(tempItem.Item_Name);
                temp.Add(i.Quantity.ToString());
                lstOutput.Items.Add(tempItem.Item_Name + " x " + i.Quantity);
            }

        }
    }
}