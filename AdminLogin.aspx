<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" Inherits="AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Login</title>
     <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <div style="background-color:indianred;color:white;font-size:x-large">AdminLogin</div>
    <form id="form1" runat="server">
        
        <table style="width: 100%;">
           
            <tr class="form-group">
                <td>


                    <asp:Label ID="lblAdminId" for="exampleInputEmail1" runat="server" Text="AdminID" ForeColor="Maroon"></asp:Label>
                    
                </td>
                <td>
                    <asp:TextBox ID="txtAdminID" class="form-control" placeholder="Enter AdminID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr class="form-group">
                <td>
                    <asp:Label ID="lblPassword" runat="server" Text="Password" ForeColor="Maroon"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPassword" class="form-control" placeholder="Enter Password" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnSubmit" runat="server" class="btn" BackColor="IndianRed" Text="Submit" OnClick="btnSubmit_Click" />
                    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
