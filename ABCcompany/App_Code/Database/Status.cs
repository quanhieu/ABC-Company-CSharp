using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace abcompany
{
    /// <summary>
    /// Summary description for Status
    /// </summary>
    public class Status
    {
        #region Phương thức xóa Status
        /// <summary>
        /// Phương thức xóa Status
        /// </summary>
        /// <param name="statusid"></param>
        public static void Status_Delete(string statusid)
        {
            OleDbCommand cmd = new OleDbCommand("Status_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@statusid", statusid);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới Màu vào bảng Màu
        /// <summary>
        /// Phương thức thêm mới Màu vào bảng Màu
        /// </summary>
        /// <param name="statusname"></param>
        /// <param name="ret"></param>

        public static void Status_Inser(string statusname, string ret)
        {
            OleDbCommand cmd = new OleDbCommand("Status_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@statusname", statusname);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một Màu
        /// <summary>
        ///  Phương thức chỉnh sửa thông tin một Màu
        /// </summary>
        /// <param name="statusid"></param>
        /// <param name="statusname"></param>

        public static void Status_Update(string statusid, string statusname)
        {
            OleDbCommand cmd = new OleDbCommand("Status_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@statusid", statusid);
            cmd.Parameters.AddWithValue("@statusname", statusname);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả Màu
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả Màu
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_Status()
        {
            OleDbCommand cmd = new OleDbCommand("info_Status");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin màu theo id màu
        /// <summary>
        /// Phương thức lấy ra thông tin màu theo id màu
        /// <para name="statusid">Mã của màu cần lấy thông tin</para>
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_Status_by_id(string statusid)
        {
            OleDbCommand cmd = new OleDbCommand("info_Status_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@statusid", statusid);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
