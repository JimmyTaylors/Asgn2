<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="WebApp.NET_Asgn2.Staff" %>

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
        Staff ID
        <asp:TextBox runat="server" ID="txtSID" Width="80"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ControlToValidate="txtSID" ForeColor="Red" ErrorMessage="Please fill Staff ID" ValidationGroup="s"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator runat="server" ID="rsvAcc" ControlToValidate="txtSID" ForeColor="Red" ErrorMessage="Please fill Staff ID" ValidationGroup="c"></asp:RequiredFieldValidator><br />
        <br />
        Staff Name
        <asp:TextBox runat="server" ID="txtSName" Width="160"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ID="rsvName" ControlToValidate="txtSName" ForeColor="Red" ErrorMessage="Please fill Name" ValidationGroup="s"></asp:RequiredFieldValidator><br />
        <br />
        Staff Email
        <asp:TextBox runat="server" ID="txtSEmail" Width="400"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator2" ControlToValidate="txtSEmail" ForeColor="Red" ErrorMessage="Please fill Email" ValidationGroup="s"></asp:RequiredFieldValidator><br />
        <br />
        Staff Password
        <asp:TextBox runat="server" ID="txtSPW" Width="80"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator3" ControlToValidate="txtSPW" ForeColor="Red" ErrorMessage="Please fill Password" ValidationGroup="s"></asp:RequiredFieldValidator><br />
        <br />
        Staff Safety Question
        <asp:TextBox runat="server" ID="txtSSQ" Width="80"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator4" ControlToValidate="txtSSQ" ForeColor="Red" ErrorMessage="Please fill Safety Question" ValidationGroup="s"></asp:RequiredFieldValidator><br />
        Staff Safety Question Answer
        <asp:TextBox runat="server" ID="txtSQA" Width="80"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator5" ControlToValidate="txtSQA" ForeColor="Red" ErrorMessage="Please fill Safety Question Answer" ValidationGroup="s"></asp:RequiredFieldValidator><br />
        <br />
        <asp:Button runat="server" ID="btnClear" Text="Clear" OnClick="btnClear_Click" />
        <asp:Button runat="server" ID="btnAddNew" Text="Add New" OnClick="btnAddNew_Click" ValidationGroup="s" />
        <asp:Button runat="server" ID="btnDelete" Text="Delete" OnClick="btnDelete_Click" ValidationGroup="c" />
        <asp:Button runat="server" ID="btnUpdate" Text="Update" OnClick="btnUpdate_Click" ValidationGroup="s" />
        <asp:Button runat="server" ID="btnBack" Text="Back" OnClick="btnBack_Click" />
    </form>
</body>
</html>

