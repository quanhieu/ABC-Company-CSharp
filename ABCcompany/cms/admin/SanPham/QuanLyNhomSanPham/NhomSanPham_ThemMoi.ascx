<%@ Control Language="C#" AutoEventWireup="true" CodeFile="NhomSanPham_ThemMoi.ascx.cs" Inherits="cms_admin_SanPham_QuanLyNhomSanPham_NhomSanPham_ThemMoi" %>
<div class="head">
    Add, edit group product
</div>
<div class="FormThemMoi">
    <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>   
    <div class="thongTin">
        <div class="tenTruong">Group product name</div>
        <div class="oNhap">            
            <asp:TextBox ID="tbTenNhomSP" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="tbTenNhomSP" Display="Dynamic" SetFocusOnError="True" ForeColor="Red" ></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Image GP</div>
        <div class="oNhap">
            <div>
                <asp:HiddenField ID="hdTenAnhDaiDienCu" runat="server" />
                <asp:Literal ID="ltrAnhDaiDien" runat="server"></asp:Literal>
            </div>
            <asp:FileUpload ID="flAnhDaiDien" runat="server" />
        </div>
    </div> 
    <div class="thongTin">
        <div class="tenTruong">Order number</div>
        <div class="oNhap">
            <asp:TextBox ID="tbThuTu" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Thứ tự phải nhập kiểu số" ControlToValidate="tbThuTu" Display="Dynamic" SetFocusOnError="True" ValidationExpression="(\d)*" ForeColor="Red"  ></asp:RegularExpressionValidator>
        </div>
    </div>  
    <div class="thongTin">
        <div class="tenTruong">Number product display</div>
        <div class="oNhap">
            <asp:TextBox ID="tbSoSanPhamHienThi" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Number products must enter numeric" ControlToValidate="tbSoSanPhamHienThi" Display="Dynamic" SetFocusOnError="True" ValidationExpression="(\d)*" ForeColor="Red"  ></asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">&nbsp;</div>
        <div class="oNhap"><asp:CheckBox ID="cbThemNhieuNhom" runat="server" Text="Create more product groups after creating this product group"/></div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">&nbsp;</div>
        <div class="oNhap">
            <asp:Button ID="btThemMoi" runat="server" Text="Add new" CssClass="btThemMoi" OnClick="btThemMoi_Click" />
            <asp:Button ID="btHuy" runat="server" Text="Cancel" CssClass="btHuy" OnClick="btHuy_Click" CausesValidation="false" />
        </div>
    </div>
</div>