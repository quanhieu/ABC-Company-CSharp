using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLyDanhMuc_DanhSach_ThemMoi : System.Web.UI.UserControl
{
    private string thaotac = "";
    private string id = ""; //se lay id cua danh muc can chinh sua
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        if (Request.QueryString["id"] != null)
            id = Request.QueryString["id"];
        if (!IsPostBack)
        {     
            TakeCategoryFather();
            DisplayInformation(id);
        }
    }

    private void DisplayInformation(string categoryid)
    {
        if (thaotac == "ChinhSua")
        {
            btAddNew.Text = "Edit";
            cbAddMoreCategory.Visible = false;

            DataTable dt = new DataTable();
            dt = abcompany.Category.Info_Category_by_id(categoryid);
            if (dt.Rows.Count > 0) ;
            {
                ddlCategoryFar.SelectedValue = dt.Rows[0]["categoryidfar"].ToString();
                tbCategoryName.Text = dt.Rows[0]["categoryname"].ToString();
                tbNumOrder.Text = dt.Rows[0]["numorder"].ToString();

                tbAvatar.Text = " <img class='anhDaiDien'src='/pic/Product/" + dt.Rows[0]["avatar"] + @"'/>";

                hdAvatar.Value = dt.Rows[0]["avatar"].ToString();
            }
        }
        else
        {
            btAddNew.Text = "Add new";
            cbAddMoreCategory.Visible = true;
        }
    }

    private void TakeCategoryFather() {
        DataTable dt = new DataTable();
        dt = abcompany.Category.Info_Category_by_categoryidfar("0");

        ddlCategoryFar.Items.Clear();

        ddlCategoryFar.Items.Add(new ListItem("Original Category","0"));
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlCategoryFar.Items.Add(new ListItem(dt.Rows[i]["categoryname"].ToString(), dt.Rows[i]["categoryid"].ToString()));
            LayDanhMucCon(dt.Rows[i]["categoryid"].ToString(),"___");
        }
    }

    private void LayDanhMucCon(string categoryidfar, string distance)
    {
        DataTable dt = new DataTable();
        dt = abcompany.Category.Info_Category_by_categoryidfar(categoryidfar);

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlCategoryFar.Items.Add(new ListItem(distance + dt.Rows[i]["categoryname"].ToString(), dt.Rows[i]["categoryid"].ToString()));
            // đệ quy
            LayDanhMucCon(dt.Rows[i]["categoryid"].ToString(), distance+"___");
        }
    }

    protected void btAddNew_Click(object sender, EventArgs e)
    {
        if (thaotac == "ThemMoi")
        {
            #region Code nút thêm mới
            if (flAvatar.FileContent.Length > 0)
            {
                if (flAvatar.FileName.EndsWith(".jpeg") || flAvatar.FileName.EndsWith(".jpg") || flAvatar.FileName.EndsWith(".png") || flAvatar.FileName.EndsWith(".gif"))
                {
                    flAvatar.SaveAs(Server.MapPath("pic/Product/") + flAvatar.FileName);
                }
            }
            abcompany.Category.Category_Inser(tbCategoryName.Text, flAvatar.FileName, tbNumOrder.Text, ddlCategoryFar.SelectedValue, "");
            ltrThongBao.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>Đã tạo danh mục: " + tbCategoryName.Text + "</div>";

            if (cbAddMoreCategory.Checked)
            {
                //viết code xử lý xóa mục đã nhập để người dùng nhập danh mục tiếp theo
                ResetControl();
            }

            else
            {
                //đẩy trang về trang danh sách các damnh mục đã tạo
                Response.Redirect("Admin.aspx?modul=SanPham&modulphu=DanhMuc");
            }
        }
        #endregion
        else
        {
            #region Code nút chỉnh sửa

            string avatarName = "";
            if (flAvatar.FileContent.Length > 0)
            {
                if (flAvatar.FileName.EndsWith(".jpeg") || flAvatar.FileName.EndsWith(".jpg") || flAvatar.FileName.EndsWith(".png") || flAvatar.FileName.EndsWith(".gif"))
                {
                    flAvatar.SaveAs(Server.MapPath("pic/Product/") + flAvatar.FileName);

                    avatarName = flAvatar.FileName;

                    //Cần có thêm đoạn code xóa ảnh đại diện cũ - chưa viết
                }
            }
            if (avatarName == "")
            {
                avatarName = hdAvatar.Value;
            }

            abcompany.Category.Category_Update(id,tbCategoryName.Text, avatarName, tbNumOrder.Text, ddlCategoryFar.SelectedValue);
            //ltrThongBao.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>Đã tạo danh mục: " + tbCategoryName.Text + "</div>";

            //if (cbAddMoreCategory.Checked)
            //{
            //    //viết code xử lý xóa mục đã nhập để người dùng nhập danh mục tiếp theo
            //    ResetControl();
            //}

            //else
            //{

                //đẩy trang về trang danh sách các damnh mục đã tạo
                Response.Redirect("Admin.aspx?modul=SanPham&modulphu=DanhMuc");
            
            #endregion
        }
    }

    private void ResetControl()
    {
        tbCategoryName.Text = "";
        tbNumOrder.Text = "";
    }

    protected void btHuy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }
}