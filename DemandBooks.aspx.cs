using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
public partial class DemandBooks : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            fillgrdDemandBooks();
    }

    private void fillgrdDemandBooks()
    {
        MySqlConnection objcon = new MySqlConnection();
        objcon.ConnectionString = "server = localhost; user id = root; database = profix; persistsecurityinfo = True;SslMode=none";
        objcon.Open();

        MySqlCommand objcmd = new MySqlCommand();
        objcmd.CommandType = CommandType.Text;
        objcmd.Connection = objcon;


        string sql = "";
        sql = sql + "select Id, BookName, BookCode, BuyBackRate, DemandValue from books where DemandValue > 0";
        objcmd.CommandText = sql;
        MySqlDataReader reader = objcmd.ExecuteReader();
        // reader.Read();


        if (reader != null && reader.HasRows)
        {

            lblNoRecordFound.Visible = false;
            grdDemandBooks.Visible = true;
            grdDemandBooks.DataSource = reader;
            grdDemandBooks.DataBind();



        }
        else
        {
            lblNoRecordFound.Visible = true;
            grdDemandBooks.Visible = false;
        }
    }



    protected void btnSellBooks_Click(object sender, EventArgs e)
    {
        foreach (GridViewRow row in grdDemandBooks.Rows)
        {
            //CheckBox status = (row.Cells[5].FindControl("CheckBox1") as CheckBox);
            CheckBox status1 = (CheckBox)row.FindControl("CheckBox1");


            int Id = Convert.ToInt32(row.Cells[0].Text);
            int value1 = Convert.ToInt32(row.Cells[4].Text);

            int test = 0;   //this variable is used to check the status of  book 0->unselected by default; 1->selected;2->uncleared;3->cleared

            string bookCode = Convert.ToString(row.Cells[2].Text);


            if (status1.Checked)
            {
                test = 1;
                value1 = value1 - 1;
                txtID.Text = Id.ToString();
                txtDemand.Text = value1.ToString();
                updaterow(Id, value1, bookCode, test);
            }
            else
            {
                // updaterow(Id, value1, bookCode, test);

                continue;
            }




        }
    }

    private void updaterow(int Id, int value1, String bookcode, int bookStatus)
    {

        MySqlConnection objcon = new MySqlConnection();
        objcon.ConnectionString = "server = localhost; user id = root; database = profix; persistsecurityinfo = True;SslMode=none";
        objcon.Open();

        MySqlCommand objcmd = new MySqlCommand();
        objcmd.CommandType = CommandType.Text;
        objcmd.Connection = objcon;

        //jab bhi query do to space ka dhyan rakhna " " ke andar nahi to exception ata he  

        String sql = "";

        int isPresent = checkIfPresent(bookcode);   //checks whether UserID already present


        //if userID is not present in the sell_books_status table then we'll insert it in the table

        if (isPresent == -1)
        {
            sql = sql + "insert into sell_books_status(UserID," + bookcode.ToString() + ")Values('" + Session["UserID"].ToString() + "'," + bookStatus.ToString() + ");";

            sql = sql + " update books ";
            sql = sql + " set ";
            sql = sql + " DemandValue = " + value1 + " ";

            sql = sql + " where Id =  " + Id + "; ";

        }
        //if userID is already present in the books_status table then we'll update it in the table

        else if (isPresent % 3 == 0)        //if userID already present but book not requested
        {
            bookStatus = bookStatus + isPresent;
            sql = sql + " update sell_books_status ";
            sql = sql + " set ";
            sql = sql + bookcode.ToString() + " = " + bookStatus.ToString();
            sql = sql + " where UserID = '" + Session["UserID"].ToString() + "'; ";


            sql = sql + " update books ";
            sql = sql + " set ";
            sql = sql + " DemandValue = " + value1 + " ";

            sql = sql + " where Id =  " + Id + "; ";
        }

        else if (isPresent % 3 != 0)        //if both UserID and book already reqested for selling
        {
            bookStatus = isPresent;
            sql = sql + " update sell_books_status ";
            sql = sql + " set ";
            sql = sql + bookcode.ToString() + " = " + bookStatus.ToString();
            sql = sql + " where UserID = '" + Session["UserID"].ToString() + "'; ";

            value1 = value1 + 1;
            sql = sql + " update books ";
            sql = sql + " set ";
            sql = sql + " DemandValue = " + value1 + " ";

            sql = sql + " where Id =  " + Id + "; ";

        }

        objcmd.CommandText = sql;
        objcmd.ExecuteNonQuery();
        



    }

    private int checkIfPresent(String bookcode)
    {
        MySqlConnection objcon = new MySqlConnection();
        objcon.ConnectionString = "server = localhost; user id = root; database = profix; persistsecurityinfo = True;SslMode=none";
        objcon.Open();

        MySqlCommand objcmd = new MySqlCommand();
        objcmd.CommandType = CommandType.Text;
        objcmd.Connection = objcon;


        objcmd.CommandText = " select UserID from sell_books_status Where UserID = '" + Session["UserID"].ToString() + "'; ";

        int isPresent = -1;
        MySqlDataReader reader = objcmd.ExecuteReader();


        if (reader == null)             //if userID already not present
        {
            isPresent = -1;
        }

        else if (reader != null && reader.HasRows)       //if UserID already present 
        {
            reader.Read();


            isPresent = checkBookStatus(bookcode);

        }


        return isPresent;

    }

    private int checkBookStatus(String bookcode)
    {
        MySqlConnection objcon = new MySqlConnection();
        objcon.ConnectionString = "server = localhost; user id = root; database = profix; persistsecurityinfo = True;SslMode=none";
        objcon.Open();

        MySqlCommand objcmd = new MySqlCommand();
        objcmd.CommandType = CommandType.Text;
        objcmd.Connection = objcon;
        



        objcmd.CommandText = " select " + bookcode.ToString() + " from sell_books_status where UserID = '" + Session["UserID"].ToString() + "'; ";

     

        int value = 0;
        var check = objcmd.ExecuteScalar();

        if (check == null)
        {
            value = 0;
        }



        else if (check.ToString() == "0" || check.ToString() == "1" || check.ToString() == "2" || check.ToString() == "3" || check.ToString() == "4" || check.ToString() == "5" || check.ToString() == "6" || check.ToString() == "7")
        {
            value = Convert.ToInt32(check);
        }
        return value;



    }
}
