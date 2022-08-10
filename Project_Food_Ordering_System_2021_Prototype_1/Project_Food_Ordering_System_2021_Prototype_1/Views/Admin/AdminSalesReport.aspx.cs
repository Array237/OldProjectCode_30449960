using System;
using System.Collections.Generic;
using Project_Food_Ordering_System_2021_Prototype_1.Controllers;
using Project_Food_Ordering_System_2021_Prototype_1.Models;

namespace Project_Food_Ordering_System_2021_Prototype_1
{
    public partial class AdminSalesReport : System.Web.UI.Page
    {
        PaymentPersistenceManager paymentManager = new PaymentPersistenceManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = paymentManager.findPayment(DateTime.Now, DateTime.Now.AddDays(-30));
            GridView1.DataBind();
            lblDate.Text = "Current Date: " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/Admin/AdminSelection.aspx");
        }

        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            //    if (ddlDate.SelectedIndex == 0)
            //    {
            //        GridView1.DataSource = paymentManager.findPayment(DateTime.Now, DateTime.Now.AddDays(-30));
            //        GridView1.DataBind();
            //    }
            //    else if (ddlDate.SelectedIndex == 1)
            //    {
            //        GridView1.DataSource = paymentManager.findPayment(DateTime.Now, DateTime.Now.AddDays(-90));
            //        GridView1.DataBind();
            //    }
            //    else if(ddlDate.SelectedIndex == 2)
            //    {
            //        GridView1.DataSource = paymentManager.findPayment(DateTime.Now, DateTime.Now.AddDays(-180));
            //        GridView1.DataBind();
            //    }
            bool isStart = String.IsNullOrEmpty(txtStartDate.Text);
            bool isEnd = String.IsNullOrEmpty(txtEndDate.Text);

            if (!isStart && !isEnd)
            {
                DateTime startDate = DateTime.Parse(txtStartDate.Text);
                DateTime endDate = DateTime.Parse(txtEndDate.Text);

                GridView1.DataSource = paymentManager.findPayment(startDate, endDate);
                GridView1.DataBind();
                lblError.Visible = false;
            }
            else 
            {
                lblError.Visible = true;
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            List<Payment> paymentList;
            double sum = 0;

            //if (ddlDate.SelectedIndex == 0)
            //{
            //    paymentList = paymentManager.findPayment(DateTime.Now, DateTime.Now.AddDays(-30));
            //    foreach (Payment i in paymentList)
            //    {
            //        sum += i.Total_Amount;
            //    }
            //    if (e.Row.RowType == System.Web.UI.WebControls.DataControlRowType.Footer)
            //    {
            //        e.Row.Cells[3].Text = "Total Sales: " + sum.ToString("C2");
            //    }
            //}
            //else if (ddlDate.SelectedIndex == 1)
            //{
            //    paymentList = paymentManager.findPayment(DateTime.Now, DateTime.Now.AddDays(-90));
            //    foreach (Payment i in paymentList)
            //    {
            //        sum += i.Total_Amount;
            //    }
            //    if (e.Row.RowType == System.Web.UI.WebControls.DataControlRowType.Footer)
            //    {
            //        e.Row.Cells[3].Text = "Total Sales: " + sum.ToString("C2");
            //    }
            //}
            //else if (ddlDate.SelectedIndex == 2)
            //{
            //    paymentList = paymentManager.findPayment(DateTime.Now, DateTime.Now.AddDays(-180));
            //    foreach (Payment i in paymentList)
            //    {
            //        sum += i.Total_Amount;
            //    }
            //    if (e.Row.RowType == System.Web.UI.WebControls.DataControlRowType.Footer)
            //    {
            //        e.Row.Cells[3].Text = "Total Sales: " + sum.ToString("C2");
            //    }
            //}

            bool isStart = String.IsNullOrEmpty(txtStartDate.Text);
            bool isEnd = String.IsNullOrEmpty(txtEndDate.Text);

            if (!isStart && !isEnd)
            {
                DateTime startDate = DateTime.Parse(txtStartDate.Text);
                DateTime endDate = DateTime.Parse(txtEndDate.Text);

                paymentList = paymentManager.findPayment(startDate, endDate);
                foreach (Payment i in paymentList)
                {
                    sum += i.Total_Amount;
                }
                if (e.Row.RowType == System.Web.UI.WebControls.DataControlRowType.Footer)
                {
                    e.Row.Cells[3].Text = "Total Sales: " + sum.ToString("C2");
                }
            }
        }
    }
}