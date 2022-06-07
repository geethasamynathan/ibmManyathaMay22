<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sessionsource.aspx.cs" Inherits="StateManagementDemo.Sessionsource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>server side State management- sessionstate</h2>

            <br />
            <br />
            Username :
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br />
            <br />
            Password :<asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btnNext" runat="server" OnClick="btnNext_Click" Text="Next" />
&nbsp;&nbsp;&nbsp;

        </div>
    </form>
</body>
</html>
