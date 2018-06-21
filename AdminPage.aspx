<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminPage.aspx.cs" Inherits="AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Home Page</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body>

    <nav class="navbar navbar-inverse">
        <div class="container-fluid">
            <div class="navbar-header">
                <a class="navbar-brand" href="AdminPage.aspx">Profix</a>
            </div>
            <ul class="nav navbar-nav">
                <li style="color: red"><a href="AdminPage.aspx">Home</a></li>

                <li><a href="UpdateBookInfo.aspx">Update Book Info</a></li>
                <li><a href="SoldbooksStatus.aspx">Change Sold Books Status</a></li>
                <li><a href="booksBoughtStatus.aspx">Change Bought Books Status</a></li>
            </ul>
            <ul class="nav navbar-nav navbar-right">

                <li class="dropdown"><a class="dropdown-toggle" data-toggle="dropdown" href="#">My Profile <span class="caret"></span></a>
                    <ul class="dropdown-menu">
                        <li><a href="Dummy.aspx">
                            <asp:Label ID="lblId" ForeColor="RosyBrown" runat="server" Font-Size="Medium" Font-Bold="true" Height="30px" Width="50px"></asp:Label>
                        </a></li>
                        <li><a href="Dummy.aspx">
                            <asp:Label ID="lblName" ForeColor="RosyBrown" Font-Size="Medium" Font-Bold="True" Height="30px" Width="50px" runat="server" BorderStyle="None" ViewStateMode="Enabled"></asp:Label>
                        </a></li>

                    </ul>
                </li>

                <li><a href="Homepage.aspx">Logout</a></li>
            </ul>
        </div>
    </nav>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
