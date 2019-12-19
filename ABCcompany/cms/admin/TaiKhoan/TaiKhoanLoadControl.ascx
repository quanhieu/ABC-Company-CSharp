<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TaiKhoanLoadControl.ascx.cs" 
    Inherits="cms_admin_TaiKhoan_TaiKhoanLoadControl" %>
<div class="container">
    <div style="clear:both;height:20px"></div>
    <div class="cotTrai">
        <div class="head">
            Manage
        </div>
        <ul>
            <li><a class="<%=DanhDau("TaiKhoan","DanhSachTaiKhoan","") %>" href="Admin.aspx?modul=TaiKhoan&modulphu=DanhSachTaiKhoan">Account category</a></li>
        </ul>
        <div class="head">
            Add new
        </div>
        <ul>
            <li><a class="<%=DanhDau("TaiKhoan","DanhSachTaiKhoan","ThemMoi") %>" href="Admin.aspx?modul=TaiKhoan&modulphu=DanhSachTaiKhoan&thaotac=ThemMoi">Account category</a></li>            
        </ul>
    </div>
    <div class="cotPhai">
      
        <asp:PlaceHolder ID="plLoadControl" runat="server"></asp:PlaceHolder>
    </div>
    <div class="cb"></div>

</div>
