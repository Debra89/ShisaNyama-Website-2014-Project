using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DorisShisaWebApplication
{
    public partial class CusMaster : System.Web.UI.MasterPage
    {/*! 
  customer master page hold every page that the customer will get into contact with.
       */
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["authenticated"] != null)
            {


            }
            else
            {
                Response.Redirect("Login.aspx");

            }

            if (!Page.IsPostBack)
            {
                Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.Cache.SetNoStore();
            }
        }
    }
}