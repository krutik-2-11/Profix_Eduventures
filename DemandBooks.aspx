<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DemandBooks.aspx.cs" Inherits="DemandBooks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sell Books</title>
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" style="width:100%" class="table-responsive">
        

            <table border="2" style="width:inherit" class="table-borderless">
                <tr>
                    <th style="background-color:dodgerblue;color:whitesmoke">Sell Book
                    </th>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblBookName" Text="Search Book Name" ForeColor="Maroon" Font-Bold="true" runat="server"></asp:Label>
                        <asp:TextBox ID="txtBookName" CssClass="textfield" runat="server"></asp:TextBox>
                        <asp:Button ID="btnSearch" Text="Search" CssClass="btn-danger" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                        <asp:GridView ID="grdDemandBooks" AutoGenerateColumns="False" runat="server" CssClass="table table-striped table-bordered table-hover" BackColor="Wheat" Width="100%">

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
        
        <asp:Button ID="btnSellBooks" runat="server" OnClick="btnSellBooks_Click" Text="Sell Selected Books" CssClass="btn-primary" />
        
    </form>
</body>
</html>
