using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DorisShisaWebApplication.ServiceReference1;
namespace DorisShisaWebApplication
{
    public partial class AdminDeleteEmployees : System.Web.UI.Page
    { /*! 
    Allow the admin to delete employees from the database
       */
        private string SearchString = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //connect to the db


            }
            if (Session["authenticated"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }
             protected void imgDel_Command(object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {

            WebUsers WebUsers = new WebUsers();
            Service1Client client = new Service1Client();
            WebUsers.Email = e.CommandArgument.ToString();

            if (client.DeleteUserRegDetails(WebUsers) == true)
            {

                lblStatus.Text = "Record deleted Successfully";

            }

            else
            {

                lblStatus.Text = "Record couldn't be deleted";

            }

            gvDetails.DataBind();

        }


        public string HighlightText(string InputTxt)
        {

            string Search_Str = txtSearch.Text;

            // Setup the regular expression and add the Or operator.

            Regex RegExp = new Regex(Search_Str.Replace(" ", "|").Trim(), RegexOptions.IgnoreCase);

            // Highlight keywords by calling the 

            //delegate each time a keyword is found.

            return RegExp.Replace(InputTxt, new MatchEvaluator(ReplaceKeyWords));

        }




        public string ReplaceKeyWords(Match m)
        {

            return ("<span class=highlight>" + m.Value + "</span>");

        }
       

        protected void cmdSearch_Click(object sender, EventArgs e)
        {
            SearchString = txtSearch.Text;

        }

        protected void cmdClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";

            SearchString = "";

            gvDetails.DataBind();
        }
    }
}