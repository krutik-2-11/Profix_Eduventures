<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BuyBook.aspx.cs" Inherits="BuyBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Buy Book</title>
    <style type="text/css">
        .auto-style1 {
            height: 224px;
        }

        .auto-style2 {
            width: 997px;
            height: 301px;
        }
    </style>
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" style="width:100%" class="table-responsive">

        <table border="2" style="width:inherit" class="table-borderless">
            <tr>
                <th style="background-color:dodgerblue;color:whitesmoke">Buy Book
                </th>
            </tr>

            <tr>
                <td class="auto-style1">
                    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>

                    <asp:GridView ID="grdAvailableBooks" AutoGenerateColumns="False" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover" BackColor="Wheat">

                        <Columns>

                            <asp:BoundField DataField="Id" HeaderText="Id" />
                            <asp:BoundField DataField="BookName" HeaderText="Book Name" />
                            <asp:BoundField DataField="BookCode" HeaderText="Book Code" />
                            <asp:BoundField DataField="RentalRate" HeaderText="Rental Rate" />
                            <asp:BoundField DataField="MarketRate" HeaderText="Market Rate" />
                            <asp:BoundField DataField="StockValue" HeaderText="Stock Value" />
                            <asp:TemplateField HeaderText="Buy">
                                <ItemTemplate>
                                    <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="true" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                    <asp:Label ID="lblNoRecordFound" Text="No Record Found" runat="server" Font-Size="XX-Large"
                        Font-Bold="true" ForeColor="Red"></asp:Label>
                </td>
            </tr>
        </table>

        <asp:Button ID="Button1" runat="server" CssClass="btn-success" OnClick="Button1_Click" Text="Buy Selected Books" />
        <asp:Label ID="lblConfirm" runat="server" ForeColor="Green"></asp:Label>
        
    </form>
</body>
</html>
