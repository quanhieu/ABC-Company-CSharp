<%@ Control Language="C#" AutoEventWireup="true" CodeFile="QuangCaoLoadControl.ascx.cs" Inherits="cms_admin_QuangCao_QuangCaoLoadControl" %>

<div class="container">
    <div style="clear:both;height:20px"></div>
    <div class="cotTrai">
        <div class="head">
           Manage
        </div>
        <ul>
            <li><a class="<%=DanhDau("QuangCao","NhomQuangCao","") %>" href="Admin.aspx?modul=QuangCao&modulphu=NhomQuangCao">Ads group</a></li>
            <li><a class="<%=DanhDau("QuangCao","DanhSachQuangCao","") %>" href="Admin.aspx?modul=QuangCao&modulphu=DanhSachQuangCao">Ads List</a></li>            
        </ul>
        <div class="head">
            Add new
        </div>
        <ul>
            <li><a class="<%=DanhDau("QuangCao","NhomQuangCao","ThemMoi") %>" href="Admin.aspx?modul=QuangCao&modulphu=NhomQuangCao&thaotac=ThemMoi">Ads group</a></li>
            <li><a class="<%=DanhDau("QuangCao","DanhSachQuangCao","ThemMoi") %>" href="Admin.aspx?modul=QuangCao&modulphu=DanhSachQuangCao&thaotac=ThemMoi">Ads List</a></li>            
        </ul>
    </div>
    <div class="cotPhai">
        <asp:PlaceHolder ID="plQuangCaoLoadControl" runat="server"></asp:PlaceHolder>
    </div>
    <div class="cb"></div>

</div>