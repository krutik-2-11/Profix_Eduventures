using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;



public partial class ShowUsers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        fillgrdUsers();
    }

    private void fillgrdUsers()
    {
        MySqlConnection objcon = new MySqlConnection();
        objcon.ConnectionString = "server = localhost; user id = root; database = profix; persistsecurityinfo = True;SslMode=none";
        objcon.Open();

        MySqlCommand objcmd = new MySqlCommand();
        objcmd.CommandType = CommandType.Text;
        objcmd.Connection = objcon;

        string sql = "";
        sql = sql + "Select Id, Name, Branch, Year, Email, Phone, UserID, Password from customers";
        //if (txtProductName.Text != "") sql = sql + " where ProductName = '" + txtProductName.Text + "'";
        objcmd.CommandText = sql;
        MySqlDataReader reader = objcmd.ExecuteReader();
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
        MySqlConnection objcon = new MySqlConnection();
        objcon.ConnectionString = "server = localhost; user id = root; database = profix; persistsecurityinfo = True; SslMode = none";
        objcon.Open();

        MySqlCommand objcmd = new MySqlCommand();
        objcmd.CommandType = CommandType.Text;
        objcmd.Connection = objcon;

        string sql = "";
        sql = sql + "Select Id, Name, Branch, Year, Email, Phone, UserID, Password from customers";
        if (txtCustomerName.Text != "") sql = sql + " where Name = '" + txtCustomerName.Text + "'";
        objcmd.CommandText = sql;
        MySqlDataReader reader = objcmd.ExecuteReader();
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
