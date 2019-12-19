<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TaiKhoan_ThemMoi.ascx.cs" Inherits="cms_admin_TaiKhoan_TaiKhoan_ThemMoi" %>
<div class="head"> 
    Add, edit account
</div>
<div class="FormThemMoi">
    <asp:Literal ID="ltrNotify" runat="server"></asp:Literal>
    <div class="thongTin">
        <div class="tenTruong">Choose login access</div>
        <div class="oNhap"><asp:DropDownList ID="ddlLoginID" runat="server"></asp:DropDownList></div>
    </div>

    <div class="thongTin">
        <div class="tenTruong">User name</div>
        <div class="oNhap">
            <asp:TextBox ID="tbUserName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="tbUserName"
                Display="Dynamic" SetFocusOnError="true" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
    </div>
    
    <div class="thongTin">
        <div class="tenTruong">Mật khẩu</div>
        <div class="oNhap">
            <asp:HiddenField ID="hdOldPassword" runat="server" />
            <asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="tbPassword"
                Display="Dynamic" SetFocusOnError="true" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
    </div>
      
    <div class="thongTin">
        <div class="tenTruong">Email</div>
        <div class="oNhap">
            <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
        </div>
    </div>
          
    <div class="thongTin">
        <div class="tenTruong">Address</div>
        <div class="oNhap">
            <asp:TextBox ID="tbAddressRe" runat="server"></asp:TextBox>
        </div>
    </div>
              
    <div class="thongTin">
        <div class="tenTruong">Full name</div>
        <div class="oNhap">
            <asp:TextBox ID="tbFullName" runat="server"></asp:TextBox>
        </div>
    </div>
                  
    <div class="thongTin">
        <div class="tenTruong">Date of birth (Month/Day/Year)</div>
        <div class="oNhap">
            <asp:TextBox ID="tbDOB" runat="server"></asp:TextBox>
        </div>
    </div>
                  
    <div class="thongTin">
        <div class="tenTruong">Sex</div>
        <div class="oNhap">
            <asp:DropDownList ID="ddlSexRe" runat="server">
                <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                <asp:ListItem Text="Other" Value="Other"></asp:ListItem>
            </asp:DropDownList>
               
        </div>
    </div>


     <div class="thongTin">
        <div class="tenTruong"> &nbsp</div>
        <div class="oNhap"> <asp:CheckBox ID="cbAddMore" runat="server" Text="Continue creating another account after complete"/></div>
    </div>

    <div class="thongTin">
        <div class="tenTruong"> &nbsp;</div>
        <div class="oNhap">
            <asp:Button ID="btAddNew" runat="server" Text="Add neww" CssClass="btThemMoi" OnClick="btAddNew_Click"/>
            <asp:Button ID="btHuy" runat="server" Text="Cancel" CssClass="btHuy" OnClick="btHuy_Click" CausesValidation="false"/>
        </div>
        
    </div>
</div>
