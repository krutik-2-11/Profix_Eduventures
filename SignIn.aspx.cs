using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class SignIn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        SqlConnection objcon = new SqlConnection();
        objcon.ConnectionString = "Data source = LAPTOP-CCHRDOI8\\SQLEXPRESS;user id = sa;password = kittu2pathak;Initial Catalog = Test;";
        objcon.Open();

        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandType = CommandType.Text;
        objcmd.Connection = objcon;

        objcmd.CommandText = "Insert into SignIn(Name, Branch, Year, Email, Phone)Values('" + txtName.Text+"','" + txtBranch.Text + "','" + txtYear.Text + "','" + txtEmail.Text + "','" + txtPhone.Text + "')";
        objcmd.ExecuteNonQuery();
        lblMessage.Text = "Record Submitted Successfully!!!";
    }
    
}