<%@ Page Language="C#" AutoEventWireup="true" CodeFile="checkMyBookStatus.aspx.cs" Inherits="checkMyBookStatus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Check your Book Status</title>
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body style="background-color:wheat">
    <form id="form1" runat="server">
        <div style="background-color:dodgerblue;color:white;font-size:x-large;font-weight:700">
            Check Your Book Status
        </div>
        <table style="width:100%;">
            <tr class="form-group">
                <td>
                    <asp:TextBox ID="txtBook1" class="form-control" placeholder="Enter Book Code" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblBook1" Font-Size="X-Large" ForeColor="YellowGreen" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan ="2" align ="center">
                    <asp:Button ID="btnStatus" runat="server" Text="Check Your Sold Books Status" OnClick="btnStatus_Click" CssClass="btn-primary"/>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
