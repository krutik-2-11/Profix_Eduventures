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

            //to avoid same bookcode being added twice
            cmd.CommandText = "select BookCode from Books where BookCode = '" + txtBookCode.Text + "'; ";
            var check = cmd.ExecuteScalar();

            if (check == null)
            {
                string sql = "";
                sql = sql + "INSERT INTO Books(BookName, BookCode, BuyBackRate,RentalRate,PenaltyRate,MarketRate) Values('" + txtBookName.Text + "','" + txtBookCode.Text + "','" + txtBuyBackRate.Text + "','" + txtRentalRate.Text + "','" + txtPenaltyRate.Text + "','" + txtMarketRate.Text + "');";



                string temp = txtBookCode.Text;
                sql = sql + "ALTER TABLE books_status ADD " + txtBookCode.Text.ToString() + " INT; ";
                sql = sql + "ALTER TABLE sell_books_status ADD " + txtBookCode.Text.ToString() + " INT; ";
                cmd.CommandText = sql;

                cmd.ExecuteNonQuery();
                lblMessage.Text = "Record Submitted Successfully!!";
            }

            else
            {
                 
                lblMessage.Text = "record already submitted";
            }
            objcon.Close();



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



       




    }
}