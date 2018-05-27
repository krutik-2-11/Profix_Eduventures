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
      //  fillddlBranch();
       // fillddlYear();
    }


    


    protected void btnSubmit_Click1(object sender, EventArgs e)
    {
        SqlConnection objcon = new SqlConnection();
        objcon.ConnectionString = "Data source = LAPTOP-CCHRDOI8\\SQLEXPRESS;user id = sa;password = kittu2pathak;Initial Catalog = Profix;";
        objcon.Open();

        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandType = CommandType.Text;
        objcmd.Connection = objcon;

       // objcmd.CommandText = "Insert into Customers(Name, Branch, Year, Email, Phone, UserID, Password)Values('" + txtName.Text + "'," +ddlBranch.SelectedItem.Value+ "," + ddlYear.SelectedItem.Value+ ",'" + txtEmail.Text + "','" + txtPhone.Text + "','" + txtUserID.Text + "','" + txtPassword.Text + "')";
        objcmd.CommandText = "Insert into Customers(Name,Branch,Year,Email, Phone, UserID, Password)Values('" + txtName.Text + "',@Branch,@Year,'" + txtEmail.Text + "','" + txtPhone.Text + "','" + txtUserID.Text + "','" + txtPassword.Text + "')";

       
        objcmd.Parameters.AddWithValue("Branch",ddlBranch.SelectedItem.Value);
        
        objcmd.Parameters.AddWithValue("Year", ddlYear.SelectedItem.Value);
        objcmd.ExecuteNonQuery();
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


