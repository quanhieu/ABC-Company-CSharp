using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_TaiKhoan_TaiKhoan_HienThi : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            TakeAccount();
    }
    private void TakeAccount()
    {
        DataTable dt = new DataTable();
        dt = abcompany.Registration.Info_Registration();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ltrRegistration.Text += @"

        <tr id='maDong_" + dt.Rows[i]["username"] + @"'>
           <td class='cotTenDK'>" + dt.Rows[i]["username"] + @"</td>
           <td class='cotEmail'>" + dt.Rows[i]["emailre"] + @"</td>
           <td class='cotDiaChia'>" + dt.Rows[i]["addressre"] + @"</td>
           <td class='cotHoTen'>" + dt.Rows[i]["fullname"] + @"</td>
           <td class='cotNgaySinh'>" + dt.Rows[i]["dob"] + @"</td>
           <td class='cotGioiTinh'>" + dt.Rows[i]["sexre"] + @"</td>
           <td class='cotCongCu'>
               <a href='Admin.aspx?modul=TaiKhoan&modulphu=TaiKhoan&thaotac=ChinhSua&id=" + dt.Rows[i]["username"] + @"' class='sua' title='Edit'></a>
               <a href=javascript:DeleteRegistration('" + dt.Rows[i]["username"] + @"') class='xoa' title='Delete'></a>
           </td>
       </tr>
";
        }

    }
}