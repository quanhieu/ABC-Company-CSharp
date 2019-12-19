<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" ValidateRequest="false" %>

<%@ Register Src="~/cms/admin/AdminLoadControl.ascx" TagPrefix="uc1" TagName="AdminLoadControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Adminstrator website</title>
    <link href="cms/admin/css/cssAdmin.css" rel="stylesheet" />

    <script src="cms/admin/js/jquery-3.3.1.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            <%-- Phan Header--%>
            <div id="header">
                <div class="container">
                    <div class="logo">
                        
                        <a href="Admin.aspx"><img src="pic/Logo/capture.png" /> </a>
                    </div>
                   
                    <div class="accountMenu">
                        Xin chào: <asp:Literal ID="ltrTenDangNhap" runat="server"></asp:Literal> |
                            <asp:LinkButton ID="lbtDangXuat" runat="server" OnClick="lbtDangXuat_Click">Đăng xuất</asp:LinkButton>
                    </div>
                </div>
            </div>

            <%-- Menu chinh --%>
            <div class="MenuChinh">
                <div class="container">
                    <ul>
                        <%--<li><a class="<%=DanhDau("") %>" href="Admin.aspx">Trang chu</a> </li>--%>
                        <li><a class="<%=DanhDau("SanPham") %>" href="Admin.aspx?modul=SanPham">Product</a> </li>
                        <li><a class="<%=DanhDau("TaiKhoan") %>" href="Admin.aspx?modul=TaiKhoan">Account</a> </li>
                        <li><a class="<%=DanhDau("KhachHang") %>" href="Admin.aspx?modul=KhachHang">Customer</a> </li>
                        <li><a class="<%=DanhDau("TinTuc") %>" href="Admin.aspx?modul=TinTuc">News</a> </li>
                        <li><a class="<%=DanhDau("QuangCao") %>" href="Admin.aspx?modul=QuangCao">Ads</a> </li>
                        <li><a class="<%=DanhDau("Order") %>" href="Admin.aspx?modul=Order">Order</a> </li>
                        <li><a class="<%=DanhDau("Menu") %>" href="Admin.aspx?modul=Menu">Menu</a> </li>
                    </ul>
                </div>
            </div>

            <%--Phan noi dung trang--%>
            <uc1:AdminLoadControl runat="server" ID="AdminLoadControl" />

        </div>

    </form>
</body>
</html>
