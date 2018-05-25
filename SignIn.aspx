﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignIn.aspx.cs" Inherits="SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSignIn" runat="server" Text="SignIn"></asp:Label>
        </div>
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="lblBranch" runat="server" Text="Branch"></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtBranch" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblYear" runat="server" Text="Year"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtYear" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPhone" runat="server" Text="Phone"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPhone" runat="server" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan ="2" align ="center">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
                    <asp:Label ID="lblMessage" runat="server" ForeColor="Green"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>