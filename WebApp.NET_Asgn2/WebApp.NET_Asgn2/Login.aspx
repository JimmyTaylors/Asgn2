<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApp.NET_Asgn2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <link href='https://fonts.googleapis.com/css?family=Open+Sans:700,600' rel='stylesheet' type='text/css'>

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

        h1 {
            font-size: 1.5em;
            color: #525252;
        }

        .box {
            background: white;
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
            width: 125px;
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
            <h1>Staff Login</h1>

            <asp:TextBox runat="server" type="text" ID="txtID" CssClass="email" placeholder="Enter your ID"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvTxtID" ControlToValidate="txtID" ErrorMessage="Staff ID is required!" runat="server" ValidationGroup="login" />

            <asp:TextBox runat="server" type="password" ID="txtPW" CssClass="email" placeholder="Enter your password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvTxtPW" ControlToValidate="txtPW" ErrorMessage="Staff Password is required!" runat="server" ValidationGroup="login" />

            <asp:Button runat="server" ID="btnPwForgot" Text="Forgot Pw?" OnClick="btnPwForgot_Click" CssClass="btn" />

            <asp:Button runat="server" ID="btnLogin" Text="Login" OnClick="btnLogin_Click" CssClass="btn" PostBackUrl="~/Login.aspx" ValidationGroup="login" />
        </asp:Panel>

        <asp:Panel ID="Panel1" runat="server" Visible="true">
            <asp:Label runat="server" ID="labFailAuth"></asp:Label>
        </asp:Panel>



    </form>
</body>
</html>
