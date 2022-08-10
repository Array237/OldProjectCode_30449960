using System;
using System.Collections.Generic;
using Project_Food_Ordering_System_2021_Prototype_1.Models;
using Project_Food_Ordering_System_2021_Prototype_1.Controllers;

namespace Project_Food_Ordering_System_2021_Prototype_1
{
    public partial class Basket : System.Web.UI.Page
    {
        OrderPersistenceManager orderManager = new OrderPersistenceManager();
        public void viewBasket()
        {
            Student userTemp = (Student)Session["User"];

            foreach (string i in userTemp.userCart.ProductList())
            {
                ListBox1.Items.Add(i);
            }

            if (userTemp.userCart.itemsList.Count > 0)
            {
                ListBox1.Items.Add("--------------------------------------------------------");
                ListBox1.Items.Add("Total: " + userTemp.userCart.getTotal().ToString("C"));
            }
            else
            {
                ListBox1.Items.Add("Your Basket is empty");
            }
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Student userTemp = (Student)Session["User"];

                if (userTemp != null)
                  {
                    foreach (string i in userTemp.userCart.ProductList())
                    {
                        ListBox1.Items.Add(i);
                    }

                    if (((Student)userTemp).userCart.itemsList.Count > 0)
                    {
                        ListBox1.Items.Add("-------------------------------------------------------------------------------------------------");
                        ListBox1.Items.Add("Total: " + userTemp.userCart.getTotal().ToString("C"));
                    }
                    else
                    {
                        ListBox1.Items.Add("Your Basket is empty");
                    }
                }
            }
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            Student userTemp = (Student)Session["User"];

            if (ListBox1.SelectedIndex != -1)
            {
                if (ListBox1.SelectedIndex < ListBox1.Items.Count - 2)
                {
                    userTemp.userCart.RemoveItem(userTemp.userCart.itemsList[ListBox1.SelectedIndex].item);
                    ListBox1.Items.Clear();
                    viewBasket();
                }
            }
        }

        protected void btnDecrease_Click(object sender, EventArgs e)
        {
            Student userTemp = (Student)Session["User"];

            if (ListBox1.SelectedIndex != -1)
            {
                if (ListBox1.SelectedIndex < ListBox1.Items.Count - 2)
                {
                    userTemp.userCart.DecreaseItem(userTemp.userCart.itemsList[ListBox1.SelectedIndex].item);
                    ListBox1.Items.Clear();
                    viewBasket();
                }
            }
            
        }

        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            Student userTemp = (Student)Session["User"];

            if (userTemp.userCart.itemsList.Count > 0)
            {
                Response.Redirect("/Views/Client/ClientPayment.aspx");
            }
        }
    }
}