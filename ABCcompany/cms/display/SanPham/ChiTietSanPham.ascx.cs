using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_display_SanPham_ChiTietSanPham : System.Web.UI.UserControl
{
    protected string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
            id = Request.QueryString["id"];

        if (!IsPostBack)
            LayChiTietSanPham(id);
    }

    private void LayChiTietSanPham(string id)
    {
        DataTable dt = new DataTable();
        dt = abcompany.Product.Info_Products_by_id(id);
        if (dt.Rows.Count > 0)
        {
            ltrAnhSanPham.Text = "<img class='imgsp' src='/pic/product/" + dt.Rows[0]["ImageP"] + @"' alt='" + dt.Rows[0]["ProductName"] + @"' />";

            ltrTenSanPham.Text = dt.Rows[0]["ProductName"].ToString();
            ltrGiaSP.Text = dt.Rows[0]["PriceP"].ToString();

            ltrKichThuoc.Text = LayTenKichThuoc(dt.Rows[0]["SupplyID"].ToString());
            ltrMau.Text = LayTenMau(dt.Rows[0]["StatusID"].ToString());

            ltrThongTinChiTiet.Text = dt.Rows[0]["DescribeP"].ToString();
        }
    }

    private string LayTenKichThuoc(string SupplyID)
    {
        DataTable dt = new DataTable();
        dt = abcompany.Supply.Info_Supply_by_id(SupplyID);
        if (dt.Rows.Count > 0)
            return dt.Rows[0]["SupplyName"].ToString();
        else
            return "";
    }

    private string LayTenMau(string StatusID)
    {
        DataTable dt = new DataTable();
        dt = abcompany.Status.Info_Status_by_id(StatusID);
        if (dt.Rows.Count > 0)
            return dt.Rows[0]["StatusName"].ToString();
        else
            return "";
    }

}