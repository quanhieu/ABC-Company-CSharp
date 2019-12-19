using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_display_TinTuc_TrangChuModulTinTuc : System.Web.UI.UserControl
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            ltrNhomTin.Text = LayDanhTinTuc();

        }
    }
    #region Lấy danh mục tin và các tin tức bên trong
    private string LayDanhTinTuc()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = abcompany.CategoryNews.Info_CategoryNews_by_newscodefar("0");
        for (int i = 0; i < dt.Rows.Count; i++)
        {

            s += @"
<div class='baonewinde'>
    <a class='titlehead' href='/Default.aspx?modul=TinTuc&modulphu=DanhSachTinTuc&id=" + dt.Rows[i]["NewsCode"] + @"' title='" + dt.Rows[i]["NewsName"] + @"'>
        <span class='ten'>" + dt.Rows[i]["NewsName"] + @"</span>
    </a>
    <div class='cb'></div>
    <div class='list'>
        " + LayDanhSachTinTucTheoDanhMuc(dt.Rows[i]["NewsCode"].ToString()) + @"
    </div>
</div>

";
        }

        return s;
    }

    private string LayDanhSachTinTucTheoDanhMuc(string NewsCode)
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = abcompany.News.Info_News_by_NewsCode(NewsCode);

        string link = "";
        if (dt.Rows.Count > 0)
        {
            //Hiện ra tin đầu tiên, có ảnh đại diện 
            link = "Default.aspx?modul=TinTuc&modulphu=ChiTietTinTuc&id=" + dt.Rows[0]["NewsID"];
            s += @"
<div class='box1'>
    <div class='khungAnh'>
        <a class='nentren' href='" + link + @"'></a>
        <a class='khungAnhCrop' href='" + link + @"'>
            <img class='imgmuctin' src='/pic/news/" + dt.Rows[0]["Avatar"] + @"' alt='" + dt.Rows[0]["Title"] + @"' />
        </a>
    </div>
    <a class='title' href='" + link + @"' title='" + dt.Rows[0]["Title"] + @"'>" + dt.Rows[0]["Title"] + @"</a>
    <span class=''><span class='view'>" + dt.Rows[0]["Views"] + @"</span><span class='date'>" + ((DateTime)dt.Rows[0]["PostDate"]).ToString("dd/MM/yyyy") + @"</span></span>
    <div class='desc'>" + dt.Rows[0]["Describe"] + @"</div>
    <a class='detail' href='" + link + @"' title='" + dt.Rows[0]["Title"] + @"'>View more</a>

    <div class='cb'></div>
</div>
";
            //Hiện ra các tin khác
            for (int i = 1; i < dt.Rows.Count; i++)
            {
                link = "Default.aspx?modul=TinTuc&modulphu=ChiTietTinTuc&id=" + dt.Rows[i]["NewsID"];

                s += @"
<a class='title1' href='" + link + @"' title='" + dt.Rows[i]["Title"] + @"'>
    " + dt.Rows[i]["Title"] + @"
    <span>(" + ((DateTime)dt.Rows[i]["PostDate"]).ToString("dd/MM/yyyy") + @")</span>
</a>
";
            }
        }
        return s;
    }

    #endregion
}