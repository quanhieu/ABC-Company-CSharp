using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;


public partial class cms_admin_TinTuc_DanhSachTinTuc_DanhSachTinTuc_ThemMoi : System.Web.UI.UserControl
{
    private string thaotac = "";
    private string NewsID = "";//lấy id của tin tức cần chỉnh sửa
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        if (Request.QueryString["NewsID"] != null)
            NewsID = Request.QueryString["NewsID"];
        if (!IsPostBack)
        {

            TakeNewsFar();

            ShowInformation(NewsID);
        }
            
    }

    private void ShowInformation(string NewsID)
    {
        if(thaotac=="ChinhSua")
        {
            btThemMoi.Text = "Edit";
            cbAddMoreNews.Visible = false;

            DataTable dt = new DataTable();
            dt = abcompany.News.Info_News_by_id(NewsID);
            if (dt.Rows.Count > 0)
            {
                ddlCodeFar.SelectedValue = dt.Rows[0]["newscode"].ToString();
                tbTitle.Text = dt.Rows[0]["Title"].ToString();
                tbDescribe.Text = dt.Rows[0]["Describe"].ToString();
                tbViews.Text = dt.Rows[0]["Views"].ToString();
                tbPostDate.Text = dt.Rows[0]["PostDate"].ToString();
                tbNumOrder.Text = dt.Rows[0]["NumOrder"].ToString();
                tbDetail.Text = dt.Rows[0]["Detail"].ToString();
                ltrAvatarNews.Text = "<img class='anhDaiDien'src='/pic/Product/" + dt.Rows[0]["Avatar"] + @"'/>";
                hdavatarNameOld.Value = dt.Rows[0]["Avatar"].ToString();
            }
        }

        else
        {
            btThemMoi.Text = "Add new";
            cbAddMoreNews.Visible = true;
            tbViews.Text = "0";
            tbNumOrder.Text = "1";
            tbPostDate.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
        }

    }
   
    #region Lấy ra thông tin danh mục
    private void TakeNewsFar()
    {
        DataTable dt = new DataTable();
        dt = abcompany.CategoryNews.Info_CategoryNews_by_newscodefar("0");
        ddlCodeFar.Items.Clear();
        for(int i = 0 ; i<dt.Rows.Count ; i++)
        {
            ddlCodeFar.Items.Add(new ListItem(dt.Rows[i]["newsname"].ToString(), dt.Rows[i]["newscode"].ToString()));
            TakeSubNews(dt.Rows[i]["newscode"].ToString(), "___");
        }
    }

    private void TakeSubNews(string newscodefar, string Distance)
    {
        DataTable dt = new DataTable();
        dt = abcompany.CategoryNews.Info_CategoryNews_by_newscodefar(newscodefar);

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlCodeFar.Items.Add(new ListItem(Distance + dt.Rows[i]["newsname"].ToString(), dt.Rows[i]["newscode"].ToString()));
            TakeSubNews(dt.Rows[i]["newscode"].ToString(), Distance + "___");
        }
    }
    #endregion
    protected void btThemMoi_Click(object sender, EventArgs e)
    {
        if (thaotac == "ThemMoi")
        {
            #region code nút thêm mới

            if (flAvatar.FileContent.Length > 0)
            {
                if (flAvatar.FileName.EndsWith(".jpeg") || flAvatar.FileName.EndsWith(".jpg") || flAvatar.FileName.EndsWith(".png") || flAvatar.FileName.EndsWith(".gif"))
                {
                    flAvatar.SaveAs(Server.MapPath("pic/News/") + flAvatar.FileName);
                }
            }
            //else ltrNotify.Text = "Nhập sai hoặc thiếu thông tin! Mời nhập lại";


            abcompany.News.News_Inser(
                tbTitle.Text, flAvatar.FileName, tbDescribe.Text,
                tbPostDate.Text, tbViews.Text, tbDetail.Text,
                tbNumOrder.Text, ddlCodeFar.SelectedValue);
            ltrNotify.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>New created</div>";

            if (cbAddMoreNews.Checked)
            {
                //viết code xử lý xóa mục đã nhập để người dùng nhập danh mục tiếp theo
                ResetControl();
            }

            else
            {
                //đẩy trang về trang danh sách các damnh mục đã tạo

                Response.Redirect("Admin.aspx?modul=TinTuc&modulphu=DanhSachTinTuc");
            }
            #endregion
        }
        else
        {
            #region code nút chỉnh sửa
            string avatarName = "";

            if (flAvatar.FileContent.Length > 0)
            {
                if (flAvatar.FileName.EndsWith(".jpeg") || flAvatar.FileName.EndsWith(".jpg") || flAvatar.FileName.EndsWith(".png") || flAvatar.FileName.EndsWith(".gif"))
                {
                    flAvatar.SaveAs(Server.MapPath("pic/News/") + flAvatar.FileName);
                    avatarName = flAvatar.FileName;

                    // viết đoạn code xóa ảnh đại diện cũ tại đây - tạm thời chưa viết
                }
            }

            if (avatarName == "")
            {
                avatarName = hdavatarNameOld.Value;
            }

            abcompany.News.News_Update(
                NewsID, tbTitle.Text, avatarName, tbDescribe.Text, 
                tbPostDate.Text, tbViews.Text, tbDetail.Text, 
                tbNumOrder.Text, ddlCodeFar.SelectedValue);

            //đẩy trang về trang danh sách các damnh mục đã tạo
            Response.Redirect("Admin.aspx?modul=TinTuc&modulphu=DanhSachTinTuc");

            #endregion
        }
    }

    private void ResetControl()
    {
        tbTitle.Text = "";
        tbDetail.Text = "";
        tbNumOrder.Text = "";
        tbViews.Text = "";
        tbPostDate.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
        tbDescribe.Text = "";
    }
    protected void btHuy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }
}