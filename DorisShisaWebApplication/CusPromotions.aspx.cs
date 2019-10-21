using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DorisShisaWebApplication.ServiceReference1;
namespace DorisShisaWebApplication
{
    public partial class CusPromotions : System.Web.UI.Page
    {/*! 
    allow the customer to view promotions
       */
        protected void Page_Load(object sender, EventArgs e)
        {
            ActivityLogs ActivityTable = new ActivityLogs();
            ActivityTable.Activity = "Clicked to view promotions";
            Service1Client client = new Service1Client();
            ActivityTable.Email = Session["Email"].ToString();
            
            string result = client.InsertActivityLogs(ActivityTable);
        }

        protected void cmdAdd_Click(object sender, EventArgs e)
        {
           
            
     
                OrderDetails OrderTable = new OrderDetails();
                OrderTable.CustomerEmail = Session["Email"].ToString();
                OrderTable.ProductName = "Farmstyle breakfast";
                OrderTable.ProductPrice = "65";
                OrderTable.ProductID = "3";

                Service1Client client = new Service1Client();

                string result = client.InsertOrderDetails(OrderTable);

                Response.Write("<script>alert('Your order is Successfully');</script>");
            

        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "call")
            {
                DataListItem item = (DataListItem)(((Button)(e.CommandSource)).NamingContainer);
                OrderDetails OrderTable = new OrderDetails();
                OrderTable.CustomerEmail = Session["Email"].ToString();
                OrderTable.ProductName = ((Label)(item.FindControl("NameLabel"))).Text;
                OrderTable.ProductPrice = ((Label)(item.FindControl("PriceLabel"))).Text;
                OrderTable.ProductID = "1";

                Service1Client client = new Service1Client();

                string result = client.InsertOrderDetails(OrderTable);

                Response.Write("<script>alert('Your order is Successfully');</script>");
               
               
            }
        }


        protected void cmdVieworder_Click(object sender, EventArgs e)
        {
            Response.Redirect("Checkout.aspx");
        }


    }
}