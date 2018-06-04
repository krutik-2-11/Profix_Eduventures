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

            /*  objcon.Open();
              cmd = objcon.CreateCommand();
              cmd.CommandText = "INSERT INTO Books(BookName, BookCode, BuyBackRate,RentalRate,PenaltyRate,MarketRate) Values('" + txtBookName.Text + "','" + txtBookCode.Text + "','" + txtBuyBackRate.Text + "','" + txtRentalRate.Text + "','" + txtPenaltyRate.Text + "','" + txtMarketRate.Text + "')";
              cmd.ExecuteNonQuery();

              string temp = txtBookCode.Text;

              cmd1 = objcon.CreateCommand();
              cmd1.CommandText = "ALTER TABLE books_status ADD " + temp + "INT; ";
              cmd1.ExecuteNonQuery();
            */

            objcon.Open();
            cmd = objcon.CreateCommand();
            string sql = "";
            sql = sql + "INSERT INTO Books(BookName, BookCode, BuyBackRate,RentalRate,PenaltyRate,MarketRate) Values('" + txtBookName.Text + "','" + txtBookCode.Text + "','" + txtBuyBackRate.Text + "','" + txtRentalRate.Text + "','" + txtPenaltyRate.Text + "','" + txtMarketRate.Text + "');";
            
            string temp = txtBookCode.Text;
            sql = sql + "ALTER TABLE books_status ADD " + txtBookCode.Text.ToString() + " INT; ";
            cmd.CommandText = sql;

            cmd.ExecuteNonQuery();
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



        lblMessage.Text = "Record Submitted Successfully!!";




    }
}