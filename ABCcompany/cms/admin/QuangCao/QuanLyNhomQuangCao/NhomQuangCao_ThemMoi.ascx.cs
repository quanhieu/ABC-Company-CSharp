using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class cms_admin_QuangCao_QuanLyNhomQuangCao_NhomQuangCao_ThemMoi : System.Web.UI.UserControl
{
    private string thaotac = "";
    private string groupadsid = "";//lấy id của nhóm quảng cáo cần chỉnh sửa
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        if (Request.QueryString["groupadsid"] != null)
            groupadsid = Request.QueryString["groupadsid"];
        if (!IsPostBack)
        {
            ShowInformation(groupadsid);
        }
    }

    private void ShowInformation(string groupadsid)
    {
        if (thaotac == "ChinhSua")
        {
            btThemMoi.Text = "Edit";
            cbAddMoreGroupAds.Visible = false;

            DataTable dt = new DataTable();
            dt = abcompany.GroupAds.Info_GroupAds_by_id(groupadsid);
            if (dt.Rows.Count > 0)
            {
                tbGroupAdsName.Text = dt.Rows[0]["groupadsname"].ToString();
                tbLocationGA.Text = dt.Rows[0]["locationga"].ToString();
                tbNumOrderGA.Text = dt.Rows[0]["numorderga"].ToString();
                ltrAvatarGA.Text = "<img class='anhDaiDien'src='/pic/Ads/" + dt.Rows[0]["avatarga"] + @"'/>";
                hdAvatarGaOld.Value = dt.Rows[0]["avatarga"].ToString();
            }
        }

        else
        {
            btThemMoi.Text = "Add neww";
            cbAddMoreGroupAds.Visible = true;
        }

    }
    protected void btThemMoi_Click(object sender, EventArgs e)
    {
        if (thaotac == "ThemMoi")
        {
            #region code nút thêm mới

            if (flAvatarGa.FileContent.Length > 0)
            {
                if (flAvatarGa.FileName.EndsWith(".jpeg") || flAvatarGa.FileName.EndsWith(".jpg") || flAvatarGa.FileName.EndsWith(".png") || flAvatarGa.FileName.EndsWith(".gif"))
                {
                    flAvatarGa.SaveAs(Server.MapPath("pic/Ads/") + flAvatarGa.FileName);
                }
            }
            //else ltrNotify.Text = "Nhập sai hoặc thiếu thông tin! Mời nhập lại";


            abcompany.GroupAds.GroupAds_Inser(tbGroupAdsName.Text, tbLocationGA.Text, tbNumOrderGA.Text, flAvatarGa.FileName, "");
            ltrNotify.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>GroupAds created: " + tbGroupAdsName.Text + "</div>";

            if (cbAddMoreGroupAds.Checked)
            {
                //viết code xử lý xóa mục đã nhập để người dùng nhập danh mục tiếp theo
                ResetControl();
            }

            else
            {
                //đẩy trang về trang danh sách các damnh mục đã tạo

                Response.Redirect("Admin.aspx?modul=QuangCao&modulphu=NhomQuangCao");
            }
            #endregion
        }
        else
        {
            #region code nút chỉnh sửa
            string tenAnhDaiDien = "";

            if (flAvatarGa.FileContent.Length > 0)
            {
                if (flAvatarGa.FileName.EndsWith(".jpeg") || flAvatarGa.FileName.EndsWith(".jpg") || flAvatarGa.FileName.EndsWith(".png") || flAvatarGa.FileName.EndsWith(".gif"))
                {
                    flAvatarGa.SaveAs(Server.MapPath("pic/GroupAds/") + flAvatarGa.FileName);
                    tenAnhDaiDien = flAvatarGa.FileName;

                    // viết đoạn code xóa ảnh đại diện cũ tại đây - tạm thời chưa viết
                }
            }

            if (tenAnhDaiDien == "")
            {
                tenAnhDaiDien = hdAvatarGaOld.Value;
            }

            abcompany.GroupAds.GroupAds_Update(groupadsid, tbGroupAdsName.Text, tbLocationGA.Text, tbNumOrderGA.Text, flAvatarGa.FileName);

            //đẩy trang về trang danh sách các damnh mục đã tạo
            Response.Redirect("Admin.aspx?modul=QuangCao&modulphu=NhomQuangCao");

            #endregion
        }
    }

    private void ResetControl()
    {
        tbGroupAdsName.Text = "";
        tbLocationGA.Text = "";
        tbNumOrderGA.Text = "";

    }
    protected void btHuy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }
}