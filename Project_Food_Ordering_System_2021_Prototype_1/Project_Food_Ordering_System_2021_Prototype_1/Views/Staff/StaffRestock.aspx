<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="StaffRestock.aspx.cs" Inherits="Project_Food_Ordering_System_2021_Prototype_1.Views.Staff.StaffRestock" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

    .auto-style2 {
        font-size: x-large;
    }
        .auto-style3 {
            text-align: center;
            height: 33px;
        }
        .auto-style4 {
            font-size: large;
        }
        .auto-style5 {
            text-align: right;
            width: 197px;
        }
        .auto-style6 {
            margin-left: 5px;
        }
        .auto-style7 {
            width: 237px;
        }
        .auto-style9 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style3" colspan="3"><strong>    <asp:Label ID="Label5" runat="server" Text="Stock Resupply" CssClass="auto-style2"></asp:Label>
            </strong></td>
        </tr>
        <tr>
            <td class="auto-style9" colspan="2">
                    <asp:DropDownList ID="dropListNames" runat="server" Height="32px" Width="180px">
                    </asp:DropDownList>
            </td>
            <td rowspan="5">
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" Width="90%" CssClass="auto-style6">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="Item_Name" HeaderText="Product Name" HeaderStyle-HorizontalAlign="Left"/>
                        <asp:BoundField DataField="Quantity" HeaderText="Amount In Stock" HtmlEncode="False" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" />
                     </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="Label6" runat="server" Text="Restock Amount:" CssClass="auto-style4"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAmount" ErrorMessage="Please enter a number" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style9" colspan="2">
                <asp:Button ID="btnRestock1" runat="server" OnClick="btnRestock1_Click" Text="Restock" CssClass="myButtons" Width="100px"/>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Back" CssClass="myButtons" Width="100px"/>
            </td>
        </tr>
    </table>
</asp:Content>
