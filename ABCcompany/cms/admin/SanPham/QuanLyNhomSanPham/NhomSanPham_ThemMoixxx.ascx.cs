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
            cbAddMoreGroupProduct.Visible = false;

            DataTable dt = new DataTable();
            dt = abcompany.GroupProduct.Info_GroupProduct_by_id(groupid);
            if (dt.Rows.Count > 0)
            {
                tbGroupName.Text = dt.Rows[0]["groupname"].ToString();
                tbNumOrder.Text = dt.Rows[0]["numorder"].ToString();
                tbNumShow.Text = dt.Rows[0]["numshow"].ToString();
                ltrAvatar.Text = "<img class='anhDaiDien'src='/pic/Product/" + dt.Rows[0]["avatar"] + @"'/>";
                hdAvatar.Value = dt.Rows[0]["avatar"].ToString();
            }
        }

        else
        {
            btThemMoi.Text = "Add new";
            cbAddMoreGroupProduct.Visible = true;
        }

    }
    protected void btThemMoi_Click(object sender, EventArgs e)
    {
        if (thaotac == "ThemMoi")
        {
            #region code nút thêm mới

            if (flAvatar.FileContent.Length > 0)
            {
                if (flAvatar.FileName.EndsWith(".jpeg") || flAvatar.FileName.EndsWith(".jpg") || flAvatar.FileName.EndsWith(".png") || flAvatar.FileName.EndsWith(".gif"))
                {
                    flAvatar.SaveAs(Server.MapPath("pic/Product/") + flAvatar.FileName);
                }
            }
            //else ltrThongBao.Text = "Nhập sai hoặc thiếu thông tin! Mời nhập lại";


            abcompany.GroupProduct.GroupProduct_Inser(tbGroupName.Text, flAvatar.FileName, tbNumOrder.Text, tbNumShow.Text, "");
            ltrThongBao.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>Category created: " + tbGroupName.Text + "</div>";

            if (cbAddMoreGroupProduct.Checked)
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
            string nameAvatar = "";

            if (flAvatar.FileContent.Length > 0)
            {
                if (flAvatar.FileName.EndsWith(".jpeg") || flAvatar.FileName.EndsWith(".jpg") || flAvatar.FileName.EndsWith(".png") || flAvatar.FileName.EndsWith(".gif"))
                {
                    flAvatar.SaveAs(Server.MapPath("pic/Product/") + flAvatar.FileName);
                    nameAvatar = flAvatar.FileName;

                    // viết đoạn code xóa ảnh đại diện cũ tại đây - tạm thời chưa viết
                }
            }

            if (nameAvatar == "")
            {
                nameAvatar = hdAvatar.Value;
            }

            abcompany.GroupProduct.GroupProduct_Update(groupid, tbGroupName.Text, nameAvatar, tbNumOrder.Text, tbNumShow.Text);

            //đẩy trang về trang danh sách các damnh mục đã tạo
            Response.Redirect("Admin.aspx?modul=SanPham&modulphu=NhomSanPham");

            #endregion
        }
    }

    private void ResetControl()
    {
        tbGroupName.Text = "";
        tbNumOrder.Text = "";
        tbNumShow.Text = "";

    }
    protected void btHuy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }
}