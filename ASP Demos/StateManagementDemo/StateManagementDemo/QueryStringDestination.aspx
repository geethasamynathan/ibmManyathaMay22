<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryStringDestination.aspx.cs" Inherits="StateManagementDemo.QueryStringDestination" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <h2> Client side Statemanagement -Query String Destnation</h2> 

            <asp:Button ID="btnLoadPreviousPageData" runat="server" Text="LoadPreviousPageData" OnClick="btnLoadPreviousPageData_Click" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

        </div>
    </form>
</body>
</html>
