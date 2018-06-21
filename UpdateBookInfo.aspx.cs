using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
using Demo;

public partial class UpdateBookInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindGridViewData();
        }
    }

    private void BindGridViewData()
    {
        grdBooks.DataSource = BookDataAccessLayer.GetAllBooks();
        grdBooks.DataBind();
    }


    protected void grdBooks_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "EditRow")
        {
            int rowIndex = ((GridViewRow)((LinkButton)e.CommandSource).NamingContainer).RowIndex;
            grdBooks.EditIndex = rowIndex;
            BindGridViewData();
        }
        else if (e.CommandName == "DeleteRow")
        {
            BookDataAccessLayer.DeleteBooks(Convert.ToInt32(e.CommandArgument));
            BindGridViewData();
        }
        else if (e.CommandName == "CancelUpdate")
        {
            grdBooks.EditIndex = -1;
            BindGridViewData();
        }
        else if (e.CommandName == "UpdateRow")
        {
            int rowIndex = ((GridViewRow)((LinkButton)e.CommandSource).NamingContainer).RowIndex;

            int Id = Convert.ToInt32(e.CommandArgument);
            string BookName = ((TextBox)grdBooks.Rows[rowIndex].FindControl("txtBookName")).Text;
            int BuyBackRate = Convert.ToInt32(((TextBox)grdBooks.Rows[rowIndex].FindControl("txtBuyBackRate")).Text);
            int RentalRate = Convert.ToInt32(((TextBox)grdBooks.Rows[rowIndex].FindControl("txtRentalRate")).Text);
            int PenaltyRate = Convert.ToInt32(((TextBox)grdBooks.Rows[rowIndex].FindControl("txtPenaltyRate")).Text);
            int MarketRate = Convert.ToInt32(((TextBox)grdBooks.Rows[rowIndex].FindControl("txtMarketRate")).Text);

            BookDataAccessLayer.UpdateBooks(Id,BookName,BuyBackRate,RentalRate,PenaltyRate,MarketRate);

            grdBooks.EditIndex = -1;
            BindGridViewData();
        }
    }
}