using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_TaiKhoan_TaiKhoan_ThemMoi : System.Web.UI.UserControl
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
            TakeLoginAccess();
            ShowInformation(id);
        }
    }

    private void ShowInformation(string id)
    {
        if (thaotac == "ChinhSua")
        {
            btAddNew.Text = "Edit";
            cbAddMore.Visible = false;
            tbUserName.Enabled = false;

            DataTable dt = new DataTable();
            dt = abcompany.Registration.Info_Registration_by_Username(id);
            if (dt.Rows.Count > 0) 
            {
                ddlLoginID.SelectedValue = dt.Rows[0]["loginid"].ToString();
                tbUserName.Text = dt.Rows[0]["username"].ToString();
                //tbPassword.Text= dt.Rows[0]["Password"].ToString();
                tbEmail.Text = dt.Rows[0]["emailre"].ToString();
                tbAddressRe.Text = dt.Rows[0]["addressre"].ToString();
                tbFullName.Text = dt.Rows[0]["fullname"].ToString();
                tbDOB.Text = dt.Rows[0]["dob"].ToString();
                ddlSexRe.Text = dt.Rows[0]["sexre"].ToString();

                //lưu lại mật khẩu cũ vào trường ẩn để lấy lại khi ko cập nhật mật khẩu mới
                hdOldPassword.Value= dt.Rows[0]["password"].ToString();
                // bỏ yêu cầu bắt buộc nhập mật khẩu khi cập nhật
                RequiredFieldValidator2.Visible = false;
            }
        }
        else
        {
            btAddNew.Text = "Add new";
            cbAddMore.Visible = true;
        }
    }

    private void TakeLoginAccess()
    {
        DataTable dt = new DataTable();
        dt = abcompany.LoginAccess.Info_LoginAccess();

        ddlLoginID.Items.Clear();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlLoginID.Items.Add(new ListItem(dt.Rows[i]["loginname"].ToString(), dt.Rows[i]["loginid"].ToString()));
        }
    }


    protected void btAddNew_Click(object sender, EventArgs e)
    {
        if (thaotac == "ThemMoi")
        {
            #region Code nút thêm mới

            // Mã hóa mật khẩu trước khi thêm vào database
            string Password = abcompany.MaHoa.MaHoaMD5(tbPassword.Text);



            abcompany.Registration.Registration_Inser
               (tbUserName.Text, Password, tbEmail.Text, tbAddressRe.Text, tbFullName.Text,"",tbDOB.Text, ddlSexRe.SelectedValue, ddlLoginID.SelectedValue,"");
            ltrNotify.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>Account created: " + tbUserName.Text + "</div>";

            if (cbAddMore.Checked)
            {
                //viết code xử lý xóa mục đã nhập để người dùng nhập danh mục tiếp theo
                ResetControl();
            }

            else
            {
                //đẩy trang về trang danh sách các damnh mục đã tạo
                Response.Redirect("Admin.aspx?modul=TaiKhoan&modulphu=DanhSachTaiKhoan");
            }
        }
        #endregion
        else
        {
            #region Code nút chỉnh sửa
            // Mã hóa mật khẩu trước khi thêm vào database
            string Password = "";
            if (tbPassword.Text != "")
                Password = abcompany.MaHoa.MaHoaMD5(tbPassword.Text);
            else
                Password = abcompany.MaHoa.MaHoaMD5(hdOldPassword.Value); // trường hợp không nhập mật khẩu thì lấy lại mật khẩu cũ

            abcompany.Registration.Registration_Update
                (id,Password, tbEmail.Text, tbAddressRe.Text, tbFullName.Text,"",tbDOB.Text,ddlSexRe.SelectedValue, ddlLoginID.SelectedValue);
            //đẩy trang về trang danh sách các damnh mục đã tạo
            Response.Redirect("Admin.aspx?modul=TaiKhoan&modulphu=DanhSachTaiKhoan");

            #endregion
        }
    }

    private void ResetControl()
    {
        tbUserName.Text = "";
        tbPassword.Text = "";
        tbEmail.Text = "";
        tbAddressRe.Text = "";
        tbFullName.Text = "";
        tbDOB.Text = "";

    }

    protected void btHuy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }
}