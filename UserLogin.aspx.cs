using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class UserLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        SqlConnection objcon = new SqlConnection();
        objcon.ConnectionString = "Data source = LAPTOP-CCHRDOI8\\SQLEXPRESS;user id = sa;password = kittu2pathak;Initial Catalog = Profix;";
        objcon.Open();

        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandType = CommandType.Text;
        objcmd.Connection = objcon;

        String sql = "";
        sql = sql + " Select UserID from Customers ";
        sql = sql + " where UserID = '" + txtUserId.Text + "' ";
        sql = sql + " and Password = '" + txtPassword.Text + "'";
        objcmd.CommandText = sql;

        SqlDataReader reader = objcmd.ExecuteReader();
        if (reader != null && reader.HasRows)
        {
            Session["UserID"] = txtUserId.Text;
            
            
            
            Response.Redirect("Dummy.aspx", false);
            

        }


        else
        {
           
            lblDenied.Text = "Access Denied!!!";

        }
    }
}