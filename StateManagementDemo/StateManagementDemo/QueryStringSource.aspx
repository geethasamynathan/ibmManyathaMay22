<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryStringSource.aspx.cs" Inherits="StateManagementDemo.QueryStringSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2> Client side Statemanagement -Query String Source</h2>


            <br />
            Enter the Name : <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter the Comapny Name :<asp:TextBox ID="txtCompanyName" placeholder="dd-mm-YYYY" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnNext" runat="server" OnClick="btnNext_Click" Text="Goto Next Page" />


        </div>
    </form>
</body>
</html>
