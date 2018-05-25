using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI; 
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;



public partial class Books : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        SqlConnection objcon = new SqlConnection();
        objcon.ConnectionString = "Data source = LAPTOP-CCHRDOI8\\SQLEXPRESS;user id = sa;password = kittu2pathak;Initial Catalog = Profix;";
        objcon.Open();

        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandType = CommandType.Text;
        objcmd.Connection = objcon;

        objcmd.CommandText = "INSERT INTO Books(BookName, BookCode, BuyingPrice, SellingPrice) Values('"+txtBookName.Text+"','"+txtBookCode.Text+"','"+ txtBuyingPrice.Text +"','"+ txtSellingPrice.Text +"')";
        objcmd.ExecuteNonQuery();
        lblMessage.Text = "Record Submitted Successfully!!";



    }
}