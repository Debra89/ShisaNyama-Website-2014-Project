using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DorisShisaWebApplication.ServiceReference1;
namespace DorisShisaWebApplication
{
    public partial class CusMenu : System.Web.UI.Page
    {/*! 
    allow the customer to view the menu
       */
        protected void Page_Load(object sender, EventArgs e)
        {
            ActivityLogs ActivityTable = new ActivityLogs();
            ActivityTable.Activity = "Clicked to view menu";
            Service1Client client = new Service1Client();
            ActivityTable.Email = Session["Email"].ToString();
           string result = client.InsertActivityLogs(ActivityTable);

        }

        protected void cmdorder1_Click(object sender, EventArgs e)
        {
            ReportDetails Report = new ReportDetails();
            Service1Client client = new Service1Client();
            string results = client.OrderReport(Report);
            OrderDetails OrderTable = new OrderDetails();
            OrderTable.CustomerEmail = Session["Email"].ToString();
            OrderTable.ProductName = "Micro breakfast";
            OrderTable.ProductPrice = ("40");
            OrderTable.ProductID = ("4");
           
            string result = client.InsertOrderDetails(OrderTable);
            Response.Write("<script>alert('Your order for micro breakfast is successfully');</script>");
        }

        protected void cmdorder2_Click(object sender, EventArgs e)
        {
            ReportDetails Report = new ReportDetails();
            Service1Client client = new Service1Client();
            string results = client.OrderReport(Report);
            OrderDetails OrderTable = new OrderDetails();
            OrderTable.CustomerEmail = Session["Email"].ToString();
            OrderTable.ProductName = "Farmstyle breakfast";
            OrderTable.ProductPrice = ("65");
            OrderTable.ProductID = ("1");

          
            string result = client.InsertOrderDetails(OrderTable);
            Response.Write("<script>alert('Your order for Farmstyle breakfats is Successfully');</script>");
        }

        protected void cmdorder3_Click(object sender, EventArgs e)
        {
            ReportDetails Report = new ReportDetails();
            Service1Client client = new Service1Client();
            string results = client.OrderReport(Report);
            OrderDetails OrderTable = new OrderDetails();
            OrderTable.CustomerEmail = Session["Email"].ToString();
            OrderTable.ProductName = "Southern style breakfast";
            OrderTable.ProductPrice = ("65");
            OrderTable.ProductID = ("2");

           
            string result = client.InsertOrderDetails(OrderTable);
            Response.Write("<script>alert('Your order for Southern style breakfast is Successfully');</script>");
        }

        protected void cmdorder4_Click(object sender, EventArgs e)
        {
            ReportDetails Report = new ReportDetails();
            Service1Client client = new Service1Client();
            string results = client.OrderReport(Report);
            OrderDetails OrderTable = new OrderDetails();
            OrderTable.CustomerEmail = Session["Email"].ToString();
            OrderTable.ProductName = "Egg Benedict";
            OrderTable.ProductPrice = ("60");
            OrderTable.ProductID = ("3");

            
            string result = client.InsertOrderDetails(OrderTable);
            Response.Write("<script>alert('Your order for Egg benedict is Successfully');</script>");
        }

        protected void cmdorder5_Click(object sender, EventArgs e)
        {
            ReportDetails Report = new ReportDetails();
            Service1Client client = new Service1Client();
            string results = client.OrderReport(Report);
            OrderDetails OrderTable = new OrderDetails();
            OrderTable.CustomerEmail = Session["Email"].ToString();
            OrderTable.ProductName = "Fresh fruit plate";
            OrderTable.ProductPrice = ("60");
            OrderTable.ProductID = ("5");

            
            string result = client.InsertOrderDetails(OrderTable);
            Response.Write("<script>alert('Your order for Fresh fruit plate is Successfully');</script>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ReportDetails Report = new ReportDetails();
            Service1Client client = new Service1Client();
            string results = client.OrderReport(Report);
            OrderDetails OrderTable = new OrderDetails();
            OrderTable.CustomerEmail = Session["Email"].ToString();
            OrderTable.ProductName = "Cape Velvet Creme Brulee";
            OrderTable.ProductPrice = ("55");
            OrderTable.ProductID = ("6");

            
            string result = client.InsertOrderDetails(OrderTable);
            Response.Write("<script>alert('Your order for Cape velvet creme brulee is Successfully');</script>");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ReportDetails Report = new ReportDetails();
            Service1Client client = new Service1Client();
            string results = client.OrderReport(Report);
            OrderDetails OrderTable = new OrderDetails();
            OrderTable.CustomerEmail = Session["Email"].ToString();
            OrderTable.ProductName = "Vanilla Panacotta";
            OrderTable.ProductPrice = ("55");
            OrderTable.ProductID = ("7");

            
            string result = client.InsertOrderDetails(OrderTable);
            Response.Write("<script>alert('Your order for Vanilla panacotta is Successfully');</script>");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ReportDetails Report = new ReportDetails();
            Service1Client client = new Service1Client();
            string results = client.OrderReport(Report);
            OrderDetails OrderTable = new OrderDetails();
            OrderTable.CustomerEmail = Session["Email"].ToString();
            OrderTable.ProductName = "Chocolate Fondant";
            OrderTable.ProductPrice = ("65");
            OrderTable.ProductID = ("8");

           
            string result = client.InsertOrderDetails(OrderTable);
            Response.Write("<script>alert('Your order for Chocolate fondant is Successfully');</script>");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            ReportDetails Report = new ReportDetails();
            Service1Client client = new Service1Client();
            string results = client.OrderReport(Report);
            OrderDetails OrderTable = new OrderDetails();
            OrderTable.CustomerEmail = Session["Email"].ToString();
            OrderTable.ProductName = "Lindt Chocolate Bon-bons";
            OrderTable.ProductPrice = ("55");
            OrderTable.ProductID = ("9");

           
            string result = client.InsertOrderDetails(OrderTable);
            Response.Write("<script>alert('Your order for Lindt chocolate bon-bons is Successfully');</script>");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            ReportDetails Report = new ReportDetails();
            Service1Client client = new Service1Client();
            string results = client.OrderReport(Report);
            OrderDetails OrderTable = new OrderDetails();
            OrderTable.CustomerEmail = Session["Email"].ToString();
            OrderTable.ProductName = "Gluhwein Vanilla";
            OrderTable.ProductPrice = ("55");
            OrderTable.ProductID = ("10");

           
            string result = client.InsertOrderDetails(OrderTable);
            Response.Write("<script>alert('Your order for Gluhwein vanilla is Successfully');</script>");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            ReportDetails Report = new ReportDetails();
            Service1Client client = new Service1Client();
            string results = client.OrderReport(Report);
            OrderDetails OrderTable = new OrderDetails();
            OrderTable.CustomerEmail = Session["Email"].ToString();
            OrderTable.ProductName = "Moroccan falafel";
            OrderTable.ProductPrice = ("60");
            OrderTable.ProductID = ("11");

            
            string result = client.InsertOrderDetails(OrderTable);
            Response.Write("<script>alert('Your order for Moroccan falafel is Successfully');</script>");
        }
        

        protected void Button7_Click(object sender, EventArgs e)
        {
            ReportDetails Report = new ReportDetails();
            Service1Client client = new Service1Client();
            string results = client.OrderReport(Report);
            OrderDetails OrderTable = new OrderDetails();
            OrderTable.CustomerEmail = Session["Email"].ToString();
            OrderTable.ProductName = "Sirloin pita";
            OrderTable.ProductPrice = ("65");
            OrderTable.ProductID = ("12");

           
            string result = client.InsertOrderDetails(OrderTable);
            Response.Write("<script>alert('Your order for Sirlon pita is Successfully');</script>");
            
       }
        protected void Button8_Click(object sender, EventArgs e)
        {
            ReportDetails Report = new ReportDetails();
            Service1Client client = new Service1Client();
            string results = client.OrderReport(Report);
            OrderDetails OrderTable = new OrderDetails();
            OrderTable.CustomerEmail = Session["Email"].ToString();
            OrderTable.ProductName = "Tempura prawn wrap";
            OrderTable.ProductPrice = ("75");
            OrderTable.ProductID = ("13");

           
            string result = client.InsertOrderDetails(OrderTable);
            Response.Write("<script>alert('Your order for Tempura prawn wrap is Successfully');</script>");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            ReportDetails Report = new ReportDetails();
            Service1Client client = new Service1Client();
            string results = client.OrderReport(Report);
            OrderDetails OrderTable = new OrderDetails();
            OrderTable.CustomerEmail = Session["Email"].ToString();
            OrderTable.ProductName = "Fillet steak sandwich";
            OrderTable.ProductPrice = ("75");
            OrderTable.ProductID = ("14");

            
            string result = client.InsertOrderDetails(OrderTable);
            Response.Write("<script>alert('Your order for Fillet steak sandwich is Successfully');</script>");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            ReportDetails Report = new ReportDetails();
            Service1Client client = new Service1Client();
            string results = client.OrderReport(Report);
            OrderDetails OrderTable = new OrderDetails();
            OrderTable.CustomerEmail = Session["Email"].ToString();
            OrderTable.ProductName = "Beef or Chicken Portuguese prego";
            OrderTable.ProductPrice = ("75");
            OrderTable.ProductID = ("14");

           
            string result = client.InsertOrderDetails(OrderTable);
            Response.Write("<script>alert('Your order for Beef or Chicken portuguese prego is Successfully');</script>");
        }

        protected void cmdvieworder_Click(object sender, EventArgs e)
        {
            Response.Redirect("Checkout.aspx");
        }
    }
}