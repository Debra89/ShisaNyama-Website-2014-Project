using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Drawing;
using DorisShisaWebApplication.ServiceReference1;
namespace DorisShisaWebApplication
{
    public partial class AdminUpdateProducts : System.Web.UI.Page
    { /*! 
    Allow the admin to update products
       */
        Service1Client client = new Service1Client();
        private string SearchString = "";
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

        protected void cmdCreateUser_Click(object sender, EventArgs e)
        {
            if (cmdCreateUser.Text == "Update")
            {

                UpdateProductss();

            }
        }
        private void UpdateProductss()
        {

            ProductsDetails Products = new ProductsDetails();

            Products.ProductID = Convert.ToInt32((ViewState["ProductID"].ToString()));


            Products.Name = txtname.Text.Trim();
            Products.Description = txtdescription.Text.Trim();
            Products.Category = txtcategory.Text.Trim();
            Products.Price = decimal.Parse(txtprice.Text.Trim());
            string FileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
            FileUpload1.PostedFile.SaveAs(Server.MapPath(FileName));
            Products.ImageUrl = FileName;
            client.UpdateProducts(Products);

            lblStatus.Text = client.UpdateProducts(Products);

            ClearControls();

            gvDetails.DataBind();



        }
        protected void imgEdit_Command(object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {

            ProductsDetails Products = new ProductsDetails();

            Products.ProductID = int.Parse(e.CommandArgument.ToString());

            ViewState["ProductID"] = Products.ProductID;

            DataSet ds = new DataSet();

            ds = client.FetchUpdatedProducts(Products);


            if (ds.Tables[0].Rows.Count > 0)
            {

                txtname.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                txtdescription.Text = ds.Tables[0].Rows[0]["Description"].ToString();

                txtcategory.Text = ds.Tables[0].Rows[0]["Category"].ToString();
                txtprice.Text = ds.Tables[0].Rows[0]["Price"].ToString();

                string FileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
                //FileUpload1.PostedFile.SaveAs(Server.MapPath(FileName));
                FileName = ds.Tables[0].Rows[0]["ImageUrl"].ToString(); ;

                cmdCreateUser.Text = "Update";

            }

        }
        private void ClearControls()
        {



            txtname.Text = string.Empty;

            txtdescription.Text = string.Empty;

            txtcategory.Text = string.Empty;

            txtcategory.Text = string.Empty;

            txtprice.Text = string.Empty;


            cmdCreateUser.Text = "Update Product";

            txtname.Focus();

        }

    }
}