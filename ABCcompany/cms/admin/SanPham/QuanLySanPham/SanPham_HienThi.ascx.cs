using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLySanPham_SanPham_HienThi : System.Web.UI.UserControl
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            TakeProduct();
        }
    }
    private void TakeProduct()
    {
        DataTable dt = new DataTable();
        dt = abcompany.Product.Info_Products();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ltrProduct.Text += @"


        <tr  id='maDong_" + dt.Rows[i]["productid"] + @"'>
            <td class='cotMa'>" + dt.Rows[i]["productid"] + @" </td>
            <td class='cotTen'>" + dt.Rows[i]["productname"] + @"</td>
            <td class='cotAnh'>
                <img class='anhDaiDien'src='/pic/Product/" + dt.Rows[i]["imagep"] + @"'/>
                <img class='anhDaiDienHover'src='/pic/Product/" + dt.Rows[i]["imagep"] + @"'/>
               </td>
            <td class='cotSoLuong'>" + dt.Rows[i]["quantityp"] + @" </td>
            <td class='cotDonGia'>" + dt.Rows[i]["pricep"] + @" </td>
            <td class='cotNgayTao'>" + dt.Rows[i]["datecreated"] + @" </td>
            <td class='cotCongCu'>
                <a href='Admin.aspx?modul=SanPham&modulphu=DanhSachSanPham&thaotac=ChinhSua&productid=" + dt.Rows[i]["productid"] + @"' class='sua' title='Edit'></a>
                <a href='javascript:DeleteProduct(" + dt.Rows[i]["productid"] + @")' class='xoa' title='Delete'></a>
            </td>
        </tr>
        ";
        }
    }
   
}