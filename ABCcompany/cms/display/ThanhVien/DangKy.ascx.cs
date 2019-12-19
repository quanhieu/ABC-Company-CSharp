using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_display_ThanhVien_DangKy : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void lbtDangKy_Click(object sender, EventArgs e)
    {
        //Kiểm tra nếu chưa có ai đăng ký email này trong phần khách hàng thì mới cho thực hiện
        if (DaTonTaiEmail(tbEmail.Text))
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "", "alert('This email is already registered. Please fill out another email to register.');", true);
        }
        else
        {
            //Thực hiện thêm mới tài khoản khách hàng
            string matkhau = abcompany.MaHoa.MaHoaMD5(tbMatKhau.Text);

            abcompany.Customer.Customer_Inser(tbHoTen.Text, tbDiaChi.Text, tbSoDienThoai.Text, tbEmail.Text, matkhau, "");

            ScriptManager.RegisterStartupScript(this, this.GetType(), "", "alert('Registered a customer account successfully. You can log in with the email and password just created.');location.href='/Default.aspx?modul=ThanhVien&modulphu=DangNhap';", true);
        }
    }


    /// <summary>
    /// Phương thức kiểm tra xem có tồn tại bản ghi khách hàng với email này không
    /// </summary>
    /// <param name="email"></param>
    /// <returns></returns>
    private bool DaTonTaiEmail(string email)
    {
        DataTable dt = new DataTable();
        dt = abcompany.Customer.Info_Customer_by_emailcus(email);
        if (dt.Rows.Count > 0)
            return true;
        else
            return false;
    }
}