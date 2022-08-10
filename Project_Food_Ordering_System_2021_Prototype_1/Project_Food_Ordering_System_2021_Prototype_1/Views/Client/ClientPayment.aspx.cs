using System;
using System.Data;
using System.Collections.Generic;
using Project_Food_Ordering_System_2021_Prototype_1.Controllers;
using Project_Food_Ordering_System_2021_Prototype_1.Models;

namespace Project_Food_Ordering_System_2021_Prototype_1.Views.Client
{
    public partial class ClientPayment : System.Web.UI.Page
    {
        PaymentPersistenceManager paymentManager = new PaymentPersistenceManager();
        OrderPersistenceManager orderManager = new OrderPersistenceManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            Student userTemp = (Student)Session["User"];

            GridView1.DataSource = userTemp.userCart.itemsList;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            Student userTemp = (Student)Session["User"];

            if (e.Row.RowType == System.Web.UI.WebControls.DataControlRowType.Footer)
            {
                e.Row.Cells[3].Text = "Total: " + userTemp.userCart.getTotal().ToString("C2");
            }

        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            Student userTemp = (Student)Session["User"];

            Order newOrder = new Order(
                    userTemp.userCart.getTotal(),
                    userTemp.User_ID,
                    DateTime.Now, userTemp.userCart);

            Guid orderGuid = orderManager.insertOrder(newOrder);
            Order payOrder = orderManager.findOrderGuid(orderGuid);

            Payment newPayment = new Payment(payOrder.Total_Amount, payOrder.Order_Id, payOrder.Order_Date, payOrder.Order_Number);
            paymentManager.insertPayment(newPayment);

            userTemp.userCart.clearCart();

            Response.Redirect("/Views/Home/HomePage.aspx");

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Client/Basket.aspx");
        }
    }
}