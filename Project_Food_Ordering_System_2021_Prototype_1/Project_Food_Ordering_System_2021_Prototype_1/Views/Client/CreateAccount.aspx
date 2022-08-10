<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateAccount.aspx.cs" Inherits="Project_Food_Ordering_System_2021_Prototype_1.CreateAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="StaffStyleSheet.css" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 647px;
        }
        .auto-style2 {
            width: 459px;
        }
        .auto-style3 {
            width: 459px;
            height: 146px;
            text-align: center;
        }
        .auto-style4 {
            height: 146px;
        }
        .auto-style5 {
            width: 100%;
            height: 430px;
        }
        .auto-style6 {
            text-align: center;
        }
        .auto-style7 {
            text-align: right;
        }
        .auto-style8 {
            width: 459px;
            text-align: center;
        }
        .auto-style9 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                        <asp:Label ID="Label2" runat="server" Font-Size="32pt" Text="Student Centre Cafeteria" ForeColor="White"></asp:Label>
                        <br />
                        <asp:Label ID="Label4" runat="server" Font-Size="16pt" Text="Create Account"></asp:Label>
                    </td>
                <td class="auto-style4"></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <table class="auto-style5">
                        <tr>
                            <td class="auto-style6" colspan="2">Sign Up for Your New Account</td>
                        </tr>
                        <tr>
                            <td class="auto-style7">
                                <asp:Label ID="Label5" runat="server" Text="User Name:"></asp:Label>
                            </td>
                            <td class="auto-style9">
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style7">
                                <asp:Label ID="Label6" runat="server" Text="User Surname:"></asp:Label>
                            </td>
                            <td class="auto-style9">
                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style7">
                                <asp:Label ID="Label9" runat="server" Text="E-mail:"></asp:Label>
                            </td>
                            <td class="auto-style9">
                                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style7">
                                <asp:Label ID="Label7" runat="server" Text="Password:"></asp:Label>
                            </td>
                            <td class="auto-style9">
                                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style7">
                                <asp:Label ID="Label8" runat="server" Text="Confirm Password:"></asp:Label>
                            </td>
                            <td class="auto-style9">
                                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style6" colspan="2">
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox4" ControlToValidate="TextBox5" ErrorMessage="The Password and Confirmation Password must match."></asp:CompareValidator>
                            </td>
                        </tr>
                    </table>
                    <br />
                    <asp:Button ID="btnCreate" runat="server" Height="25px" Text="Create" Width="80px" />
&nbsp;
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
