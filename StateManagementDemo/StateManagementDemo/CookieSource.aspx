<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookieSource.aspx.cs" Inherits="StateManagementDemo.CookieSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2> Client-side State Management -Cookies Source</h2>
            <p> &nbsp;</p>
            <p> Country Name:<asp:TextBox ID="txtCountryName" runat="server"></asp:TextBox>
            </p>
            <p> &nbsp;</p>
            <p> Country Code :<asp:TextBox ID="txtCountryCode" runat="server"></asp:TextBox>
            </p>
            <p> &nbsp;</p>
            <p> 
                <asp:Button ID="btnGoNext" runat="server" OnClick="btnGoNext_Click" Text="Go Next" />
            </p>
        </div>
    </form>
</body>
</html>
