using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
namespace WebApp.NET_Asgn2
{
    public partial class Staff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["staffID"] != null)
                staffID.Text = Session["staffID"].ToString();
            if (Session["staffName"] != null)
                staffName.Text = Session["staffName"].ToString();

            string connString = ConfigurationManager.ConnectionStrings["mainConn"].ConnectionString;
            SqlConnection curConn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = curConn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "Select * from Asgn2_TStaff";
            try
            {
                curConn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                Response.Write("<table border=1>" +
                                "<tr>" +
                                    "<th> Staff ID </td>" +
                                    "<th> Staff Name </td>" +
                                    "<th> Staff Email </td>" +
                                    "<th> Staff Password </td>" +
                                    "<th> Staff Safety Question </td>" +
                                    "<th> Staff Safety Question Answer </td>" +
                                 "</tr>");
                while (sdr.Read())
                {

                    Response.Write(
                            "<tr>" +

                              "<td>" + sdr.GetString(0) + "</td>" +
                              "<td>" + sdr.GetString(1) + "</td>" +
                              "<td>" + sdr.GetString(2) + "</td>" +
                              "<td>" + sdr.GetString(3) + "</td>" +
                              "<td>" + sdr.GetString(4) + "</td>" +
                              "<td>" + sdr.GetString(5) + "</td>" +

                            "</tr>");
                }
                Response.Write("</table>");
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
        protected void btnExtract_Click(object sender, EventArgs e)
        {
            Response.Redirect("Staff.aspx");
        }
        protected void btnAddNew_Click(object sender, EventArgs e)
        {

            string connString = ConfigurationManager.ConnectionStrings["mainConn"].ConnectionString;
            SqlConnection curConn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = curConn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO Asgn2_TStaff(StaffID, StaffName, StaffEmail, StaffPW,StaffSQ,StaffSQA) VALUES ('" +
            txtSID.Text + "','" +
            txtSName.Text + "','" +
            txtSEmail.Text + "','" +
            txtSPW.Text + "','" +
            txtSSQ.Text + "','" +
            txtSQA.Text + "')";

            try
            {
                curConn.Open();
                cmd.ExecuteNonQuery();
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
        protected void btnDelete_Click(object sender, EventArgs e)
        {

            string connString = ConfigurationManager.ConnectionStrings["mainConn"].ConnectionString;
            SqlConnection curConn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = curConn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "DELETE Asgn2_TStaff WHERE StaffID = '" + txtSID.Text + "'";
            try
            {

                curConn.Open();
                cmd.ExecuteNonQuery();
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
        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtSID.Text = "";
            txtSEmail.Text = "";
            txtSName.Text = "";
            txtSPW.Text = "";
            txtSQA.Text = "";
            txtSSQ.Text = "";
        }
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            string connString = ConfigurationManager.ConnectionStrings["mainConn"].ConnectionString;
            SqlConnection curConn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = curConn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "UPDATE Asgn2_TStaff SET StaffID = '" +
            txtSID.Text + "', StaffName ='" +
             txtSName.Text + "', StaffEmail ='" +
             txtSEmail.Text + "', StaffPW ='" +
             txtSPW.Text + "', StaffSQ ='" +
             txtSSQ.Text + "', StaffSQA ='" +
            txtSQA.Text + "' where StaffID = '" +
             txtSID.Text + "'";
            try
            {
                curConn.Open();
                cmd.ExecuteNonQuery();
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


    }

}
