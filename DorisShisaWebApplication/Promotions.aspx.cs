using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DorisShisaWebApplication.ServiceReference1;
namespace DorisShisaWebApplication
{
    public partial class Promotions : System.Web.UI.Page
    {/*! 
    allow the visitor to view promotions
       */
        protected void Page_Load(object sender, EventArgs e)
        {
            PageVisit PagevisitTable = new PageVisit();
            PagevisitTable.PageName = "Promotions";
            Service1Client client = new Service1Client();
            string result = client.InsertPageVisit(PagevisitTable);
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("RegisterOrder.aspx");
        }
        protected void cmdAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterOrder.aspx");
        }

    }
}