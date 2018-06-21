using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Demo
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string BookCode { get; set; }
        public int BuyBackRate { get; set; }
        public int RentalRate { get; set; }
        public int PenaltyRate { get; set; }
        public int MarketRate { get; set; }
        public int DemandValue { get; set; }
        public int StockValue { get; set; }
        public string Image { get; set; }
    }

    public class BookDataAccessLayer
    {
        // Select Method for ObjectDataSource control
        public static List<Book> GetAllBooks()
        {
            MySqlConnection objcon = new MySqlConnection();
            objcon.ConnectionString = "server = localhost; user id = root; database = profix; persistsecurityinfo = True; SslMode = none;";
            objcon.Open();

            MySqlCommand objcmd = new MySqlCommand();
            objcmd.CommandType = CommandType.Text;
            objcmd.Connection = objcon;

            List<Book> listBooks = new List<Book>();

            string sql = "";
            sql = sql + "Select * from Books";
            objcmd.CommandText = sql;



            MySqlDataReader rdr = objcmd.ExecuteReader();
            while (rdr.Read())
            {
                Book books = new Book();
                books.Id = Convert.ToInt32(rdr["Id"]);
                books.BookName = rdr["BookName"].ToString();
                books.BookCode = rdr["BookCode"].ToString();
                books.BuyBackRate = Convert.ToInt32(rdr["BuyBackRate"]);
                books.RentalRate = Convert.ToInt32(rdr["RentalRate"]);
                books.PenaltyRate = Convert.ToInt32(rdr["PenaltyRate"]);
                books.MarketRate = Convert.ToInt32(rdr["MarketRate"]);
                books.DemandValue = Convert.ToInt32(rdr["DemandValue"]);
                books.StockValue = Convert.ToInt32(rdr["StockValue"]);
                books.Image = rdr["Image"].ToString();

                listBooks.Add(books);
            }


            return listBooks;
        }

        // Delete Method for ObjectDataSource control
        public static void DeleteBooks(int Id)
        {
            MySqlConnection objcon = new MySqlConnection();
            objcon.ConnectionString = "server = localhost; user id = root; database = profix; persistsecurityinfo = True; SslMode = none;";
            objcon.Open();

            MySqlCommand objcmd = new MySqlCommand();
            objcmd.CommandType = CommandType.Text;
            objcmd.Connection = objcon;

            objcmd.CommandText = "Delete  from Books Where Id = " + Id + "";
            objcmd.ExecuteNonQuery();

        }

        // Update Method for ObjectDataSource control
        public static int UpdateBooks(int Id, string BookName, int BuyBackRate, int RentalRate, int PenaltyRate, int MarketRate)
        {


            MySqlConnection objcon = new MySqlConnection();
            objcon.ConnectionString = "server = localhost; user id = root; database = profix; persistsecurityinfo = True; SslMode = none;";
            objcon.Open();

            MySqlCommand objcmd = new MySqlCommand();
            objcmd.CommandType = CommandType.Text;
            objcmd.Connection = objcon;

            string updateQuery = "Update Books SET BookName = '" + BookName + "'," +
                "BuyBackRate = '" + BuyBackRate + "', RentalRate = " + RentalRate + ",PenaltyRate = " + PenaltyRate + ",MarketRate = " + MarketRate + " WHERE Id = " + Id + " ";

            objcmd.CommandText = updateQuery;
            return objcmd.ExecuteNonQuery();
        }


    }
}
