<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TaiKhoan_HienThi.ascx.cs" Inherits="cms_admin_TaiKhoan_TaiKhoan_HienThi" %>
<div class="head">
    The account has been created
    <div class="fr ter"><a class="btThemMoi" href="/Admin.aspx?modul=TaiKhoan&modulphu=DanhSachTaiKhoan&thaotac=ThemMoi">Add new accounts</a></div>
    <div class="cb"></div>
</div>
<div class="KhungChuaBang">
   <table class="tbDanhMuc">
       <tr>
           <th class="cotTenDK">Login name</th>
           <th class="cotEmail">Email</th>
           <th class="cotDiaChi">Address</th>
           <th class="cotHoTen">Full name</th>
           <th class="cotNgaySinh">Date of birth</th>
           <th class="cotGioiTinh">Sex</th>
           <th class="cotCongCu">Tool</th>
       </tr>
       <asp:Literal ID="ltrRegistration" runat="server"></asp:Literal>
   </table>
</div>
<script type="text/javascript">
    function DeleteRegistration(username) {
        if (confirm("Are you sure to delete this account?")) {
            //Viết code xóa màu tại đây

            $.post("cms/admin/TaiKhoan/Ajax/Registration.aspx",
                {
                    "ThaoTac": "DeleteRegistration",
                    "username": username
                },
                function (data, status) {
                    //alert("Data :" + data + "\n Status :" + status);
                    if (data == 1) {
                        //thực hiện thành công => ẩn dòng vừa xóa đi
                        $("#maDong_" + username).slideUp();

                    }

                    else
                    {
                        alert(data);
                    }
                });
        }
    }
</script>