using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class cms_admin_TinTuc_DanhSachTinTuc_DanhSachTinTuc_HienThi : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            TakeNews();
    }

    private void TakeNews()
    {
        DataTable dt = new DataTable();
        dt = abcompany.News.Info_News();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ltrTinTuc.Text += @"
        <tr id='maDong_" + dt.Rows[i]["NewsID"] + @"'>
               <td class='cotMa'>" + dt.Rows[i]["NewsID"] + @"</td>
               <td class='cotTen'>" + dt.Rows[i]["Title"] + @"</td>
               <td class='cotAnh'>
                 <img class='anhDaiDien'src='/pic/News/" + dt.Rows[i]["Avatar"] + @"'/>
                 <img class='anhDaiDienHover'src='/pic/News/" + dt.Rows[i]["Avatar"] + @"'/>
               </td>
               <td class='cotSoLuong'>" + dt.Rows[i]["Views"] + @"</td>
               <td class='cotNgayDang'>" + dt.Rows[i]["PostDate"] + @"</td>
               <td class='cotThuTu'>" + dt.Rows[i]["NumOrder"] + @"</td>
               <td class='cotCongCu'>
                   <a href='Admin.aspx?modul=TinTuc&modulphu=DanhSachTinTuc&thaotac=ChinhSua&NewsID=" + dt.Rows[i]["NewsID"] + @"' class='sua' title='Edit'></a>
                   <a href='javascript:DeleteNews(" + dt.Rows[i]["NewsID"] + @")' class='xoa' title='News'></a>
               </td>
        </tr>
";
        }
        
    }

}