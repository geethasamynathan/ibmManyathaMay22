<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropDownListDemo.aspx.cs" Inherits="WebApp1.DropDownListDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2> DropDownList Demonstration</h2>

            Choose the dynamically added Items from Dropdown : <asp:DropDownList ID="ddlCountry"
                runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged"></asp:DropDownList>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="lblSelectedCountry" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            Choose the Item from DropDownlist
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Name">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=LAPTOP-0TBPBTEL\SQLEXPRESS;Initial Catalog=IBM_May_Batch;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [id], [Name] FROM [Department]"></asp:SqlDataSource>
            <br />
            <br />
            <br />
&nbsp;<br />
            Fetch department from Database&nbsp;
            <asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
