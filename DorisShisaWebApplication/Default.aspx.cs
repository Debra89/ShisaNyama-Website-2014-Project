using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DorisShisaWebApplication.ServiceReference1;
namespace DorisShisaWebApplication
{
    public partial class _Default : Page
    {/*! 
   this is the first page the visitor gets into contact with
       */
        protected void Page_Load(object sender, EventArgs e)
        {
            PageVisit PagevisitTable = new PageVisit();
            PagevisitTable.PageName = "HomePage";
            Service1Client client = new Service1Client();
            string result = client.InsertPageVisit(PagevisitTable);
            

            
        }
    }
}