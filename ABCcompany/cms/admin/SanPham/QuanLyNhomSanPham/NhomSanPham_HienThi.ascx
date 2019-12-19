<%@ Control Language="C#" AutoEventWireup="true" CodeFile="NhomSanPham_HienThi.ascx.cs" Inherits="cms_admin_SanPham_QuanLyNhomSanPham_NhomSanPham_HienThi" %>
<div class="head">
    Product groups created
    <div class="fr ter"><a class="btThemMoi" href="/Admin.aspx?modul=SanPham&modulphu=Nhom&thaotac=ThemMoi">Add new product group</a></div>
    <div class="cb"></div>
</div>
<div class="KhungChuaBang">
   <table class="tbNhomSanPham">
       <tr>
           <th class="cotMa">NO</th>
           <th class="cotTen">Group product name</th>
           <th class="cotAnh">Avatar</th>
           <th class="cotThuTu">Number Order</th>
           <th class="cotSoSanPhamHienThi">Some products show</th>
           <th class="cotCongCu">Tool</th>
       </tr>
       <asp:Literal ID="GroupProduct" runat="server"></asp:Literal>
   </table>
</div>

<script type="text/javascript">
    function DeleteGroupProduct(groupid) {
        if (confirm("Are you sure to delete this product group?")) {
            //Viết code xóa danh mục tại đây

            $.post("cms/admin/SanPham/QuanLyNhomSanPham/Ajax/GroupProduct.aspx",
                {
                    "ThaoTac": "DeleteGroupProduct",
                    "groupid": groupid
                },
                function (data, status) {
                    //alert("Data :" + data + "\n Status :" + status);
                    if (data == 1) {
                        //thực hiện thành công => ẩn dòng vừa xóa đi
                        $("#maDong_" + groupid).slideUp();

                    }
                });
        }
    }
</script>