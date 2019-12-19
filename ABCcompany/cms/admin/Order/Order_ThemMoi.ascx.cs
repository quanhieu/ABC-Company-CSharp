using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_Order_Order_ThemMoi : System.Web.UI.UserControl
{
    private string thaotac = "";
    private string orderid = ""; //se lay id cua danh muc can chinh sua
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        if (Request.QueryString["orderid"] != null)
            orderid = Request.QueryString["orderid"];
        if (!IsPostBack)
        {

            ShowInformation(orderid);
        }
    }

    private void ShowInformation(string orderid)
    {
        if (thaotac == "ChinhSua")
        {
            btAddNew.Text = "Edit";
            cbAddMore.Visible = false;

            tbOrderpay.Enabled = false;
            tbDateCreate.Enabled = false;
            tbOrderID.Enabled = false;
            //tbCustomerID.Enabled = false;



            DataTable dt = new DataTable();
            dt = abcompany.Order.Info_Order_by_id(orderid);
            if (dt.Rows.Count > 0)
            {

                tbOrderID.Text = dt.Rows[0]["orderid"].ToString();
                tbDateCreate.Text = dt.Rows[0]["datecreated"].ToString();
                tbOrderMoney.Text = dt.Rows[0]["ordermoney"].ToString();

                tbOrderpay.Text = dt.Rows[0]["orderpay"].ToString();
                tbCustomerID.Text = dt.Rows[0]["customerid"].ToString();

                tbCustomerName.Text = dt.Rows[0]["customerna"].ToString();
                tbCallNum.Text = dt.Rows[0]["callnumcus"].ToString();

                tbEmail.Text = dt.Rows[0]["emailcus"].ToString();

                ddlOrderDetail.Text = dt.Rows[0]["orderdetail"].ToString();

                //lưu lại mật khẩu cũ vào trường ẩn để lấy lại khi ko cập nhật orderpay mới
                hdOldOrderpay.Value = dt.Rows[0]["orderpay"].ToString();
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


    protected void btAddNew_Click(object sender, EventArgs e)
    {
        if (thaotac == "ThemMoi")
        {
            #region Code nút thêm mới

            // Mã hóa mật khẩu trước khi thêm vào database
            string OrderPay = abcompany.MaHoa.MaHoaMD5(tbOrderpay.Text);


            abcompany.Order.Order_Inser
               (tbDateCreate.Text, tbOrderMoney.Text, tbOrderpay.Text, tbCustomerID.Text, tbCustomerName.Text, tbCallNum.Text, tbEmail.Text, ddlOrderDetail.Text, "");
            ltrNotify.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>Order created: " + tbCustomerName.Text + "</div>";

            if (cbAddMore.Checked)
            {
                //viết code xử lý xóa mục đã nhập để người dùng nhập danh mục tiếp theo
                ResetControl();
            }

            else
            {
                //đẩy trang về trang danh sách các damnh mục đã tạo
                Response.Redirect("Admin.aspx?modul=Order&modulphu=DanhSachOrder");
            }
        }
        #endregion
        else
        {
            #region Code nút chỉnh sửa
            // Mã hóa mật khẩu trước khi thêm vào database
            string OrderPay = "";
            if (tbOrderpay.Text != "")
                OrderPay = abcompany.MaHoa.MaHoaMD5(tbOrderpay.Text);
            else
                OrderPay = abcompany.MaHoa.MaHoaMD5(hdOldOrderpay.Value); // trường hợp không nhập mật khẩu thì lấy lại mật khẩu cũ

            abcompany.Order.Order_Update
            (orderid, tbDateCreate.Text, tbOrderMoney.Text, OrderPay, tbCustomerID.Text, tbCustomerName.Text, tbCallNum.Text, tbEmail.Text, ddlOrderDetail.Text);

            //đẩy trang về trang danh sách các damnh mục đã tạo
            Response.Redirect("Admin.aspx?modul=Order&modulphu=DanhSachOrder");

            #endregion
        }
    }

    private void ResetControl()
    {
        tbDateCreate.Text = "";

        tbOrderID.Text = "";
        tbDateCreate.Text = "";
        tbOrderMoney.Text = "";

        tbOrderpay.Text = "";
        tbCustomerID.Text = "";

        tbCustomerName.Text = "";
        tbCallNum.Text = "";

        tbEmail.Text = "";



    }

    protected void btHuy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }
}