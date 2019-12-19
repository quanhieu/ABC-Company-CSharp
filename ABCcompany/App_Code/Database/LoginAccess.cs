using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace abcompany
{
    /// <summary>
    /// Class thực hiện truy vấn liên quan đế bảng QuyenDangNhap
    /// </summary>
    public class LoginAccess
    {
        #region Phương thức xóa Quyendangnhap
        /// Phương thức xóa Quyendangnhap theo mã Quyendangnhap truyền vào
        /// </summary>
        /// <param name="masp">mã Quyendangnhap cần xóa</param>
        public static void LoginAccess_delete(string LoginID)
        {
            OleDbCommand cmd = new OleDbCommand("LoginAccess_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@loginid", LoginID);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới Quyendangnhap vào bảng Quyendangnhap
        /// <summary>
        /// Phương thức thêm mới Quyendangnhap vào bảng Quyendangnhap
        /// </summary>
        /// <param name="loginname"></param>

        public static void LoginAccess_Inser(string loginname, string ret)
        {
            OleDbCommand cmd = new OleDbCommand("LoginAccess_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@loginname", loginname);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một QuyenDangNhap
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một LoginAccess
        /// </summary>
        /// <param name="loginid"></param>
        /// <param name="loginname"></param>

        public static void LoginAccess_Update(string loginid, string loginname)
        {
            OleDbCommand cmd = new OleDbCommand("LoginAccess_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@loginid", loginid);
            cmd.Parameters.AddWithValue("@loginname", loginname);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả Quyendangnhap
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả Quyendangnhap
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_LoginAccess()
        {
            OleDbCommand cmd = new OleDbCommand("info_LoginAccess");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra quyền đăng nhập theo mã quyền
        /// <summary>
        /// Phương thức lấy ra quyền đăng nhập theo mã quyền
        /// </summary>
        /// <param name="LoginID"></param>
        /// <returns></returns>
        public static DataTable Info_LoginAccess_by_id(string LoginID)
        {
            OleDbCommand cmd = new OleDbCommand("info_LoginAccess_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@LoginID", LoginID);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
