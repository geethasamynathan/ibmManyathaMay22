<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My First Page</title>
    <style type="text/css">
       /* .auto-style1 {
            width: 36%;
            height: 220px;
        }
        .auto-style2 {
            background-color: #993333;
        }
        .auto-style3 {
            font-size: medium;
            color: #FFFFFF;
        }*/
        .table1{
            margin:100px 200px 20px 200px;
            background-color:aquamarine;
        }
    </style>
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
                <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="height: 29px" Text="Login" CssClass="auto-style3" ForeColor="Black" />
                    </td>
                    <td class="auto-style2">
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="auto-style3" ForeColor="Black" />
                    </td>
                </tr>
            </table>
            <p>  This is My First webForm</p>
            <p>  
                <asp:Label ID="lblLogin" runat="server" Text="Login Form"></asp:Label>
            </p>
            <p>  
            &nbsp;&nbsp;&nbsp;
                </p>
              <p>  
            &nbsp;&nbsp;&nbsp;
                </p>
            <p>  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </p>
            <p>  
                &nbsp;</p>
            <p>  
                &nbsp;</p>
            <p>  &nbsp;</p>
            <p>  &nbsp;</p>
            <p>  &nbsp;</p>
        </div>
    </form>
</body>
</html>
