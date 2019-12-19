<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Order_HienThi.ascx.cs" Inherits="cms_admin_Order_Order_HienThi" %>

<div class="head">
    The order has been created
   <%-- <div class="fr ter"><a class="btThemMoi" href="/Admin.aspx?modul=Order&modulphu=DanhSachOrder&thaotac=ThemMoi">Add new order</a></div>--%>
    <div class="cb"></div>
</div>
<div class="KhungChuaBang">
   <table class="tbDanhMuc">
       <tr>
           <th class="cotOrderID">OrderID</th>
           <th class="cotDateCreated">Date Created</th>
           <th class="cotOrderMoney">Total money ($)</th>
           <th class="cotOrderPay">Order Pay</th>
           <th class="cotCustomerID">CustomerID</th>
           <th class="cotCustomerNA">Customer name</th>
           <th class="cotCallNumCUS">CallNumer</th>
           <th class="cotEmailCUS">Email</th>
           <th class="cotOrderDetail">Order Detail</th>

           <th class="cotCongCu">Tool</th>
       </tr>
       <asp:Literal ID="ltrOrder" runat="server"></asp:Literal>
   </table>
</div>
<script type="text/javascript">
    function DeleteOrder(orderid) {
        if (confirm("Are you sure to delete this account?")) {
            //Viết code xóa màu tại đây

            $.post("cms/admin/Order/Ajax/Order.aspx",
                {
                    "ThaoTac": "DeleteOrder",
                    "orderid": orderid
                },
                function (data, status) {
                    //alert("Data :" + data + "\n Status :" + status);
                    if (data == 1) {
                        //thực hiện thành công => ẩn dòng vừa xóa đi
                        $("#maDong_" + orderid).slideUp();

                    }

                    else
                    {
                        alert(data);
                    }
                });
        }
    }
</script>