<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SanPham_ThemMoixxx.ascx.cs" Inherits="cms_admin_SanPham_QuanLySanPham_SanPham_ThemMoi" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<div class="head"> 
    Add, edit products
</div>
<div class="FormThemMoi">
    <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
    <div class="thongTin">
        <div class="tenTruong">Select category</div>
        <div class="oNhap"><asp:DropDownList ID="ddCategoryFar" runat="server"></asp:DropDownList></div>
    </div>

    <div class="thongTin">
        <div class="tenTruong">Product's name</div>
        <div class="oNhap"> <asp:TextBox ID="tbProductName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="tbProductName"
                Display="Dynamic" SetFocusOnError="true" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
    </div>

    <div class="thongTin">
        <div class="tenTruong">Avatar</div>
        <div class="oNhap">
            <div>
                <asp:HiddenField ID="hdNameOldImage" runat="server" />
                <asp:Literal ID="ltImage" runat="server"></asp:Literal>
            </div>
            <asp:FileUpload ID="flAvataImage" runat="server" /></div>
    </div>

    <div class="thongTin">
        <div class="tenTruong">Quantily</div>
        <div class="oNhap"> 
            <asp:TextBox ID="tbQuantity" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Quantity entered must be numeric"
                ControlToValidate="tbQuantity" Display="Dynamic" SetFocusOnError="true" ValidationExpression="(\d)*" ForeColor="red"></asp:RegularExpressionValidator>
        </div>
    </div>
    
    <div class="thongTin">
        <div class="tenTruong">Price</div>
        <div class="oNhap"> 
            <asp:TextBox ID="tbPrice" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Price must be entered as number"
                ControlToValidate="tbPrice" Display="Dynamic" SetFocusOnError="true" ValidationExpression="(\d)*" ForeColor="red"></asp:RegularExpressionValidator>
        </div>
    </div>
        
    <div class="thongTin">
        <div class="tenTruong">Date created</div>
        <div class="oNhap"> 
            <asp:TextBox ID="tbDateCreated" runat="server"></asp:TextBox>
            
        </div>
    </div>
            
    <div class="thongTin">
        <div class="tenTruong">Day canceled</div>
        <div class="oNhap"> 
            <asp:TextBox ID="tbDateCancel" runat="server"></asp:TextBox>
            
        </div>
    </div>

        <div class="thongTin">
        <div class="tenTruong">Select status</div>
        <div class="oNhap"><asp:DropDownList ID="tbStatus" runat="server"></asp:DropDownList></div>
    </div>
    
        <div class="thongTin">
        <div class="tenTruong">Select supply</div>
        <div class="oNhap"><asp:DropDownList ID="tbSupply" runat="server"></asp:DropDownList></div>
    </div>
        
        <%--<div class="thongTin">
        <div class="tenTruong">Chọn chất liệu</div>
        <div class="oNhap"><asp:DropDownList ID="ddlChatLieu" runat="server"></asp:DropDownList></div>
    </div>--%>
            
        <div class="thongTin">
        <div class="tenTruong">Select Group's product</div>
        <div class="oNhap"><asp:DropDownList ID="ddlgroup" runat="server"></asp:DropDownList></div>
    </div>

    
    <div class="thongTin">
        <div class="tenTruong">Product Description</div>
        <div class="oNhap"> 
            <%--<asp:TextBox ID="tbDescribe" runat="server" TextMode="MultiLine" Height="150px"></asp:TextBox>--%>
            <CKEditor:CKEditorControl ID="tbDescribe" runat="server" FilebrowserImageBrowseUrl="ckeditor/ckfinder/ckfinder.aspx?type=Images&path=pic"></CKEditor:CKEditorControl>
        </div>
    </div>


     <div class="thongTin">
        <div class="tenTruong"> &nbsp</div>
        <div class="oNhap"> <asp:CheckBox ID="cbAddMoreCategory" runat="server" Text="Add another product after creating this product"/></div>
    </div>

    <div class="thongTin">
        <div class="tenTruong"> &nbsp;</div>
        <div class="oNhap">
            <asp:Button ID="btAddNew" runat="server" Text="Add new" CssClass="btAddNew" OnClick="btAddNew_Click"/>
            <asp:Button ID="btHuy" runat="server" Text="Cancel" CssClass="btHuy" OnClick="btHuy_Click" CausesValidation="false"/>
        </div>
        
    </div>
</div>
