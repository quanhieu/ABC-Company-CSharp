using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void lbtDangNhap_Click(object sender, EventArgs e)
    {
        //Kiểm tra xem trong database có tên đang nhập và mật khẩu đúng như thế này hay không ->> nếu có thì xác nhận đăng nhập thành công

        //DataTable dt = emdepvn.DangKy.Thongtin_DangKy_by_tendangnhap_matkhau(tbTenDangNhap.Text, emdepvn.MaHoa.MaHoaMD5(tbMatKhau.Text));
        DataTable dt = abcompany.Registration.Info_Registration_by_id_Password(tbTenDangNhap.Text, abcompany.MaHoa.MaHoaMD5(tbMatKhau.Text));

        if (dt.Rows.Count > 0)
        {
            //Đăng nhăp thành công ->> lưu giá trị vào Session để đánh dấu là đã đăng nhập thành công
            Session["DangNhap"]="1"; //Gán bằng 1 thể hiện đang nhập thành công

            // Gán thêm thông tài khoản đã đăng nhập
            Session["TenDangNhap"] = dt.Rows[0]["username"];

            Response.Redirect("/Admin.aspx");
        }
        else
        {
            ltrThongBao.Text = "<div class='thongBao'>Username or password incorrect </div>";
        }
    }
}