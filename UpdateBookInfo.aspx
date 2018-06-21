<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateBookInfo.aspx.cs" Inherits="UpdateBookInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="table-responsive">
        <div style="background-color:dodgerblue;color:whitesmoke"> Update Book Information </div>
        <asp:GridView ID="grdBooks" AutoGenerateColumns="False" runat="server" Width="100%" OnRowCommand="grdBooks_RowCommand">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lbEdit" CommandArgument='<%# Eval("Id") %>' CommandName="EditRow" ForeColor="#8C4510" runat="server">Edit</asp:LinkButton>
                        <asp:LinkButton ID="lbDelete" CommandArgument='<%# Eval("Id") %>' CommandName="DeleteRow" ForeColor="#8C4510" runat="server" CausesValidation="false">Delete</asp:LinkButton>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:LinkButton ID="lbUpdate" CommandArgument='<%# Eval("Id") %>' CommandName="UpdateRow" ForeColor="#8C4510" runat="server">Update</asp:LinkButton>
                        <asp:LinkButton ID="lbCancel" CommandArgument='<%# Eval("Id") %>' CommandName="CancelUpdate" ForeColor="#8C4510" runat="server" CausesValidation="false">Cancel</asp:LinkButton>
                    </EditItemTemplate>
                </asp:TemplateField>



                <asp:TemplateField HeaderText="Id">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtId" runat="server" Text='<%# Bind("Id") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblId" runat="server" Text='<%# Bind("Id") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Book Name">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtBookName" runat="server" Text='<%# Bind("BookName") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblBookName" runat="server" Text='<%# Bind("BookName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Book Code">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtBookCode" runat="server" Text='<%# Bind("BookCode") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblBookCode" runat="server" Text='<%# Bind("BookCode") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="BuyBack Rate">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtBuyBackRate" runat="server" Text='<%# Bind("BuyBackRate") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblBuyBackRate" runat="server" Text='<%# Bind("BuyBackRate") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Rental Rate">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtRentalRate" runat="server" Text='<%# Bind("RentalRate") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblRentalRate" runat="server" Text='<%# Bind("RentalRate") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Penalty Rate">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtPenaltyRate" runat="server" Text='<%# Bind("PenaltyRate") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblPenaltyRate" runat="server" Text='<%# Bind("PenaltyRate") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Market Rate">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtMarketRate" runat="server" Text='<%# Bind("MarketRate") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblMarketRate" runat="server" Text='<%# Bind("MarketRate") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Demand Value">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtDemandValue" runat="server" Text='<%# Bind("DemandValue") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblDemandValue" runat="server" Text='<%# Bind("DemandValue") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Stock Value">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtStockValue" runat="server" Text='<%# Bind("StockValue") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblStockValue" runat="server" Text='<%# Bind("StockValue") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Book Image">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtImage" runat="server" Text='<%# Eval("Image") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Image ID="lblImage" runat="server" ImageUrl='<%# Eval("Image") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField></asp:TemplateField>


            </Columns>
        </asp:GridView>
    </form>

</body>
</html>
