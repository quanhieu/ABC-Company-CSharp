using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLySanPham_SanPham_ThemMoi : System.Web.UI.UserControl
{
    private string thaotac = "";
    private string id = ""; //se lay id cua sản phẩm can chinh sua
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        if (Request.QueryString["id"] != null)
            id = Request.QueryString["id"];
        if (!IsPostBack)
        {
            TakeCategoryFarther();
            TakeStatus();
            TakeSupply();
            
            TakeGroupProduct();


            DisplayInformation(id);
        }
    }

    private void DisplayInformation(string id)
    {
        if (thaotac == "ChinhSua")
        {
            btAddNew.Text = "Edit";
            cbAddMoreCategory.Visible = false;

            DataTable dt = new DataTable();
            dt = abcompany.Product.Info_Products_by_id(id);
            if (dt.Rows.Count > 0) 
            {
                ddCategoryFar.SelectedValue = dt.Rows[0]["categoryidfar"].ToString();


                tbProductName.Text = dt.Rows[0]["productname"].ToString();
                tbQuantity.Text = dt.Rows[0]["quantityp"].ToString();
                tbPrice.Text = dt.Rows[0]["pricep"].ToString();
                tbDateCreated.Text = dt.Rows[0]["datecreated"].ToString();
                tbDateCancel.Text = dt.Rows[0]["datecancel"].ToString();

                tbStatus.SelectedValue = dt.Rows[0]["statusid"].ToString();
                tbSupply.SelectedValue = dt.Rows[0]["supplyid"].ToString();
                
                ddlgroup.SelectedValue = dt.Rows[0]["groupid"].ToString();

                tbDescribe.Text = dt.Rows[0]["describep"].ToString();

                ltImage.Text = " <img class='anhDaiDien'src='/pic/Product/" + dt.Rows[0]["imagep"] + @"'/>";

                hdNameOldImage.Value = dt.Rows[0]["imagep"].ToString();
            }
        }
        else
        {
            btAddNew.Text = "Add new";
            cbAddMoreCategory.Visible = true;

            tbDateCreated.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
            tbDateCancel.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
        }
    }

    #region Lấy màu, size, chất liệu, nhóm

    private void TakeGroupProduct()
    {
        DataTable dt = new DataTable();
        //Thêm phần class Nhom xong thì mở cmt dưới
        dt = abcompany.GroupProduct.Info_GroupProduct();
        ddlgroup.Items.Clear();
        //ddlgroup.Items.Add(new ListItem("Chọn nhóm", "0"));

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlgroup.Items.Add(new ListItem(dt.Rows[i]["groupname"].ToString(), dt.Rows[i]["groupid"].ToString()));

        }
    }
    //private void LayChatLieu()
    //{
    //    DataTable dt = new DataTable();
    //    //Thêm phần class ChatLieu xong thì mở cmt dưới
    //    dt = abcompany.ChatLieu.Thongtin_Chatlieu();
    //    ddlChatLieu.Items.Clear();
    //    //ddlChatLieu.Items.Add(new ListItem("Chọn Chất liệu", "0"));

    //    for (int i = 0; i < dt.Rows.Count; i++)
    //    {
    //        ddlChatLieu.Items.Add(new ListItem(dt.Rows[i]["TenChatLieu"].ToString(), dt.Rows[i]["ChatLieuID"].ToString()));

    //    }
    //}
    private void TakeSupply()
    {
        DataTable dt = new DataTable();
        //Thêm phần class size sản phẩm xong thì mở cmt dưới
        dt = abcompany.Supply.Info_Supply();
        tbSupply.Items.Clear();
        //tbSupply.Items.Add(new ListItem("Chọn size", "0"));

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            tbSupply.Items.Add(new ListItem(dt.Rows[i]["supplyname"].ToString(), dt.Rows[i]["supplyid"].ToString()));

        }
    }
    private void TakeStatus()
    {
        DataTable dt = new DataTable();
        //Thêm phần class màu sản phẩm xong thì mở cmt dưới
        dt = abcompany.Status.Info_Status();
        tbStatus.Items.Clear();
        //tbStatus.Items.Add(new ListItem("Chọn màu", "0"));

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            tbStatus.Items.Add(new ListItem(dt.Rows[i]["statusname"].ToString(), dt.Rows[i]["statusid"].ToString()));

        }
    }
    #endregion

    #region Lấy ra thông tin danh mục
    private void TakeCategoryFarther()
    {
        DataTable dt = new DataTable();
        dt = abcompany.Category.Info_Category_by_categoryidfar("0");

        ddCategoryFar.Items.Clear();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddCategoryFar.Items.Add(new ListItem(dt.Rows[i]["categoryname"].ToString(), dt.Rows[i]["categoryidfar"].ToString()));
            TakeSubCategory(dt.Rows[i]["categoryidfar"].ToString(), "___");
        }
    }

    private void TakeSubCategory(string categoryidfarCha, string khoangCach)
    {
        DataTable dt = new DataTable();
        dt = abcompany.Category.Info_Category_by_categoryidfar(categoryidfarCha);

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddCategoryFar.Items.Add(new ListItem(khoangCach + dt.Rows[i]["categoryname"].ToString(), dt.Rows[i]["categoryidfar"].ToString()));
            // đệ quy
            TakeSubCategory(dt.Rows[i]["categoryidfar"].ToString(), khoangCach + "___");
        }
    }
    #endregion

    protected void btAddNew_Click(object sender, EventArgs e)
    {
        if (thaotac == "ThemMoi")
        {
            #region Code nút thêm mới
            if (flAvataImage.FileContent.Length > 0)
            {
                if (flAvataImage.FileName.EndsWith(".jpeg") || flAvataImage.FileName.EndsWith(".jpg") || flAvataImage.FileName.EndsWith(".png") || flAvataImage.FileName.EndsWith(".gif"))
                {
                    flAvataImage.SaveAs(Server.MapPath("pic/SanPham/") + flAvataImage.FileName);
                }
            }

            abcompany.Product.Products_Inser(tbProductName.Text, tbStatus.SelectedValue, tbSupply.SelectedValue, flAvataImage.FileName, 
                tbQuantity.Text, tbPrice.Text, tbDescribe.Text, tbDateCreated.Text, tbDateCancel.Text, ddCategoryFar.SelectedValue, ddlgroup.SelectedValue, "");

            ltrThongBao.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>Product created: " + tbProductName.Text + "</div>";


            if (cbAddMoreCategory.Checked)
            {
                //viết code xử lý xóa mục đã nhập để người dùng nhập danh mục tiếp theo
                ResetControl();
            }

            else
            {
                //đẩy trang về trang danh sách các damnh mục đã tạo
                Response.Redirect("Admin.aspx?modul=SanPham&modulphu=DanhSachSanPham");
            }
        }
        #endregion
        else
        {
            #region Code nút chỉnh sửa

            string tenAnhDaiDien = "";
            if (flAvataImage.FileContent.Length > 0)
            {
                if (flAvataImage.FileName.EndsWith(".jpeg") || flAvataImage.FileName.EndsWith(".jpg") || flAvataImage.FileName.EndsWith(".png") || flAvataImage.FileName.EndsWith(".gif"))
                {
                    flAvataImage.SaveAs(Server.MapPath("pic/SanPham/") + flAvataImage.FileName);

                    tenAnhDaiDien = flAvataImage.FileName;

                    //Cần có thêm đoạn code xóa ảnh đại diện cũ - chưa viết
                }
            }
            if (tenAnhDaiDien == "")
            {
                tenAnhDaiDien = hdNameOldImage.Value;
            }

            abcompany.Product.Products_Update(id, tbProductName.Text, tbStatus.SelectedValue, tbSupply.SelectedValue, tenAnhDaiDien,
                tbQuantity.Text, tbPrice.Text, tbDescribe.Text, tbDateCreated.Text, tbDateCancel.Text, ddCategoryFar.SelectedValue, ddlgroup.SelectedValue );

            //đẩy trang về trang danh sách các damnh mục đã tạo
            Response.Redirect("Admin.aspx?modul=SanPham&modulphu=DanhSachSanPham");

            #endregion
        }
    }

    private void ResetControl()
    {
        tbProductName.Text = "";
        tbQuantity.Text = "";
        tbPrice.Text = "";
        tbDateCancel.Text = "";

        tbDateCreated.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
        tbDateCancel.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
    }

    protected void btHuy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }
}