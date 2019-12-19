<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Menu_HienThi.ascx.cs" Inherits="cms_admin_Menu_Menu_HienThi" %>
<div class="head">
    Menu created
    <div class="fr ter"><a class="btThemMoi" href="/Admin.aspx?modul=Menu&modulphu=DanhSachMenu&thaotac=ThemMoi">Add new menu</a></div>
    <div class="cb"></div>
</div>
<div class="KhungChuaBang">
   <table class="tbDanhMuc">
       <tr>
           <th class="cotMa">No</th>
           <th class="cotTen">Menu name</th>
           <th class="cotThuTu">Order number</th>
           <th class="cotCongCu">Tool</th>
       </tr>
       <asp:Literal ID="ltrMenu" runat="server"></asp:Literal>
   </table>
</div>

<script type="text/javascript">
    function DeleteMenu(menuid) {
        if (confirm("Are you want to delete this menu?")) {
            //Viết code xóa danh mục tại đây

            $.post("cms/admin/Menu/Ajax/Menu.aspx",
                {
                    "ThaoTac": "DeleteMenu",
                    "menuid": menuid
                },
                function (data, status) {
                    //alert("Data :" + data + "\n Status :" + status);
                    if (data == 1) {
                        //thực hiện thành công => ẩn dòng vừa xóa đi
                        $("#maDong_" + menuid).slideUp();

                    }
                });
        }
    }
</script>