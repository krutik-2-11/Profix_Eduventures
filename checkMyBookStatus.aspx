<%@ Page Language="C#" AutoEventWireup="true" CodeFile="checkMyBookStatus.aspx.cs" Inherits="checkMyBookStatus" %>

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
                    <asp:TextBox ID="txtBook1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblBook1" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan ="2" align ="center">
                    <asp:Button ID="btnStatus" runat="server" Text="Check Your Sold Books Status" OnClick="btnStatus_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
