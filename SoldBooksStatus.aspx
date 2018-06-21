<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SoldBooksStatus.aspx.cs" Inherits="SoldBooksStatus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Sold Book Status </title>
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body style="background-color:wheat">
    <form id="form1" runat="server" style="width:100%" class="table-responsive">
        <div style="background-color:indianred;color:whitesmoke">
            Check Sold Book Status
        </div>
        <table class="table-borderless" style="width:inherit">
            <tr class="form-group">
                <td>
                    <asp:Label ID="lblUserID" runat="server" Text="Enter UserID" ForeColor="Maroon"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtUserID" class="form-control" placeholder="Enter UserID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblBookCode" runat="server" Text="Enter Book Code" ForeColor="Maroon"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBookCode" class="form-control" placeholder="Enter Book Code"  runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnSearchBook" runat="server" Text="Check Book Status" OnClick="btnSearchBook_Click" CssClass="btn-danger"/>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblSearchedBook" runat="server"  ForeColor="Maroon"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSearchStatus" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnChangeStatus" runat="server" Text="Change Book Status" OnClick="btnChangeStatus_Click" CssClass="btn-success" />
                    <asp:Label ID="lblChangedStatus" runat="server" ForeColor="Green"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
