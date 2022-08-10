using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using Project_Food_Ordering_System_2021_Prototype_1.Controllers;
using Project_Food_Ordering_System_2021_Prototype_1.Models;

namespace Project_Food_Ordering_System_2021_Prototype_1.Views.Admin
{
    public partial class AdminMaintain_ProductsAndPrices : System.Web.UI.Page
    {
        private ItemPersistenceManager itemManager = new ItemPersistenceManager();
        private StockPersistenceManager stockManager = new StockPersistenceManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = itemManager.getAll();
                GridView1.DataBind();
            }
        }

        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            bool price = String.IsNullOrEmpty(txtNewPrice.Text);
            bool name = String.IsNullOrEmpty(txtNewName.Text);

            double itemPrice = 0;
            if (!price && !name)
            {
                if (double.TryParse(txtNewPrice.Text, out itemPrice))
                {
                    Item item = new Item(itemPrice, txtNewName.Text, DropDownList1.SelectedValue);
                    itemManager.insertItem(item);

                    item = itemManager.findItem(txtNewName.Text);

                    Stock newStock = new Stock(item.Item_ID, 0);
                    stockManager.insertStock(newStock);

                    txtNewName.Text = "";
                    txtNewPrice.Text = "";
                    loadGrid();
                }
            }
            
        }

        private void loadGrid()
        {
            GridView1.DataSource = itemManager.getAll();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, System.Web.UI.WebControls.GridViewDeleteEventArgs e)
        {
            Label itemID = GridView1.Rows[e.RowIndex].FindControl("lblItem_ID") as Label;
            itemManager.removeItem(new Guid(itemID.Text));
            loadGrid();
        }

        protected void GridView1_RowUpdated(object sender, System.Web.UI.WebControls.GridViewUpdatedEventArgs e)
        {
            
        }

        protected void btnFindProduct_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtSearch.Text))
            {
                List<Item> items = new List<Item> { };
                items.Add(itemManager.findItem(txtSearch.Text));
                GridView1.DataSource = items;
                GridView1.DataBind();
            }
            else
            {
                loadGrid();
            }
        }

        protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
        }

        protected void GridView1_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
            Label itemID = GridView1.Rows[e.RowIndex].FindControl("lblItem_ID") as Label;
            TextBox name = GridView1.Rows[e.RowIndex].FindControl("txtItem_Name") as TextBox;
            TextBox price = GridView1.Rows[e.RowIndex].FindControl("txtItem_Price") as TextBox;
            TextBox category = GridView1.Rows[e.RowIndex].FindControl("txtCategory") as TextBox;

            Item item = new Item(new Guid(itemID.Text), Double.Parse(price.Text), name.Text, category.Text);
            itemManager.updateItem(item);
            GridView1.EditIndex = -1;
            loadGrid();
        }

        protected void GridView1_RowCancelingEdit(object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            loadGrid();
        }

        protected void GridView1_RowDeleted(object sender, System.Web.UI.WebControls.GridViewDeletedEventArgs e)
        {

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Admin/AdminSelection.aspx");
        }
    }
}