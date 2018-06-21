using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (txtAdminID.Text == "ADMINJITESH123" && txtPassword.Text == "helloworld123")
        {
            Response.Redirect("AdminPage.aspx");
        }

        else
        {
            lblMessage.Text = "Invalid Admin Login!!!";
        }
    }
}