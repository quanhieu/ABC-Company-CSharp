using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class cms_admin_TinTuc_DanhMucTin_DanhMucTin_ThemMoi : System.Web.UI.UserControl
{
    private string thaotac = "";
    private string newscode = "";//lấy id của danh mục tin cần chỉnh sửa
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        if (Request.QueryString["newscode"] != null)
            newscode = Request.QueryString["newscode"];
        if (!IsPostBack)
        {

            TakeCategoryFar();

            ShowInformation(newscode);
        }
    }

    private void ShowInformation(string newscode)
    {
        if (thaotac == "ChinhSua")
        {
            btThemMoi.Text = "Edit";
            cbAddMoreCategoryNews.Visible = false;

            DataTable dt = new DataTable();
            dt = abcompany.CategoryNews.Info_CategoryNews_by_id(newscode);
            if (dt.Rows.Count > 0)
            {
                ddlNewsCodeFar.SelectedValue = dt.Rows[0]["newscodefar"].ToString();
                tbTenNewsName.Text = dt.Rows[0]["newsname"].ToString();
                tbNumOrder.Text = dt.Rows[0]["numorder"].ToString();

                ltrAvatarCaNews.Text = "<img class='anhDaiDien'src='/pic/News/" + dt.Rows[0]["avatar"] + @"'/>";
                AvatarCaNewsOld.Value = dt.Rows[0]["avatar"].ToString();
            }
        }

        else
        {
            btThemMoi.Text = "Add new";
            cbAddMoreCategoryNews.Visible = true;
        }

    }
    private void TakeCategoryFar()
    {
        DataTable dt = new DataTable();
        dt = abcompany.CategoryNews.Info_CategoryNews_by_newscodefar("0");
        ddlNewsCodeFar.Items.Clear();

        ddlNewsCodeFar.Items.Add(new ListItem("Main category news", "0"));
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlNewsCodeFar.Items.Add(new ListItem(dt.Rows[i]["newsname"].ToString(), dt.Rows[i]["newscode"].ToString()));
            TakeSubCategorynews(dt.Rows[i]["newscode"].ToString(), "___");
        }
    }

    private void TakeSubCategorynews(string newscodefar, string Distance)
    {
        DataTable dt = new DataTable();
        dt = abcompany.CategoryNews.Info_CategoryNews_by_newscodefar(newscodefar);

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlNewsCodeFar.Items.Add(new ListItem(Distance + dt.Rows[i]["newsname"].ToString(), dt.Rows[i]["newscode"].ToString()));
            TakeSubCategorynews(dt.Rows[i]["newscode"].ToString(), Distance + "___");
        }
    }
    protected void btThemMoi_Click(object sender, EventArgs e)
    {
        if (thaotac == "ThemMoi")
        {
            #region code nút thêm mới

            if (flAvatarCaNews.FileContent.Length > 0)
            {
                if (flAvatarCaNews.FileName.EndsWith(".jpeg") || flAvatarCaNews.FileName.EndsWith(".jpg") || flAvatarCaNews.FileName.EndsWith(".png") || flAvatarCaNews.FileName.EndsWith(".gif"))
                {
                    flAvatarCaNews.SaveAs(Server.MapPath("pic/News/") + flAvatarCaNews.FileName);
                }
            }
            //else ltrNotify.Text = "Nhập sai hoặc thiếu thông tin! Mời nhập lại";


            abcompany.CategoryNews.CategoryNews_Inser(tbTenNewsName.Text, flAvatarCaNews.FileName, tbNumOrder.Text, ddlNewsCodeFar.SelectedValue, "");
            ltrNotify.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>Category news created: " + tbTenNewsName.Text + "</div>";

            if (cbAddMoreCategoryNews.Checked)
            {
                //viết code xử lý xóa mục đã nhập để người dùng nhập danh mục tiếp theo
                ResetControl();
            }

            else
            {
                //đẩy trang về trang danh sách các damnh mục đã tạo

                Response.Redirect("Admin.aspx?modul=TinTuc&modulphu=DanhMucTin");
            }
            #endregion
        }
        else
        {
            #region code nút chỉnh sửa
            string imageName = "";

            if (flAvatarCaNews.FileContent.Length > 0)
            {
                if (flAvatarCaNews.FileName.EndsWith(".jpeg") || flAvatarCaNews.FileName.EndsWith(".jpg") || flAvatarCaNews.FileName.EndsWith(".png") || flAvatarCaNews.FileName.EndsWith(".gif"))
                {
                    flAvatarCaNews.SaveAs(Server.MapPath("pic/News/") + flAvatarCaNews.FileName);
                    imageName = flAvatarCaNews.FileName;

                    // viết đoạn code xóa ảnh đại diện cũ tại đây - tạm thời chưa viết
                }
            }

            if (imageName == "")
            {
                imageName = AvatarCaNewsOld.Value;
            }

            abcompany.CategoryNews.CategoryNews_Update(newscode, tbTenNewsName.Text, flAvatarCaNews.FileName, tbNumOrder.Text, ddlNewsCodeFar.SelectedValue);

            //đẩy trang về trang danh sách các damnh mục đã tạo
            Response.Redirect("Admin.aspx?modul=TinTuc&modulphu=DanhMucTin");

            #endregion
        }
    }

    private void ResetControl()
    {
        tbTenNewsName.Text = "";
        tbNumOrder.Text = "";

    }
    protected void btHuy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }
}