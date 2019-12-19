<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Menu_ThemMoi.ascx.cs" Inherits="cms_admin_Menu_Menu_ThemMoi" %>
<div class="head">
    Add, edit menu category
</div>
<div class="FormThemMoi">
    <asp:Literal ID="ltrNotify" runat="server"></asp:Literal>
    <div class="thongTin">
        <div class="tenTruong">Main Menu</div>
        <div class="oNhap"><asp:DropDownList ID="ddlMenuFar" runat="server"></asp:DropDownList></div>
    </div>   
    <div class="thongTin">
        <div class="tenTruong">Menu name</div>
        <div class="oNhap">            
            <asp:TextBox ID="tbMenuName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="tbMenuName" Display="Dynamic" SetFocusOnError="True" ForeColor="Red" ></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Link</div>
        <div class="oNhap">            
            <asp:TextBox ID="tbLink" runat="server"></asp:TextBox>
        </div>
    </div>
    
    <div class="thongTin">
        <div class="tenTruong">Order number</div>
        <div class="oNhap">
            <asp:TextBox ID="tbNumberOrder" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="The order must be numeric" ControlToValidate="tbNumberOrder" Display="Dynamic" SetFocusOnError="True" ValidationExpression="(\d)*" ForeColor="Red"  ></asp:RegularExpressionValidator>
        </div>
    </div>  
    <div class="thongTin">
        <div class="tenTruong">&nbsp;</div>
        <div class="oNhap"><asp:CheckBox ID="cbAddNewMenuCategory" runat="server" Text="Add another menu category after creating this menu category"/></div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">&nbsp;</div>
        <div class="oNhap">
            <asp:Button ID="btThemMoi" runat="server" Text="Add new" CssClass="btThemMoi" OnClick="btThemMoi_Click" />
            <asp:Button ID="btHuy" runat="server" Text="Cancel" CssClass="btHuy" OnClick="btHuy_Click" CausesValidation="false" />
        </div>
    </div>
</div>

