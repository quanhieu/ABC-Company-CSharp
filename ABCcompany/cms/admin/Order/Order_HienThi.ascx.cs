using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_Order_Order_HienThi : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            TakeOrder();
    }
    private void TakeOrder()
    {
        DataTable dt = new DataTable();
        dt = abcompany.Order.Info_Order();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ltrOrder.Text += @"

        <tr id='maDong_" + dt.Rows[i]["orderid"] + @"'>
           <td class='cotOrderID'>" + dt.Rows[i]["orderid"] + @"</td>
           <td class='cotDateCreated'>" + dt.Rows[i]["datecreated"] + @"</td>
           <td class='cotOrderMoney'>" + dt.Rows[i]["ordermoney"] + @"</td>
           <td class='cotOrderPay'>" + dt.Rows[i]["orderpay"] + @"</td>
           <td class='cotCustomerID'>" + dt.Rows[i]["customerid"] + @"</td>
           <td class='cotCustomerNA'>" + dt.Rows[i]["customerna"] + @"</td>
           <td class='cotCallNumCUS'>" + dt.Rows[i]["callnumcus"] + @"</td>
           <td class='cotEmailCUS'>" + dt.Rows[i]["emailcus"] + @"</td>
           <td class='cotOrderDetail'>" + dt.Rows[i]["orderdetail"] + @"</td>

           <td class='cotCongCu'>
               <a href='/Admin.aspx?modul=Order&modulphu=DanhSachOrder&thaotac=ChinhSua&orderid=" + dt.Rows[i]["orderid"] + @"' class='sua' title='Edit'></a>
               <a href=javascript:DeleteOrder('" + dt.Rows[i]["orderid"] + @"') class='xoa' title='Delete'></a>
           </td>
       </tr>
";
        }

    }
}