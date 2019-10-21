using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Drawing;
using DorisShisaWebApplication.ServiceReference1;
using System.Net.Mail;
using System.Text.RegularExpressions;
namespace DorisShisaWebApplication
{
    public partial class AdminViewAssignedOrderTask : System.Web.UI.Page
    {/*! 
    Allow the admin to view assigned order task from the database
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

        protected void imgDel_Command(object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {

            TaskDetails TaskTable = new TaskDetails();

            TaskTable.TaskID = int.Parse(e.CommandArgument.ToString());

            if (client.DeleteOrderTaskDetails(TaskTable) == true)
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

            TaskTable.OrderID = int.Parse(txtorder.Text.Trim());
            TaskTable.Dates = DateTime.Parse(txtdate.Text.Trim());
            TaskTable.Times = DateTime.Parse(txttime.Text.Trim());
            TaskTable.CusName = txtname.Text.Trim();
            
            client.UpdateOrderTaskDetails(TaskTable);

            lblStatus.Text = client.UpdateOrderTaskDetails(TaskTable);

            ClearControls();

            gvDetails.DataBind();

        }
        protected void imgEdit_Command(object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {

            TaskDetails TaskTable = new TaskDetails();

            TaskTable.TaskID = int.Parse(e.CommandArgument.ToString());

            ViewState["TaskID"] = TaskTable.TaskID;

            DataSet ds = new DataSet();

            ds = client.GetOrderTaskDetails(TaskTable);


            if (ds.Tables[0].Rows.Count > 0)
            {
                txttask.Text = ds.Tables[0].Rows[0]["TaskID"].ToString();
                txtorder.Text = ds.Tables[0].Rows[0]["OrderID"].ToString();
                DropDownList1.SelectedItem.Text = ds.Tables[0].Rows[0]["EmpName"].ToString();
               
                txtdate.Text = ds.Tables[0].Rows[0]["Dates"].ToString();
                txttime.Text = ds.Tables[0].Rows[0]["Times"].ToString();
               
                DropDownList2.SelectedItem.Text = ds.Tables[0].Rows[0]["TableNo"].ToString();
                cmdUpdate.Text = "Update";

            }

        }
        private void ClearControls()
        {



            txtname.Text = string.Empty;

            txtdate.Text = string.Empty;

            txttime.Text = string.Empty;

            txtorder.Text = string.Empty;

          

            cmdUpdate.Text = "Update";

            txtname.Focus();

        }

        protected void chkMailNotifyAdd_CheckedChanged(object sender, EventArgs e)
        {
            this.chkMailNotifyAdd.Text = this.chkMailNotifyAdd.Text;


            try
            {
                MailMessage Email_Information = new MailMessage();
                Email_Information.To.Add(DropDownList1.SelectedItem.Value.ToString());
                Email_Information.From = new MailAddress("dorisdorah20@gmail.com");
                Email_Information.Subject = (" your task have been updated  to Order ID:" + txtorder.Text.ToString() + " ");
                Email_Information.Body = "Your task  is at: " + txtdate.Text.ToString() + "<br /><br />the time is: " + txttime.Text.ToString() + "<br /><br /> for table:" + DropDownList2.SelectedItem.Text.ToString() + "<br/><br/>";
                Email_Information.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Credentials = new System.Net.NetworkCredential("dorisdorah20@gmail.com", "dorah2nkuna");
                smtp.Send(Email_Information);
                lblMailNotifyAdd.Text = "Order Task update has been sent to the waitron";
                lblMailNotifyAdd.ForeColor = Color.DarkGreen;
            }
            catch (Exception ex)
            {
                lblMailNotifyAdd.Text = "Order Task update could not be sent to the waitron" + ex.Message;
                lblMailNotifyAdd.ForeColor = Color.Red;
            }
        }
    }
}