<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="aspAddCustomer.aspx.cs" Inherits="addUser.aspAddCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Customer Details</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:Panel ID="pnlFormDataInput" runat="server" GroupingText="Add User Form" Width="361px">
            <asp:Label ID="lblName" runat="server" Text="Customer Name: "></asp:Label>
            <asp:TextBox ID="txtCustName" runat="server" Width="136px"></asp:TextBox>
            <br />
            <asp:Label ID="lblCustAddr" runat="server" Text="Customer Address: "></asp:Label>
            <asp:TextBox ID="txtCustAddr" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lvlCountry" runat="server" Text="Customer Country:   "></asp:Label>
            <asp:TextBox ID="txtCustCountry" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCity" runat="server" Text="Customer City: "></asp:Label>
            <asp:TextBox ID="txtCustCity" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblPincode" runat="server" Text="Customer Pincode: "></asp:Label>
            <asp:TextBox ID="txtCustPincode" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnAddCustomer" runat="server" OnClick="btnAddCustomer_Click1" Text="Add Customer Data" />
        </asp:Panel>
        
    </div>
        <div>
            <asp:HiddenField ID="HiddenField1" runat="server" />
            <asp:GridView ID="GridView1" runat="server" Caption="Customer Data" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
