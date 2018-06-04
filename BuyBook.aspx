<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BuyBook.aspx.cs" Inherits="BuyBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Buy Book</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table border="2" cellpadding="5" class="tablegrid" cellspacing="0" width="100%">
                <tr>
                    <th>Buy Book
                    </th>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblBookName" Text="Search Book Name" runat="server"></asp:Label>
                        <asp:TextBox ID="txtBookName" CssClass="textfield" runat="server"></asp:TextBox>
                        <asp:Button ID="btnSearch" Text="Search" CssClass="smartbutton" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>

                        <asp:GridView ID="grdAvailableBooks" AutoGenerateColumns="False" runat="server" Width="100%">

                            <Columns>

                                <asp:BoundField DataField="Id" HeaderText="Id"/>
                                <asp:BoundField DataField="BookName" HeaderText="Book Name" />
                                <asp:BoundField DataField="BookCode" HeaderText="Book Code" />
                                <asp:BoundField DataField="RentalRate" HeaderText="Rental Rate" />
                                <asp:BoundField DataField="MarketRate" HeaderText="Market Rate" />
                                <asp:BoundField DataField="StockValue" HeaderText="Stock Value" />
                                <asp:TemplateField HeaderText="Buy">
                                    <ItemTemplate>
                                        <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="true"/>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                        <asp:Label ID="lblNoRecordFound" Text="No Record Found" runat="server" Font-Size="XX-Large"
                            Font-Bold="true" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Buy Selected Books" />
        <asp:Label ID="lblConfirm" runat="server" ForeColor="Green"></asp:Label>
        <asp:TextBox ID="txtValue" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
    </form>
</body>
</html>
