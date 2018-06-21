<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowUsers.aspx.cs" Inherits="ShowUsers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Users</title>
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" style="width:100%" class="table-responsive">
        

            <table style="width:inherit" class="table-borderless">
                <tr>
                    <th style="background-color:indianred;color:whitesmoke">Show Customers
                    </th>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCustomerName" Text="Customer Name" ForeColor="Maroon" Font-Bold="true" runat="server"></asp:Label>
                        <asp:TextBox ID="txtCustomerName" CssClass="textfield" runat="server"></asp:TextBox>
                        <asp:Button ID="btnSearch" Text="Search" CssClass="btn-danger" runat="server" OnClick="btnSearch_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                        <asp:GridView ID="grdUsers" AutoGenerateColumns="false" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover" BackColor="Wheat">

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
        
    </form>
</body>
</html>
