<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddNewUser.aspx.cs" Inherits="WebApp1.AddNewUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1" class="table1">
                <tr>
                    <td class="auto-style2" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblTitle" runat="server" CssClass="auto-style3" Font-Bold="True" Font-Size="Large" Text="Login Form"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">  
                <asp:Label ID="lblUsername" runat="server" Text="Enter the USername" CssClass="auto-style3"></asp:Label>
                    </td>
                    <td class="auto-style2">
                <asp:TextBox ID="txtUsername" runat="server" CssClass="auto-style3" ForeColor="Black"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">  
                <asp:Label ID="lblPassword" runat="server" Text="Enter the Password" CssClass="auto-style3"></asp:Label>
                    </td>
                    <td class="auto-style2">
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="auto-style3" ForeColor="Black"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">  
                <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="height: 29px" Text="Add New User" CssClass="auto-style3" ForeColor="Black" />
                    </td>
                    <td class="auto-style2">
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="auto-style3" ForeColor="Black" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
