<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ClientOrder.aspx.cs" Inherits="Project_Food_Ordering_System_2021_Prototype_1.Client.ClientOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            height: 300px;
            width: 576px;
            overflow: auto;
            margin-left: 50px;
            margin-right: 0;
        }
        .auto-style5 {
            width: 236px;
            text-align: right;
        }
        .auto-style6 {
            font-size: large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style1" colspan="2">
                <strong>
                <asp:Label ID="lblWelcome" runat="server" Text="Welcome[User]:" CssClass="auto-style6" Visible="False"></asp:Label>
                </strong>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Button ID="btnDrinks" runat="server" Text="Drinks" OnClick="btnDrinks_Click" CssClass="myButtons" Width="120px"/>
            </td>
            <td rowspan="4">
                <div id="ScrollList" class="auto-style2">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="2" ForeColor="Black" GridLines="None" AutoGenerateSelectButton="True" Width="573px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px">
                        <AlternatingRowStyle BackColor="PaleGoldenrod" />
                    <Columns>
                        <asp:BoundField DataField="Item_Name" HeaderText="Item" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Left"/>
                        <asp:BoundField DataField="Item_Price" HeaderText="Price" DataFormatString="{0:c2}" HtmlEncode="False" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Left" />
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
                </div>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Button ID="btnSnacks" runat="server" Text="Snacks" OnClick="btnSnacks_Click" CssClass="myButtons" Width="120px"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Button ID="btnFastFood" runat="server" Text="Fast Food" OnClick="btnFastFood_Click" CssClass="myButtons" Width="120px"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Button ID="btnEssentials" runat="server" Text="Essentials" OnClick="btnEssentials_Click" CssClass="myButtons" Width="120px"/>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" colspan="2">
                <asp:ListBox ID="ListBox1" runat="server" Height="122px" Width="473px"></asp:ListBox>
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style1" colspan="2">
                <asp:Button ID="btnPlaceOrder" runat="server" OnClick="btnTest_Click" Text="Go to Basket" CssClass="myButtons" Visible="False" Width="120px"/>
            </td>
        </tr>
    </table>
</asp:Content>
