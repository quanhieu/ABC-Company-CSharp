﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_SanPhamLoadControll : System.Web.UI.UserControl
{
    private string modulphu = "";  
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["modulphu"] != null)
            modulphu = Request.QueryString["modulphu"];
        switch (modulphu)
        {
            case "DanhMuc":
                plSanPhamLoadControl.Controls.Add(LoadControl("QuanLyDanhMuc/DanhMucLoadControl.ascx"));
                break;
            case "Nhom":
                plSanPhamLoadControl.Controls.Add(LoadControl("QuanLyNhomSanPham/NhomLoadControl.ascx"));
                break;
            case "DanhSachSanPham":
                plSanPhamLoadControl.Controls.Add(LoadControl("QuanLySanPham/SanPhamLoadControl.ascx"));
                break;
            case "Mau":
                plSanPhamLoadControl.Controls.Add(LoadControl("QuanLyMau/MauLoadControl.ascx"));
                break;
            //case "ChatLieu":
            //    plSanPhamLoadControl.Controls.Add(LoadControl("QuanLyChatLieu/ChatLieuLoadControl.ascx"));
            //    break;
            case "Size":
                plSanPhamLoadControl.Controls.Add(LoadControl("QuanLySize/SizeLoadControl.ascx"));
                break;

            default:
                plSanPhamLoadControl.Controls.Add(LoadControl("QuanLySanPham/SanPhamLoadControl.ascx"));
                break;

        }
    }

    protected string DanhDau(string tenModul, string tenModulPhu, string tenThaoTac)
    {
        string s = "";

        /*Lấy giá trị querystring modul, modulphu, thaotac*/
        string modul = "";
        if (Request.QueryString["modul"] != null)
            modul = Request.QueryString["modul"];

        string modulphu = "";
        if (Request.QueryString["modulphu"] != null)
            modulphu = Request.QueryString["modulphu"];

        string thaotac = "";
        if (Request.QueryString["thaotac"] != null)
            thaotac = Request.QueryString["thaotac"];

        /*So sánh nếu querystring bằng tên modul, modulphu, thaotac truyền vào thì trả về current --> đánh dấu là menu hiện tại*/
        if (modul == tenModul && modulphu == tenModulPhu && thaotac == tenThaoTac)
            s = "current";
        return s;
    }
}