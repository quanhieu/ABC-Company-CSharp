<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhSachQuangCao_HienThi.ascx.cs" Inherits="cms_admin_QuangCao_QuanLyDanhSachQuangCao_DanhSachQuangCao_HienThi" %>
<div class="head">
    Ads created
    <div class="fr ter"><a class="btThemMoi" href="/Admin.aspx?modul=QuangCao&modulphu=DanhSachQuangCao&thaotac=ThemMoi">Add new product group</a></div>
    <div class="cb"></div>
</div>
<div class="KhungChuaBang">
   <table class="tbDanhMuc">
       <tr>
           <th class="cotMa">No</th>
           <th class="cotTen">Ad name</th>
           <th class="cotAnh">Image ads</th>
           <th class="cotThuTu">Order number</th>
           <th class="cotCongCu">Tool</th>
       </tr>
       <asp:Literal ID="ltrAds" runat="server"></asp:Literal>
   </table>
</div>

<script type="text/javascript">
    function DeleteAds(adsid) {
        if (confirm("Are you sure to delete this group product ")) {
            //Viết code xóa danh mục tại đây

            $.post("cms/admin/QuangCao/QuanLyDanhSachQuangCao/Ajax/Ads.aspx",
                {
                    "ThaoTac": "DeleteAds",
                    "adsid": adsid
                },
                function (data, status) {
                    //alert("Data :" + data + "\n Status :" + status);
                    if (data == 1) {
                        //thực hiện thành công => ẩn dòng vừa xóa đi
                        $("#maDong_" + adsid).slideUp();

                    }
                });
        }
    }
</script>