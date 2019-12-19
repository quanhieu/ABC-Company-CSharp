using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class cms_admin_KhachHang_KhachHang_HienThi : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            TakeCustomer();
    }

    private void TakeCustomer()
    {
        DataTable dt = new DataTable();
        dt = abcompany.Customer.Info_Customer();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ltrCustomer.Text += @"
<tr id='maDong_" + dt.Rows[i]["customerid"] + @"'>
           <td class='cotMa'>" + dt.Rows[i]["customerid"] + @"</td>
           <td class='cotTen'>" + dt.Rows[i]["customerna"] + @"</td>
           <td class='cotAnh'>" + dt.Rows[i]["addresscus"] + @"</td>
           <td class='cotThuTu'>" + dt.Rows[i]["callNumcus"] + @"</td>
           <td class='cotEmail'>" + dt.Rows[i]["emailcus"] + @"</td>
</tr>
";
        }

    }
}
