<%@ Control Language="C#" AutoEventWireup="true" CodeFile="NhomQuangCao_ThemMoi.ascx.cs" Inherits="cms_admin_QuangCao_QuanLyNhomQuangCao_NhomQuangCao_ThemMoi" %>
<div class="head">
    Add and edit ad groups
</div>
<div class="FormThemMoi">
    <asp:Literal ID="ltrNotify" runat="server"></asp:Literal>   
    <div class="thongTin">
        <div class="tenTruong">Group Ads name</div>
        <div class="oNhap">            
            <asp:TextBox ID="tbGroupAdsName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="tbGroupAdsName" Display="Dynamic" SetFocusOnError="True" ForeColor="Red" ></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Loacation</div>
        <div class="oNhap">            
            <asp:TextBox ID="tbLocationGA" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="tbLocationGA" Display="Dynamic" SetFocusOnError="True" ForeColor="Red" ></asp:RequiredFieldValidator>
        </div>
    </div> 
    <div class="thongTin">
        <div class="tenTruong">Image group Ads</div>
        <div class="oNhap">
            <div>
                <asp:HiddenField ID="hdAvatarGaOld" runat="server" />
                <asp:Literal ID="ltrAvatarGA" runat="server"></asp:Literal>
            </div>
            <asp:FileUpload ID="flAvatarGa" runat="server" />
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Order number</div>
        <div class="oNhap">
            <asp:TextBox ID="tbNumOrderGA" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="The order must be numeric" ControlToValidate="tbNumOrderGA" Display="Dynamic" SetFocusOnError="True" ValidationExpression="(\d)*" ForeColor="Red"  ></asp:RegularExpressionValidator>
        </div>
    </div>  
    <div class="thongTin">
        <div class="tenTruong">&nbsp;</div>
        <div class="oNhap"><asp:CheckBox ID="cbAddMoreGroupAds" runat="server" Text="Create more product groups after creating this product group"/></div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">&nbsp;</div>
        <div class="oNhap">
            <asp:Button ID="btThemMoi" runat="server" Text="Add neww" CssClass="btThemMoi" OnClick="btThemMoi_Click" />
            <asp:Button ID="btHuy" runat="server" Text="Cancel" CssClass="btHuy" OnClick="btHuy_Click" CausesValidation="false" />
        </div>
    </div>
</div>