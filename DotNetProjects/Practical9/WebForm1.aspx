<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Practical9.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 52px;
        }
        .auto-style2 {
            width: 281px;
            height: 122px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style2">
            <tr>
                <td>Name: </td>
                <td>
                    <asp:TextBox runat="server" ID="username" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style1">
                    <asp:Button runat="server" ID="button" OnClick="button_Click" Text="Submit" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
