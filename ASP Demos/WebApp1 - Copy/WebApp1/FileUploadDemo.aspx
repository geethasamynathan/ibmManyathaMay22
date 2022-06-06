<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUploadDemo.aspx.cs" Inherits="WebApp1.FileUploadDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2> File Upload Demonstration</h2>
            Choose the File Upload : <asp:FileUpload ID="fileupload1" runat="server" />

        &nbsp;&nbsp;
            <asp:Button ID="btnAttach" Text="Attach" runat="server" OnClick="btnAttach_Click"/>
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
