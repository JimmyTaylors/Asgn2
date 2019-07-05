<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="WebApp.NET_Asgn2.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Menu</title>
    <style type="text/css">
        body {
            font-family: 'Open Sans', sans-serif;
            background: #3498db;
            margin: 0 auto 0 auto;
            width: 100%;
            text-align: center;
            margin: 20px 0px 20px 0px;
        }

        p {
            font-size: 12px;
            text-decoration: none;
            color: #ffffff;
        }

        h1, h2 {
            font-size: 1.5em;
            color: #525252;
        }

        .box {
            background: white;
            height: 430px;
            width: 300px;
            border-radius: 6px;
            margin: 0 auto 0 auto;
            padding: 0px 0px 70px 0px;
            border: #2980b9 4px solid;
        }

        .email {
            background: #ecf0f1;
            border: #ccc 1px solid;
            border-bottom: #ccc 2px solid;
            padding: 8px;
            width: 250px;
            color: #AAAAAA;
            margin-top: 10px;
            font-size: 1em;
            border-radius: 4px;
        }

        .password {
            border-radius: 4px;
            background: #ecf0f1;
            border: #ccc 1px solid;
            padding: 8px;
            width: 250px;
            font-size: 1em;
        }

        .btn {
            background: #2ecc71;
            width: 265px;
            padding-top: 5px;
            padding-bottom: 5px;
            color: white;
            border-radius: 4px;
            border: #27ae60 1px solid;
            margin-top: 20px;
            margin-bottom: 20px;
            float: left;
            margin-left: 16px;
            font-weight: 800;
            font-size: 0.8em;
        }

            .btn:hover {
                background: #2CC06B;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="myPanel" runat="server" CssClass="box">
            <h1>Menu Page</h1>
            <h2>Welcome to Admin Page</h2>

            <asp:TextBox runat="server" type="text" ID="txtID" CssClass="email" Enabled="false"></asp:TextBox>
            <asp:TextBox runat="server" type="text" ID="txtName" CssClass="email" Enabled="false"></asp:TextBox>
            <asp:Button runat="server" ID="btnEditOrdMas" Text="Edit Order Master Table" CssClass="btn" OnClick="btnEditOrdMas_Click" PostBackUrl="~/Menu.aspx" />
            <asp:Button runat="server" ID="btnEditCust" Text="Edit Customer Table" OnClick="btnEditCust_Click" CssClass="btn" PostBackUrl="~/Menu.aspx"/>
            <asp:Button runat="server" ID="btnEditStaff" Text="Edit Staff Table" OnClick="btnEditStaff_Click" CssClass="btn" PostBackUrl="~/Menu.aspx"/>
            <asp:Button runat="server" ID="btnLogout" Text="Logout" CssClass="btn" OnClick="btnLogout_Click" PostBackUrl="~/Menu.aspx"/>
        </asp:Panel>
    </form>
</body>
</html>
