<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WizardDemo.aspx.cs" Inherits="WebApp1.WizardDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
            color: #9933FF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>  Wizard Control Demonstration</h2>
            <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="2" BackColor="#F7F6F3" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" Height="546px" OnFinishButtonClick="Wizard1_FinishButtonClick" Width="977px">
                <HeaderStyle BackColor="#5D7B9D" BorderStyle="Solid" Font-Bold="True" Font-Size="0.9em" ForeColor="White" HorizontalAlign="Left" />
                <NavigationButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
                <SideBarButtonStyle BorderWidth="0px" Font-Names="Verdana" ForeColor="White" />
                <SideBarStyle BackColor="#7C6F57" BorderWidth="0px" Font-Size="0.9em" VerticalAlign="Top" />
                <StepStyle BorderWidth="0px" ForeColor="#5D7B9D" />
                <WizardSteps>
                    <asp:WizardStep ID="WizardStep1" runat="server" Title="User Registration">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="User Registration"></asp:Label>
                        <br />
                        <br />
                        FirstName&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <br />
                        <br />
                        <br />
                        LastName&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </asp:WizardStep>
                    <asp:WizardStep ID="WizardStep2" runat="server" Title="User Login"><span class="auto-style1"><strong>User Login
                        <br />
                        <br />
                        Username :
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        <br />
                        <br />
                        Password :</strong><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                        <br />
                        </span>
                        <asp:Button ID="btnLogin" runat="server" Height="55px" Text="Login" Width="128px" />
                    </asp:WizardStep>
                    <asp:WizardStep runat="server" Title="View Employees">
                        <asp:GridView ID="GridView1" runat="server">
                        </asp:GridView>
                    </asp:WizardStep>
                    <asp:WizardStep runat="server" Title="FeedBack">
                        Enter your feeback here
                    </asp:WizardStep>
                </WizardSteps>
            </asp:Wizard>

        </div>
    </form>
</body>
</html>
