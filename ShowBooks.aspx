<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowBooks.aspx.cs" Inherits="ShowBooks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table border="2" cellpadding="5" class="tablegrid" cellspacing="0" width="100%">
                <tr>
                    <th>Show Books
                    </th>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblBookName" Text="BookName" runat="server"></asp:Label>
                        <asp:TextBox ID="txtBookName" CssClass="textfield" runat="server"></asp:TextBox>
                        <asp:Button ID="btnSearch" Text="Search" CssClass="smartbutton" runat="server" OnClick="btnSearch_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                        <asp:GridView ID="grdBooks" AutoGenerateColumns="false" runat="server" Width="100%">

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
                            </Columns>
                        </asp:GridView>
                        <asp:Label ID="lblNoRecordFound" Text="No Record Found" runat="server" Font-Size="XX-Large"
                            Font-Bold="true" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
