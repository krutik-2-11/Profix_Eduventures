using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

public partial class booksBoughtStatus : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCheckStatus_Click(object sender, EventArgs e)
    {
        MySqlConnection objcon = new MySqlConnection();
        objcon.ConnectionString = "server = localhost; user id = root; database = profix; persistsecurityinfo = True;SslMode=none";
        objcon.Open();

        MySqlCommand objcmd = new MySqlCommand();
        objcmd.CommandType = CommandType.Text;
        objcmd.Connection = objcon;

        try
        {
            string sql = "";
            sql = sql + "Select UserID," + txtBookCode.Text + " from sell_books_status";

            sql = sql + " where UserID = '" + txtUserID.Text + "'";
            objcmd.CommandText = sql;
            MySqlDataReader reader = objcmd.ExecuteReader();
            reader.Read();
            txtStatus.Text = reader[txtBookCode.Text].ToString();
            lblBookStatus.Text = txtBookCode.Text;
        }

        catch
        {
            lblBookStatus.Text = "No record found";
            txtStatus.Text = "";


        }
    }

    protected void btnChangeStatus_Click(object sender, EventArgs e)
    {
        MySqlConnection objcon = new MySqlConnection();
        objcon.ConnectionString = "server = localhost; user id = root; database = profix; persistsecurityinfo = True;SslMode=none";
        objcon.Open();

        MySqlCommand objcmd = new MySqlCommand();
        objcmd.CommandType = CommandType.Text;
        objcmd.Connection = objcon;

        string sql = "";
        sql = sql + " update sell_books_status ";
        sql = sql + " set ";
        sql = sql + txtBookCode.Text + "=" + txtStatus.Text + " ";
        sql = sql + " Where UserID = '" + txtUserID.Text + "' ";
        objcmd.CommandText = sql;
        objcmd.ExecuteNonQuery();
        lblChangedStatus.Text = "status updated successfully!!";
    }
}