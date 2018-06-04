using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;


public partial class ShowBooks : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        fillgrdBooks();
    }

    private void fillgrdBooks()
    {
        MySqlConnection objcon = new MySqlConnection();
        objcon.ConnectionString = "server = localhost; user id = root; database = profix; persistsecurityinfo = True; SslMode = none;";
        objcon.Open();

        MySqlCommand objcmd = new MySqlCommand();
        objcmd.CommandType = CommandType.Text;
        objcmd.Connection = objcon;

        string sql = "";
        sql = sql + "select Id, BookName, BookCode, BuyBackRate, RentalRate,PenaltyRate,MarketRate,DemandValue,StockValue from books";
       
        objcmd.CommandText = sql;
        MySqlDataReader reader = objcmd.ExecuteReader();
        if (reader != null && reader.HasRows)
        {
            lblNoRecordFound.Visible = false;
            grdBooks.Visible = true;
            grdBooks.DataSource = reader;
            grdBooks.DataBind();

        }
        else
        {
            lblNoRecordFound.Visible = true;
            grdBooks.Visible = false;
        }



    }



    protected void btnSearch_Click(object sender, EventArgs e)
    {
        MySqlConnection objcon = new MySqlConnection();
        objcon.ConnectionString = "server = localhost; user id = root; database = profix; persistsecurityinfo = True;SslMode=none";
        objcon.Open();

        MySqlCommand objcmd = new MySqlCommand();
        objcmd.CommandType = CommandType.Text;
        objcmd.Connection = objcon;

        string sql = "";
        sql = sql + " select Id, BookName, BookCode, BuyBackRate, RentalRate,PenaltyRate,MarketRate,DemandValue,StockValue from books";
        if (txtBookName.Text != "") sql = sql + " where BookName = '" + txtBookName.Text + "'";
        objcmd.CommandText = sql;
        MySqlDataReader reader = objcmd.ExecuteReader();
        if (reader != null && reader.HasRows)
        {
            lblNoRecordFound.Visible = false;
            grdBooks.Visible = true;
            grdBooks.DataSource = reader;
            grdBooks.DataBind();

        }
        else
        {
            lblNoRecordFound.Visible = true;
            grdBooks.Visible = false;
        }

    }
}