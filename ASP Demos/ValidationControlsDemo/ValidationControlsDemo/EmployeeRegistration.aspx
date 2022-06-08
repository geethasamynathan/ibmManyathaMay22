<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeRegistration.aspx.cs" Inherits="ValidationControlsDemo.EmployeeRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#CC3300" />
            <br />
            <br />
            Name :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" ErrorMessage="Name Required" ForeColor="#CC3300">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Email :&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Enter Email id" ForeColor="#CC3300">*</asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Enter Porper Email id" ForeColor="#CC3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
            <br />
            <br />
            Mobile:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="revMobile" runat="server" ControlToValidate="txtMobile" ErrorMessage="Mobile no should only a Numbers" ForeColor="#CC3300" ValidationExpression="^[6-9]\d{9}$">*</asp:RegularExpressionValidator>
            <br />
            <br />
            <br />
            Gender :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButtonList ID="rbtnGender" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />
            Employee Age&nbsp; :&nbsp;&nbsp;
            <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
&nbsp;<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtAge" ErrorMessage="Min value 20 and Maximum age 70" ForeColor="#CC3300" MaximumValue="70" MinimumValue="20">*</asp:RangeValidator>
            <br />
            <br />
            Department :&nbsp; <asp:TextBox ID="txtDepartment" runat="server"></asp:TextBox>
            <br />
            <br />
            Address :
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            DOB :&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDOB" runat="server" TextMode="Date"></asp:TextBox>
&nbsp;<br />
            <br />
            <br />
            <br />
            Postal Code :<asp:TextBox ID="txtPostalCode" runat="server"></asp:TextBox>
&nbsp;<asp:RegularExpressionValidator ID="revPostalCode" runat="server" ControlToValidate="txtPostalCode" ErrorMessage="postal code have 6 digits" ForeColor="#CC3300" ValidationExpression="\d{6}">*</asp:RegularExpressionValidator>
            <br />
            <br />
            <br />
            Password :<asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;<br />
            <br />
            ConfirmPassword :<asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:CompareValidator ID="cvConfirmPassword" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" ErrorMessage="password and ConfirmPassword should same." ForeColor="#CC3300">*</asp:CompareValidator>
            <br />
            <br />
            UserId : <asp:TextBox ID="txtUserid" runat="server"></asp:TextBox>
&nbsp;<asp:CustomValidator ID="CustomValidator1" 
                runat="server" ErrorMessage="Userid have min 6 chars and max 25 chars" ControlToValidate="txtUserid"
    ForeColor="#CC3300" OnServerValidate="UserCustomValidator"></asp:CustomValidator>
            <br />
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" />

        </div>
    </form>
</body>
</html>
