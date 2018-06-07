<%@ Page Language="C#" AutoEventWireup="true" CodeFile="booksBoughtStatus.aspx.cs" Inherits="booksBoughtStatus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table style="width: 100%;">
            <tr>
                <td>
                    <asp:Label ID="lblUserID" runat="server" Text="UserID"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtUserID" runat="server"></asp:TextBox>
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
                <td colspan ="2" align ="center">
                    <asp:Button ID="btnCheckStatus" runat="server" Text="Check Status" OnClick="btnCheckStatus_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblBookStatus" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtStatus" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan ="2" align ="center">
                    <asp:Button ID="btnChangeStatus" runat="server" Text="Change Status" OnClick="btnChangeStatus_Click" />
                    <asp:Label ID="lblChangedStatus" runat="server" ForeColor="Green"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>

</body>
</html>
