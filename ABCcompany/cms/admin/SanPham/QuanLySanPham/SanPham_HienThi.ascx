<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SanPham_HienThi.ascx.cs" Inherits="cms_admin_SanPham_QuanLySanPham_SanPham_HienThi" %>
<div class="head">
    Products created
    <div class="fr tar">
        <a class="btThemMoi" href="/Admin.aspx?modul=SanPham&modulphu=DanhSachSanPham&thaotac=ThemMoi">Add new product</a>
    </div>
    <div class="cb"></div>
</div>
<div class="KhungChuaBang">
    <table class="tbDanhMuc">
        <tr>
            <th class="cotMa">NO </th>
            <th class="cotTen">Product name</th>
            <th class="cotAnh">Avatar</th>
            <th class="cotSoLuong">Quantily</th>
            <th class="cotDonGia">Unit price</th>
            <th class="cotNgayTao">Date created</th>
            <th class="cotCongCu">Tool</th>
        </tr>
        <asp:Literal ID="ltrProduct" runat="server"></asp:Literal>


    </table>
</div>


<script type="text/javascript">
    function DeleteProduct(productid)
    {
        if(confirm("You definitely want to delete this product"))
        {
            //Viết code xóa danh mục tại đây
            //G:\OneDrive - K3v(1)\Engrish + IT\1 code\5.1 NET - C Sharp\project\Hello01\PTbac2\emdep.vn\cms\admin\SanPham\QuanLyDanhMuc\Ajax\DanhMuc.aspx.cs
            $.post("cms/admin/SanPham/QuanLySanPham/Ajax/Product.aspx",
                {
                    "ThaoTac":"DeleteProduct",
                    "productid": productid
                },
                function (data, status)
                {
                    //alert("Data :" + data + "\n Status :" + status);
                    if(data==1)
                    {
                        //thực hiện thành công => ẩn dòng vừa xóa đi
                        $("#maDong_" + productid).slideUp();
                    }
                });
        }
    }
</script>