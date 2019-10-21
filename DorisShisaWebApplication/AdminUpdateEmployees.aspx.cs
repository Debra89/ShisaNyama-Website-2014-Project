using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DorisShisaWebApplication.ServiceReference1;
namespace DorisShisaWebApplication
{
    public partial class AdminUpdateEmployees : System.Web.UI.Page
    { /*! 
    Allow the admin to update employees 
       */
        public static String autoPassword = AutoGeneratePassword.generatePassword();
        private string SearchString = "";
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {

                //BindRegRecordsInGrid();

            }
        }
        //private void BindRegRecordsInGrid()
        //{

        //    DataSet ds = new DataSet();

        //    ds = client.GetUserRegDetails();

        //    grdEmployees.DataSource = ds;

        //    grdEmployees.DataBind();

        //}

        protected void cmdSearch_Click(object sender, EventArgs e)
        {
            SearchString = txtSearch.Text;
        }

        protected void cmdClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";

            SearchString = "";

            grdEmployees.DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnSubmit.Text == "Update")
            {

                UpdateRegDetails();

            }


        }

        private void UpdateRegDetails()
        {

            WebUsers WebUsers = new WebUsers();

            WebUsers.Email = (ViewState["Email"].ToString());


            WebUsers.Name = TxtName.Text.Trim();
            WebUsers.Surname = Txtsurname.Text.Trim();
            WebUsers.Cell = Txtcell.Text.Trim();



            client.UpdateUserRegDetails(WebUsers);

            lblStatus.Text = client.UpdateUserRegDetails(WebUsers);

            ClearControls();

            grdEmployees.DataBind();

        }
        private void ClearControls()
        {



            TxtName.Text = string.Empty;

            Txtsurname.Text = string.Empty;

            Txtcell.Text = string.Empty;





            btnSubmit.Text = "Submit";

            TxtName.Focus();

        }

        protected void imgEdit_Command(object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {
            WebUsers WebUsers = new WebUsers();

            WebUsers.Email = e.CommandArgument.ToString();

            ViewState["Email"] = WebUsers.Email;

            DataSet ds = new DataSet();

            ds = client.FetchUpdatedRecords(WebUsers);




            if (ds.Tables[0].Rows.Count > 0)
            {

                TxtName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                Txtsurname.Text = ds.Tables[0].Rows[0]["Surname"].ToString();
                Txtcell.Text = ds.Tables[0].Rows[0]["Cell"].ToString();


                btnSubmit.Text = "Update";

            }

        }


        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();

            lblStatus.Text = string.Empty;
        }
    }
}