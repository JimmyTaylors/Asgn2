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
    public partial class Order : System.Web.UI.Page
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
            cmd.CommandText = "Select * from Orders";
            try
            {
                curConn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                Response.Write("<table border=1>" +
                                "<tr>" +
                                   "<th> Order No </td>" +
                                    "<th> Order Date </td>" +
                                    "<th> Staff ID </td>" +
                                    "<th> Receiver Account No </td>" +
                                    "<th> Receiver  Status </td>" +
                                    "<th> Sender  Branch ID </td>" +
                                   "<th> Time Delivered </td>" +
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
                              "<td>" + sdr.GetString(6) + "</td>" +
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
            Response.Redirect("Order.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["mainConn"].ConnectionString;
            SqlConnection curConn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = curConn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO Orders VALUES ('" + txtOrderNo.Text + "','" + txtOrderDate.Text + "','" + txtStaffID.Text + "','" +
            txtRAno.Text + "','" + txtRS.Text + "','" + txtSID.Text + "','" + txtTimeD.Text + "')";
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
            cmd.CommandText = "DELETE Orders WHERE OrderNo = '" + txtOrderNo.Text + "'";
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
            txtOrderNo.Text = "";
            txtOrderDate.Text = "";
            txtRAno.Text = "";
            txtRS.Text = "";
            txtSID.Text = "";
            txtStaffID.Text = "";
            txtTimeD.Text = "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["mainConn"].ConnectionString;
            SqlConnection curConn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = curConn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "UPDATE Orders SET OrderDate = '" +
            txtOrderDate.Text + "', StaffID ='" +
            txtStaffID.Text + "', RAccountNo ='" +
            txtRAno.Text + "', Rstatus ='" +
            txtRS.Text + "', SBranchID ='" +
            txtSID.Text + "', TimeDelivered ='" +
            txtTimeD.Text + "' where OrderNo = '" +
            txtOrderNo.Text + "'";
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