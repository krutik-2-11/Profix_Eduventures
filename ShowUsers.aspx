<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowUsers.aspx.cs" Inherits="ShowUsers" %>

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
                    <th>Show Customers
                    </th>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCustomerName" Text="Customer Name" runat="server"></asp:Label>
                        <asp:TextBox ID="txtCustomerName" CssClass="textfield" runat="server"></asp:TextBox>
                        <asp:Button ID="btnSearch" Text="Search" CssClass="smartbutton" runat="server" OnClick="btnSearch_Click"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                        <asp:GridView ID="grdUsers" AutoGenerateColumns="false" runat="server" Width="100%">

                            <Columns>
                                
                                <asp:BoundField DataField="Id" HeaderText="Id" />
                                <asp:BoundField DataField="Name" HeaderText="Customer Name" />
                                <asp:BoundField DataField="Section" HeaderText="Section" />
                                <asp:BoundField DataField="Enrollment" HeaderText="Enrollment" />
                                <asp:BoundField DataField="Email" HeaderText="Email Id" />
                                <asp:BoundField DataField="Phone" HeaderText="Contact No" />


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
