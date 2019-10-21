using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DorisShisaWebApplication.ServiceReference1;
namespace DorisShisaWebApplication
{
    public partial class ProductDetails : System.Web.UI.Page
    {/*! 
    allow visitor to view product details after viewing the promotion page
       */
        protected void Page_Load(object sender, EventArgs e)
        {
            PageVisit PagevisitTable = new PageVisit();
            PagevisitTable.PageName = "PromotionDetails";
            Service1Client client = new Service1Client();
            string result = client.InsertPageVisit(PagevisitTable);
        }
    }
}