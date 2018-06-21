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
      
    }


    


    protected void btnSubmit_Click1(object sender, EventArgs e)
    {

        MySqlConnection objcon = new MySqlConnection("server = localhost; user id = root; database = profix; persistsecurityinfo = True;SslMode=none");
        MySqlCommand cmd;
        
        try
        {

            objcon.Open();
            cmd = objcon.CreateCommand();

            //this statement is used so that if user accidently clicks submit button more than once then only a single recrd will be taken
            cmd.CommandText = "select UserID from customers where UserID = '" +txtUserID.Text+"'; ";    
            var check = cmd.ExecuteScalar();

            if (check == null)
            {
                cmd.CommandText = "Insert into customers(Name,Enrollment,Section,Email,Phone, UserID, Password,ProfixCard)Values('" + txtName.Text + "','" + txtEnrollment.Text + "','" + ddlSection.Text + "','" + txtEmail.Text + "','" + txtPhone.Text + "','" + txtUserID.Text + "','" + txtPassword.Text + "',0)";
                cmd.ExecuteNonQuery();
                lblMessage.Text = "Record Submitted Successfully!!!";
            }

            else
            {
                
                lblMessage.Text = "username already present!!";
            }
            //cmd.ExecuteNonQuery();

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
            
       
        
        
       
    }


    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserLogin.aspx");
    }
}


