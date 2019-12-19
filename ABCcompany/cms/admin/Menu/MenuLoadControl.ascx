<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MenuLoadControl.ascx.cs" Inherits="cms_admin_Menu_MenuLoadControl" %>

<div class="container">
    <div style="clear:both;height:20px"></div>
    <div class="cotTrai">
        <div class="head">
            Manage
        </div>
        <ul>
            <li><a class="<%=Tick("Menu","DanhSachMenu","") %>" href="Admin.aspx?modul=Menu&modulphu=DanhSachMenu">Menu list</a></li>
        </ul>
        <div class="head">
            Add new
        </div>
        <ul>
            <li><a class="<%=Tick("Menu","DanhSachMenu","ThemMoi") %>" href="Admin.aspx?modul=Menu&modulphu=DanhSachMenu&thaotac=ThemMoi">Menu list</a></li>            
        </ul>
    </div>
    <div class="cotPhai">
        <asp:PlaceHolder ID="plLoadControl" runat="server"></asp:PlaceHolder>
    </div>
    <div class="cb"></div>

</div>