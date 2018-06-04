<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Books.aspx.cs" Inherits="Books" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 80px;
        }
        .auto-style2 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="lblBookName" runat="server" Text="Book Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBookName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblBookCode" runat="server" Text="BookCode"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBookCode" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblBuyBackRate" runat="server" Text="BuyBackRate"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtBuyBackRate" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblRentalRate" runat="server" Text="RentalRate"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtRentalRate" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblPenaltyRate" runat="server" Text="PenaltyRate"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtPenaltyRate" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblMarketRate" runat="server" Text="MarketRate"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtMarketRate" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan ="2" align ="center">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                    <asp:Label ID="lblMessage" runat="server" ForeColor="Green"></asp:Label>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
