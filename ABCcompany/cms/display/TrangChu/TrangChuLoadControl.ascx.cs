using abcompany;
using System;
using System.Data;

public partial class cms_display_TrangChu_TrangChuLoadControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ltrSlide.Text = LaySlide();

            ltrNhomSanPham.Text = LayNhomSanPham();
        }
    }

    #region Lấy nhóm và các sản phẩm
    private string LayNhomSanPham()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = abcompany.GroupProduct.Info_GroupProduct();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            s += "<div class='sanphamnoibat'>";
            s += @"
<div class='title-line'>
    <h3>" + dt.Rows[i]["GroupName"] + @"</h3>
</div>
";
            s += "<div>";
            s += LayDanhSachSanPhamTheoNhom(dt.Rows[i]["GroupID"].ToString(), dt.Rows[i]["NumShow"].ToString());
            s += "</div>";
            s += "<div style='clear:both'></div>";
            s += "</div>";
        }

        return s;
    }

    private string LayDanhSachSanPhamTheoNhom(string GroupID, string NumShow)
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = abcompany.Product.Info_Products_by_GroupID(GroupID, NumShow);


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


    //    #region Lấy nhóm sản phẩm  
    //    private string LayNhomSanPham()
    //    {
    //        string s = "";
    //        DataTable dt = new DataTable();
    //        dt = emdepvn.NhomSanPham.Thongtin_Nhomsp();
    //        for (int i = 0; i < dt.Rows.Count; i++)
    //        {
    //            s += "<div class='sanphamnoibat'>";
    //            s += @"
    //<div class='title-line'>
    //    <h3>" + dt.Rows[i]["TenNhom"] + @"</h3>
    //</div>
    //";
    //            //s += "<div>";
    //            s += LayDanhSachSanPhamTheoNhom(dt.Rows[i]["GroupID"].ToString());
    //            //s += "</div>";
    //            s += "<div style='clear:both'></div>";
    //            s += "</div>";
    //        }

    //        return s;
    //    }

    //    private string LayDanhSachSanPhamTheoNhom(string GroupID)
    //    {
    //        string s = "";
    //        DataTable dt = new DataTable();
    //        dt = emdepvn.SanPham.Thongtin_SanPham_by_GroupID(GroupID);


    //        string link = "";
    //        for (int i = 0; i < dt.Rows.Count; i++)
    //        {
    //            link = "Default.aspx?modul=SanPham&modulphu=ChiTietSanPham&id=" + dt.Rows[i]["MaSP"];

    //            s += @"
    //        <div class='item'>
    //            <a href='" + link + @"' title='" + dt.Rows[i]["ProductName"] + @"'>
    //                <img src='/pic/sanpham/" + dt.Rows[i]["AnhSP"] + @"' alt='" + dt.Rows[i]["ProductName"] + @"' />
    //            </a>
    //            <a class='title-sp' href='" + link + @"' title='" + dt.Rows[i]["ProductName"] + @"'>
    //                " + dt.Rows[i]["ProductName"] + @"
    //            </a>
    //            <div class='desc'>
    //                Giá: " + dt.Rows[i]["GiaSP"] + @"
    //            </div>
    //        </div>
    //        ";
    //        }
    //        return s;
    //    }

    //#endregion

    #region Lấy logo
    private string LaySlide()
    {
        string s = "";

        //Code lấy ra vị trí quảng nhóm cáo
        DataTable dt = new DataTable();
        dt = abcompany.GroupAds.Info_GroupAds_by_locationga("slide");

        //Nếu tồn tại vị trí nhóm quảng cáo --> tìm quảng cáo trong nhóm đó
        if (dt.Rows.Count > 0)
        {
            //Gọi tới phương thức lấy ảnh quảng cáo theo id nhóm quảng cáo
            s = LayAnhSlide(dt.Rows[0]["GroupAdsID"].ToString());
        }

        return s;
    }

    private string LayAnhSlide(string GroupAdsID)
    {
        string s = "";

        DataTable dt = new DataTable();
        dt = Ads.Info_Ads_by_GroupAdsID(GroupAdsID);
        if (dt.Rows.Count > 0)
        {

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                s += @"
<div data-p='225.00' style='display: none;'>                      
    <img data-u='image' src='/pic/ads/" + dt.Rows[i]["ImageAds"] + @"' alt='" + dt.Rows[i]["AdsName"] + @"' />
</div>";
            }

        }

        return s;
    }
    #endregion
}