<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MultiViewDemo.aspx.cs" Inherits="WebApp1.MultiViewDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 223px;
        }
        .auto-style2 {
            width: 223px;
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:MultiView ID="MultiView1" runat="server" >
                <asp:View ID="StudentDetailsView" runat="server">

                    <br />
                    <asp:Label ID="lblFirstName" runat="server" Text="FirstName"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lblLastName" runat="server" Text="LastName"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="btnNext1" runat="server" Text="Next" OnClick="btnNext1_Click" />

                </asp:View>
                <asp:View ID="CourseView" runat="server">
                    <asp:Label ID="lblCourse" runat="server" Text="Course"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtCourse" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="lblBranch" runat="server" Text="Branch"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtBranch" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="btnNext2" runat="server" OnClick="btnNext2_Click" Text="Next" />
                    <br />
                </asp:View>
                <asp:View ID="PersonalView" runat="server">
                    <br />
                    Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    Contact No&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtContactNo" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    City&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="btnNext3" runat="server" OnClick="btnNext3_Click" Text="Next" />
                    <br />
                </asp:View>
                <asp:View ID="StudentInfo" runat="server">
                    <table style="width:100%;">
                        <tr>
                            <td class="auto-style1">FirstName</td>
                            <td>
                                <asp:Label ID="lblFname" runat="server"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style2">LastName</td>
                            <td class="auto-style3">
                                <asp:Label ID="lblLname" runat="server"></asp:Label>
                            </td>
                            <td class="auto-style3"></td>
                        </tr>
                        <tr>
                            <td class="auto-style1">Course</td>
                            <td>
                                <asp:Label ID="lblCourse1" runat="server"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style2">Branch</td>
                            <td class="auto-style3">
                                <asp:Label ID="lblBranch1" runat="server"></asp:Label>
                            </td>
                            <td class="auto-style3"></td>
                        </tr>
                        <tr>
                            <td class="auto-style1">Emai</td>
                            <td>
                                <asp:Label ID="lblEmail1" runat="server"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style1">Contact No</td>
                            <td>
                                <asp:Label ID="lblContactNO" runat="server"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style1">City</td>
                            <td>
                                <asp:Label ID="lblCity" runat="server"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style1">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                    <br />
                    <asp:Button ID="btnFinish" runat="server" OnClick="btnFinish_Click" Text="Finish" />
                    <br />
                </asp:View>
            </asp:MultiView>
            
        </div>
    </form>
</body>
</html>
