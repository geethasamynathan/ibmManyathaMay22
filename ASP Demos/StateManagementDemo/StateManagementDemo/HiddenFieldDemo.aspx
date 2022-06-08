<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HiddenFieldDemo.aspx.cs" Inherits="StateManagementDemo.HiddenFieldDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2> Client Side state Management-HiddenField demonstration</h2>

            <p> Enter the Information :<asp:TextBox ID="txtInfo" runat="server"></asp:TextBox>
            </p>
            <p> &nbsp;</p>
            <p> 
                <asp:Button ID="btnStore" runat="server" Text="Store" OnClick="btnStore_Click" />
&nbsp;&nbsp;
                <asp:Button ID="btnLoad" runat="server" Text="Load" OnClick="btnLoad_Click" />
            </p>
            <p> 
                <asp:HiddenField ID="HiddenField1" runat="server" />
            </p>
            <p> 
                &nbsp;</p>
            <p> 
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </p>
            <p> 
                &nbsp;</p>
            <p> 
                &nbsp;</p> 
        </div>
    </form>
</body>
</html>
