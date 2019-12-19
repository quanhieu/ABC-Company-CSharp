using System;
using System.Data;

public partial class cms_display_SanPham_AboutMoney : System.Web.UI.UserControl
{
    private string money = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["money"] != null)
            money = Request.QueryString["money"];

        if (!IsPostBack)
        {
            ltrNhomSanPham.Text = LayThongTinTimKiem();
        }
    }

    #region Lấy nhóm và các sản phẩm
    private string LayThongTinTimKiem()
    {
        string s = "";
        s += "<div class='sanphamnoibat'>";
        s += @"
<a class='title-line' href='/Default.aspx?modul=SanPham&modulphu=AboutMoney&money=" + money + @"' title='" + money + @"'>
    <h3>Result for keyword: " + money + @"</h3>
</a>
";
        s += "<div>";
        s += LayDanhSachSanPham();
        s += "</div>";
        s += "<div style='clear:both'></div>";
        s += "</div>";

        return s;
    }

    private string LayDanhSachSanPham()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = abcompany.Product.Info_Products_by_sort(money);

        string link = "";
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            link = "Default.aspx?modul=SanPham&modulphu=ChiTietSanPham&id=" + dt.Rows[i]["ProductID"];

            s += @"
<div class='item'>
    <a href='" + link + @"' title='" + dt.Rows[i]["ProductName"] + @"'>
        <img src='/pic/product/" + dt.Rows[i]["ImageP"] + @"' alt='" + dt.Rows[i]["ProductName"] + @"' />
    </a>
    <a class='title-sp' href='" + link + @"' title='" + dt.Rows[i]["ProductName"] + @"'>
        " + dt.Rows[i]["ProductName"] + @"
    </a>
    <div class='desc'>
        Price: " + dt.Rows[i]["PriceP"] + @"
    </div>
</div>
";
        }
        return s;
    }

    #endregion
}