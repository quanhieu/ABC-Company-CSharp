using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;


namespace abcompany
{
    /// <summary>
    /// Summary description for GroupProduct
    /// </summary>
    public class GroupProduct
    {
        #region Phương thức xóa GroupProduct theo mã GroupProduct truyền vào
        /// <summary>
        /// Phương thức xóa GroupProduct theo mã GroupProduct truyền vào
        /// </summary>
        /// <param name="groupid"></param>
        public static void GroupProduct_Delete(string groupid)
        {
            OleDbCommand cmd = new OleDbCommand("GroupProduct_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@groupid", groupid);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới GroupProduct vào GroupProduct
        /// <summary>
        /// Phương thức thêm mới GroupProduct vào GroupProduct
        /// </summary>
        /// <param name="groupname"></param>
        /// <param name="avatar"></param>
        /// <param name="numorder"></param>
        /// <param name="numshow"></param>
        /// <param name="ret"></param>
        public static void GroupProduct_Inser(string groupname,string avatar,string numorder,string numshow,string ret)
        {
            OleDbCommand cmd = new OleDbCommand("GroupProduct_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@groupname", groupname);
            cmd.Parameters.AddWithValue("@avatar", avatar);
            cmd.Parameters.AddWithValue("@numorder", numorder);
            cmd.Parameters.AddWithValue("@numshow", numshow);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một GroupProduct
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một GroupProduct
        /// </summary>
        /// <param name="groupid"></param>
        /// <param name="groupname"></param>
        /// <param name="avatar"></param>
        /// <param name="numorder"></param>
        /// <param name="numshow"></param>
        public static void GroupProduct_Update(string groupid,string groupname, string avatar,string numorder,string numshow)
        {
            OleDbCommand cmd = new OleDbCommand("GroupProduct_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@groupid", groupid);
            cmd.Parameters.AddWithValue("@groupname", groupname);
            cmd.Parameters.AddWithValue("@avatar", avatar);
            cmd.Parameters.AddWithValue("@numorder", numorder);
            cmd.Parameters.AddWithValue("@numshow", numshow);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả GroupProduct
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả GroupProduct
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_GroupProduct()
        {
            OleDbCommand cmd = new OleDbCommand("info_GroupProduct");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin nhóm sản phẩm theo id nhóm sản phẩm
        /// <summary>
        /// Phương thức lấy ra thông tin nhóm sản phẩm theo id nhóm sản phẩm
        /// <para name="groupid">Mã của danh mục cần lấy thông tin</para>
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_GroupProduct_by_id(string groupid)
        {
            OleDbCommand cmd = new OleDbCommand("info_GroupProduct_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@groupid", groupid);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
