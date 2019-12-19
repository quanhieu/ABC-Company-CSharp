using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class cms_admin_SanPham_QuanLySize_Size_ThemMoi : System.Web.UI.UserControl
{
    private string thaotac = "";
    private string supplyid = "";//lấy id của size cần chỉnh sửa
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        if (Request.QueryString["supplyid"] != null)
            supplyid = Request.QueryString["supplyid"];
        if (!IsPostBack)
        {
            ShowInformation(supplyid);
        }
    }

    private void ShowInformation(string supplyid)
    {
        if (thaotac == "ChinhSua")
        {
            btAddNew.Text = "Edit";
            cbAddMoreSupply.Visible = false;

            DataTable dt = new DataTable();
            dt = abcompany.Supply.Info_Supply_by_id(supplyid);
            if (dt.Rows.Count > 0)
            {
                tbSupplyName.Text = dt.Rows[0]["supplyname"].ToString();
            }
        }

        else
        {
            btAddNew.Text = "Add new";
            cbAddMoreSupply.Visible = true;
        }

    }
    protected void btAddNew_Click(object sender, EventArgs e)
    {
        if (thaotac == "ThemMoi")
        {
            #region code nút thêm mới

            abcompany.Supply.Supply_Inser(tbSupplyName.Text, "");
            ltrThongBao.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>Supply created: " + tbSupplyName.Text + "</div>";

            if (cbAddMoreSupply.Checked)
            {
                //viết code xử lý xóa mau đã nhập để người dùng nhập danh mục tiếp theo
                ResetControl();
            }

            else
            {
                //đẩy trang về trang danh sách các damnh mục đã tạo

                Response.Redirect("Admin.aspx?modul=SanPham&modulphu=Size");
            }
            #endregion
        }
        else
        {
            #region code nút chỉnh sửa

            abcompany.Supply.Supply_Update(supplyid, tbSupplyName.Text);

            //đẩy trang về trang danh sách các damnh mục đã tạo
            Response.Redirect("Admin.aspx?modul=SanPham&modulphu=Size");

            #endregion
        }
    }

    private void ResetControl()
    {
        tbSupplyName.Text = "";
    }
    protected void btHuy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }
}