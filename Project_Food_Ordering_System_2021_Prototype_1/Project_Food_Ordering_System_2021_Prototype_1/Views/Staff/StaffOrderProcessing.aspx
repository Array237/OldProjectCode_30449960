<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="StaffOrderProcessing.aspx.cs" Inherits="Project_Food_Ordering_System_2021_Prototype_1.StaffOrderProcessing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        text-align: center;
    }
        .auto-style3 {
            font-size: x-large;
        }
        .auto-style4 {
            width: 64px;
        }
        .auto-style5 {
            width: 734px;
        }
        .auto-style6 {
            font-size: large;
        }
        </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <table style="width:100%;">
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style1" colspan="2">
            <strong>
            <asp:Label ID="lblTodayOrders" runat="server" Text="Order Processing" CssClass="auto-style3"></asp:Label>
            </strong>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDate" runat="server" Text="Label" CssClass="auto-style6"></asp:Label>
        </td>
        <td class="auto-style1" colspan="2">
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1"><strong>
            <asp:Label ID="Label6" runat="server" Text="New Orders"></asp:Label>
            </strong>
            <br />
            <asp:ListBox ID="lstNewOrder" runat="server" Height="316px" Width="230px" OnSelectedIndexChanged="lstNewOrder_SelectedIndexChanged"></asp:ListBox>
        </td>
        <td class="auto-style1" colspan="2"><strong>
            <asp:Label ID="Label7" runat="server" Text="In Progress"></asp:Label>
            </strong>
            <br />
            <asp:ListBox ID="lstInProgress" runat="server" Height="316px" Width="230px"></asp:ListBox>
        </td>
        <td class="auto-style1"><strong>
            <asp:Label ID="Label8" runat="server" Text="Completed"></asp:Label>
            </strong>
            <br />
            <asp:ListBox ID="lstCompleted" runat="server" Height="316px" Width="230px"></asp:ListBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td class="auto-style1" colspan="2">&nbsp;</td>
        <td class="auto-style1">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Button ID="btnStartProcessing" runat="server" Text="Start Order" CssClass="myButtons" OnClick="btnStartProcessing_Click" Width="120px"/>
        </td>
        <td class="auto-style1" colspan="2">
            <asp:Button ID="btnFinishOrder" runat="server" Text="Finish Order" CssClass="myButtons" OnClick="btnStartProcessing0_Click" Width="120px"/>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">
            <br />
            <asp:Button ID="btnViewNewOrder" runat="server" Text="View New" CssClass="myButtons" OnClick="btnViewOrder_Click" Width="120px"/>
            <br />
            <br />
        </td>
        <td class="auto-style1">
            <asp:Button ID="btnViewProOrder" runat="server" Text="View Progress" CssClass="myButtons" OnClick="btnViewProOrder_Click" Width="120px"/>
        </td>
        <td class="auto-style1" colspan="2">
            <asp:Button ID="btnViewCompleteOrder" runat="server" Text="View Complete" CssClass="myButtons" OnClick="btnViewCompleteOrder_Click" Width="120px"/>
        </td>
    </tr>
    </table>
    <br />
    <table style="width:100%;">
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td colspan="2">
                &nbsp;<asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="Item_Name" HeaderText="Product" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Left">
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>

<ItemStyle HorizontalAlign="Left"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="Item_Quantity" HeaderText="Quantity" HtmlEncode="False" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<ItemStyle HorizontalAlign="Center"></ItemStyle>
                        </asp:BoundField>
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" ForeColor="#333333" Font-Bold="True" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                &nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
            <asp:Button ID="btnBack" runat="server" Text="Back" CssClass="myButtons" Width="100px" OnClick="btnBack_Click"/>
            </td>
            <td class="auto-style5">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
