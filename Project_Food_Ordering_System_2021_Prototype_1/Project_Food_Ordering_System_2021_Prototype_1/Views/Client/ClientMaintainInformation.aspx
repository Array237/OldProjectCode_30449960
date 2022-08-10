<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ClientMaintainInformation.aspx.cs" Inherits="Project_Food_Ordering_System_2021_Prototype_1.ClientMaintainInformation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 20px;
        }
        .auto-style2 {
            text-align: center;
            height: 28px;
        }
        .auto-style4 {
            height: 26px;
        }
        .auto-style6 {
            height: 24px;
        }
        .auto-style7 {
            height: 24px;
            width: 209px;
        }
        .auto-style8 {
            width: 209px;
        }
        .auto-style9 {
            height: 26px;
            width: 209px;
        }
        .auto-style10 {
            height: 20px;
            width: 209px;
        }
        .auto-style11 {
            color: #78635a;
            text-align: center;
            font-size: 16px;
            border-radius: 4px;
            border: 2px solid rgb(120, 99, 90);
            background-color: white;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style2" colspan="4">
                        <asp:Label ID="Label5" runat="server" Font-Size="16pt" Text="Edit accout information"></asp:Label>
                                </td>
        </tr>
        <tr>
            <td colspan="2">
                        <asp:Label ID="Label9" runat="server" Font-Size="16pt" Text="Email Change:"></asp:Label>
                                </td>
            <td>
                        <asp:Label ID="Label13" runat="server" Font-Size="16pt" Text="Password Change:"></asp:Label>
                                </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">
                                    <asp:Label ID="Label8" runat="server" Text="University Number:" Font-Bold="True"></asp:Label>
                                </td>
            <td class="auto-style7">
                                    <asp:TextBox ID="txtUniversityNumber" runat="server" ReadOnly="True"></asp:TextBox>
                                </td>
            <td class="auto-style6">
                                    <asp:Label ID="Label6" runat="server" Text="New Pasword:" Font-Bold="True"></asp:Label>
                                </td>
            <td class="auto-style6">
                                    <asp:TextBox type="password" ID="txtNewPassword" runat="server"></asp:TextBox>
                                </td>
        </tr>
        <tr>
            <td>
                                    <asp:Label ID="Name" runat="server" Text="Name:" Font-Bold="True"></asp:Label>
                                </td>
            <td class="auto-style8">
                                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                                </td>
            <td>
                                    <asp:Label ID="Label14" runat="server" Text="Confirm Password:" Font-Bold="True"></asp:Label>
                                </td>
            <td>
                                    <asp:TextBox type="password" ID="txtConfirmPassword" runat="server"></asp:TextBox>
                                </td>
        </tr>
        <tr>
            <td class="auto-style4">
                                    <asp:Label ID="lblSurname" runat="server" Text="Surname:" Font-Bold="True"></asp:Label>
                                </td>
            <td class="auto-style9">
                                    <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
                                </td>
            <td class="auto-style4">
                        <asp:Button ID="btnChangePass" runat="server" Text="Change Password" OnClick="btnChangePassword" CssClass="myButtons" Width="150px"/>
                        </td>
            <td class="auto-style4">
                                    <asp:Label ID="lblErrorSuccessPassword" runat="server" Text="*" Font-Bold="True" Visible="False"></asp:Label>
                                </td>
        </tr>
        <tr>
            <td class="auto-style1">
                                    <asp:Label ID="Label11" runat="server" Text=" Email:" Font-Bold="True"></asp:Label>
                                </td>
            <td class="auto-style10">
                                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                                </td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                        <asp:Button ID="btnUpdateInfo" runat="server" Text="Update Account" OnClick="btnUpdateInformation" CssClass="myButtons" Width="150px"/>
                        </td>
            <td class="auto-style10">
                                    <asp:Label ID="lblErrorSuccess" runat="server" Text="*" Font-Bold="True" Visible="False"></asp:Label>
                                </td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
