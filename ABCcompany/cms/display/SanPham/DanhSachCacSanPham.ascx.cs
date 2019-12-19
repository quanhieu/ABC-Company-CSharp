﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_display_SanPham_DanhSachCacSanPham : System.Web.UI.UserControl
{
    private string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
            id = Request.QueryString["id"];
        if (!IsPostBack)
        {

            ltrNhomSanPham.Text = LayDanhMucPham();

        }
    }
    #region Lấy nhóm và các sản phẩm
    private string LayDanhMucPham()
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = abcompany.Category.Info_Category_by_id(id);
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            s += "<div class='sanphamnoibat'>";
            s += @"
<a class='title-line' href='/Default.aspx?modul=SanPham&modulphu=DanhSachSanPham&id=" + dt.Rows[i]["CategoryID"] + @"' title='" + dt.Rows[i]["CategoryName"] + @"'>
    <h3>" + dt.Rows[i]["CategoryName"] + @"</h3>

</a>
";
            s += "<div>";
            s += LayTatCaDanhSachSanPhamTheoDanhMuc(dt.Rows[i]["CategoryID"].ToString());
            s += "</div>";
            s += "<div style='clear:both'></div>";
            s += "</div>";
        }

        return s;
    }

    private string LayTatCaDanhSachSanPhamTheoDanhMuc(string CategoryID)
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = abcompany.Product.Info_Products_by_CategoryID_all(CategoryID);


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