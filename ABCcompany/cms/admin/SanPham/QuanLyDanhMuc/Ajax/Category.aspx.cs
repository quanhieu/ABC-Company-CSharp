using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLyDanhMuc_Ajax_Category : System.Web.UI.Page
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        //Cần code kiểm tra đăng nhập ở đây sau đó mới thực hiện các thao tác ở dưới
        //Kiểm tra nếu đã đăng nhập thì mới cho vào trang này
        if (Session["DangNhap"] != null && Session["DangNhap"].ToString() == "1")
        {
            //Đã đăng nhập
        }
        else
        {
            //Nếu chưa đăng nhập --> return để dừng không cho thực hiện các câu lệnh bên dưới
            return;
        }

        if (Request.Params["ThaoTac"] != null)
            thaotac = Request.Params["ThaoTac"];
        switch (thaotac)
        {
            case "DeleteCategory":
                DeleteCategory();
                break;
        }
    }

    private void DeleteCategory()
    {
        string categoryid = "";
        if (Request.Params["categoryid"] != null)
            categoryid = Request.Params["categoryid"];

        //Thực hiện code xóa
            //bước 1: xóa ảnh đại diện đã lưu trên server - tạm bỏ qua
            //bước 2: xóa bản ghi trong sql
        abcompany.Category.Category_Delete(categoryid);

        //Trả về thông báo: 1 - thực hiện thành công; 2 - không thực hiện thành công
        Response.Write("1");
    }
}