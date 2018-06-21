<%@ Page Language="C#" AutoEventWireup="true" CodeFile="booksBoughtStatus.aspx.cs" Inherits="booksBoughtStatus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bought Boos Status</title>
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body style="background-color:wheat" style="width:100%" class="table-responsive">
    <form id="form1" runat="server">
        <div style="background-color:indianred;color:whitesmoke">
            Check Bought Book Status
        </div>
        <table style="width: 100%;">
            <tr>
                <td>
                    <asp:Label ID="lblUserID" runat="server" Text="Enter UserID" ForeColor="Maroon"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtUserID" class="form-control" placeholder="Enter UserID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblBookCode" runat="server" Text="Enter BookCode" ForeColor="Maroon"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBookCode" class="form-control" placeholder="Enter Book Code" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan ="2" align ="center">
                    <asp:Button ID="btnCheckStatus" runat="server" Text="Check Status" OnClick="btnCheckStatus_Click" CssClass="btn-danger" />
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
                    <asp:Button ID="btnChangeStatus" runat="server" Text="Change Status" CssClass="btn-success" OnClick="btnChangeStatus_Click"/>
                    <asp:Label ID="lblChangedStatus" runat="server" ForeColor="Green"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>

</body>
</html>
