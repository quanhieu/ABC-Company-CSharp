using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class cms_admin_SanPham_QuanLyNhomSanPham_NhomSanPham_HienThi : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            TakeGroupProduct();
    }

    private void TakeGroupProduct()
    {
        DataTable dt = new DataTable();
        dt = abcompany.GroupProduct.Info_GroupProduct();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            GroupProduct.Text += @"
<tr id='maDong_" + dt.Rows[i]["groupid"] + @"'>
           <td class='cotMa'>" + dt.Rows[i]["groupid"] + @"</td>
           <td class='cotTen'>" + dt.Rows[i]["groupname"] + @"</td>
           <td class='cotAnh'>
             <img class='anhDaiDien'src='/pic/Product/" + dt.Rows[i]["avatar"] + @"'/>
             <img class='anhDaiDienHover'src='/pic/Product/" + dt.Rows[i]["avatar"] + @"'/>
           </td>
           <td class='cotThuTu'>" + dt.Rows[i]["numorder"] + @"</td>
           <td class='cotSoSanPhamHienThi'>" + dt.Rows[i]["numshow"] + @"</td>
           <td class='cotCongCu'>
              
               <a href='Admin.aspx?modul=SanPham&modulphu=Nhom&thaotac=ChinhSua&groupid=" + dt.Rows[i]["groupid"] + @"' class='sua' title='Edit'></a>
               <a href='javascript:DeleteGroupProduct(" + dt.Rows[i]["groupid"] + @")' class='xoa' title='Delete'></a>
           </td>
</tr>
";
        }

    }
}