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
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["staffID"] != null)
                staffID.Text = Session["staffID"].ToString();
            if (Session["staffName"] != null)
                staffName.Text = Session["staffName"].ToString();
            string status;
            string connString = ConfigurationManager.ConnectionStrings["mainConn"].ConnectionString;
            SqlConnection curConn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = curConn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "Select * from Customer";
            try
            {
                curConn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                Response.Write("<table border=1>" +
                                "<tr>" +
                                    "<th> Customer Account No </td>" +
                                    "<th> Customer Name </td>" +
                                    "<th> Customer Address </td>" +
                                    "<th> Customer Telephone Number </td>" +
                                    "<th> Customer Status </td>" +
                                 "</tr>");
                while (sdr.Read())
                {
                    if (sdr.GetBoolean(4) == true)
                        status = "Active";
                    else
                        status = "Inactive";
                    Response.Write(
                            "<tr>" +

                              "<td>" + sdr.GetString(0) + "</td>" +
                              "<td>" + sdr.GetString(1) + "</td>" +
                              "<td>" + sdr.GetString(2) + "</td>" +
                              "<td>" + sdr.GetString(3) + "</td>" +
                              "<td>" + status + "</td>" +
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
            Response.Redirect("Customer.aspx");
        }
        protected void btnAddNew_Click(object sender, EventArgs e)
        {

            string connString = ConfigurationManager.ConnectionStrings["mainConn"].ConnectionString;
            SqlConnection curConn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = curConn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO Customer(RAccountNo, Rname, RAddress, RTel,RStatus) VALUES ('" +
            txtCAccount.Text + "','" +
            txtCName.Text + "','" +
            txtCAddress.Text + "','" +
            txtCTel.Text + "'," +
            "1" + ")";
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
            cmd.CommandText = "DELETE Customer WHERE RAccountNo = '" + txtCAccount.Text + "'";
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
            txtCAddress.Text = "";
            txtCAccount.Text = "";
            txtCName.Text = "";
            txtCTel.Text = "";
            txtCStatus.Text = "";
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
            cmd.CommandText = "UPDATE Customer SET RAccountNo = '" +
            txtCAccount.Text + "', Rname ='" +
             txtCName.Text + "', Raddress ='" +
             txtCAddress.Text + "', RTel ='" +
             txtCTel.Text + "', Rstatus ='" +
            txtCStatus.Text + "' where RAccountNo = '" +
             txtCAccount.Text + "'";
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
