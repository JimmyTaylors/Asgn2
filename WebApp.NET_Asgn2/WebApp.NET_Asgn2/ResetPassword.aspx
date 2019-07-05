<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResetPassword.aspx.cs" Inherits="WebApp.NET_Asgn2.ResetPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reset Password</title>
    <link href='https://fonts.googleapis.com/css?family=Open+Sans:700,600' rel='stylesheet' type='text/css' />

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

        #btn2 {
            float: left;
            background: #3498db;
            width: 125px;
            padding-top: 5px;
            padding-bottom: 5px;
            color: white;
            border-radius: 4px;
            border: #2980b9 1px solid;
            margin-top: 20px;
            margin-bottom: 20px;
            margin-left: 10px;
            font-weight: 800;
            font-size: 0.8em;
        }

            #btn2:hover {
                background: #3594D2;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="Panel2" runat="server" CssClass="box" Visible="true">
            <h1>Staff Reset Password</h1>

            <%--Check for Staff ID--%>
            <asp:TextBox runat="server" type="text" ID="txtIDFP" CssClass="email" placeholder="Enter your ID"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvTxtIDFP" ControlToValidate="txtIDFP" ErrorMessage="Staff ID is required!" runat="server" />
            <asp:Button runat="server" ID="btnIDCheck" Text="Check Staff ID" OnClick="btnIDCheck_Click" CssClass="btn" PostBackUrl="~/ResetPassword.aspx" />

            <asp:Panel runat="server" ID="Panel3" Visible="false">
                <%--Check for SQ--%>
                <asp:TextBox runat="server" type="text" ID="txtSQ" CssClass="email" Enabled="false"></asp:TextBox>
                <asp:TextBox runat="server" type="text" ID="txtSQAEntered" CssClass="email" placeholder="Enter your Answer"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvTxtSQAEntered" ControlToValidate="txtSQAEntered" ErrorMessage="Please enter Security Answer" runat="server" />
                <asp:Button runat="server" ID="btnSQACheck" Text="Check SQ Answer" OnClick="btnSQACheck_Click" CssClass="btn" PostBackUrl="~/ResetPassword.aspx" />
            </asp:Panel>

            <asp:Panel runat="server" ID="Panel4" Visible="false">
                <%--Change PW--%>
                <asp:TextBox runat="server" type="text" ID="txtPWEntered1" CssClass="email" placeholder="Enter new password"></asp:TextBox>
                <asp:TextBox runat="server" type="text" ID="txtPWEntered2" CssClass="email" placeholder="Enter new password again"></asp:TextBox>
                <asp:CompareValidator ID="cmpResetPassword" ControlToValidate="txtPWEntered1" ControlToCompare="txtPWEntered2" ErrorMessage="Password not match" runat="server" /><br />
                <asp:Button runat="server" ID="btnPWChange" Text="Submit" OnClick="btnPWChange_Click" CssClass="btn" PostBackUrl="~/ResetPassword.aspx" />
                <asp:Button runat="server" ID="btnCancel" Text="Cancel" OnClick="btnCancel_Click" CssClass="btn" PostBackUrl="~/ResetPassword.aspx" />
            </asp:Panel>

        </asp:Panel>
    </form>
</body>
</html>
