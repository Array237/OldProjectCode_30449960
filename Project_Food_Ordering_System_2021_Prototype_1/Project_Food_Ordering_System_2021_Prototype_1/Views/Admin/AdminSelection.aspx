<%@ Page Title="Admin Selection" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminSelection.aspx.cs" Inherits="Project_Food_Ordering_System_2021_Prototype_1.AdminSelection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style10 {
            text-align: center;
            height: 50px;
        }
        .auto-style11 {
            width: 100%;
        }
        .auto-style12 {
            height: 50px;
        }
        .auto-style13 {
            text-align: center;
            height: 60px;
        }
        .auto-style14 {
            text-align: center;
            height: 62px;
        }
        .auto-style15 {
            text-align: center;
            height: 61px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <table class="auto-style11">
        <tr>
            <td class="auto-style12"></td>
            <td class="auto-style10">
                <asp:Label ID="Label5" runat="server" Font-Size="18pt" Text="Admin Selection Page"></asp:Label>
            </td>
            <td class="auto-style12"></td>
        </tr>
        <tr>
            <td class="auto-style13" colspan="3">
                <asp:Button ID="btnSalesReport" runat="server" Text="Sales Report" CssClass="myButtons" OnClick="btnSales_Click" Width="200px"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style13" colspan="3">
                <asp:Button ID="btnStockReport" runat="server" Text="Stock Report" CssClass="myButtons" OnClick="btnStockReport_Click" Width="200px"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style14" colspan="3">
                <asp:Button ID="btnMaintainProducts" runat="server" Text="Maintain Products" CssClass="myButtons" OnClick="btnMaintainProducts_Click" Width="200px"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style13" colspan="3">
                <asp:Button ID="Button1" runat="server" Text="Maintain Staff" CssClass="myButtons" Width ="200px" OnClick="Button1_Click"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style15" colspan="3">
                <asp:Button ID="btnMaintainClient" runat="server" Text="Maintain Clients" CssClass="myButtons" Width="200px" OnClick="btnMaintainClient_Click"/>
            </td>
        </tr>
        </table>
</asp:Content>
