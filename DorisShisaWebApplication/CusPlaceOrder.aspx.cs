using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DorisShisaWebApplication.ServiceReference1;
using System.Data;
using System.Configuration;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Net.Mail;
using System.Text;
using System.IO;
using System.Drawing;
namespace DorisShisaWebApplication
{
    public partial class CusPlaceOrder : System.Web.UI.Page

    {
        /*! 
    allow the customers to place an order for food
       */
        DataTable MyDT = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            ActivityLogs ActivityTable = new ActivityLogs();
            ActivityTable.Activity = "Clicked to place an order";
            Service1Client client = new Service1Client();
            ActivityTable.Email = Session["Email"].ToString();
           
            string result = client.InsertActivityLogs(ActivityTable);

          if (Session["authenticated"] == null)
            {
                Response.Redirect("Login.aspx");
            }
           
        }

        private void DataTable()
        {

            DataRow MyRow;

            if (ViewState["DataTable"] == null)
            {

                MyDT.Columns.Add("ProductId", System.Type.GetType("System.Int32"));

                MyDT.Columns.Add("Name");

                MyDT.Columns.Add("Price", System.Type.GetType("System.Decimal"));

                MyRow = MyDT.NewRow();

                MyRow[0] = MyDT.Rows.Count + 1;

                MyRow[1] = DropDownList1.SelectedItem.Text;

                MyRow[2] = DropDownList1.SelectedItem.Value;

                MyDT.Rows.Add(MyRow);





            }

            else
            {

                MyDT = (DataTable)ViewState["DataTable"];

                MyRow = MyDT.NewRow();

                MyRow[0] = MyDT.Rows.Count + 1;

                MyRow[1] = DropDownList1.SelectedItem.Text;

                MyRow[2] = DropDownList1.SelectedItem.Value;

                MyDT.Rows.Add(MyRow);

            }

            ViewState["DataTable"] = MyDT;

            GridView1.DataSource = MyDT;

            GridView1.DataBind();



        }



        protected decimal TotalUnitPrice;

        protected decimal GetUnitPrice(decimal Price)
        {

            TotalUnitPrice += Price;

            return Price;

        }

        protected decimal GetTotal()
        {

            return TotalUnitPrice;

        }

       

        protected void chkMailNotifyAdd_CheckedChanged(object sender, EventArgs e)
        {
            this.chkMailNotifyAdd.Text = this.chkMailNotifyAdd.Text;


        try
        {
            string to = Session["Email"].ToString();

            string Add = "dorisdorah@ymail.com";

            string From = "dorisdorah20@gmail.com";
            string subject = "Order Details";

            string Body = "Dear Sir/Madam ,<br> Please Check the  Attachment for your order details if there is any mistake you can log in to change it<br><br>";
            Body += GridViewToHtml(GridView1); //Elaborate this function detail later
            Body += "<br><br>Regards,<br>DD Nkuna";

            bool send = send_mail(to, From, subject, Body);//Elaborate this function detail later
            bool sends = send_mail(Add, From, subject, Body);

            if (send == true)
            {
                string CloseWindow = "alert('Mail Sent Successfully!');";
                ClientScript.RegisterStartupScript(this.GetType(), "CloseWindow", CloseWindow, true);
            }
            else
            {
                string CloseWindow = "alert('Problem in Sending mail...try later!');";
                ClientScript.RegisterStartupScript(this.GetType(), "CloseWindow", CloseWindow, true);
            }
            lblMailNotifyAdd.Text = "Password has been sent to the user";
            lblMailNotifyAdd.ForeColor = Color.DarkGreen;
        }
        catch (Exception ex)
        {
            lblMailNotifyAdd.Text = "Password could not be sent to the user" + ex.Message;
            lblMailNotifyAdd.ForeColor = Color.Red;
        }
                            
        }

        public bool send_mail(string to, string from, string subject, string body)
        {
            MailMessage msg = new MailMessage(from, to);
            msg.Subject = subject;
            AlternateView view;
            SmtpClient client;
            StringBuilder msgText = new StringBuilder();
            msgText.Append(" <html><body><br></body></html> <br><br><br>  " + body);
            view = AlternateView.CreateAlternateViewFromString(msgText.ToString(), null, "text/html");

            msg.AlternateViews.Add(view);
            client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential("dorisdorah20@gmail.com", "dorah2nkuna");
            client.EnableSsl = true; //Gmail works on Server Secured Layer
            client.Send(msg);
            bool k = true;
            return k;
        }



        private string GridViewToHtml(GridView gv)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            gv.RenderControl(hw);
            return sb.ToString();
        }
 public override void VerifyRenderingInServerForm(Control control)
        {
            //Confirms that an HtmlForm control is rendered for the specified ASP.NET server control at run time.
        }
        

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Checkout.aspx");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            ReportDetails Report = new ReportDetails();
            Service1Client client = new Service1Client();
            string results = client.OrderReport(Report);
            DataTable();
            OrderDetails OrderTable = new OrderDetails();
            OrderTable.CustomerEmail = Session["Email"].ToString();
            OrderTable.ProductName = DropDownList1.SelectedItem.Text;
            OrderTable.ProductPrice = DropDownList1.SelectedItem.Value;

            OrderTable.ProductID = "1";

           

            string result = client.InsertOrderDetails(OrderTable);

        }
    }
}