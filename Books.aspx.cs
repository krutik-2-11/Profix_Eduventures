using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI; 
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;




public partial class Books : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        MySqlConnection objcon = new MySqlConnection("server = localhost; user id = root; database = profix; persistsecurityinfo = True;SslMode=none");
        MySqlCommand cmd;

        try
        {

            objcon.Open();
            cmd = objcon.CreateCommand();
            cmd.CommandText = "INSERT INTO stock(BookName, BookCode, BuyingPrice, SellingPrice) Values('"+txtBookName.Text+"','"+txtBookCode.Text+"','"+txtBuyingPrice.Text+"','"+txtSellingPrice.Text+"')";

            cmd.ExecuteNonQuery();

        }
        catch (Exception)
        {
            throw;

        }
        finally
        {
            if (objcon.State == ConnectionState.Open)
            {
                objcon.Close();
            }
        }
        
        lblMessage.Text = "Record Submitted Successfully!!";



    }
}