using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class cms_admin_Menu_Menu_HienThi : System.Web.UI.UserControl
{
    string menuidfar = "0";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["menuidfar"] != null)
            menuidfar = Request.QueryString["menuidfar"];
        if (!IsPostBack)
            TakeMenu();
    }

    private void TakeMenu()
    {
        DataTable dt = new DataTable();
        dt = abcompany.Menu.Info_Menu_by_menuidfar(menuidfar);
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ltrMenu.Text += @"
          
           <tr id='maDong_" + dt.Rows[i]["menuid"] + @"'>
               <td class='cotMa'>" + dt.Rows[i]["menuid"] + @"</td>
               <td class='cotTen'>" + dt.Rows[i]["menuname"] + @"</td>
               <td class='cotThuTu'>" + dt.Rows[i]["numordermenu"] + @"</td>
               <td class='cotCongCu'>";
            if (SubMenu(dt.Rows[i]["menuid"].ToString()))
                ltrMenu.Text += @"<a href='Admin.aspx?modul=Menu&modulphu=DanhSachMenu&menuidfar=" + dt.Rows[i]["menuid"] + @"' class='dmcon' title='Show subMenu'></a>";
                ltrMenu.Text += @"
               <a href='Admin.aspx?modul=Menu&modulphu=DanhSachMenu&thaotac=ChinhSua&menuid=" + dt.Rows[i]["menuid"] + @"' class='sua' title='Edit'></a>
               <a href='javascript:DeleteMenu(" + dt.Rows[i]["menuid"] + @")' class='xoa' title='Delete'></a>
               </td>
           </tr>
";
        }
        
    }

    //Hàm kiểm tra danh mục có danh mục con hay ko
    bool SubMenu(string menuidfar)
    {
        DataTable dt = new DataTable();
        dt = abcompany.Menu.Info_Menu_by_menuidfar(menuidfar);
        if (dt.Rows.Count > 0)
            return true;
        else
            return false;
    }
}