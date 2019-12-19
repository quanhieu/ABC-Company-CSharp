using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using abcompany;

public partial class _Default : System.Web.UI.Page
{
    private string modul = "";
    protected string tukhoa = "";
    protected string money = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["tukhoa"] != null)
            tukhoa = Request.QueryString["tukhoa"];

        if (Request.QueryString["money"] != null)
            money = Request.QueryString["money"];

        #region Nếu là modul tin tức --> Hiện danh mục tin., Các modul khác --> Hiện danh mục sản phẩm
        if (Request.QueryString["modul"] != null)
            modul = Request.QueryString["modul"];

        if (modul == "TinTuc")
        {
            plDanhMucTinTuc.Visible = true;
            plDanhMucSanPham.Visible = false;
        }
        else
        {
            plDanhMucTinTuc.Visible = false;
            plDanhMucSanPham.Visible = true;
        }
        #endregion

        if (!IsPostBack)
        {
            #region Kiểm tra đã đăng nhập hay chưa

            if (Session["KhachHang"] != null && Session["KhachHang"].ToString() == "1")
            {
                //Đã đăng nhập
                plDaDangNhap.Visible = true;
                plChuaDangNhap.Visible = false;

                if (Session["KhachHang"] != null)
                    ltrTenKhachHang.Text = Session["TenKH"].ToString();
            }
            else
            {
                plDaDangNhap.Visible = false;          
                plChuaDangNhap.Visible = true;
            }
            #endregion

            ltrLogo.Text = LayLogo();
            ltrBanner.Text = LayBanner();

            ltrMenu.Text = LayMenu();
            ltrDanhMucSanPham.Text = LayDanhMucSanPham();
            ltrDanhMucTinTuc.Text = LayDanhMucTinTuc();
        }
    }

    #region Lấy danh mục tin tức
    private string LayDanhMucTinTuc()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = abcompany.CategoryNews.Info_CategoryNews_by_newscodefar("0");
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            s += @"<li><a href='/Default.aspx?modul=TinTuc&modulphu=DanhSachTinTuc&id=" + dt.Rows[i]["NewsCode"] + @"' title='" + dt.Rows[i]["NewsName"] + @"'>" + dt.Rows[i]["NewsName"] + @"</a></li>";
        }
        return s;
    }
    #endregion

    #region Lấy danh mục sản phẩm
    private string LayDanhMucSanPham()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = abcompany.Category.Info_Category_by_categoryidfar("0");
        for (int i = 0; i < dt.Rows.Count; i++)
        {           
            s += @"<li><a href='/Default.aspx?modul=SanPham&modulphu=DanhSachSanPham&id=" + dt.Rows[i]["CategoryID"] + @"' title='" + dt.Rows[i]["CategoryName"] + @"'>" + dt.Rows[i]["CategoryName"] +@"</a></li>";
        }
        return s;
    }
    #endregion

    #region Lấy menu
    private string LayMenu()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = abcompany.Menu.Info_Menu_by_menuidfar("0");
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            string link = dt.Rows[i]["Link"].ToString();
            if (link == "")
                link = "#";

            s += @"<li class='menu1'><a href='" + link + @"' title='" + dt.Rows[i]["MenuName"] + @"'>" + dt.Rows[i]["MenuName"] + @"</a></li>";
        }
        return s;
    }
    #endregion

    #region Lấy banner
    private string LayBanner()
    {
        string s = "";

        //Code lấy ra vị trí quảng nhóm cáo
        DataTable dt = new DataTable();
        dt = abcompany.GroupAds.Info_GroupAds_by_locationga("banner");

        //Nếu tồn tại vị trí nhóm quảng cáo --> tìm quảng cáo trong nhóm đó
        if (dt.Rows.Count > 0)
        {
            //Gọi tới phương thức lấy ảnh quảng cáo theo id nhóm quảng cáo
            s = LayAnhBanner(dt.Rows[0]["GroupAdsID"].ToString());
        }

        return s;
    }

    private string LayAnhBanner(string GroupAdsID)
    {
        string s = "";

        DataTable dt = new DataTable();
        dt = Ads.Info_Ads_by_GroupAdsID(GroupAdsID);
        if (dt.Rows.Count > 0)
        {
            string link = dt.Rows[0]["Link"].ToString();
            if (link == "")
                link = "#";

            s += @"
<a href='" + link + @"' title='" + dt.Rows[0]["AdsName"] + @"'>
    <img src='/pic/ads/" + dt.Rows[0]["ImageAds"] + @"' alt='" + dt.Rows[0]["AdsName"] + @"'/>
</a>";
        }

        return s;
    }
    #endregion

    #region Lấy logo
    private string LayLogo()
    {
        string s = "";

        //Code lấy ra vị trí quảng nhóm cáo - vị trí tên "logo"
        DataTable dt = new DataTable();
        dt = abcompany.GroupAds.Info_GroupAds_by_locationga("logo");

        //Nếu tồn tại vị trí nhóm quảng cáo --> tìm quảng cáo trong nhóm đó
        if (dt.Rows.Count > 0)
        {
            //Gọi tới phương thức lấy ảnh quảng cáo theo id nhóm quảng cáo
            s = LayAnhLogo(dt.Rows[0]["GroupAdsID"].ToString());
        }

        return s;
    }

    private string LayAnhLogo(string GroupAdsID)
    {
        string s = "";

        DataTable dt = new DataTable();
        dt = Ads.Info_Ads_by_GroupAdsID(GroupAdsID);
        if (dt.Rows.Count > 0)
        {
            string link = dt.Rows[0]["Link"].ToString();
            if (link == "")
                link = "#";

            s += @"
<a href='" + link + @"' title='" + dt.Rows[0]["AdsName"] + @"'>
    <img src='/pic/ads/" + dt.Rows[0]["ImageAds"] + @"' alt='" + dt.Rows[0]["AdsName"] + @"'/>
</a>";
        }

        return s;
    }
    #endregion

    protected void lbtDangXuat_Click(object sender, EventArgs e)
    {
        //Xóa các session đã lưu
        Session["KhachHang"] = null;

        Session["CustomerID"] = null;
        Session["TenKH"] = null;
        Session["DiaChiKH"] = null;
        Session["sdtKH"] = null;
        Session["EmailKH"] = null;

        //đẩy về trang đăng nhập
        Response.Redirect("/Default.aspx");
    }


}