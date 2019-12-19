<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Size_HienThi.ascx.cs" Inherits="cms_admin_SanPham_QuanLySize_Size_HienThi" %>
<div class="head">
    Supply created
    <div class="fr ter"><a class="btThemMoi" href="/Admin.aspx?modul=SanPham&modulphu=Size&thaotac=ThemMoi">Add a new Supply</a></div>
    <div class="cb"></div>
</div>
<div class="KhungChuaBang">
   <table class="tbSize">
       <tr>
           <th class="cotMa">No</th>
           <th class="cotTen">Supply name</th>
           <th class="cotCongCu">Tool</th>
       </tr>
       <asp:Literal ID="ltrSize" runat="server"></asp:Literal>
   </table>
</div>
<script type="text/javascript">
    function DeleteSupply(supplyid) {
        if (confirm("Are you want to delete this Supply")) {
            //Viết code xóa màu tại đây

            $.post("cms/admin/SanPham/QuanLySize/Ajax/Supply.aspx",
                {
                    "ThaoTac": "DeleteSupply",
                    "supplyid": supplyid
                },
                function (data, status) {
                    //alert("Data :" + data + "\n Status :" + status);
                    if (data == 1) {
                        //thực hiện thành công => ẩn dòng vừa xóa đi
                        $("#maDong_" + supplyid).slideUp();

                    }
                });
        }
    }
</script>