<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project_Food_Ordering_System_2021_Prototype_1.Client.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style2 {
            text-align: right;
            width: 464px;
        }
        .auto-style5 {
            text-align: right;
            height: 26px;
            width: 464px;
        }
        .auto-style6 {
            width: 190px;
            text-align: left;
            height: 26px;
        }
        .auto-style7 {
            height: 26px;
        }
        .auto-style8 {
            text-align: center;
            height: 20px;
        }
        .auto-style9 {
            font-size: large;
        }
        .auto-style10 {
            width: 190px;
            text-align: left;
        }
        .auto-style11 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    
    <table style="width:100%;">
    <tr>
        <td class="auto-style8" colspan="3">
            <strong>
            <asp:Label ID="Label5" runat="server" Text="User Login " CssClass="auto-style9"></asp:Label>
            </strong>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label6" runat="server" Text="Staff Number/Student Number: "></asp:Label>
        </td>
        <td class="auto-style10">
            <asp:TextBox ID="txtStudentNumber" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="lblError1" runat="server" Text="Waiting for input" ForeColor="AliceBlue"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">
            <asp:Label ID="Label8" runat="server" Text="Password: "></asp:Label>
        </td>
        <td class="auto-style6">
            <asp:TextBox type="password" ID="txtPassword" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style7">
            <asp:Label ID="lblError2" runat="server" Text="Waiting for input" ForeColor="AliceBlue"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style11" colspan="3">
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click1" Text="Log In" CssClass="myButtons" Width="100px"/>
        </td>
    </tr>
</table>
    
</asp:Content>
