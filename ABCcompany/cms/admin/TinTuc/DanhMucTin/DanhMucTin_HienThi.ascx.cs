using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class cms_admin_TinTuc_DanhMucTin_DanhMucTin_HienThi : System.Web.UI.UserControl
{
    string newscode = "0";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["newscodefar"] != null)
            newscode = Request.QueryString["newscodefar"];
        if (!IsPostBack)
            TakeCategoryNews();
    }

    private void TakeCategoryNews()
    {
        DataTable dt = new DataTable();
        dt = abcompany.CategoryNews.Info_CategoryNews_by_newscodefar(newscode);
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ltrCategoryNews.Text += @"
<tr id='maDong_" + dt.Rows[i]["newscode"] + @"'>
           <td class='cotMa'>" + dt.Rows[i]["newscode"] + @"</td>
           <td class='cotTen'>" + dt.Rows[i]["newsname"] + @"</td>
           <td class='cotAnh'>
             <img class='anhDaiDien'src='/pic/News/" + dt.Rows[i]["avatar"] + @"'/>
             <img class='anhDaiDienHover'src='/pic/News/" + dt.Rows[i]["avatar"] + @"'/>
           </td>
           <td class='cotThuTu'>" + dt.Rows[i]["numorder"] + @"</td>
           <td class='cotCongCu'>";
            if (subCategoryNews(dt.Rows[i]["newscode"].ToString()))
                ltrCategoryNews.Text += @"<a href='Admin.aspx?modul=TinTuc&modulphu=DanhMucTin&newscodefar=" + dt.Rows[i]["newscode"] + @"' class='dmcon' title='Show subCategory news'></a>";
            ltrCategoryNews.Text += @"
               <a href='Admin.aspx?modul=TinTuc&modulphu=DanhMucTin&thaotac=ChinhSua&id=" + dt.Rows[i]["newscode"] + @"' class='sua' title='Edit'></a>
               <a href='javascript:DeleteCategoryNews(" + dt.Rows[i]["newscode"] + @")' class='xoa' title='Delete'></a>
           </td>
</tr>
";
        }

    }

    //Hàm kiểm tra danh mục có danh mục con hay ko
    bool subCategoryNews(string newscodefar)
    {
        DataTable dt = new DataTable();
        dt = abcompany.CategoryNews.Info_CategoryNews_by_newscodefar(newscodefar);
        if (dt.Rows.Count > 0)
            return true;
        else
            return false;
    }
}