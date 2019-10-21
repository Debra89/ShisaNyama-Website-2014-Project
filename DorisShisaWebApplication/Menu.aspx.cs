using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DorisShisaWebApplication.ServiceReference1;
namespace DorisShisaWebApplication
{
    public partial class Menu : System.Web.UI.Page
    {/*! 
    allow the visitors to view menu
       */
        protected void Page_Load(object sender, EventArgs e)
        {
            PageVisit PagevisitTable = new PageVisit();
            PagevisitTable.PageName = "Menu";
            Service1Client client = new Service1Client();
            string result = client.InsertPageVisit(PagevisitTable);
        }

        protected void cmdorder1_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterOrder.aspx");
        }

        protected void cmdorder2_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterOrder.aspx");
        }

        protected void cmdorder3_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterOrder.aspx");
        }

        protected void cmdorder4_Click(object sender, EventArgs e)
        {

        }

        protected void cmdorder5_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterOrder.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterOrder.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterOrder.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterOrder.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterOrder.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterOrder.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterOrder.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterOrder.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterOrder.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterOrder.aspx");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterOrder.aspx");
        }
    }
}