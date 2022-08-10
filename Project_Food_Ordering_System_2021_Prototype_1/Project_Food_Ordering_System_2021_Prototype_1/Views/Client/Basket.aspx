<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Basket.aspx.cs" Inherits="Project_Food_Ordering_System_2021_Prototype_1.Basket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            text-align: right;
            height: 34px;
            width: 444px;
        }
        .auto-style3 {
            height: 34px;
        }
    .auto-style4 {
        font-size: x-large;
    }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <table style="width:100%;">
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1" colspan="2">
                <strong>
                <asp:Label ID="Label5" runat="server" Text="Your Basket" CssClass="auto-style4"></asp:Label>
                </strong>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1" colspan="2">
                <asp:ListBox ID="ListBox1" runat="server" Height="347px" Width="377px"></asp:ListBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td rowspan="2">&nbsp;</td>
            <td class="auto-style2">
                <asp:Button ID="btnDecrease" runat="server" Text="Decrease" CssClass="myButtons" OnClick="btnDecrease_Click" Width="120px"/>
            </td>
            <td class="auto-style3">
                <asp:Button ID="btnRemove" runat="server" OnClick="btnRemove_Click" Text="Remove" CssClass="myButtons" Width="120px"/>
            </td>
            <td rowspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1" colspan="2">
                <asp:Button ID="btnPlaceOrder" runat="server" Text="Place Order" CssClass="myButtons" OnClick="btnPlaceOrder_Click" Width="120px"/>
            </td>
        </tr>
    </table>
</asp:Content>
