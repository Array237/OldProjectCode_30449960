<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ClientRegister.aspx.cs" Inherits="Project_Food_Ordering_System_2021_Prototype_1.Client.ClientRegister" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style2 {
        text-align: center;
    }
    .auto-style3 {
        width: 470px;
        height: 20px;
        text-align: right;
    }
    .auto-style4 {
        height: 20px;
    }
    .auto-style5 {
        width: 470px;
        text-align: right;
    }
        .auto-style6 {
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <table style="width:100%;">
    <tr>
        <td class="auto-style2" colspan="2">
            <strong>
            <asp:Label ID="Label5" runat="server" Text="Register Account" CssClass="auto-style6"></asp:Label>
            </strong>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">
            <asp:Label ID="Label6" runat="server" Text="User ID(Student number):"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtUserStudentNumber" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtUserStudentNumber" ErrorMessage="Enter your Student Number"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">
            <asp:Label ID="Label7" runat="server" Text="User Name:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtUserName" ErrorMessage="Enter your Name"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">
            <asp:Label ID="Label8" runat="server" Text="User Surname:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtUserSurname" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserSurname" ErrorMessage="Enter your Surname"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">
            <asp:Label ID="Label9" runat="server" Text="Email:"></asp:Label>
        </td>
        <td class="auto-style4">
            <asp:TextBox ID="txtUserEmail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtUserEmail" ErrorMessage="Must fill in the email"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtUserEmail" ErrorMessage="Enter a vailid email!!" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">
            <asp:Label ID="Label10" runat="server" Text="Password:"></asp:Label>
        </td>
        <td>
            <asp:TextBox type="password" ID="txtUserPassword" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtUserPassword" ErrorMessage="Enter a Password"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">
            <asp:Label ID="Label11" runat="server" Text="Confirm Password:"></asp:Label>
        </td>
        <td>
            <asp:TextBox type="password" ID="txtUserConfirm" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtUserConfirm" ErrorMessage="Enter Password"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="txtUserPassword" ControlToValidate="txtUserConfirm" ErrorMessage="Passwords does not match"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style2" colspan="2">
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtUserPassword" ControlToValidate="txtUserConfirm" ErrorMessage="The Password and Confirmation Password must match."></asp:CompareValidator>
                            </td>
    </tr>
    <tr>
        <td class="auto-style2" colspan="2">
                    <asp:Label ID="lblExistingUser" runat="server" Text="Student Number already exist" Visible="False"></asp:Label>
                    <br />
                    <asp:Button ID="btnCreate" runat="server" Text="Create" OnClick="btnCreate_Click" CssClass="myButtons"/>
        </td>
    </tr>
</table>
</asp:Content>
