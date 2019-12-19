<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Size_ThemMoi.ascx.cs" Inherits="cms_admin_SanPham_QuanLySize_Size_ThemMoi" %>
<div class="head">
    Add, edit Supply
</div>
<div class="FormThemMoi">
    <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
    <div class="thongTin">
        <div class="tenTruong">Supply name</div>
        <div class="oNhap">
            <asp:TextBox ID="tbSupplyName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="tbSupplyName" Display="Dynamic" SetFocusOnError="True" ForeColor="Red" ></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">&nbsp;</div>
        <div class="oNhap"><asp:CheckBox ID="cbAddMoreSupply" runat="server" Text="Add another Supply after creating this Supply"/></div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">&nbsp;</div>
        <div class="oNhap">
            <asp:Button ID="btAddNew" runat="server" Text="Add new" CssClass="btThemMoi" OnClick="btAddNew_Click" />
            <asp:Button ID="btHuy" runat="server" Text="Cancel" CssClass="btHuy" OnClick="btHuy_Click" CausesValidation="false" />
        </div>
    </div>
</div>