<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhMucTin_ThemMoi.ascx.cs" Inherits="cms_admin_TinTuc_DanhMucTin_DanhMucTin_ThemMoi" %>
<div class="head">
    Add, edit the News category
</div>
<div class="FormThemMoi">
    <asp:Literal ID="ltrNotify" runat="server"></asp:Literal>
    <div class="thongTin">
        <div class="tenTruong">Main category news</div>
        <div class="oNhap"><asp:DropDownList ID="ddlNewsCodeFar" runat="server"></asp:DropDownList></div>
    </div>   
    <div class="thongTin">
        <div class="tenTruong">Category news name</div>
        <div class="oNhap">            
            <asp:TextBox ID="tbTenNewsName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="tbTenNewsName" Display="Dynamic" SetFocusOnError="True" ForeColor="Red" ></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Image CNews</div>
        <div class="oNhap">
            <div>
                <asp:HiddenField ID="AvatarCaNewsOld" runat="server" />
                <asp:Literal ID="ltrAvatarCaNews" runat="server"></asp:Literal>
            </div>
            <asp:FileUpload ID="flAvatarCaNews" runat="server" />
        </div>
    </div> 
    <div class="thongTin">
        <div class="tenTruong">Order number</div>
        <div class="oNhap">
            <asp:TextBox ID="tbNumOrder" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="The order must be numeric" ControlToValidate="tbNumOrder" Display="Dynamic" SetFocusOnError="True" ValidationExpression="(\d)*" ForeColor="Red"  ></asp:RegularExpressionValidator>
        </div>
    </div>  
    <div class="thongTin">
        <div class="tenTruong">&nbsp;</div>
        <div class="oNhap"><asp:CheckBox ID="cbAddMoreCategoryNews" runat="server" Text="Add another category after creating this category news"/></div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">&nbsp;</div>
        <div class="oNhap">
            <asp:Button ID="btThemMoi" runat="server" Text="Add news" CssClass="btThemMoi" OnClick="btThemMoi_Click" />
            <asp:Button ID="btHuy" runat="server" Text="Cancel" CssClass="btHuy" OnClick="btHuy_Click" CausesValidation="false" />
        </div>
    </div>
</div>