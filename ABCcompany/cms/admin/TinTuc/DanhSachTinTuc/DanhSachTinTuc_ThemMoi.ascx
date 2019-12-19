<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhSachTinTuc_ThemMoi.ascx.cs" Inherits="cms_admin_TinTuc_DanhSachTinTuc_DanhSachTinTuc_ThemMoi" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<div class="head">
    Add, edit news
</div>
<div class="FormThemMoi">
    <asp:Literal ID="ltrNotify" runat="server"></asp:Literal>
    <div class="thongTin">
        <div class="tenTruong">Chose category news</div>
        <div class="oNhap"><asp:DropDownList ID="ddlCodeFar" runat="server"></asp:DropDownList></div>
    </div>   
    <div class="thongTin">
        <div class="tenTruong">Title</div>
        <div class="oNhap">            
            <asp:TextBox ID="tbTitle" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="tbTitle" Display="Dynamic" SetFocusOnError="True" ForeColor="Red" ></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Describe</div>
        <div class="oNhap">            
            <asp:TextBox ID="tbDescribe" TextMode="MultiLine" runat="server" Height="150px"></asp:TextBox>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Views</div>
        <div class="oNhap">
            <asp:TextBox ID="tbViews" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Quantity must enter numeric" ControlToValidate="tbViews" Display="Dynamic" SetFocusOnError="True" ValidationExpression="(\d)*" ForeColor="Red"  ></asp:RegularExpressionValidator>
        </div>
    </div> 
    <div class="thongTin">
        <div class="tenTruong">Post date</div>
        <div class="oNhap">
            <asp:TextBox ID="tbPostDate" runat="server"></asp:TextBox>
        </div>
    </div> 
    <div class="thongTin">
        <div class="tenTruong">Image news</div>
        <div class="oNhap">
            <div>
                <asp:HiddenField ID="hdavatarNameOld" runat="server" />
                <asp:Literal ID="ltrAvatarNews" runat="server"></asp:Literal>
            </div>
            <asp:FileUpload ID="flAvatar" runat="server" />
        </div>
    </div> 
    <div class="thongTin">
        <div class="tenTruong">Order number</div>
        <div class="oNhap">
            <asp:TextBox ID="tbNumOrder" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Order number must be numeberic" ControlToValidate="tbNumOrder" Display="Dynamic" SetFocusOnError="True" ValidationExpression="(\d)*" ForeColor="Red"  ></asp:RegularExpressionValidator>
        </div>
    </div>  
    <div class="thongTin">
        <div class="tenTruong">News detail</div>
        <div class="oNhap">            
            <%--<asp:TextBox ID="tbDescribe" TextMode="MultiLine" runat="server" Height="150px"></asp:TextBox>--%>
            <CKEditor:CKEditorControl ID="tbDetail" runat="server" FilebrowserImageBrowseUrl="ckeditor/ckfinder/ckfinder.aspx?type=Images&path=pic"></CKEditor:CKEditorControl>
        </div>
    </div>
   
    <div class="thongTin">
        <div class="tenTruong">&nbsp;</div>
        <div class="oNhap"><asp:CheckBox ID="cbAddMoreNews" runat="server" Text="Create more news after creating this news"/></div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">&nbsp;</div>
        <div class="oNhap">
            <asp:Button ID="btThemMoi" runat="server" Text="Add new" CssClass="btThemMoi" OnClick="btThemMoi_Click" />
            <asp:Button ID="btHuy" runat="server" Text="Cancel" CssClass="btHuy" OnClick="btHuy_Click" CausesValidation="false" />
        </div>
    </div>
</div>