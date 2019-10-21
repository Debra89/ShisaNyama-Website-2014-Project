using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DorisShisaWebApplication.ServiceReference1;
using System.Text.RegularExpressions;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Drawing;


namespace DorisShisaWebApplication
{
    public partial class AdminAddProducts : System.Web.UI.Page
    { /*! 
    Allow the admin to add products to the database
       */
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmdCreateUser_Click(object sender, EventArgs e)
        {
            Service1Client client = new Service1Client();
            ProductsDetails Products = new ProductsDetails();

            Products.ProductID = int.Parse(txtproductid.Text);
            Products.Name = txtname.Text;
            Products.Description = txtdescription.Text;
            Products.Category = txtcategory.Text;
            Products.Price = decimal.Parse(txtprice.Text);
            string FileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
            FileUpload1.PostedFile.SaveAs(Server.MapPath(FileName));
            Products.ImageUrl = FileName;
            string result = client.AddProducts(Products);
            Label1.Text = result;
            ClearControls(this);     
           
        }

        private void ClearControls(Control ctrl)
        {
            foreach (Control tb in ctrl.Controls)
            {
                if (tb is TextBox)
                {
                    ((TextBox)tb).Text = "";
                }
                else
                {
                    if (tb.Controls.Count > 0)
                    {
                        ClearControls(tb);

                    }
                }
            }

        
        
        }
    }
}