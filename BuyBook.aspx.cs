using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

public partial class BuyBook : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fillgrdAvailableBooks();

        }
    }

    private void fillgrdAvailableBooks()
    {
        MySqlConnection objcon = new MySqlConnection();
        objcon.ConnectionString = "server = localhost; user id = root; database = profix; persistsecurityinfo = True;SslMode=none";
        objcon.Open();

        MySqlCommand objcmd = new MySqlCommand();
        objcmd.CommandType = CommandType.Text;
        objcmd.Connection = objcon;


        string sql = "";
        sql = sql + "select Id, BookName, BookCode,RentalRate,MarketRate,StockValue from books where StockValue > 1";
        objcmd.CommandText = sql;
        MySqlDataReader reader = objcmd.ExecuteReader();
        // reader.Read();


        if (reader != null && reader.HasRows)
        {

            lblNoRecordFound.Visible = false;
            grdAvailableBooks.Visible = true;
            grdAvailableBooks.DataSource = reader;
            grdAvailableBooks.DataBind();



        }
        else
        {
            lblNoRecordFound.Visible = true;
            grdAvailableBooks.Visible = false;
        }
    }






    protected void Button1_Click(object sender, EventArgs e)
    {
        foreach (GridViewRow row in grdAvailableBooks.Rows)
        {
            // CheckBox status = (row.Cells[5].FindControl("CheckBox1") as CheckBox);
            CheckBox status = (CheckBox)row.FindControl("CheckBox1");


            int Id = Convert.ToInt32(row.Cells[0].Text);
            int value1 = Convert.ToInt32(row.Cells[5].Text);
            int test = 0;   //this variable is used for giving status whether bought or not if bought then 1 if not then 0

            //below line is for books_status
            string bookCode = Convert.ToString(row.Cells[2].Text);


            if (status.Checked)
            {
                test = 1;
                value1 = value1 - 1;
                txtId.Text = bookCode;
                txtValue.Text = value1.ToString();
                updaterow(Id, value1, bookCode, test);
            }

            else
            {
                updaterow(Id, value1, bookCode, test);
            }

        }


    }

    private void updaterow(int Id, int value1, String bookCode, int test)
    {

        MySqlConnection objcon = new MySqlConnection();
        objcon.ConnectionString = "server = localhost; user id = root; database = profix; persistsecurityinfo = True;SslMode=none";
        objcon.Open();

        MySqlCommand objcmd = new MySqlCommand();
        objcmd.CommandType = CommandType.Text;
        objcmd.Connection = objcon;

        //jab bhi query do to space ka dhyan rakhna " " ke andar nahi to exception ata he  

        String sql = "";
        sql = sql + " update books ";
        sql = sql + " set ";
        sql = sql + " StockValue = " + value1 + " ";

        sql = sql + " where Id =  " + Id + "; ";

        //books_status queries from here....

        int isPresent = checkIfPresent();   //checks whether UserID already present


        //if userID is not present in the books_status table then we'll insert it in the table

        if (isPresent == 0)
        {
            sql = sql + "insert into books_status(UserID," + bookCode.ToString() + ")Values('" + Session["UserID"].ToString() + "'," + test.ToString() + ");";
        }
        //if userID is already present in the books_status table then we'll update it in the table

        else if (isPresent == 1)
        {
            sql = sql + " update books_status ";
            sql = sql + " set ";
            sql = sql + bookCode.ToString() + " = " + test.ToString();
            sql = sql + " where UserID = '" + Session["UserID"].ToString() + "' ";
        }
        objcmd.CommandText = sql;
        objcmd.ExecuteNonQuery();
        lblConfirm.Text = "Record Updated";



    }


    private int checkIfPresent()
    {
        MySqlConnection objcon = new MySqlConnection();
        objcon.ConnectionString = "server = localhost; user id = root; database = profix; persistsecurityinfo = True;SslMode=none";
        objcon.Open();

        MySqlCommand objcmd = new MySqlCommand();
        objcmd.CommandType = CommandType.Text;
        objcmd.Connection = objcon;

        objcmd.CommandText = " select UserID from books_status Where UserID = '" + Session["UserID"].ToString() + "'; ";

        int isPresent = 0;
        //int isBookPresent = 0;

        MySqlDataReader reader = objcmd.ExecuteReader();

        if (reader != null && reader.HasRows)       //if UserID already present
        {
            reader.Read();
            isPresent = 1;
            

            


        }
        else if (reader == null)
            isPresent = 0;

        return isPresent;

    }
}