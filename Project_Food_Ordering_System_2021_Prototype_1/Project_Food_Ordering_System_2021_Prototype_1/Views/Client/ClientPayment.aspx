<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ClientPayment.aspx.cs" Inherits="Project_Food_Ordering_System_2021_Prototype_1.Views.Client.ClientPayment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

    .auto-style2 {
        font-size: x-large;
    }
        .auto-style3 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <table style="width:100%;">
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style3"><strong>    <asp:Label ID="Label5" runat="server" Text="Order Payment" CssClass="auto-style2"></asp:Label>
            </strong></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:GridView ID="GridView1" runat="server" ShowFooter="True" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="5" ForeColor="Black" GridLines="None" Width="100%" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
                    OnRowDataBound ="GridView1_RowDataBound" >
                    <AlternatingRowStyle BackColor="PaleGoldenrod" />
                    <HeaderStyle HorizontalAlign="Left" />
                    <FooterStyle HorizontalAlign="Right" />
                    <Columns>
                        <asp:BoundField DataField="Item.Item_Name" HeaderText="Item" />
                        <asp:BoundField DataField="quantity" HeaderText="Quantity" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" />
                        <asp:BoundField DataField="Item.Item_Price" HeaderText="Price per Item" DataFormatString="{0:c2}" HtmlEncode="False" ItemStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right"/>
                        <asp:BoundField DataField="Total_Price" HeaderText="Total Price for Items" DataFormatString="{0:c2}" HtmlEncode="False" ItemStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right"/>
                    </Columns>
                    <FooterStyle BackColor="Tan" />
                    <HeaderStyle BackColor="Tan" Font-Bold="True" />
                    <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                    <SortedAscendingCellStyle BackColor="#FAFAE7" />
                    <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                    <SortedDescendingCellStyle BackColor="#E1DB9C" />
                    <SortedDescendingHeaderStyle BackColor="#C2A47B" />
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style3">
                <asp:Button ID="btnCheckout" runat="server" OnClick="btnCheckout_Click" Text="Checkout" CssClass="myButtons" Width="100px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Button ID="btnBack" runat="server" Text="Back" CssClass="myButtons" Width="100px" OnClick="btnBack_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
