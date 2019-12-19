using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLyDanhMuc_DanhMuc_HienThi : System.Web.UI.UserControl
{
    private string categoryidfar = "0";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["categoryidfar"] != null)
            categoryidfar = Request.QueryString["categoryidfar"];
        if (!IsPostBack)
        {
            SubCategory();
        }
    }

    private void SubCategory()
    {
        DataTable dt = new DataTable();
        dt = abcompany.Category.Info_Category_by_categoryidfar(categoryidfar);

        //GridView1.DataSource = dt;
        //GridView1.DataBind();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ltrCategory.Text += @"
        <tr id='maDong_" + dt.Rows[i]["categoryid"] + @"'>
            <td class='cotMa'>" + dt.Rows[i]["categoryid"] + @"</td>
            <td class='cotTen'>" + dt.Rows[i]["categoryname"] + @"</td>
            <td class='cotAnh'>
             <img class='anhDaiDien'src='/pic/Product/" + dt.Rows[i]["avatar"] + @"'/>
             <img class='anhDaiDienHover'src='/pic/Product/" + dt.Rows[i]["avatar"] + @"'/>
           </td>
            <td class='cotThuTu'>" + dt.Rows[i]["numorder"] + @"</td>
            <td class='cotCongCu'>";

                if(SubCategory(dt.Rows[i]["categoryid"].ToString()))
                    ltrCategory.Text += @"
                <a href='Admin.aspx?modul=SanPham&modulphu=DanhMuc&categoryidfar=" + dt.Rows[i]["categoryid"] + @"' class='dmcon' title='Show subCategory product'></a>";

                ltrCategory.Text+= @"
                <a href='Admin.aspx?modul=SanPham&modulphu=DanhMuc&thaotac=ChinhSua&id=" + dt.Rows[i]["categoryid"] + @"' class='sua' title='Edit'></a>
                <a href='javascript:DeleteCategory(" + dt.Rows[i]["categoryid"] + @")' class='xoa' title='Delete'></a>
            </td>
        </tr>
       ";
        }
    }
    /// <summary>
    /// Phương thức kiển tra xem danh mục này có danh mục con không
    /// </summary>
    /// <param name="categoryidfar"></param>
    /// <returns></returns>
    bool SubCategory(string categoryidfar)
    {
        DataTable dt = new DataTable();
        dt = abcompany.Category.Info_Category_by_categoryidfar(categoryidfar);

        if (dt.Rows.Count > 0)
            return true;
        else
            return false;
    }
}