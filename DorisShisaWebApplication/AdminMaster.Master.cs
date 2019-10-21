using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DorisShisaWebApplication
{
    public partial class AdminMaster : System.Web.UI.MasterPage
    { /*! 
    this page is the admin master page which welcomes the admin after logging in
       */
        protected void Page_Load(object sender, EventArgs e)
        {
           Label1.Visible = false;
            if (Session["authenticated"] != null)
            {
                welcome.Text = Session["Email"].ToString();
                Label1.Text = "[Administrator]".ToString();
                Label1.Visible = true;
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
