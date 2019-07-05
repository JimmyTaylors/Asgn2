<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="WebApp.NET_Asgn2.Order" %>

<!DOCTYPE html>
<style>
    .style1 {
        font-weight: bold;
        color: midnightblue;
        float: right;
        display: inline;
    }
</style>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button runat="server" ID="btnExtract" Text="Extract" OnClick="btnExtract_Click" />
        <asp:TextBox runat="server" ID="staffID" CssClass="style1"></asp:TextBox>
        <asp:TextBox runat="server" ID="staffName" CssClass="style1"></asp:TextBox>
        <br />
        <br />
        Order   No<asp:TextBox runat="server" ID="txtOrderNo" Width="80"></asp:TextBox><br />
        <br />
        Order   Date<asp:TextBox runat="server" ID="txtOrderDate" Width="160"></asp:TextBox><br />
        <br />
        Staff   Id
        <asp:TextBox runat="server" ID="txtStaffID" Width="400"></asp:TextBox><br />
        <br />
        Receiver    Account No<asp:TextBox runat="server" ID="txtRAno" Width="80"></asp:TextBox><br />
        <br />
        Receiver    Status
        <asp:TextBox runat="server" ID="txtRS" Width="80"></asp:TextBox><br />
        Sender  Branch  ID<asp:TextBox runat="server" ID="txtSID" Width="80"></asp:TextBox><br />
        <br />
        Time   Delivered<asp:TextBox runat="server" ID="txtTimeD" Width="80"></asp:TextBox><br />
        <br />
        <asp:Button runat="server" ID="btnClear" Text="Clear" OnClick="btnClear_Click" />
        <asp:Button runat="server" ID="btnAddNew" Text="Add New" OnClick="btnAddNew_Click" />
        <asp:Button runat="server" ID="btnDelete" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Button runat="server" ID="btnUpdate" Text="Update" OnClick="btnUpdate_Click" />
        <asp:Button runat="server" ID="btnBack" Text="Back" OnClick="btnBack_Click" />
    </form>
</body>
</html>
