using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class cms_admin_SanPham_QuanLyMau_Mau_ThemMoi : System.Web.UI.UserControl
{
    private string thaotac = "";
    private string statusid = "";//lấy id của màu cần chỉnh sửa
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        if (Request.QueryString["statusid"] != null)
            statusid = Request.QueryString["statusid"];
        if (!IsPostBack)
        {
            ShowInformation(statusid);
        }
           
    }

    private void ShowInformation(string statusid)
    {
        if (thaotac == "ChinhSua")
        {
            btAddNew.Text = "Edit";
            btAddMoreStatus.Visible = false;

            DataTable dt = new DataTable();
            dt = abcompany.Status.Info_Status_by_id(statusid);
            if (dt.Rows.Count > 0)
            {
                tbStatusName.Text = dt.Rows[0]["statusname"].ToString();
            }
        }

        else
        {
            btAddNew.Text = "Add new";
            btAddMoreStatus.Visible = true;
        }

    }
    protected void btAddNew_Click(object sender, EventArgs e)
    {
        if (thaotac == "ThemMoi")
        {
            #region code nút thêm mới

            abcompany.Status.Status_Inser(tbStatusName.Text,"");
            ltrThongBao.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>Status created: " + tbStatusName.Text + "</div>";

            if (btAddMoreStatus.Checked)
            {
                //viết code xử lý xóa mau đã nhập để người dùng nhập danh mục tiếp theo
                ResetControl();
            }

            else
            {
                //đẩy trang về trang danh sách các damnh mục đã tạo

                Response.Redirect("Admin.aspx?modul=SanPham&modulphu=Mau");
            }
            #endregion
        }
        else
        {
            #region code nút chỉnh sửa

            abcompany.Status.Status_Update(statusid, tbStatusName.Text);

            //đẩy trang về trang danh sách các damnh mục đã tạo
            Response.Redirect("Admin.aspx?modul=SanPham&modulphu=Mau");

            #endregion
        }
    }

    private void ResetControl()
    {
        tbStatusName.Text = "";
    }
    protected void btHuy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }
}