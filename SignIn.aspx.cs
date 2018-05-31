using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;



public partial class SignIn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      //  fillddlBranch();
       // fillddlYear();
    }


    


    protected void btnSubmit_Click1(object sender, EventArgs e)
    {

        MySqlConnection objcon = new MySqlConnection("server = localhost; user id = root; database = profix; persistsecurityinfo = True;SslMode=none");
        MySqlCommand cmd;
        
        try
        {

            objcon.Open();
            cmd = objcon.CreateCommand();
            cmd.CommandText = "Insert into customers(Name,Branch,Year,Email, Phone, UserID, Password)Values('"+txtName.Text+"','"+ddlBranch.Text+"','"+txtEmail.Text+"','"+ddlYear.Text+"','"+txtPhone.Text+"','"+txtUserID.Text+"','"+txtPassword.Text+"')";

            cmd.ExecuteNonQuery();

        }
        catch(Exception)
        {
            throw;

        }
        finally
        {
            if(objcon.State==ConnectionState.Open)
            {
                objcon.Close();
            }
        }
            
       
        
        
        lblMessage.Text = "Record Submitted Successfully!!!";
    }

   /* private void fillddlBranch()
    {
        SqlConnection objcon = new SqlConnection();
        objcon.ConnectionString = "Data source = LAPTOP-CCHRDOI8\\SQLEXPRESS;user id = sa;password = kittu2pathak;Initial Catalog = Profix;";
        objcon.Open();

        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandType = CommandType.Text;
        objcmd.Connection = objcon;

        //objcmd.CommandText = "Select Id,Branch from Branch";
        objcmd.CommandText = "Select ID,Branch from Branch";
        SqlDataReader reader = objcmd.ExecuteReader();

        ddlBranch.DataSource = reader;
        ddlBranch.DataTextField = "Branch";
        ddlBranch.DataValueField = "Id";
        ddlBranch.DataBind();

    }


    private void fillddlYear()
    {
        SqlConnection objcon = new SqlConnection();
        objcon.ConnectionString = "Data source = LAPTOP-CCHRDOI8\\SQLEXPRESS;user id = sa;password = kittu2pathak;Initial Catalog = Profix;";
        objcon.Open();

        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandType = CommandType.Text;
        objcmd.Connection = objcon;

        // objcmd.CommandText = "select Id,Year from Year";
        objcmd.CommandText = "Select Id,Year from Year";
        SqlDataReader reader = objcmd.ExecuteReader();

        ddlYear.DataSource = reader;
        ddlYear.DataTextField = "Year";
        ddlYear.DataValueField = "Id";
        ddlYear.DataBind();

    }
    */
}


