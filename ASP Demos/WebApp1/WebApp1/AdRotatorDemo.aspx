<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdRotatorDemo.aspx.cs" Inherits="WebApp1.AdRotatorDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2> Adrototator Demo</h2>
            <p> &nbsp;</p>
            <p> 
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
            </p>
            <p> &nbsp;</p>
            <p> </p>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
<br />
                    <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/AdsFile.xml" />
                    <br />
                    <br />
                    <br />
                    <asp:Timer ID="Timer1" runat="server"
                       Interval="1000" OnTick="Timer1_Tick1">
                    </asp:Timer>
                </ContentTemplate>
            </asp:UpdatePanel>
           
           <%-- <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/AdsFile.xml"></asp:XmlDataSource>--%>
           
        </div>
    </form>
</body>
</html>
