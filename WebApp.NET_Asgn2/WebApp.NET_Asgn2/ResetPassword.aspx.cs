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
    public partial class ResetPassword : System.Web.UI.Page
    {
        string connString = ConfigurationManager.ConnectionStrings["mainConn"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIDCheck_Click(object sender, EventArgs e)
        {
            SqlConnection curConn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = curConn;
            cmd.CommandType = System.Data.CommandType.Text;
            string id = txtIDFP.Text;


            cmd.CommandText = "SELECT StaffID, StaffSQ FROM Asgn2_TStaff WHERE StaffID = '" + id + "'";
            try
            {
                curConn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    txtSQ.Text = sdr.GetString(1);
                    txtIDFP.Enabled = false;
                    Panel3.Visible = true;
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

        protected void btnSQACheck_Click(object sender, EventArgs e)
        {

            SqlConnection curConn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = curConn;
            cmd.CommandType = System.Data.CommandType.Text;
            string id = txtIDFP.Text;
            string answer = txtSQAEntered.Text;

            cmd.CommandText = "SELECT StaffSQA FROM Asgn2_TStaff WHERE StaffID = '" + id + "'";
            try
            {
                curConn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    if(answer == sdr.GetString(0))
                    {
                        txtSQAEntered.Enabled = false;
                        Panel4.Visible = true;
                    }
                    else
                    {
                        Response.Write("Wrong Security Answer!");
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

        protected void btnPWChange_Click(object sender, EventArgs e)
        {
            string pw1 = txtPWEntered1.Text;
            string pw2 = txtPWEntered2.Text;

            SqlConnection curConn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = curConn;
            cmd.CommandType = System.Data.CommandType.Text;
            string id = txtIDFP.Text;
            string answer = txtSQAEntered.Text;

            cmd.CommandText = "UPDATE Asgn2_TStaff SET StaffPW = '" + pw2 + "' WHERE StaffID = '" + id + "'";
            try
            {
                curConn.Open();
                cmd.ExecuteNonQuery();
                Response.Redirect("Login.aspx");
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

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}