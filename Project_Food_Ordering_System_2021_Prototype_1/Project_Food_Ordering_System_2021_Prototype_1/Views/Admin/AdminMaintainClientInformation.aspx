<%@ Page Title="Maintain Client Information" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminMaintainClientInformation.aspx.cs" Inherits="Project_Food_Ordering_System_2021_Prototype_1.AdminMaintainClientInformation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style4 {
            width: 100%;
        }
        .auto-style14 {
            font-size: x-large;
        }
        </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <table class="auto-style4">
        <tr>
            <td class="auto-style1" colspan="3">
                <strong>
                <asp:Label ID="Label5" runat="server" Text="Maintain Client Information" CssClass="auto-style14"></asp:Label>
                </strong>
            </td>
        </tr>
        <tr>
            <td colspan="3">&nbsp;&nbsp;
                </td>
        </tr>
        <tr>
            <td class="auto-style1" colspan="3">
                    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" Width="99%">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                        <asp:BoundField DataField="Student_Number" HeaderText="Student Number" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Left"/>
                        <asp:BoundField DataField="User_Name" HeaderText="Name" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Left" />
                        <asp:BoundField DataField="User_Surname" HeaderText="Surname" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Left" />
                        <asp:BoundField DataField="User_Email" HeaderText="Email" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Left"/>
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
            <td class="auto-style1" colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1" colspan="3">
                <asp:Label ID="Label9" runat="server" Text="Enter University  No. to Remove client"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtRemoveStudent" runat="server" OnTextChanged="txtRemoveStudent_TextChanged"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="auto-style1">
                <strong>
                <asp:Label ID="lblError" runat="server" ForeColor="Red" Text="User does not exist" Visible="False"></asp:Label>
                </strong>
                </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="auto-style1">
                <asp:Button ID="btnRemove" runat="server" Text="Remove" CssClass="myButtons" Width="100px" OnClick="btnRemove_Click1"/>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Button ID="btnBack" runat="server" Text="Back" CssClass="myButtons" Width="100px" OnClick="btnBack_Click"/>
            </td>
        </tr>
        </table>
</asp:Content>
