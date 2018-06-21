<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowBooks.aspx.cs" Inherits="ShowBooks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 844px;
        }
    </style>
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" style="width:100%" class="table-responsive">
        

            <table border="2" style="width:inherit" class="table-bordered">
                <tr>
                    <th class="auto-style1" style="background-color:dodgerblue;color:whitesmoke">Show Books
                    </th>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblBookName" Text="BookName" ForeColor="green" Font-Bold="true" runat="server"></asp:Label>
                        <asp:TextBox ID="txtBookName" CssClass="textfield" runat="server"></asp:TextBox>
                        <asp:Button ID="btnSearch" Text="Search" CssClass="btn-success" runat="server" OnClick="btnSearch_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                        <asp:GridView ID="grdBooks" AutoGenerateColumns="False" runat="server" Width="100%" CssClass="table-hover">

                            <Columns>




                                <asp:BoundField DataField="Id" HeaderText="Id" />
                                <asp:BoundField DataField="BookName" HeaderText="Book Name" />
                                <asp:BoundField DataField="BookCode" HeaderText="Book Code" />
                                <asp:BoundField DataField="BuyBackRate" HeaderText="BuyBack Rate" />
                                <asp:BoundField DataField="RentalRate" HeaderText="Rental Rate" />
                                <asp:BoundField DataField="PenaltyRate" HeaderText="Penalty Rate" />
                                <asp:BoundField DataField="MarketRate" HeaderText="Market Rate" />
                                <asp:BoundField DataField="DemandValue" HeaderText="Demand Value" />
                                <asp:BoundField DataField="StockValue" HeaderText="Stock Value" />
                                <asp:ImageField DataImageUrlField="Image" HeaderText="Book Image">
                                </asp:ImageField>


                            </Columns>
                        </asp:GridView>



                        <asp:Label ID="lblNoRecordFound" Text="No Record Found" runat="server" Font-Size="XX-Large"
                            Font-Bold="true" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
            </table>
    
    </form>
</body>
</html>
