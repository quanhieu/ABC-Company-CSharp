<%@ Control Language="C#" AutoEventWireup="true" CodeFile="KhachHangLoadControl.ascx.cs" Inherits="cms_admin_KhachHang_KhachHangLoadControl" %>
<div class="container">
    <div style="clear:both;height:20px"></div>
    <div class="cotTrai">
        <div class="head">
           Manage
        </div>
        <ul>
            <li><a class="<%=Tick("KhachHang","DanhSachKhachHang","") %>" href="Admin.aspx?modul=KhachHang&modulphu=DanhSachKhachHang">List of customers</a></li>
        </ul>
    </div>
    <div class="cotPhai">
        <asp:PlaceHolder ID="plLoadControl" runat="server"></asp:PlaceHolder>
    </div>
    <div class="cb"></div>

</div>