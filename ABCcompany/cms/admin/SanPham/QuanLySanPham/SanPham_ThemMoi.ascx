<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SanPham_ThemMoi.ascx.cs" Inherits="cms_admin_SanPham_QuanLySanPham_SanPham_ThemMoi" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<div class="head"> 
    Add, edit product
</div>
<div class="FormThemMoi">
    <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
    <div class="thongTin">
        <div class="tenTruong">Select category product</div>
        <div class="oNhap"><asp:DropDownList ID="ddlDanhMucCha" runat="server"></asp:DropDownList></div>
    </div>

    <div class="thongTin">
        <div class="tenTruong">Product name</div>
        <div class="oNhap"> <asp:TextBox ID="tbTenSanPham" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="tbTenSanPham"
                Display="Dynamic" SetFocusOnError="true" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
    </div>

    <div class="thongTin">
        <div class="tenTruong">Image</div>
        <div class="oNhap">
            <div>
                <asp:HiddenField ID="hdTenAnhDaiDienCu" runat="server" />
                <asp:Literal ID="ltrAnhDaiDien" runat="server"></asp:Literal>
            </div>
            <asp:FileUpload ID="flAnhDaiDien" runat="server" /></div>
    </div>

    <div class="thongTin">
        <div class="tenTruong">Quantity</div>
        <div class="oNhap"> 
            <asp:TextBox ID="tbSoLuong" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Quantity entered must be numeric"
                ControlToValidate="tbSoLuong" Display="Dynamic" SetFocusOnError="true" ValidationExpression="(\d)*" ForeColor="red"></asp:RegularExpressionValidator>
        </div>
    </div>
    
    <div class="thongTin">
        <div class="tenTruong">Price</div>
        <div class="oNhap"> 
            <asp:TextBox ID="tbGiaBan" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Price entered must be numeric"
                ControlToValidate="tbGiaBan" Display="Dynamic" SetFocusOnError="true" ValidationExpression="(\d)*" ForeColor="red"></asp:RegularExpressionValidator>
        </div>
    </div>
        
    <div class="thongTin">
        <div class="tenTruong">Date create</div>
        <div class="oNhap"> 
            <asp:TextBox ID="tbNgayTao" runat="server"></asp:TextBox>
            
        </div>
    </div>
            
    <div class="thongTin">
        <div class="tenTruong">Date cancel</div>
        <div class="oNhap"> 
            <asp:TextBox ID="tbNgayHuy" runat="server"></asp:TextBox>
            
        </div>
    </div>

        <div class="thongTin">
        <div class="tenTruong">Status</div>
        <div class="oNhap"><asp:DropDownList ID="ddlMau" runat="server"></asp:DropDownList></div>
    </div>
    
        <div class="thongTin">
        <div class="tenTruong">Supply</div>
        <div class="oNhap"><asp:DropDownList ID="ddlSize" runat="server"></asp:DropDownList></div>
    </div>
        

            
        <div class="thongTin">
        <div class="tenTruong">Group product</div>
        <div class="oNhap"><asp:DropDownList ID="ddlNhom" runat="server"></asp:DropDownList></div>
    </div>

    
    <div class="thongTin">
        <div class="tenTruong">Product Description</div>
        <div class="oNhap"> 
            <%--<asp:TextBox ID="tbMoTa" runat="server" TextMode="MultiLine" Height="150px"></asp:TextBox>--%>
            <CKEditor:CKEditorControl ID="tbMoTa" runat="server" FilebrowserImageBrowseUrl="ckeditor/ckfinder/ckfinder.aspx?type=Images&path=pic"></CKEditor:CKEditorControl>
        </div>
    </div>


     <div class="thongTin">
        <div class="tenTruong"> &nbsp</div>
        <div class="oNhap"> <asp:CheckBox ID="cbAddMoreCatePro" runat="server" Text="Add another product after creating this product"/></div>
    </div>

    <div class="thongTin">
        <div class="tenTruong"> &nbsp;</div>
        <div class="oNhap">
            <asp:Button ID="btThemMoi" runat="server" Text="Add new" CssClass="btThemMoi" OnClick="btThemMoi_Click"/>
            <asp:Button ID="btHuy" runat="server" Text="Cancel" CssClass="btHuy" OnClick="btHuy_Click" CausesValidation="false"/>
        </div>
        
    </div>
</div>
