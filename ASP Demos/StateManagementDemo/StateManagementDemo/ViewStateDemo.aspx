<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewStateDemo.aspx.cs" Inherits="StateManagementDemo.ViewStateDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <h2> Client Side state Management-ViewState demonstration</h2>

            Enter the Information :<asp:TextBox ID="txtInfo1" runat="server"></asp:TextBox>

            <br />
            <br />

            Entet the MobileNumber&nbsp;&nbsp; <asp:TextBox ID="txtMobileno" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
&nbsp;<asp:Button ID="btnLoad" runat="server" Text="Load" OnClick="btnLoad_Click" />

        &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnStore" runat="server" OnClick="btnStore_Click" Text="Store" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

        </div>
    </form>
</body>
</html>
