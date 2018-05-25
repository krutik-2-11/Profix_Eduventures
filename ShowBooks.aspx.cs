using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class ShowBooks : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        fillgrdBooks();
    }

    private void fillgrdBooks()
    {
        SqlConnection objcon = new SqlConnection();
        objcon.ConnectionString = "Data source = LAPTOP-CCHRDOI8\\SQLEXPRESS;user id = sa;password = kittu2pathak;Initial Catalog = Profix;";
        objcon.Open();

        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandType = CommandType.Text;
        objcmd.Connection = objcon;

        string sql = "";
        sql = sql + " select Id, BookName, BookCode, BuyingPrice, SellingPrice from Books";
        //if (txtProductName.Text != "") sql = sql + " where ProductName = '" + txtProductName.Text + "'";
        objcmd.CommandText = sql;
        SqlDataReader reader = objcmd.ExecuteReader();
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