<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DemandBooks.aspx.cs" Inherits="DemandBooks" %>

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
                    <th>Sell Book
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
                        <asp:GridView ID="grdDemandBooks" AutoGenerateColumns="False" runat="server" Width="100%">

                            <Columns>

                                <asp:BoundField DataField="Id" HeaderText="Id" />
                                <asp:BoundField DataField="BookName" HeaderText="Book Name" />
                                <asp:BoundField DataField="BookCode" HeaderText="Book Code" />
                                <asp:BoundField DataField="BuyBackRate" HeaderText="Buy Back Rate" />
                                <asp:BoundField DataField="DemandValue" HeaderText="Demand Value" />
                                
                                <asp:TemplateField HeaderText="Sell">
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
        </div>
        <asp:Button ID="btnSellBooks" runat="server" OnClick="btnSellBooks_Click" Text="Sell Selected Books" />
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtDemand" runat="server"></asp:TextBox>
    </form>
</body>
</html>
