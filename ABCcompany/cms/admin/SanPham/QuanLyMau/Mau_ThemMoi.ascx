<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Mau_ThemMoi.ascx.cs" Inherits="cms_admin_SanPham_QuanLyMau_Mau_ThemMoi" %>
<div class="head">
    Add, edit status
</div>
<div class="FormThemMoi">
    <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
    <div class="thongTin">
        <div class="tenTruong">Status name</div>
        <div class="oNhap">
            <asp:TextBox ID="tbStatusName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="tbStatusName" Display="Dynamic" SetFocusOnError="True" ForeColor="Red" ></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">&nbsp;</div>
        <div class="oNhap"><asp:CheckBox ID="btAddMoreStatus" runat="server" Text="Add another color after creating this status"/></div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">&nbsp;</div>
        <div class="oNhap">
            <asp:Button ID="btAddNew" runat="server" Text="Add new" CssClass="btThemMoi" OnClick="btAddNew_Click" />
            <asp:Button ID="btHuy" runat="server" Text="Cancel" CssClass="btHuy" OnClick="btHuy_Click" CausesValidation="false" />
        </div>
    </div>
</div>