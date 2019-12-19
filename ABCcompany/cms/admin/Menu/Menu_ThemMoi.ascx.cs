using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;


public partial class cms_admin_Menu_Menu_ThemMoi : System.Web.UI.UserControl
{
    private string thaotac = "";
    private string menuid = "";//lấy id của danh mục cần chỉnh sửa
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        if (Request.QueryString["menuid"] != null)
            menuid = Request.QueryString["menuid"];
        if (!IsPostBack)
        {

            TakeMenuFar();

            ShowInformation(menuid);
        }
            
    }

    private void ShowInformation(string menuid)
    {
        if(thaotac=="ChinhSua")
        {
            btThemMoi.Text = "Edit";
            cbAddNewMenuCategory.Visible = false;

            DataTable dt = new DataTable();
            dt = abcompany.Menu.Info_Menu_by_id(menuid);
            if(dt.Rows.Count>0)
            {
                ddlMenuFar.SelectedValue = dt.Rows[0]["menuidfar"].ToString();
                tbMenuName.Text = dt.Rows[0]["menuname"].ToString();
                tbLink.Text = dt.Rows[0]["link"].ToString();
                tbNumberOrder.Text = dt.Rows[0]["numordermenu"].ToString();
            }
        }

        else
        {
            btThemMoi.Text = "Add new";
            cbAddNewMenuCategory.Visible = true;
        }

    }
    private void TakeMenuFar()
    {
        DataTable dt = new DataTable();
        dt = abcompany.Menu.Info_Menu_by_menuidfar("0");
        ddlMenuFar.Items.Clear();

        ddlMenuFar.Items.Add(new ListItem("Main menu", "0"));
        for(int i = 0 ; i<dt.Rows.Count ; i++)
        {
            ddlMenuFar.Items.Add(new ListItem(dt.Rows[i]["menuname"].ToString(), dt.Rows[i]["menuid"].ToString()));
            TakeSubMenu(dt.Rows[i]["menuid"].ToString(), "___");
        }
    }

    private void TakeSubMenu(string menuidfar, string distance)
    {
        DataTable dt = new DataTable();
        dt = abcompany.Menu.Info_Menu_by_menuidfar(menuidfar);

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ddlMenuFar.Items.Add(new ListItem(distance + dt.Rows[i]["menuname"].ToString(), dt.Rows[i]["menuid"].ToString()));
            TakeSubMenu(dt.Rows[i]["menuid"].ToString(), distance + "___");
        }
    }
    protected void btThemMoi_Click(object sender, EventArgs e)
    {
        if(thaotac=="ThemMoi")
        {
            #region code nút thêm mới

            abcompany.Menu.Menu_Inser(
                tbMenuName.Text, tbLink.Text, 
                ddlMenuFar.SelectedValue, tbNumberOrder.Text,"");
            ltrNotify.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>Menu category created: " + tbMenuName.Text + "</div>";

            if (cbAddNewMenuCategory.Checked)
            {
                //viết code xử lý xóa mục đã nhập để người dùng nhập danh mục tiếp theo
                ResetControl();
               // tbMenuName.Text = "";
                //tbLink.Text = "";
                //tbNumberOrder.Text = "";
            }

            else
            {
                //đẩy trang về trang danh sách các damnh mục đã tạo

                Response.Redirect("Admin.aspx?modul=Menu&modulphu=DanhSachMenu");
            }
            #endregion
        }
        else
        {
            #region code nút chỉnh sửa

            abcompany.Menu.Menu_Update(menuid, tbMenuName.Text, tbLink.Text,
                ddlMenuFar.SelectedValue, tbNumberOrder.Text);

             //đẩy trang về trang danh sách các damnh mục đã tạo
            Response.Redirect("Admin.aspx?modul=Menu&modulphu=DanhSachMenu");
            
            #endregion
        }
    }

    private void ResetControl()
    {
        tbMenuName.Text = "";
        tbLink.Text = "";
        tbNumberOrder.Text = "";

    }
    protected void btHuy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }
}