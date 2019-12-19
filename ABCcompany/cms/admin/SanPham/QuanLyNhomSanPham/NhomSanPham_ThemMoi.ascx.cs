using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class cms_admin_SanPham_QuanLyNhomSanPham_NhomSanPham_ThemMoi : System.Web.UI.UserControl
{
    private string thaotac = "";
    private string groupid = "";//lấy id của nhóm sản phẩm cần chỉnh sửa
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        if (Request.QueryString["groupid"] != null)
            groupid = Request.QueryString["groupid"];
        if (!IsPostBack)
        {
            ShowInformation(groupid);
        }
    }

    private void ShowInformation(string groupid)
    {
        if (thaotac == "ChinhSua")
        {
            btThemMoi.Text = "Edit";
            cbThemNhieuNhom.Visible = false;

            DataTable dt = new DataTable();
            dt = abcompany.GroupProduct.Info_GroupProduct_by_id(groupid);
            if (dt.Rows.Count > 0)
            {
                tbTenNhomSP.Text = dt.Rows[0]["groupname"].ToString();
                tbThuTu.Text = dt.Rows[0]["numorder"].ToString();
                tbSoSanPhamHienThi.Text = dt.Rows[0]["numshow"].ToString();
                ltrAnhDaiDien.Text = "<img class='anhDaiDien'src='/pic/Product/" + dt.Rows[0]["avatar"] + @"'/>";
                hdTenAnhDaiDienCu.Value = dt.Rows[0]["avatar"].ToString();
            }
        }

        else
        {
            btThemMoi.Text = "Add new";
            cbThemNhieuNhom.Visible = true;
        }

    }
    protected void btThemMoi_Click(object sender, EventArgs e)
    {
        if (thaotac == "ThemMoi")
        {
            #region code nút thêm mới

            if (flAnhDaiDien.FileContent.Length > 0)
            {
                if (flAnhDaiDien.FileName.EndsWith(".jpeg") || flAnhDaiDien.FileName.EndsWith(".jpg") || flAnhDaiDien.FileName.EndsWith(".png") || flAnhDaiDien.FileName.EndsWith(".gif"))
                {
                    flAnhDaiDien.SaveAs(Server.MapPath("pic/Product/") + flAnhDaiDien.FileName);
                }
            }
            //else ltrThongBao.Text = "Nhập sai hoặc thiếu thông tin! Mời nhập lại";


            abcompany.GroupProduct.GroupProduct_Inser(tbTenNhomSP.Text, flAnhDaiDien.FileName, tbThuTu.Text, tbSoSanPhamHienThi.Text, "");
            ltrThongBao.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>Group product created: " + tbTenNhomSP.Text + "</div>";

            if (cbThemNhieuNhom.Checked)
            {
                //viết code xử lý xóa mục đã nhập để người dùng nhập danh mục tiếp theo
                ResetControl();
            }

            else
            {
                //đẩy trang về trang danh sách các damnh mục đã tạo

                Response.Redirect("Admin.aspx?modul=SanPham&modulphu=NhomSanPham");
            }
            #endregion
        }
        else
        {
            #region code nút chỉnh sửa
            string tenAnhDaiDien = "";

            if (flAnhDaiDien.FileContent.Length > 0)
            {
                if (flAnhDaiDien.FileName.EndsWith(".jpeg") || flAnhDaiDien.FileName.EndsWith(".jpg") || flAnhDaiDien.FileName.EndsWith(".png") || flAnhDaiDien.FileName.EndsWith(".gif"))
                {
                    flAnhDaiDien.SaveAs(Server.MapPath("pic/Product/") + flAnhDaiDien.FileName);
                    tenAnhDaiDien = flAnhDaiDien.FileName;

                    // viết đoạn code xóa ảnh đại diện cũ tại đây - tạm thời chưa viết
                }
            }

            if (tenAnhDaiDien == "")
            {
                tenAnhDaiDien = hdTenAnhDaiDienCu.Value;
            }

            abcompany.GroupProduct.GroupProduct_Update(groupid, tbTenNhomSP.Text, tenAnhDaiDien, tbThuTu.Text, tbSoSanPhamHienThi.Text);

            //đẩy trang về trang danh sách các damnh mục đã tạo
            Response.Redirect("Admin.aspx?modul=SanPham&modulphu=NhomSanPham");

            #endregion
        }
    }

    private void ResetControl()
    {
        tbTenNhomSP.Text = "";
        tbThuTu.Text = "";
        tbSoSanPhamHienThi.Text = "";

    }
    protected void btHuy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }
}