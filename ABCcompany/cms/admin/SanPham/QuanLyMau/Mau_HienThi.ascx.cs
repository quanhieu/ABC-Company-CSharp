using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class cms_admin_SanPham_QuanLyMau_Mau_HienThi : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            TakeStatus();
    }

    private void TakeStatus()
    {
        DataTable dt = new DataTable();
        dt = abcompany.Status.Info_Status();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ltrMau.Text += @"
<tr id='maDong_" + dt.Rows[i]["statusid"] + @"'>
           <td class='cotMa'>" + dt.Rows[i]["statusid"] + @"</td>
           <td class='cotTen'>" + dt.Rows[i]["statusname"] + @"</td>
           <td class='cotCongCu'>
     
               <a href='Admin.aspx?modul=SanPham&modulphu=Mau&thaotac=ChinhSua&statusid=" + dt.Rows[i]["statusid"] + @"' class='sua' title='Edit'></a>
               <a href='javascript:DeleteStatus(" + dt.Rows[i]["statusid"] + @")' class='xoa' title='Delete'></a>
           </td>
</tr>
";
        }

    }
}