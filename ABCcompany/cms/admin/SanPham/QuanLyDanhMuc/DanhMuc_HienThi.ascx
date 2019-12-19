<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhMuc_HienThi.ascx.cs" Inherits="cms_admin_SanPham_QuanLyDanhMuc_DanhMuc_HienThi" %>
<div class="head">
    Product categories created
    <div class="fr tar">
        <a class="btThemMoi" href="/Admin.aspx?modul=SanPham&modulphu=DanhMuc&thaotac=ThemMoi">Add new category</a>
    </div>
    <div class="cb"></div>
</div>
<div class="KhungChuaBang">
    <table class="tbDanhMuc">
        <tr>
            <th class="cotMa">NO </th>
            <th class="cotTen">Category name</th>
            <th class="cotAnh">Avatar</th>
            <th class="cotThuTu">Number Order</th>
            <th class="cotCongCu">Tool</th>
        </tr>
        <asp:Literal ID="ltrCategory" runat="server"></asp:Literal>


    </table>
</div>

<%--<script type="text/javascript">
    function XoaDanhMuc(categoryid) {
        if (confirm("Bạn muốn xóa danh mục này?")) {
            //Viết code xóa danh mục tại đây
            $.post("demo_test_post.asp",
                {
                    "categoryid": categoryid
                }
                function (data, status) {
                    alert("Data: " + data + "\nStatus: " + status);
                });
        }
    }
</script>--%>

<script type="text/javascript">
    function DeleteCategory(categoryid)
    {
        if(confirm("Are you sure to delete this category?"))
        {
            //Viết code xóa danh mục tại đây
            //G:\OneDrive - K3v(1)\Engrish + IT\1 code\5.1 NET - C Sharp\project\Hello01\PTbac2\emdep.vn\cms\admin\SanPham\QuanLyDanhMuc\Ajax\DanhMuc.aspx.cs
            $.post("cms/admin/SanPham/QuanLyDanhMuc/Ajax/Category.aspx",
                {
                    "ThaoTac":"DeleteCategory",
                    "categoryid": categoryid
                },
                function (data, status)
                {
                    //alert("Data :" + data + "\n Status :" + status);
                    if(data==1)
                    {
                        //thực hiện thành công => ẩn dòng vừa xóa đi
                        $("#maDong_" + categoryid).slideUp();
                    }
                });
        }
    }
</script>