<%@ Control Language="C#" AutoEventWireup="true" CodeFile="NhomSanPham_ThemMoixxx.ascx.cs" Inherits="cms_admin_SanPham_QuanLyNhomSanPham_NhomSanPham_ThemMoi" %>
<div class="head">
    Add, edit product group
</div>
<div class="FormThemMoi">
    <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>   
    <div class="thongTin">
        <div class="tenTruong">Group product name</div>
        <div class="oNhap">            
            <asp:TextBox ID="tbGroupName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="tbGroupName" Display="Dynamic" SetFocusOnError="True" ForeColor="Red" ></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Avatar</div>
        <div class="oNhap">
            <div>
                <asp:HiddenField ID="hdAvatar" runat="server" />
                <asp:Literal ID="ltrAvatar" runat="server"></asp:Literal>
            </div>
            <asp:FileUpload ID="flAvatar" runat="server" />
        </div>
    </div> 
    <div class="thongTin">
        <div class="tenTruong">Number Order</div>
        <div class="oNhap">
            <asp:TextBox ID="tbNumOrder" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="The order number must be numeric" ControlToValidate="tbNumOrder" Display="Dynamic" SetFocusOnError="True" ValidationExpression="(\d)*" ForeColor="Red"  ></asp:RegularExpressionValidator>
        </div>
    </div>  
    <div class="thongTin">
        <div class="tenTruong">Number of products displayed</div>
        <div class="oNhap">
            <asp:TextBox ID="tbNumShow" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Number products of display must be numeric" ControlToValidate="tbNumShow" Display="Dynamic" SetFocusOnError="True" ValidationExpression="(\d)*" ForeColor="Red"  ></asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">&nbsp;</div>
        <div class="oNhap"><asp:CheckBox ID="cbAddMoreGroupProduct" runat="server" Text="Create more product groups after creating this product group"/></div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">&nbsp;</div>
        <div class="oNhap">
            <asp:Button ID="btThemMoi" runat="server" Text="Add new" CssClass="btThemMoi" OnClick="btThemMoi_Click" />
            <asp:Button ID="btHuy" runat="server" Text="Cancel" CssClass="btHuy" OnClick="btHuy_Click" CausesValidation="false" />
        </div>
    </div>
</div>