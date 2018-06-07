<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SoldBooksStatus.aspx.cs" Inherits="SoldBooksStatus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:Label ID="lblUserID" runat="server" Text="Enter UserID"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtUserID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblBookCode" runat="server" Text="Enter Book Code"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBookCode" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan ="2" align ="center">
                    <asp:Button ID="btnSearchBook" runat="server" Text="Check Book Status" OnClick="btnSearchBook_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblSearchedBook" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSearchStatus" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan ="2" align ="center">
                    <asp:Button ID="btnChangeStatus" runat="server" Text="Change Book Status" OnClick="btnChangeStatus_Click" />
                    <asp:Label ID="lblChangedStatus" runat="server" ForeColor="Green"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
