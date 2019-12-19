<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhSachQuangCao_ThemMoi.ascx.cs" Inherits="cms_admin_QuangCao_QuanLyDanhSachQuangCao_DanhSachQuangCao_ThemMoi" %>
<div class="head">
    Add, edit the ad
</div>
<div class="FormThemMoi">
    <asp:Literal ID="ltrNotify" runat="server"></asp:Literal>
    <div class="thongTin">
        <div class="tenTruong">Chọn nhóm Quảng cáo</div>
        <div class="oNhap"><asp:DropDownList ID="ddlAdsFar" runat="server"></asp:DropDownList></div>
    </div>   
    <div class="thongTin">
        <div class="tenTruong">Ads name</div>
        <div class="oNhap">            
            <asp:TextBox ID="tbAdsName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="tbAdsName" Display="Dynamic" SetFocusOnError="True" ForeColor="Red" ></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Image ads</div>
        <div class="oNhap">
            <div>
                <asp:HiddenField ID="hdImageAds" runat="server" />
                <asp:Literal ID="ltrImageAds" runat="server"></asp:Literal>
            </div>
            <asp:FileUpload ID="flImageAds" runat="server" />
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
            <asp:TextBox ID="tbNumOrderAds" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="The order must be numeric" ControlToValidate="tbNumOrderAds" Display="Dynamic" SetFocusOnError="True" ValidationExpression="(\d)*" ForeColor="Red"  ></asp:RegularExpressionValidator>
        </div>
    </div>  
   
    <div class="thongTin">
        <div class="tenTruong">&nbsp;</div>
        <div class="oNhap"><asp:CheckBox ID="cbAddMoreCategoryAds" runat="server" Text="Create more news after creating this news"/></div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">&nbsp;</div>
        <div class="oNhap">
            <asp:Button ID="btThemMoi" runat="server" Text="Add new" CssClass="btThemMoi" OnClick="btThemMoi_Click" />
            <asp:Button ID="btHuy" runat="server" Text="Cancel" CssClass="btHuy" OnClick="btHuy_Click" CausesValidation="false" />
        </div>
    </div>
</div>