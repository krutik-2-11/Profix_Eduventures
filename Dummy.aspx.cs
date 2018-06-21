using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;


public partial class Dummy : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ShowDetails();   
    }

    private void ShowDetails() 
    {
        MySqlConnection objcon = new MySqlConnection();
        objcon.ConnectionString = "server = localhost;user id = root; database = profix; persistsecurityinfo = True;SslMode=none";
        objcon.Open();

        MySqlCommand objcmd = new MySqlCommand();
        objcmd.CommandType = CommandType.Text;
        objcmd.Connection = objcon;

        

        string sql = "";
        sql = sql + "Select Name,UserId from customers";
        string check1 = Session["UserId"].ToString();
        if (check1!= "") sql = sql + " where UserId = '" + Session["UserId"] + "'";
        objcmd.CommandText = sql;
        MySqlDataReader reader = objcmd.ExecuteReader();
        reader.Read();
        lblId.Text = reader["UserId"].ToString();
        lblName.Text = reader["Name"].ToString();
        


       
    }

    
}