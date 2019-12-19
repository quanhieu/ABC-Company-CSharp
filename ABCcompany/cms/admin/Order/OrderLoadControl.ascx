<%@ Control Language="C#" AutoEventWireup="true" CodeFile="OrderLoadControl.ascx.cs" Inherits="cms_admin_Order_OrderLoadControl" %>


<div class="container">
    <div style="clear:both;height:20px"></div>
    <div class="cotTrai">
        <div class="head">
            Manage
        </div>
        <ul>
            <li><a class="<%=DanhDau("Order","DanhSachOrder","") %>" href="Admin.aspx?modul=Order&modulphu=DanhSachOrder">Order category</a></li>
        </ul>
        <div class="head">
            Add new
        </div>
        <ul>
            <li><a class="<%=DanhDau("Order","DanhSachOrder","ThemMoi") %>" href="Admin.aspx?modul=Order&modulphu=DanhSachOrder&thaotac=ThemMoi">Order category</a></li>            
        </ul>
    </div>
    <div class="cotPhai">
      
        <asp:PlaceHolder ID="plLoadControl" runat="server"></asp:PlaceHolder>
    </div>
    <div class="cb"></div>

</div>
