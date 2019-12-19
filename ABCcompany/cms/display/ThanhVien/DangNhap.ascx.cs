using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_display_ThanhVien_DangNhap : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void lbtDangNhap_Click(object sender, EventArgs e)
    {
        //Kiểm tra xem trong database có tên đang nhập và mật khẩu đúng như thế này hay không ->> nếu có thì xác nhận đăng nhập thành công

        DataTable dt = new DataTable();
        dt = abcompany.Customer.Info_Customer_by_emailcus_password(tbEmail.Text, abcompany.MaHoa.MaHoaMD5(tbMatKhau.Text));


        if (dt.Rows.Count > 0)
        {
            //Đăng nhăp thành công ->> lưu giá trị vào Session để đánh dấu là đã đăng nhập thành công
            Session["KhachHang"] = "1"; //Gán bằng 1 thể hiện đang nhập thành công

            // Gán thêm thông tài khoản đã đăng nhập
            Session["MaKH"] = dt.Rows[0]["CustomerID"];
            Session["TenKH"] = dt.Rows[0]["CustomerNa"];
            Session["DiaChiKH"] = dt.Rows[0]["AddressCus"];
            Session["sdtKH"] = dt.Rows[0]["CallNumCUS"];
            Session["EmailKH"] = dt.Rows[0]["EmailCUS"];

            Response.Redirect("/Default.aspx");
        }
        else
        {
            ScriptManager.RegisterStartupScript(this,this.GetType(),"", "alert('Username or password incorrect!')", true);
           
        }
    }
}