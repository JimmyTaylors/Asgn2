using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.NET_Asgn2
{
    public partial class Login : System.Web.UI.Page
    {
        string connString = ConfigurationManager.ConnectionStrings["mainConn"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection curConn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = curConn;
            cmd.CommandType = System.Data.CommandType.Text;
            string id = txtID.Text;
            string pwEntered = txtPW.Text;

            cmd.CommandText = "SELECT StaffName, StaffPw FROM Asgn2_TStaff WHERE StaffID = '" + id + "'";
            try
            {
                curConn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    if (pwEntered == sdr.GetString(1))
                    {
                        Session["staffID"] = id;
                        Session["staffName"] = sdr.GetString(0);
                        Response.Redirect("Menu.aspx");
                    }
                    else
                    {
                        labFailAuth.Text = "Wrong ID or Password!";
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                curConn.Close();
            }

        }

        protected void btnPwForgot_Click(object sender, EventArgs e)
        {
            Response.Redirect("ResetPassword.aspx");
        }
    }
}