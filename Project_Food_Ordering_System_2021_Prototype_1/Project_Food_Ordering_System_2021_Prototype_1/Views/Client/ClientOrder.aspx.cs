using System;
using System.Collections.Generic;
using Project_Food_Ordering_System_2021_Prototype_1.Models;
using Project_Food_Ordering_System_2021_Prototype_1.Controllers;

namespace Project_Food_Ordering_System_2021_Prototype_1.Client
{
    public partial class ClientOrder : System.Web.UI.Page
    {
        ItemPersistenceManager itemManager = new ItemPersistenceManager();
        StockPersistenceManager stockManager = new StockPersistenceManager();

        private void UpdateList(string[] items)
        {
            ListBox1.Items.Clear();
            foreach (string x in items)
            {
                ListBox1.Items.Add(x);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["User"] != null)
                {
                    User userTemp = (User)Session["User"];
                    Session["Products"] = itemManager.getAll();
                    UpdateList(((Student)userTemp).userCart.ProductList());
                    btnPlaceOrder.Visible = true;
                    lblWelcome.Text = "Welcome " + userTemp.User_Name;
                    lblWelcome.Visible = true;
                    GridView1.DataSource = itemManager.getAll();
                    GridView1.DataBind();
                }

                GridView1.DataSource = itemManager.getAll();
                GridView1.DataBind();
            }
        }

        protected void btnDrinks_Click(object sender, EventArgs e)
        {
            Session["Products"] = itemManager.findCategory("Drink");
            GridView1.DataSource = itemManager.findCategory("Drink");
            GridView1.DataBind();
        }

        protected void btnSnacks_Click(object sender, EventArgs e)
        {
            Session["Products"] = itemManager.findCategory("Snack");
            GridView1.DataSource = itemManager.findCategory("Snack");
            GridView1.DataBind();
        }

        protected void btnFastFood_Click(object sender, EventArgs e)
        {
            Session["Products"] = itemManager.findCategory("Fast Food");
            GridView1.DataSource = itemManager.findCategory("Fast Food");
            GridView1.DataBind();
        }

        protected void btnEssentials_Click(object sender, EventArgs e)
        {
            Session["Products"] = itemManager.findCategory("Essential");
            GridView1.DataSource = itemManager.findCategory("Essential");
            GridView1.DataBind();
        }

        protected void btnTest_Click(object sender, EventArgs e)
        {
            Response.Redirect("Basket.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            User userTemp = (User)Session["User"];

            List<Item> LstProdTemp = (List<Item>)Session["Products"];
            if (userTemp != null)
            {
                ((Student)userTemp).userCart.addItem(LstProdTemp[GridView1.SelectedIndex]);
                Session["User"] = userTemp;
                UpdateList(((Student)userTemp).userCart.ProductList());
            }
            else
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("Login to add items to basket");
            }
        }
    }
}
