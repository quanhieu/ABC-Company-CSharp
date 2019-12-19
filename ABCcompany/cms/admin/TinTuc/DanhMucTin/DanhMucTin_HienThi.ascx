<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhMucTin_HienThi.ascx.cs" Inherits="cms_admin_TinTuc_DanhMucTin_DanhMucTin_HienThi" %>
<div class="head">
    Category news created
    <div class="fr ter"><a class="btThemMoi" href="/Admin.aspx?modul=TinTuc&modulphu=DanhMucTin&thaotac=ThemMoi">Add category news</a></div>
    <div class="cb"></div>
</div>
<div class="KhungChuaBang">
   <table class="tbDanhMuc">
       <tr>
           <th class="cotMa">No</th>
           <th class="cotTen">Category news name</th>
           <th class="cotAnh">Image category news</th>
           <th class="cotThuTu">Order number</th>
           <th class="cotCongCu">Tool</th>
       </tr>
       <asp:Literal ID="ltrCategoryNews" runat="server"></asp:Literal>
   </table>
</div>

<script type="text/javascript">
    function DeleteCategoryNews(newscode) {
        if (confirm("Are you want to delete category news")) {
            //Viết code xóa danh mục tại đây

            $.post("cms/admin/TinTuc/DanhMucTin/Ajax/CategoryNews.aspx",
                {
                    "ThaoTac": "DeleteCategoryNews",
                    "newscode": newscode
                },
                function (data, status) {
                    //alert("Data :" + data + "\n Status :" + status);
                    if (data == 1) {
                        //thực hiện thành công => ẩn dòng vừa xóa đi
                        $("#maDong_" + newscode).slideUp();

                    }
                });
        }
    }
</script>