<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="WebApp.NET_Asgn2.Customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .style1 {
            font-weight: bold;
            color: midnightblue;
            float: right;
            display: inline;
        }
    </style>


</head>
<body>
    <form id="form1" runat="server">
        <asp:Button runat="server" ID="btnExtract" Text="Extract" OnClick="btnExtract_Click" />
        <br />
        <br />
        <asp:TextBox runat="server" ID="staffID" CssClass="style1"></asp:TextBox>
        <asp:TextBox runat="server" ID="staffName" CssClass="style1"></asp:TextBox>
        Customer Account Number
        <asp:TextBox runat="server" ID="txtCAccount" Width="80"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ControlToValidate="txtCAccount" ForeColor="Red" ErrorMessage="Please fill Account Number" ValidationGroup="s"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator runat="server" ID="rsvAcc" ControlToValidate="txtCAccount" ForeColor="Red" ErrorMessage="Please fill Account Number" ValidationGroup="c"></asp:RequiredFieldValidator><br />
        <br />
        Customer Name
        <asp:TextBox runat="server" ID="txtCName" Width="160"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ID="rsvName" ControlToValidate="txtCName" ForeColor="Red" ErrorMessage="Please fill Name" ValidationGroup="s"></asp:RequiredFieldValidator><br />
        <br />
        Customer Address
        <asp:TextBox runat="server" ID="txtCAddress" Width="400"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator2" ControlToValidate="txtCAddress" ForeColor="Red" ErrorMessage="Please fill Address" ValidationGroup="s"></asp:RequiredFieldValidator><br />
        <br />
        Customer Telephone number
        <asp:TextBox runat="server" ID="txtCTel" Width="80"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator3" ControlToValidate="txtCTel" ForeColor="Red" ErrorMessage="Please fill Telephone Number. ex: 010-2285892" ValidationGroup="s"></asp:RequiredFieldValidator><br />
        <br />
        Customer Status
        <asp:TextBox runat="server" ID="txtCStatus" Width="80"></asp:TextBox>1 = Active, 0 = Inactive
        <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator4" ControlToValidate="txtCStatus" ForeColor="Red" ErrorMessage="Please fill Status" ValidationGroup="s"></asp:RequiredFieldValidator>
        <asp:RangeValidator runat="server" ID="RequiredFieldValidator5" ControlToValidate="txtCStatus" Type="Integer" MinimumValue="0" MaximumValue="1" ForeColor="Red" ErrorMessage="Please only enter 0 or 1" ValidationGroup="s"></asp:RangeValidator><br />
        <asp:Button runat="server" ID="btnClear" Text="Clear" OnClick="btnClear_Click" />
        <asp:Button runat="server" ID="btnAddNew" Text="Add New" OnClick="btnAddNew_Click" ValidationGroup="s" />
        <asp:Button runat="server" ID="btnDelete" Text="Delete" OnClick="btnDelete_Click" ValidationGroup="c" />
        <asp:Button runat="server" ID="btnUpdate" Text="Update" OnClick="btnUpdate_Click" ValidationGroup="s" />
        <asp:Button runat="server" ID="btnBack" Text="Back" OnClick="btnBack_Click" />
    </form>
</body>
</html>

