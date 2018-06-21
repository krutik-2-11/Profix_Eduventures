<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Books.aspx.cs" Inherits="Books" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Book</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 80px;
        }

        .auto-style2 {
            height: 26px;
        }
    </style>
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color:indianred;color:azure">
            Enter Book Information
        </div>
        <table style="width: 100%;" class="form-group">
            <tr>
                <td>
                    <asp:Label ID="lblBookName" runat="server" ForeColor="#990000" Text="Book Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBookName" class="form-control" placeholder="Enter Book Name" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblBookCode" runat="server" ForeColor="#990000" Text="BookCode"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBookCode" class="form-control" placeholder="Enter Book Code" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblBuyBackRate" runat="server" ForeColor="#990000" Text="BuyBackRate"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtBuyBackRate" class="form-control" placeholder="Enter Buy Back Rate" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblRentalRate" runat="server" ForeColor="#990000" Text="RentalRate"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtRentalRate" class="form-control" placeholder="Enter Rental Rate" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblPenaltyRate" runat="server" ForeColor="#990000" Text="PenaltyRate"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtPenaltyRate" class="form-control" placeholder="Enter Penalty Rate" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblMarketRate" runat="server" ForeColor="#990000" Text="MarketRate"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtMarketRate" class="form-control" placeholder="Enter Market Rate" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblPic" runat="server" ForeColor="#990000" Text="Upload Book Picture"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:FileUpload ID="FileUpload1" class="form-control"  runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2" align="center">
                    <asp:Button ID="btnSubmit" class="btn-danger" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                    <asp:Label ID="lblMessage" runat="server" ForeColor="Green"></asp:Label>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
