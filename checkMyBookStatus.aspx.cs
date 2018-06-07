using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
public partial class checkMyBookStatus : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnStatus_Click(object sender, EventArgs e)
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
            sql = sql + " select " + txtBook1.Text + " from sell_books_status where UserID = '" + Session["UserID"] + "' ";
            objcmd.CommandText = sql;

            MySqlDataReader reader = objcmd.ExecuteReader();
            reader.Read();
            lblBook1.Text = reader[txtBook1.Text].ToString();
        }

        catch
        {
            lblBook1.Text = "No Record";
        }




    }
}