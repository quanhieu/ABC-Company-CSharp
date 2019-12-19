<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SanPhamLoadControll.ascx.cs" Inherits="cms_admin_SanPham_SanPhamLoadControll" %>
<%--Day la trang san pham--%>

<div class="container">
    <div style="clear: both; height: 20px"></div>
    <div class="cotTrai">
        <%--Menu san pham--%>
        <div class="head">
            Manage
        </div>
        <ul>
            <li><a class="<%=DanhDau("SanPham","DanhMuc","") %>" href="Admin.aspx?modul=SanPham&modulphu=DanhMuc">Product Category</a></li>
            <li><a class="<%=DanhDau("SanPham","Nhom","") %>" href="Admin.aspx?modul=SanPham&modulphu=Nhom">Group Product</a></li>
            <li><a class="<%=DanhDau("SanPham","DanhSachSanPham","") %>" href="Admin.aspx?modul=SanPham&modulphu=DanhSachSanPham">Product</a></li>
            <li><a class="<%=DanhDau("SanPham","Mau","") %>" href="Admin.aspx?modul=SanPham&modulphu=Mau">Status product</a></li>
            <%--<li><a class="<%=DanhDau("SanPham","ChatLieu","") %>" href="Admin.aspx?modul=SanPham&modulphu=ChatLieu">Chat lieu san pham</a></li>--%>
            <li><a class="<%=DanhDau("SanPham","Size","") %>" href="Admin.aspx?modul=SanPham&modulphu=Size">Supply product</a></li>

        </ul>

        <div class="head">
            Add new
        </div>

        <ul>
            <li><a class="<%=DanhDau("SanPham","DanhMuc","ThemMoi") %>" href="Admin.aspx?modul=SanPham&modulphu=DanhMuc&thaotac=ThemMoi">Product Category</a></li>
            <li><a class="<%=DanhDau("SanPham","Nhom","ThemMoi") %>" href="Admin.aspx?modul=SanPham&modulphu=Nhom&thaotac=ThemMoi">Group Product</a></li>
            <li><a class="<%=DanhDau("SanPham","DanhSachSanPham","ThemMoi") %>" href="Admin.aspx?modul=SanPham&modulphu=DanhSachSanPham&thaotac=ThemMoi">Product</a></li>
            <li><a class="<%=DanhDau("SanPham","Mau","ThemMoi") %>" href="Admin.aspx?modul=SanPham&modulphu=Mau&thaotac=ThemMoi">Status</a></li>
            <%--<li><a class="<%=DanhDau("SanPham","ChatLieu","ThemMoi") %>" href="Admin.aspx?modul=SanPham&modulphu=ChatLieu&thaotac=ThemMoi">Chat lieu san pham</a></li>--%>
            <li><a class="<%=DanhDau("SanPham","Size","ThemMoi") %>" href="Admin.aspx?modul=SanPham&modulphu=Size&thaotac=ThemMoi">Supply product</a></li>
        </ul>

    </div>

    <div class="cotPhai">
        <%--abc--%>
        <asp:PlaceHolder ID="plSanPhamLoadControl" runat="server"></asp:PlaceHolder>
    </div>

    <div class="cb"> <!----------------------> </div>
</div>

