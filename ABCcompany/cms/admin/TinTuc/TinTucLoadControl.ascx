<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TinTucLoadControl.ascx.cs" Inherits="cms_admin_TinTuc_TinTucLoadControl" %>

<div class="container">
    <div style="clear:both;height:20px"></div>
    <div class="cotTrai">
        <div class="head">
            Manage
        </div>
        <ul>
            <li><a class="<%=DanhDau("TinTuc","DanhMucTin","") %>" href="Admin.aspx?modul=TinTuc&modulphu=DanhMucTin">Category News</a></li>
            <li><a class="<%=DanhDau("TinTuc","DanhSachTinTuc","") %>" href="Admin.aspx?modul=TinTuc&modulphu=DanhSachTinTuc">News list</a></li>            
        </ul>
        <div class="head">
            Add new
        </div>
        <ul>
            <li><a class="<%=DanhDau("TinTuc","DanhMucTin","ThemMoi") %>" href="Admin.aspx?modul=TinTuc&modulphu=DanhMucTin&thaotac=ThemMoi">Category News</a></li>
            <li><a class="<%=DanhDau("TinTuc","DanhSachTinTuc","ThemMoi") %>" href="Admin.aspx?modul=TinTuc&modulphu=DanhSachTinTuc&thaotac=ThemMoi">News list</a></li>            
        </ul>
    </div>
    <div class="cotPhai">
        <asp:PlaceHolder ID="plTinTucLoadControl" runat="server"></asp:PlaceHolder>
    </div>
    <div class="cb"></div>

</div>
