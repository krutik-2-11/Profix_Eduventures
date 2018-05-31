<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Dummy.aspx.cs" Inherits="Dummy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Profix</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body>
   
    <form id="form1" runat="server">

        <div>
            <asp:Label ID="lblId" BorderWidth="2px" ForeColor="Yellow" runat="server"></asp:Label>
            <asp:Label ID="lblName" BorderWidth="2px" ForeColor="YellowGreen" runat="server"></asp:Label></li>

            <asp:Button ID="btnBuyBooks" Text="Buy Books" runat="server" OnClick="btnBuyBooks_Click" />
            <asp:Button ID="btnSellBooks" Text="Sell Books" runat="server" OnClick="btnSellBooks_Click" />
        </div>

    </form>








</body>
</html>
