<%@ Page Title="Sales Report" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminSalesReport.aspx.cs" Inherits="Project_Food_Ordering_System_2021_Prototype_1.AdminSalesReport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style6 {
            font-size: x-large;
        }
        .auto-style7 {
            text-align: center;
        }
    .auto-style8 {
        text-align: left;
    }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <table style="width:100%;">
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style7" colspan="2">
                <strong>
                <asp:Label ID="lblSalesReport" runat="server" Text="Sales Report" CssClass="auto-style6" Visible="True"></asp:Label>
                </strong>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style8" colspan="2">
                <strong>
                <asp:Label ID="lblDate" runat="server" Text="Label"></asp:Label>
                </strong>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td rowspan="2">
                <br />
            </td>
            <td colspan="2">
                <strong>
                <asp:Label ID="Label5" runat="server" Text="Choose Time Period for report"></asp:Label>
                </strong>
                <br />
            </td>
            <td rowspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Start Date"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label7" runat="server" Text="End Date"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td colspan="2">
                &nbsp;<asp:TextBox ID="txtEndDate" runat="server" TextMode="Month"></asp:TextBox>
                To
                <asp:TextBox ID="txtStartDate" runat="server" TextMode="Month"></asp:TextBox>
                <br />
                <asp:Label ID="lblError" runat="server" ForeColor="Red" Text="Please enter valid dates" Visible="False"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td colspan="2">
                <asp:Button ID="btnGenerate" runat="server" Text="Generate" CssClass="myButtons" OnClick="btnGenerate_Click" Width="120px
                    "/>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" Width="100%" ShowFooter="true"
                    OnRowDataBound ="GridView1_RowDataBound" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="White" />
                    <FooterStyle HorizontalAlign="Right" />
                    <Columns>
                        <asp:BoundField DataField="Order_Number" HeaderText="Order Number" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Left">
                        </asp:BoundField>
                        <asp:BoundField DataField="Payment_Reference" HeaderText="Reference Number" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Left" >
                        </asp:BoundField>
                        <asp:BoundField DataField="Payment_Date" HeaderText="Payment Date" DataFormatString="{0:dd/MM/yyyy}" HtmlEncode="False" ItemStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right">
                        </asp:BoundField>
                        <asp:BoundField DataField="Total_Amount" HeaderText="Amount Paid" DataFormatString="{0:c2}" HtmlEncode="False" ItemStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right">
<HeaderStyle HorizontalAlign="Right"></HeaderStyle>

<ItemStyle HorizontalAlign="Right"></ItemStyle>
                        </asp:BoundField>
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
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="2">
                <asp:Button ID="btnBack" runat="server" Text="Back" CssClass="myButtons" OnClick="btnBack_Click" Width="120px"/>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
