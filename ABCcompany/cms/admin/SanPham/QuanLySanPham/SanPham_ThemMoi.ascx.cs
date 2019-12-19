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
    private string productid = ""; //se lay id cua sản phẩm can chinh sua
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        if (Request.QueryString["productid"] != null)
            productid = Request.QueryString["productid"];
        if (!IsPostBack)
        {
            TakeCategoryProFar();
            TakeStatus();
            TakeSupply();
            
            TakeGroupProduct();


            ShowInformation(productid);
        }
    }

    private void ShowInformation(string productid)
    {
        if (thaotac == "ChinhSua")
        {
            btThemMoi.Text = "Edit";
            cbAddMoreCatePro.Visible = false;

            DataTable dt = new DataTable();
            dt = abcompany.Product.Info_Products_by_id(productid);
            if (dt.Rows.Count > 0) 
            {
                ddlDanhMucCha.SelectedValue = dt.Rows[0]["categoryid"].ToString();


                tbTenSanPham.Text = dt.Rows[0]["productname"].ToString();
                tbSoLuong.Text = dt.Rows[0]["quantityp"].ToString();
                tbGiaBan.Text = dt.Rows[0]["pricep"].ToString();
                tbNgayTao.Text = dt.Rows[0]["datecreated"].ToString();
                tbNgayHuy.Text = dt.Rows[0]["datecancel"].ToString();

                ddlMau.SelectedValue = dt.Rows[0]["statusid"].ToString();
                ddlSize.SelectedValue = dt.Rows[0]["supplyid"].ToString();
                
                ddlNhom.SelectedValue = dt.Rows[0]["groupid"].ToString();

                tbMoTa.Text = dt.Rows[0]["describep"].ToString();

                ltrAnhDaiDien.Text = " <img class='anhDaiDien'src='/pic/Product/" + dt.Rows[0]["imagep"] + @"'/>";

                hdTenAnhDaiDienCu.Value = dt.Rows[0]["imagep"].ToString();
            }
        }
        else
        {
            btThemMoi.Text = "Add new";
            cbAddMoreCatePro.Visible = true;

            tbNgayTao.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
            tbNgayHuy.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
        }
    }

    #region Lấy mau, supply, nhóm

    private void TakeGroupProduct()
    {
        DataTable dt = new DataTable();
        //Thêm phần class Nhom xong thì mở cmt dưới
        dt = abcompany.GroupProduct.Info_GroupProduct();
        ddlNhom.Items.Clear();
        //ddlNhom.Items.Add(new ListItem("Chọn nhóm", "0"));

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlNhom.Items.Add(new ListItem(dt.Rows[i]["groupname"].ToString(), dt.Rows[i]["groupid"].ToString()));

        }
    }

    private void TakeSupply()
    {
        DataTable dt = new DataTable();
        //Thêm phần class size sản phẩm xong thì mở cmt dưới
        dt = abcompany.Supply.Info_Supply();
        ddlSize.Items.Clear();
        //ddlSize.Items.Add(new ListItem("Chọn size", "0"));

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlSize.Items.Add(new ListItem(dt.Rows[i]["supplyname"].ToString(), dt.Rows[i]["supplyid"].ToString()));

        }
    }
    private void TakeStatus()
    {
        DataTable dt = new DataTable();
        //Thêm phần class màu sản phẩm xong thì mở cmt dưới
        dt = abcompany.Status.Info_Status();
        ddlMau.Items.Clear();
        //ddlMau.Items.Add(new ListItem("Chọn màu", "0"));

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlMau.Items.Add(new ListItem(dt.Rows[i]["statusname"].ToString(), dt.Rows[i]["statusid"].ToString()));

        }
    }
    #endregion

    #region Lấy ra thông tin danh mục
    private void TakeCategoryProFar()
    {
        DataTable dt = new DataTable();
        dt = abcompany.Category.Info_Category_by_categoryidfar("0");

        ddlDanhMucCha.Items.Clear();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlDanhMucCha.Items.Add(new ListItem(dt.Rows[i]["categoryname"].ToString(), dt.Rows[i]["categoryid"].ToString()));
            LayDanhMucCon(dt.Rows[i]["categoryid"].ToString(), "___");
        }
    }

    private void LayDanhMucCon(string categoryid, string khoangCach)
    {
        DataTable dt = new DataTable();
        dt = abcompany.Category.Info_Category_by_categoryidfar(categoryid);

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlDanhMucCha.Items.Add(new ListItem(khoangCach + dt.Rows[i]["categoryname"].ToString(), dt.Rows[i]["categoryid"].ToString()));
            // đệ quy
            LayDanhMucCon(dt.Rows[i]["categoryid"].ToString(), khoangCach + "___");
        }
    }
    #endregion

    protected void btThemMoi_Click(object sender, EventArgs e)
    {
        if (thaotac == "ThemMoi")
        {
            #region Code nút thêm mới
            if (flAnhDaiDien.FileContent.Length > 0)
            {
                if (flAnhDaiDien.FileName.EndsWith(".jpeg") || flAnhDaiDien.FileName.EndsWith(".jpg") || flAnhDaiDien.FileName.EndsWith(".png") || flAnhDaiDien.FileName.EndsWith(".gif"))
                {
                    flAnhDaiDien.SaveAs(Server.MapPath("pic/Product/") + flAnhDaiDien.FileName);
                }
            }

            abcompany.Product.Products_Inser(tbTenSanPham.Text, ddlMau.SelectedValue, ddlSize.SelectedValue, flAnhDaiDien.FileName, 
                tbSoLuong.Text, tbGiaBan.Text, tbMoTa.Text, tbNgayTao.Text, tbNgayHuy.Text, ddlDanhMucCha.SelectedValue, ddlNhom.SelectedValue, "");

            ltrThongBao.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>Product created: " + tbTenSanPham.Text + "</div>";


            if (cbAddMoreCatePro.Checked)
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
            if (flAnhDaiDien.FileContent.Length > 0)
            {
                if (flAnhDaiDien.FileName.EndsWith(".jpeg") || flAnhDaiDien.FileName.EndsWith(".jpg") || flAnhDaiDien.FileName.EndsWith(".png") || flAnhDaiDien.FileName.EndsWith(".gif"))
                {
                    flAnhDaiDien.SaveAs(Server.MapPath("pic/Product/") + flAnhDaiDien.FileName);

                    tenAnhDaiDien = flAnhDaiDien.FileName;

                    //Cần có thêm đoạn code xóa ảnh đại diện cũ - chưa viết
                }
            }
            if (tenAnhDaiDien == "")
            {
                tenAnhDaiDien = hdTenAnhDaiDienCu.Value;
            }

            abcompany.Product.Products_Update(productid, tbTenSanPham.Text, ddlMau.SelectedValue, ddlSize.SelectedValue, tenAnhDaiDien,
                tbSoLuong.Text, tbGiaBan.Text, tbMoTa.Text, tbNgayTao.Text, tbNgayHuy.Text, ddlDanhMucCha.SelectedValue, ddlNhom.SelectedValue );

            //đẩy trang về trang danh sách các damnh mục đã tạo
            Response.Redirect("Admin.aspx?modul=SanPham&modulphu=DanhSachSanPham");

            #endregion
        }
    }

    private void ResetControl()
    {
        tbTenSanPham.Text = "";
        tbSoLuong.Text = "";
        tbGiaBan.Text = "";
        tbNgayHuy.Text = "";

        tbNgayTao.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
        tbNgayHuy.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
    }

    protected void btHuy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }
}