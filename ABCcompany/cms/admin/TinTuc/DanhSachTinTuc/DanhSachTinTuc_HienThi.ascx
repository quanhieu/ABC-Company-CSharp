<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhSachTinTuc_HienThi.ascx.cs" Inherits="cms_admin_TinTuc_DanhSachTinTuc_DanhSachTinTuc_HienThi" %>
<div class="head">
    News created
    <div class="fr ter"><a class="btThemMoi" href="/Admin.aspx?modul=TinTuc&modulphu=DanhSachTinTuc&thaotac=ThemMoi">Add news</a></div>
    <div class="cb"></div>
</div>
<div class="KhungChuaBang">
   <table class="tbDanhMuc">
       <tr>
           <th class="cotMa">No</th>
           <th class="cotTen">Title</th>
           <th class="cotAnh">Image news</th>
           <th class="cotSoLuong">Views</th>
           <th class="cotNgayDang">Post Date</th>
           <th class="cotThuTu">Order date</th>
           <th class="cotCongCu">Tool</th>
       </tr>
       <asp:Literal ID="ltrTinTuc" runat="server"></asp:Literal>
   </table>
</div>

<script type="text/javascript">
    function DeleteNews(NewsID) {
        if (confirm("Are you want to delete this news")) {
            //Viết code xóa danh mục tại đây

            $.post("cms/admin/TinTuc/DanhSachTinTuc/Ajax/News.aspx",
                {
                    "ThaoTac": "DeleteNews",
                    "NewsID": NewsID
                },
                function (data, status) {
                    //alert("Data :" + data + "\n Status :" + status);
                    if (data == 1) {
                        //thực hiện thành công => ẩn dòng vừa xóa đi
                        $("#maDong_" + NewsID).slideUp();

                    }
                });
        }
    }
</script>