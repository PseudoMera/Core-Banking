<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Core.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style>
        body {
            background:#ccc;
        }

        h2 {
            text-align:center;
        }

        .formClass {
            padding:10px;
            margin:0px auto;
            background:#ffffff;
            width:200px;
        }

        .input {
            padding:2px;
            width:100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="formClass">
            <h2>LogIn</h2>
            <asp:TextBox ID="TxtUser" CssClass="input" placeholder="user name" runat="server">
            </asp:TextBox><br />
            
            <asp:TextBox ID="TxtPassword" CssClass="input" placeholder="password" TextMode="Password" runat="server">
            </asp:TextBox><br />

            <asp:Button ID="BtnLog" class="button" CssClass="input"  runat="server" Text="Log In" OnClick="BtnLog_Click" />

        </div>
    </form>
</body>
</html>
