using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLyDanhMuc_DanhMucLoadControl : System.Web.UI.UserControl
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];
        switch (thaotac)
        {
            //case "ThemMoi":
            //    plLoadControl.Controls.Add(LoadControl("QuanLyDanhMuc/DanhMucLoadControl.ascx"));
            //    break;
            //case "ChinhSua":
            //    plSanPhamLoadControl.Controls.Add(LoadControl("QuanLySanPham/SanPhamLoadControl.ascx"));
            //    break;
            //case "Mau":
            //    plSanPhamLoadControl.Controls.Add(LoadControl("QuanLyMau/MauLoadControl.ascx"));
            //    break;
            //case "ChatLieu":
            //    plSanPhamLoadControl.Controls.Add(LoadControl("QuanLyChatLieu/ChatLieuLoadControl.ascx"));
            //    break;
            //case "Size":
            //    plSanPhamLoadControl.Controls.Add(LoadControl("QuanLySize/SizeLoadControl.ascx"));
            //    break;
            //case "NhomSanPham":
            //    plSanPhamLoadControl.Controls.Add(LoadControl("QuanLyNhom/NhomLoadControl.ascx"));
            //    break;

            case "ThemMoi":
            case "ChinhSua":
                plLoadControl.Controls.Add(LoadControl("DanhMuc_ThemMoi.ascx"));
                break;
            case "HienThi":
                plLoadControl.Controls.Add(LoadControl("DanhMuc_HienThi.ascx"));
                break;
            default:
                plLoadControl.Controls.Add(LoadControl("DanhMuc_HienThi.ascx"));
                break;
        }
    }
}