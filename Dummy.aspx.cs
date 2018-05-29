using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


public partial class Dummy : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ShowDetails();   
    }

    private void ShowDetails()
    {
        SqlConnection objcon = new SqlConnection();
        objcon.ConnectionString = "Data source = LAPTOP-CCHRDOI8\\SQLEXPRESS;user id = sa;password = kittu2pathak;Initial Catalog = Profix;";
        objcon.Open();

        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandType = CommandType.Text;
        objcmd.Connection = objcon;

        

        string sql = "";
        sql = sql + "Select Name, Branch, Year, Email, Phone, UserID, Password from Customers";
        string check1 = Session["UserID"].ToString();
        if (check1!= "") sql = sql + " where UserID = '" + Session["UserID"] + "'";
        objcmd.CommandText = sql;
        SqlDataReader reader = objcmd.ExecuteReader();
        reader.Read();
        lblId.Text = reader["UserID"].ToString();
        lblName.Text = reader["Name"].ToString();
        


       
    }
}