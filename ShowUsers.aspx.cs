using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;



public partial class ShowUsers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        fillgrdUsers();
    }

    private void fillgrdUsers()
    {
        SqlConnection objcon = new SqlConnection();
        objcon.ConnectionString = "Data source = LAPTOP-CCHRDOI8\\SQLEXPRESS;user id = sa;password = kittu2pathak;Initial Catalog = Profix;";
        objcon.Open();

        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandType = CommandType.Text;
        objcmd.Connection = objcon;

        string sql = "";
        sql = sql + "Select Id, Name, Branch, Year, Email, Phone, UserID, Password from Customers";
        //if (txtProductName.Text != "") sql = sql + " where ProductName = '" + txtProductName.Text + "'";
        objcmd.CommandText = sql;
        SqlDataReader reader = objcmd.ExecuteReader();
        if (reader != null && reader.HasRows)
        {
            lblNoRecordFound.Visible = false;
            grdUsers.Visible = true;
            grdUsers.DataSource = reader;
            grdUsers.DataBind();

        }
        else
        {
            lblNoRecordFound.Visible = true;
            grdUsers.Visible = false;
        }



    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        SqlConnection objcon = new SqlConnection();
        objcon.ConnectionString = "Data source = LAPTOP-CCHRDOI8\\SQLEXPRESS;user id = sa;password = kittu2pathak;Initial Catalog = Profix;";
        objcon.Open();

        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandType = CommandType.Text;
        objcmd.Connection = objcon;

        string sql = "";
        sql = sql + "Select Id, Name, Branch, Year, Email, Phone, UserID, Password from Customers";
        if (txtCustomerName.Text != "") sql = sql + " where Name = '" + txtCustomerName.Text + "'";
        objcmd.CommandText = sql;
        SqlDataReader reader = objcmd.ExecuteReader();
        if (reader != null && reader.HasRows)
        {
            lblNoRecordFound.Visible = false;
            grdUsers.Visible = true;
            grdUsers.DataSource = reader;
            grdUsers.DataBind();

        }
        else
        {
            lblNoRecordFound.Visible = true;
            grdUsers.Visible = false;
        }
    }
}
