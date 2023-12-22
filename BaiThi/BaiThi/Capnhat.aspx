<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Masterpage.Master" CodeBehind="Capnhat.aspx.cs" Inherits="BaiThi.Capnhat" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <div>
                 <asp:Label ID="Label3" runat="server" Text="DANH SÁCH MÔN HỌC "></asp:Label>
            </div>
           <div>
               <asp:Label ID="Label2" runat="server" Text="Mã môn học"></asp:Label>
               <asp:TextBox ID="txtmamonhoc" runat="server"></asp:TextBox>
           </div>
            <div>
                <asp:Label ID="Label4" runat="server" Text="Tên môn học"></asp:Label>
                <asp:TextBox ID="txttenmonhoc" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" PageSize="3">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="MaMH" HeaderText="Mã môn học" />
                        <asp:BoundField DataField="TenMH" HeaderText="Tên môn học" />
                        <asp:CommandField SelectText="Chọn" ShowSelectButton="True" />
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
            </div>
            <div>
                <asp:Label ID="lbtthongbao" runat="server" Text="Label"></asp:Label>
            </div>
            <div>
                <asp:Button ID="btnthem" runat="server" Text="Thêm" OnClick="btnthem_Click" />
                <asp:Button ID="btnluu" runat="server" Text="Lưu" OnClick="btnluu_Click" />
                <asp:Button ID="btnsua" runat="server" Text="Sửa" OnClick="btnsua_Click" />
                <asp:Button ID="btnxoa" runat="server" Text="Xóa" OnClick="btnxoa_Click" />
            </div>
</asp:Content>
