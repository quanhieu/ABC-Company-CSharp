using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class cms_admin_QuangCao_QuanLyNhomQuangCao_NhomQuangCao_HienThi : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            TakeGroupAds();
    }

     private void TakeGroupAds()
    {
        DataTable dt = new DataTable();
        dt = abcompany.GroupAds.Info_GroupAds();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ltrGroupAds.Text += @"
<tr id='maDong_" + dt.Rows[i]["groupadsid"] + @"'>
           <td class='cotMa'>" + dt.Rows[i]["groupadsid"] + @"</td>
           <td class='cotTen'>" + dt.Rows[i]["groupadsname"] + @"</td>
           <td class='cotViTri'>" + dt.Rows[i]["locationga"] + @"</td>
           <td class='cotAnh'>
             <img class='anhDaiDien'src='/pic/Ads/" + dt.Rows[i]["avatarga"] + @"'/>
             <img class='anhDaiDienHover'src='/pic/Ads/" + dt.Rows[i]["avatarga"] + @"'/>
           </td>
           <td class='cotThuTu'>" + dt.Rows[i]["numorderga"] + @"</td>
           <td class='cotCongCu'>
               <a href='Admin.aspx?modul=QuangCao&modulphu=NhomQuangCao&thaotac=ChinhSua&groupadsid=" + dt.Rows[i]["groupadsid"] + @"' class='sua' title='Edit'></a>
               <a href='javascript:DeleteGroupAds(" + dt.Rows[i]["groupadsid"] + @")' class='xoa' title='Delete'></a>
           </td>
</tr>
";
        }

    }
}
