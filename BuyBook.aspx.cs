using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

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
        SqlConnection objcon = new SqlConnection();
        objcon.ConnectionString = "Data source = LAPTOP-CCHRDOI8\\SQLEXPRESS;user id = sa;password = kittu2pathak;Initial Catalog = Profix;";
        objcon.Open();

        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandType = CommandType.Text;
        objcmd.Connection = objcon;


        string sql = "";
        sql = sql + "select Id, BookName, BookCode, BuyingPrice, SellingPrice, DemandValue, StockValue from Books where StockValue > 1";
        objcmd.CommandText = sql;
        SqlDataReader reader = objcmd.ExecuteReader();
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
            int value1 = Convert.ToInt32(row.Cells[4].Text);


            if (status.Checked)
            {
                
                value1 = value1 - 1;
                txtId.Text = Id.ToString();
                txtValue.Text = value1.ToString();
                updaterow(Id,value1,"true");
            }
            else
            {
                updaterow(Id, value1,"false");

            }


          

        }


    }

    private void updaterow(int Id,int value1,String markstatus)
    {
        
        SqlConnection objcon = new SqlConnection();
        objcon.ConnectionString = "Data source = LAPTOP-CCHRDOI8\\SQLEXPRESS;user id = sa;password = kittu2pathak;Initial Catalog = Profix;";
        objcon.Open();

        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandType = CommandType.Text;
        objcmd.Connection = objcon;

        //jab bhi query do to space ka dhyan rakhna " " ke andar nahi to exception ata he  

        String sql = "";
        sql = sql + " update Books ";
        sql = sql + " set ";
        sql = sql + " StockValue = "+value1+", ";
        sql = sql + " CheckBox = '"+markstatus+"' ";
        sql = sql + " where Id =  "+Id+" ";

        objcmd.CommandText = sql;
        objcmd.ExecuteNonQuery();
        lblConfirm.Text = "Record Updated";


       
    }
}