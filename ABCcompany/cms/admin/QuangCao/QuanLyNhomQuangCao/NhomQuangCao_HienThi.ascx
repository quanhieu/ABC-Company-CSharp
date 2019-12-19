<%@ Control Language="C#" AutoEventWireup="true" CodeFile="NhomQuangCao_HienThi.ascx.cs" Inherits="cms_admin_QuangCao_QuanLyNhomQuangCao_NhomQuangCao_HienThi" %>
<div class="head">
    Ad groups created
    <div class="fr ter"><a class="btThemMoi" href="/Admin.aspx?modul=QuangCao&modulphu=NhomQuangCao&thaotac=ThemMoi">Add a new ad group</a></div>
    <div class="cb"></div>
</div>
<div class="KhungChuaBang">
   <table class="tbNhomQuangCao">
       <tr>
           <th class="cotMa">No</th>
           <th class="cotTen">Ad group name</th>
           <th class="cotViTri">Ads location</th>
           <th class="cotAnh">Image ads</th>
           <th class="cotThuTu">Order number</th>
           <th class="cotCongCu">Tool</th>
       </tr>
       <asp:Literal ID="ltrGroupAds" runat="server"></asp:Literal>
   </table>
</div>

<script type="text/javascript">
    function DeleteGroupAds(groupadsid) {
        if (confirm("Are you sure to delete this product group")) {
            //Viết code xóa danh mục tại đây

            $.post("cms/admin/QuangCao/QuanLyNhomQuangCao/Ajax/GroupAds.aspx",
                {
                    "ThaoTac": "DeleteGroupAds",
                    "groupadsid": groupadsid
                },
                function (data, status) {
                    //alert("Data :" + data + "\n Status :" + status);
                    if (data == 1) {
                        //thực hiện thành công => ẩn dòng vừa xóa đi
                        $("#maDong_" + groupadsid).slideUp();

                    }
                });
        }
    }
</script>