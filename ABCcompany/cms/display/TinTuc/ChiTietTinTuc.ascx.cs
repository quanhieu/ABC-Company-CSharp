using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_display_TinTuc_ChiTietTinTuc : System.Web.UI.UserControl
{
    protected string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
            id = Request.QueryString["id"];

        if (!IsPostBack)
            LayChiTietTinTuc(id);
    }

    private void LayChiTietTinTuc(string id)
    {
        CapNhatLuotXemTin(id);

        DataTable dt = new DataTable();
        dt = abcompany.News.Info_News_by_id(id);
        if (dt.Rows.Count > 0)
        {

            ltrTieuDeTin.Text = dt.Rows[0]["Title"].ToString();
            ltrNgayDang.Text = ((DateTime)dt.Rows[0]["PostDate"]).ToString("dd//MM/yyyy");
            ltrLuotXem.Text= dt.Rows[0]["Views"].ToString();
            ltrNoiDungChiTiet.Text = dt.Rows[0]["Detail"].ToString();

        }
    }

    private void CapNhatLuotXemTin(string id)
    {
        abcompany.News.UpdateNewsView(id);
    }
}