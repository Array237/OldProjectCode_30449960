using System;
using System.Collections.Generic;
using Project_Food_Ordering_System_2021_Prototype_1.Models;
using Project_Food_Ordering_System_2021_Prototype_1.Controllers;

namespace Project_Food_Ordering_System_2021_Prototype_1
{
    public partial class StaffOrderProcessing : System.Web.UI.Page
    {
        OrderPersistenceManager orderManager = new OrderPersistenceManager();
        OrderItemPersistenceManager orderItemManager = new OrderItemPersistenceManager();
        ItemPersistenceManager itemManager = new ItemPersistenceManager();

        private void populateListBoxes()
        {
            List<Order> orders = orderManager.getAllByDateRange(DateTime.Now, DateTime.Now);
            string[] arrString = new string[orders.Count];

            lstNewOrder.Items.Add("Order ID - Status");
            lstNewOrder.Items.Add("--------------------------------------------------------");

            lstInProgress.Items.Add("Order ID - Status");
            lstInProgress.Items.Add("--------------------------------------------------------");

            lstCompleted.Items.Add("Order ID - Status");
            lstCompleted.Items.Add("--------------------------------------------------------");


            for (int i = 0; i < orders.Count; i++)
            {
                arrString[i] = $"{orders[i].Order_Number} - {orders[i].Order_Status}";

                if (orders[i].Order_Status == "New")
                {
                    lstNewOrder.Items.Add(arrString[i]);
                }
                else if (orders[i].Order_Status == "Processing")
                {
                    lstInProgress.Items.Add(arrString[i]);
                }
                else
                {
                    lstCompleted.Items.Add(arrString[i]);
                }

            }

            Session["Orders"] = orders;
        }

        private void clearListBoxes()
        {
            lstCompleted.Items.Clear();
            lstInProgress.Items.Clear();
            lstNewOrder.Items.Clear();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                populateListBoxes();
                List<Order> tempNewOrders = orderManager.FindOrderByStatusAndDateRange(DateTime.Now, DateTime.Now, "New");
                lblDate.Text = "Showing orders for " + DateTime.Now.ToString("dd-MM-yy");
            }
        }

        protected void btnStartProcessing_Click(object sender, EventArgs e)
        {
            
            if (lstNewOrder.SelectedIndex > 1)
            {
                List<Order> tempOrders = orderManager.FindOrderByStatusAndDateRange(DateTime.Now, DateTime.Now, "New");
                orderManager.updateOrderStatus(tempOrders[lstNewOrder.SelectedIndex - 2], "Processing");
                clearListBoxes();
                populateListBoxes();
                Session["newOrders"] = tempOrders;
            }
        }

        protected void btnStartProcessing0_Click(object sender, EventArgs e)
        {
            if (lstInProgress.SelectedIndex > 1)
            {
                List<Order> tempOrders = orderManager.FindOrderByStatusAndDateRange(DateTime.Now, DateTime.Now, "Processing");
                orderManager.updateOrderStatus(tempOrders[lstInProgress.SelectedIndex - 2], "Completed");
                clearListBoxes();
                populateListBoxes();
            }
        }

        protected void lstNewOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void btnViewOrder_Click(object sender, EventArgs e)
        {
            List<Order> tempOrders = orderManager.FindOrderByStatusAndDateRange(DateTime.Now, DateTime.Now, "New");
            if (lstNewOrder.SelectedIndex > 1)
            {
                Database.DatabaseOperations.LoadToTable("SELECT ItemTable.Item_Name,OrderItemTable.Item_Quantity FROM ItemTable " +
                $"INNER JOIN OrderItemTable ON (ItemTable.Item_ID = OrderItemTable.Item_ID) AND " +
                $"(OrderItemTable.Order_ID = '{tempOrders[lstNewOrder.SelectedIndex - 2].Order_Id}') ", ref GridView1);
            }

            /*lstOutput.Items.Clear();
            List<Order> tempOrders = orderManager.FindOrderByStatusAndDateRange(DateTime.Now, DateTime.Now, "New");
            List<List<string>> Values = new List<List<string>>();
            if (lstNewOrder.SelectedIndex > 1)
            {
                List<OrderItems> orderItems = orderItemManager.findOrderID(tempOrders[lstNewOrder.SelectedIndex - 2].Order_Id);

                
                foreach (OrderItems i in orderItems)
                {
                    Item tempItem = itemManager.findItemID(i.Item_ID);
                    if (tempItem.Category == "Fast Food")
                    {
                        List<string> temp = new List<string>();
                        temp.Add(tempItem.Item_Name);
                        temp.Add(i.Quantity.ToString());
                        Values.Add(temp);
                        lstOutput.Items.Add(tempItem.Item_Name + " x " + i.Quantity);
                    }
                }
                GridView1.DataSource = Values[];
                GridView1.DataBind();
            }*/
        }

        protected void btnViewProOrder_Click(object sender, EventArgs e)
        {
            //lstOutput.Items.Clear();
            List<Order> tempOrders = orderManager.FindOrderByStatusAndDateRange(DateTime.Now, DateTime.Now, "Processing");

            if (lstInProgress.SelectedIndex > 1)
            {
                Database.DatabaseOperations.LoadToTable("SELECT ItemTable.Item_Name,OrderItemTable.Item_Quantity FROM ItemTable " +
                $"INNER JOIN OrderItemTable ON (ItemTable.Item_ID = OrderItemTable.Item_ID) AND " +
                $"(OrderItemTable.Order_ID = '{tempOrders[lstInProgress.SelectedIndex - 2].Order_Id}') ", ref GridView1);
            }

            //if (lstInProgress.SelectedIndex > 1)
            //{
            //    List<OrderItems> orderItems = orderItemManager.findOrderID(tempOrders[lstInProgress.SelectedIndex - 2].Order_Id);

            //    foreach (OrderItems i in orderItems)
            //    {
            //        Item tempItem = itemManager.findItemID(i.Item_ID);
            //        if (tempItem.Category == "Fast Food")
            //        {
            //            lstOutput.Items.Add(tempItem.Item_Name + " x " + i.Quantity);
            //            //displayList.Add(tempItem);
            //        }
            //    }
            //}
        }

        protected void btnViewCompleteOrder_Click(object sender, EventArgs e)
        {
            //lstOutput.Items.Clear();
            List<Order> tempOrders = orderManager.FindOrderByStatusAndDateRange(DateTime.Now, DateTime.Now, "Completed");

            if (lstCompleted.SelectedIndex > 1)
            {
                Database.DatabaseOperations.LoadToTable("SELECT ItemTable.Item_Name,OrderItemTable.Item_Quantity FROM ItemTable " +
                $"INNER JOIN OrderItemTable ON (ItemTable.Item_ID = OrderItemTable.Item_ID) AND " +
                $"(OrderItemTable.Order_ID = '{tempOrders[lstCompleted.SelectedIndex - 2].Order_Id}') ", ref GridView1);
            }

            //if (lstCompleted.SelectedIndex > 1)
            //{
            //    List<OrderItems> orderItems = orderItemManager.findOrderID(tempOrders[lstCompleted.SelectedIndex - 2].Order_Id);

            //    foreach (OrderItems i in orderItems)
            //    {
            //        Item tempItem = itemManager.findItemID(i.Item_ID);
            //        lstOutput.Items.Add(tempItem.Item_Name + " " + tempItem.Item_Price + " x " + i.Quantity);
            //    }
            //}
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Staff/StaffSelectionPage.aspx");
        }
    }
}