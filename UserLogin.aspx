<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserLogin.aspx.cs" Inherits="UserLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Login</title>
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body style="background-color:wheat">

    <div style="background-color:dodgerblue;color:white;font-size:x-large">UserLogin</div>
    <form id="form1" runat="server">


        <table style="width: 100%;">
            <tr class="form-group">
                <td>
                    <asp:Label ID="lblUserId"  runat="server" Text="UserId" ForeColor="#009900"></asp:Label>
                </td>
                <td>

                    <asp:TextBox ID="txtUserId" class="form-control" placeholder="Enter UserID" runat="server"></asp:TextBox>
                </td>

            </tr>

            <tr class="form-group">
                <td>
                    <asp:Label ID="lblPassword" runat="server" Text="Password" ForeColor="#009900"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPassword" class="form-control" placeholder="Enter Password" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnSubmit" runat="server" class="btn btn-primary" Text="Login" OnClick="btnSubmit_Click" />
                    <asp:Label ID="lblDenied" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnRedirect" runat="server" class="btn-danger" Text="Dont Have An Account? Create One!!" OnClick="btnRedirect_Click"/>
                   
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
