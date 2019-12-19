using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class cms_admin_QuangCao_QuanLyDanhSachQuangCao_DanhSachQuangCao_HienThi : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            TakeAds();
    }

    private void TakeAds()
    {
        DataTable dt = new DataTable();
        dt = abcompany.Ads.Info_Ads();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ltrAds.Text += @"
        <tr id='maDong_" + dt.Rows[i]["adsid"] + @"'>
               <td class='cotMa'>" + dt.Rows[i]["adsid"] + @"</td>
               <td class='cotTen'>" + dt.Rows[i]["adsname"] + @"</td>
               <td class='cotAnh'>
                 <img class='anhDaiDien'src='/pic/Ads/" + dt.Rows[i]["imageads"] + @"'/>
                 <img class='anhDaiDienHover'src='/pic/Ads/" + dt.Rows[i]["imageads"] + @"'/>
               </td>
               <td class='cotThuTu'>" + dt.Rows[i]["numorderads"] + @"</td>
               <td class='cotCongCu'>
                   <a href='Admin.aspx?modul=QuangCao&modulphu=DanhSachQuangCao&thaotac=ChinhSua&adsid=" + dt.Rows[i]["adsid"] + @"' class='sua' title='Edit'></a>
                   <a href='javascript:DeleteAds(" + dt.Rows[i]["adsid"] + @")' class='xoa' title='Delete'></a>
               </td>
        </tr>
";
        }
        
    }

}