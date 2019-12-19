﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class cms_admin_SanPham_QuanLySize_Size_HienThi : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            TakeSupply();
    }

    private void TakeSupply()
    {
        DataTable dt = new DataTable();
        dt = abcompany.Supply.Info_Supply();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ltrSize.Text += @"
<tr id='maDong_" + dt.Rows[i]["supplyid"] + @"'>
           <td class='cotMa'>" + dt.Rows[i]["supplyid"] + @"</td>
           <td class='cotTen'>" + dt.Rows[i]["supplyname"] + @"</td>
           <td class='cotCongCu'>
              
               <a href='Admin.aspx?modul=SanPham&modulphu=Size&thaotac=ChinhSua&supplyid=" + dt.Rows[i]["supplyid"] + @"' class='sua' title='Edit'></a>
               <a href='javascript:DeleteSupply(" + dt.Rows[i]["supplyid"] + @")' class='xoa' title='Delete'></a>
           </td>
</tr>
";
        }

    }
}