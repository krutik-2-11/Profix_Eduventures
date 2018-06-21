using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

public partial class UserLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        MySqlConnection objcon = new MySqlConnection();
        objcon.ConnectionString = "server = localhost; user id = root; database = profix; persistsecurityinfo = True;SslMode=none";
        objcon.Open();

        MySqlCommand objcmd = new MySqlCommand();
        objcmd.CommandType = CommandType.Text;
        objcmd.Connection = objcon;

        String sql = "";
        sql = sql + " Select UserID from customers ";
        sql = sql + " where UserId = '" + txtUserId.Text + "' ";
        sql = sql + " and Password = '" + txtPassword.Text + "'";
        objcmd.CommandText = sql;

        MySqlDataReader reader = objcmd.ExecuteReader();
        if (reader != null && reader.HasRows)
        {
            Session["UserId"] = txtUserId.Text;
            
            
            
            Response.Redirect("Dummy.aspx", false);
            

        }


        else
        {
           
            lblDenied.Text = "Access Denied!!!";

        }
    }

    protected void btnRedirect_Click(object sender, EventArgs e)
    {
        Response.Redirect("SignIn.aspx");
    }
}