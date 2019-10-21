using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DorisShisaWebApplication
{
    public partial class ReportOrder : System.Web.UI.Page
    {/*! 
    allow the admin to view order reports
       */
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Page.IsPostBack))
            {
                txtEnd.Text = DateTime.Now.ToShortDateString();
                txtStart.Text = DateTime.Now.ToShortDateString();
            }

        }

        protected void cmdView_Click(object sender, EventArgs e)
        {
            ReportViewer1.LocalReport.Refresh();
        }
    }
}