using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DorisShisaWebApplication.ServiceReference1;
using System.Net.Mail;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Drawing;
using System.Text.RegularExpressions;
namespace DorisShisaWebApplication
{
    public partial class AdminViewAssignedBookingTask : System.Web.UI.Page
    { /*! 
    Allow the admin to view assigned booking task from the database
       */
        private string SearchString = "";
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
            }

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
        protected void imgDel_Command(object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {
            Service1Client client = new Service1Client();
            TaskDetails TaskTable = new TaskDetails();

            TaskTable.TaskID = int.Parse(e.CommandArgument.ToString());

            if (client.DeleteBookingTAskDetails(TaskTable) == true)
            {

                lblStatus.Text = "Record deleted Successfully";

            }

            else
            {

                lblStatus.Text = "Record couldn't be deleted";

            }
            gvDetails.DataBind();
        }

        protected void cmdUpdate_Click(object sender, EventArgs e)
        {
            if (cmdUpdate.Text == "Update")
            {

                UpdateTask();

            }
        }
        private void UpdateTask()
        {

            TaskDetails TaskTable = new TaskDetails();
            TaskTable.TaskID = int.Parse(txttask.Text.Trim());
            TaskTable.EmpName = DropDownList1.SelectedItem.Text;
            TaskTable.TableNo = DropDownList2.SelectedItem.Text;
            TaskTable.BookingID = int.Parse(txtbooking.Text.Trim());
            TaskTable.Dates = DateTime.Parse(txtdate.Text.Trim());
            TaskTable.Times = DateTime.Parse(txttime.Text.Trim());
            
            client.UpdateBookingTAskDetails(TaskTable);

            lblStatus.Text = client.UpdateBookingTAskDetails(TaskTable);

            ClearControls();

            gvDetails.DataBind();

        }
        protected void imgEdit_Command(object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {

            TaskDetails TaskTable = new TaskDetails();

            TaskTable.TaskID = int.Parse(e.CommandArgument.ToString());

            ViewState["TaskID"] = TaskTable.TaskID;

            DataSet ds = new DataSet();

            ds = client.GetBookingTAskDetails(TaskTable);


            if (ds.Tables[0].Rows.Count > 0)
            {
                txttask.Text = ds.Tables[0].Rows[0]["TaskID"].ToString();
                DropDownList1.SelectedItem.Text = ds.Tables[0].Rows[0]["EmpName"].ToString();
                txtbooking.Text = ds.Tables[0].Rows[0]["BookingID"].ToString();
                DropDownList2.SelectedItem.Text = ds.Tables[0].Rows[0]["TableNo"].ToString();
                txtdate.Text = ds.Tables[0].Rows[0]["Dates"].ToString();
                txttime.Text = ds.Tables[0].Rows[0]["Times"].ToString();
             
              
               

                cmdUpdate.Text = "Update";

            }

        }
        private void ClearControls()
        {



           

            txtdate.Text = string.Empty;

            txttime.Text = string.Empty;

            txtbooking.Text = string.Empty;

            

            cmdUpdate.Text = "Update";

            
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

        protected void chkMailNotifyAdd_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}