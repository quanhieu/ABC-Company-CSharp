<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhMuc_ThemMoi.ascx.cs" Inherits="cms_admin_SanPham_QuanLyDanhMuc_DanhSach_ThemMoi" %>
<div class="head"> 
    Add, edit product category
</div>
<div class="FormThemMoi">
    <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
    <div class="thongTin">
        <div class="tenTruong">Parent category</div>
        <div class="oNhap"><asp:DropDownList ID="ddlCategoryFar" runat="server"></asp:DropDownList></div>
    </div>

    <div class="thongTin">
        <div class="tenTruong">Category name</div>
        <div class="oNhap"> <asp:TextBox ID="tbCategoryName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="tbCategoryName"
                Display="Dynamic" SetFocusOnError="true" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
    </div>

    <div class="thongTin">
        <div class="tenTruong">Avatar</div>
        <div class="oNhap">
            <div>
                <asp:HiddenField ID="hdAvatar" runat="server" />
                <asp:Literal ID="tbAvatar" runat="server"></asp:Literal>
            </div>
            <asp:FileUpload ID="flAvatar" runat="server" /></div>
    </div>

    <div class="thongTin">
        <div class="tenTruong">Order number</div>
        <div class="oNhap"> 
            <asp:TextBox ID="tbNumOrder" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="The order must be numbered"
                ControlToValidate="tbNumOrder" Display="Dynamic" SetFocusOnError="true" ValidationExpression="(\d)*" ForeColor="red"></asp:RegularExpressionValidator>
        </div>
    </div>

     <div class="thongTin">
        <div class="tenTruong"> &nbsp</div>
        <div class="oNhap"> <asp:CheckBox ID="cbAddMoreCategory" runat="server" Text="Continue to create another category after completing this category"/></div>
    </div>

    <div class="thongTin">
        <div class="tenTruong"> &nbsp;</div>
        <div class="oNhap">
            <asp:Button ID="btAddNew" runat="server" Text="Thêm Mới" CssClass="btThemMoi" OnClick="btAddNew_Click"/>
            <asp:Button ID="btHuy" runat="server" Text="Cancel" CssClass="btHuy" OnClick="btHuy_Click" CausesValidation="false"/>
        </div>
        
    </div>
</div>
