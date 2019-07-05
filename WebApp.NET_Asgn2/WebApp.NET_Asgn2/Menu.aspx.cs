using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.NET_Asgn2
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["staffID"] != null)
                txtID.Text = Session["staffID"].ToString();
            if (Session["staffName"] != null)
                txtName.Text = Session["staffName"].ToString();
        }

        protected void btnEditOrdMas_Click(object sender, EventArgs e)
        {
            Response.Redirect("Order.aspx");
        }

        protected void btnEditCust_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customer.aspx");
        }

        protected void btnEditStaff_Click(object sender, EventArgs e)
        {
            Response.Redirect("Staff.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}