<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Mau_HienThi.ascx.cs" Inherits="cms_admin_SanPham_QuanLyMau_Mau_HienThi" %>
<div class="head">
    Status created
    <div class="fr ter"><a class="btThemMoi" href="/Admin.aspx?modul=SanPham&modulphu=Mau&thaotac=ThemMoi">Add a new status</a></div>
    <div class="cb"></div>
</div>
<div class="KhungChuaBang">
   <table class="tbMau">
       <tr>
           <th class="cotMa">No</th>
           <th class="cotTen">Status name</th>
           <th class="cotCongCu">Tool</th>
       </tr>
       <asp:Literal ID="ltrMau" runat="server"></asp:Literal>
   </table>
</div>
<script type="text/javascript">
    function DeleteStatus(statusid) {
        if (confirm("You definitely want to delete this status")) {
            //Viết code xóa màu tại đây

            $.post("cms/admin/SanPham/QuanLyMau/Ajax/Status.aspx",
                {
                    "ThaoTac": "DeleteStatus",
                    "statusid": statusid
                },
                function (data, status) {
                    //alert("Data :" + data + "\n Status :" + status);
                    if (data == 1) {
                        //thực hiện thành công => ẩn dòng vừa xóa đi
                        $("#maDong_" + statusid).slideUp();

                    }
                });
        }
    }
</script>