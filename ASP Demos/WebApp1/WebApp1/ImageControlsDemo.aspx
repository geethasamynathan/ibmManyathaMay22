<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImageControlsDemo.aspx.cs" Inherits="WebApp1.ImageControlsDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1"  runat="server" Height="257px" ImageUrl="~/images/art.jpg" Width="276px" />
            /<br />
            <br />
            <br />
            ImageMap Control Demo<br />
            <br />
            <asp:ImageMap 
                ID="ImageMap1" runat="server"
                Height="470px" ImageUrl="~/images/Map.jpg" Width="502px">
                <asp:CircleHotSpot AlternateText="China" HotSpotMode="Navigate" NavigateUrl="~/Default.aspx" Radius="50" X="400" Y="50" />
                <asp:CircleHotSpot AlternateText="Arabic Ocean" NavigateUrl="~/EmployeeRegistration.aspx" Radius="50" Y="400" />
            </asp:ImageMap>
        </div>
    </form>
</body>
</html>
