﻿using System;
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
        if(!IsPostBack)
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

            //txtID.Text = Id.ToString();
            //txtDemand.Text = value1.ToString();


            if (status1.Checked)
            {

                value1 = value1-1;
                txtID.Text = Id.ToString();
                txtDemand.Text = value1.ToString();
                updaterow(Id, value1, "true");
            }
            else
            {
                updaterow(Id, value1, "false");

            }




        }
    }

    private void updaterow(int Id, int value1, String markstatus)
    {

        MySqlConnection objcon = new MySqlConnection();
        objcon.ConnectionString = "server = localhost; user id = root; database = profix; persistsecurityinfo = True;SslMode=none";
        objcon.Open();

        MySqlCommand objcmd = new MySqlCommand();
        objcmd.CommandType = CommandType.Text;
        objcmd.Connection = objcon;

        //jab bhi query do to space ka dhyan rakhna " " ke andar nahi to exception ata he  

        String sql = "";
        sql = sql + " update Books ";
        sql = sql + " set ";
        sql = sql + " DemandValue = " + value1 + " ";
        
        sql = sql + " where Id =  " + Id + " ";

        objcmd.CommandText = sql;
        objcmd.ExecuteNonQuery();
       // lblConfirm.Text = "Record Updated";



    }
}