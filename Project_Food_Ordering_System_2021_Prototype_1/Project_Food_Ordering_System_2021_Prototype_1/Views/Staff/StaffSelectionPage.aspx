<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="StaffSelectionPage.aspx.cs" Inherits="Project_Food_Ordering_System_2021_Prototype_1.StaffSelectionPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            font-size: x-large;
        }
        .auto-style3 {
            text-align: center;
            height: 50px;
        }
        .auto-style4 {
            text-align: center;
            height: 60px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label5" runat="server" CssClass="auto-style2" Text="Staff Selection Page"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Button ID="btnOrder" runat="server" OnClick="btnOrder_Click" Text="View Orders" CssClass="myButtons" Width="120px"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Button ID="btnStocks" runat="server" OnClick="btnStocks_Click" Text="Maintain Stock" CssClass="myButtons" Width="120px"/>
            </td>
        </tr>
        </table>
</asp:Content>
