using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;


public partial class cms_admin_QuangCao_QuanLyDanhSachQuangCao_DanhSachQuangCao_ThemMoi : System.Web.UI.UserControl
{
    private string thaotac = "";
    private string adsid = "";//lấy id của tin tức cần chỉnh sửa
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        if (Request.QueryString["adsid"] != null)
            adsid = Request.QueryString["adsid"];
        if (!IsPostBack)
        {

            TakeGroup();

            ShowInformation(adsid);
        }
            //ltrImageAds
    }

    private void ShowInformation(string adsid)
    {
        if(thaotac=="ChinhSua")
        {
            btThemMoi.Text = "Edit";
            cbAddMoreCategoryAds.Visible = false;

            DataTable dt = new DataTable();
            dt = abcompany.Ads.Info_Ads_by_id(adsid);
            if (dt.Rows.Count > 0)
            {
                ddlAdsFar.SelectedValue = dt.Rows[0]["groupadsid"].ToString();
                tbAdsName.Text = dt.Rows[0]["adsname"].ToString();
                tbLink.Text = dt.Rows[0]["link"].ToString();
                tbNumOrderAds.Text = dt.Rows[0]["numorderads"].ToString();
                ltrImageAds.Text = "<img class='anhDaiDien'src='/pic/Ads/" + dt.Rows[0]["imageads"] + @"'/>";
                hdImageAds.Value = dt.Rows[0]["imageads"].ToString();
            }
        }

        else
        {
            btThemMoi.Text = "Add new";
            cbAddMoreCategoryAds.Visible = true;
        }

    }

    private void TakeGroup()
    {
        DataTable dt = new DataTable();
        dt = abcompany.GroupAds.Info_GroupAds();
        ddlAdsFar.Items.Clear();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlAdsFar.Items.Add(new ListItem(dt.Rows[i]["groupadsname"].ToString(), dt.Rows[i]["groupadsid"].ToString()));
            //dt.Rows[i]["AnhDaiDien"].ToString(), dt.Rows[i]["ThuTu"].ToString(), dt.Rows[i]["SoSPHienThi"].ToString()
        }
    }
    protected void btThemMoi_Click(object sender, EventArgs e)
    {
        if (thaotac == "ThemMoi")
        {
            #region code nút thêm mới

            if (flImageAds.FileContent.Length > 0)
            {
                if (flImageAds.FileName.EndsWith(".jpeg") || flImageAds.FileName.EndsWith(".jpg") || flImageAds.FileName.EndsWith(".png") || flImageAds.FileName.EndsWith(".gif"))
                {
                    flImageAds.SaveAs(Server.MapPath("pic/Ads/") + flImageAds.FileName);
                }
            }
            //else ltrNotify.Text = "Nhập sai hoặc thiếu thông tin! Mời nhập lại";


            abcompany.Ads.Ads_Inser(
                tbAdsName.Text, "", flImageAds.FileName,
                tbLink.Text, tbNumOrderAds.Text, ddlAdsFar.SelectedValue, "");
            ltrNotify.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>New ad created</div>";

            if (cbAddMoreCategoryAds.Checked)
            {
                //viết code xử lý xóa mục đã nhập để người dùng nhập danh mục tiếp theo
                ResetControl();
            }

            else
            {
                //đẩy trang về trang danh sách các damnh mục đã tạo

                Response.Redirect("Admin.aspx?modul=QuangCao&modulphu=DanhSachQuangCao");
            }
            #endregion
        }
        else
        {
            #region code nút chỉnh sửa
            string AdsName = "";

            if (flImageAds.FileContent.Length > 0)
            {
                if (flImageAds.FileName.EndsWith(".jpeg") || flImageAds.FileName.EndsWith(".jpg") || flImageAds.FileName.EndsWith(".png") || flImageAds.FileName.EndsWith(".gif"))
                {
                    flImageAds.SaveAs(Server.MapPath("pic/Ads/") + flImageAds.FileName);
                    AdsName = flImageAds.FileName;

                    // viết đoạn code xóa ảnh đại diện cũ tại đây - tạm thời chưa viết
                }
            }

            if (AdsName == "")
            {
                AdsName = hdImageAds.Value;
            }

            abcompany.Ads.Ads_Update(
                adsid, tbAdsName.Text, "", AdsName,
                tbLink.Text, tbNumOrderAds.Text, ddlAdsFar.SelectedValue);

            //đẩy trang về trang danh sách các damnh mục đã tạo
            Response.Redirect("Admin.aspx?modul=QuangCao&modulphu=DanhSachQuangCao");

            #endregion
        }
    }

    private void ResetControl()
    {
        tbAdsName.Text = "";
        tbNumOrderAds.Text = "";
        tbLink.Text = "";
    }
    protected void btHuy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }
}