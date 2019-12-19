using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_display_TinTuc_DanhSachCacTinTuc : System.Web.UI.UserControl
{
    private string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
            id = Request.QueryString["id"];
        if (!IsPostBack)
        {

            ltrNhomTinTuc.Text = LayDanhTinTuc();

        }
    }
    #region Lấy nhóm và các tin tức
    private string LayDanhTinTuc()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = abcompany.CategoryNews.Info_CategoryNews_by_id(id);
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            s += "<div class='sanphamnoibat'>";
            s += @"
<a class='title-line' href='/Default.aspx?modul=TinTuc&modulphu=DanhSachTinTuc&id=" + dt.Rows[i]["NewsCode"] + @"' title='" + dt.Rows[i]["NewsName"] + @"'>
    <h3>" + dt.Rows[i]["NewsName"] + @"</h3>

</a>
";
            s += "<div>";
            s += LayTatCaDanhSachTinTucTheoDanhMuc(dt.Rows[i]["NewsCode"].ToString());
            s += "</div>";
            s += "<div style='clear:both'></div>";
            s += "</div>";
        }

        return s;
    }

    private string LayTatCaDanhSachTinTucTheoDanhMuc(string NewsCode)
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = abcompany.News.Info_News_by_NewsCode_all(NewsCode);

        string link = "";
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            link = "Default.aspx?modul=TinTuc&modulphu=ChiTietTinTuc&id=" + dt.Rows[i]["NewsID"];

            s += @"
<div class='itemtintuc'>
    <div class='khungAnh'>
        <a class='khungAnhCrop' href='" + link + @"'>
            <img class='imganh' src='/pic/news/" + dt.Rows[i]["Avatar"] + @"' alt='" + dt.Rows[i]["Title"] + @"' />
        </a>
    </div>
    <div class='itemContent'>
        <a href='" + link + @"' class='title' title='" + dt.Rows[i]["Title"] + @"'>
            " + dt.Rows[i]["Title"] + @"
        </a>
        <span class=''><span class='view'>" + dt.Rows[i]["Views"] + @"</span><span class='date'>" + ((DateTime)dt.Rows[i]["PostDate"]).ToString("dd/MM/yyyy") + @"</span></span>
        <div class='desc'>
            " + dt.Rows[i]["Describe"] + @"
        </div>
        <div class='tar'><a href='" + link + @"' class='detail'>View details</a></div>
    </div>
    <div class='cb'><!----></div>
</div>
";
        }
        return s;
    }

    #endregion
}