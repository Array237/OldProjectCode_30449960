<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminMaintainStaff.aspx.cs" Inherits="Project_Food_Ordering_System_2021_Prototype_1.AdminMaintainStaff" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style14 {
            font-size: x-large;
        }
        .auto-style15 {
            text-align: center;
        }
        .auto-style16 {
            text-align: right;
            width: 223px;
        }
        .auto-style17 {
            height: 26px;
        }
        .auto-style18 {
            text-align: right;
            height: 26px;
            width: 223px;
        }
        .auto-style19 {
            text-align: left;
            width: 232px;
        }
        .auto-style20 {
            text-align: left;
            height: 26px;
            width: 232px;
        }
        .auto-style21 {
            height: 26px;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style15" colspan="6">
                <strong>
                <asp:Label ID="Label5" runat="server" Text="Maintain Staff Information" CssClass="auto-style14"></asp:Label>
                </strong>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="4">
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" AutoGenerateColumns="False">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="Staff_Number" HeaderText="Staff Number" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Left"/>
                        <asp:BoundField DataField="Staff_Role" HeaderText="Role" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Left" />
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
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style15" colspan="2">
                <strong>
                <asp:Label ID="Label6" runat="server" Text="Add Staff"></asp:Label>
                </strong>
            </td>
            <td class="auto-style15" colspan="2">
                <strong>
                <asp:Label ID="Label7" runat="server" Text="Remove Staff"></asp:Label>
                </strong>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style17"></td>
            <td class="auto-style18">
                <asp:Label ID="Label10" runat="server" Text="Name: "></asp:Label>
            </td>
            <td class="auto-style20">
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style21">
                <asp:Label ID="Label9" runat="server" Text="Enter Staff  No. to Remove staff"></asp:Label>
            </td>
            <td colspan="2" rowspan="6">
                &nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style16">
                <asp:Label ID="Label11" runat="server" Text="Surame: "></asp:Label>
            </td>
            <td class="auto-style19">
                <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style15">
                <asp:TextBox ID="txtRemove" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style16">
                <asp:Label ID="Label12" runat="server" Text="Email: "></asp:Label>
            </td>
            <td class="auto-style19">
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style15">
                <strong>
                <asp:Label ID="lblError" runat="server" ForeColor="Red" Text="User does not exist" Visible="False"></asp:Label>
                </strong>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style16">
                <asp:Label ID="Label13" runat="server" Text="Password:"></asp:Label>
            </td>
            <td class="auto-style19">
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style15">
                <asp:Button ID="btnRemove" runat="server" Text="Remove" CssClass="myButtons" Width="100px" OnClick="btnRemove_Click"/>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style16">
                <asp:Label ID="Label14" runat="server" Text="Staff Number:"></asp:Label>
            </td>
            <td class="auto-style19">
                <asp:TextBox ID="txtStaffNumber" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style16">
                <asp:Label ID="Label15" runat="server" Text="Staff Role:"></asp:Label>
            </td>
            <td class="auto-style19">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Admin</asp:ListItem>
                    <asp:ListItem>Kitchen</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style15" colspan="2">
                    <strong>
                    <asp:Label ID="lblExistingUser" runat="server" Text="Staff Number already exist" Visible="False" ForeColor="Red"></asp:Label>
                    </strong>
                    </td>
            <td class="auto-style15" colspan="2">
                    &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style15" colspan="2">
                <asp:Button ID="btnAdd" runat="server" Text="Add Staff" CssClass="myButtons" Width="100px" OnClick="btnAdd_Click"/>
            </td>
            <td class="auto-style15" colspan="2">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="6">
                <asp:Button ID="btnBack" runat="server" Text="Back" CssClass="myButtons" Width="100px" OnClick="btnBack_Click"/>
            </td>
        </tr>
    </table>
</asp:Content>
