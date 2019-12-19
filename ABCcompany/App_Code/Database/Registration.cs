using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace abcompany
{
    /// <summary>
    /// Summary description for DangKy
    /// </summary>
    public class Registration
    {
        #region Phương thức xóa tài khoản theo tên đăng nhập truyền vào
        /// <summary>
        ///  Phương thức xóa tài khoản theo tên đăng nhập truyền vào
        /// </summary>
        /// <param name="username"></param>
        public static void Registration_Delete(string username)
        {
            OleDbCommand cmd = new OleDbCommand("Registration_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới tài khoản vào bảng đăng ký
        /// <summary>
        /// Phương thức thêm mới tài khoản vào bảng đăng ký
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="emailre"></param>
        /// <param name="addressre"></param>
        /// <param name="fullname"></param>
        /// <param name="securityquestion"></param>
        /// <param name="dob"></param>
        /// <param name="sexre"></param>
        /// <param name="loginid"></param>
        /// <param name="ret"></param>
        public static void Registration_Inser(string username,string password,string emailre,string addressre,string fullname,string securityquestion,string dob,string sexre,string loginid, string ret)
        {
            OleDbCommand cmd = new OleDbCommand("Registration_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@emailre", emailre);
            cmd.Parameters.AddWithValue("@addressre", addressre);
            cmd.Parameters.AddWithValue("@fullname", fullname);

            cmd.Parameters.AddWithValue("@securityquestion", securityquestion);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@sexre", sexre);
            cmd.Parameters.AddWithValue("@loginid", loginid);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một tài khoản đăng ký
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một tài khoản đăng ký
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="emailre"></param>
        /// <param name="addressre"></param>
        /// <param name="fullname"></param>
        /// <param name="securityquestion"></param>
        /// <param name="dob"></param>
        /// <param name="sexre"></param>
        /// <param name="loginid"></param>
        public static void Registration_Update(string username, string password, string emailre, string addressre, string fullname, string securityquestion, string dob, string sexre, string loginid)
        {
            OleDbCommand cmd = new OleDbCommand("Registration_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@emailre", emailre);
            cmd.Parameters.AddWithValue("@addressre", addressre);
            cmd.Parameters.AddWithValue("@fullname", fullname);

            cmd.Parameters.AddWithValue("@securityquestion", securityquestion);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@sexre", sexre);
            cmd.Parameters.AddWithValue("@loginid", loginid);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả tài khoản đăng ký
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả tài khoản đăng ký
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_Registration()
        {
            OleDbCommand cmd = new OleDbCommand("info_Registration");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin tài khoản theo tên đăng nhập
        /// <summary>
        /// Phương thức lấy ra thông tin tìa khoản theo tên đăng nhập
        /// <para name="username">Tên đăng nhập của tài khoản cần lấy thông tin</para>
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_Registration_by_id(string username)
        {
            OleDbCommand cmd = new OleDbCommand("info_Registration_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username);
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin tài khoản theo tên đăng nhập và mật khẩu
        /// <summary>
        /// Phương thức lấy ra thông tin tài khoản theo tên đăng nhập và mật khẩu
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static DataTable Info_Registration_by_id_Password(string username, string password)
        {
            OleDbCommand cmd = new OleDbCommand("info_Registration_by_id_Password");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy danh sách tài khoản theo tên đăng nhập
        /// <summary>
        /// Phương thức lấy ra thông tin tìa khoản theo tên đăng nhập
        /// <para name="username">Tên đăng nhập của tài khoản cần lấy thông tin</para>
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_Registration_by_Username(string username)
        {
            OleDbCommand cmd = new OleDbCommand("info_Registration_by_Username");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username);
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy danh sách tài khoản theo tên đăng nhập và mật khẩu
        /// <summary>
        /// Phương thức lấy ra thông tin tìa khoản theo tên đăng nhập
        /// <para name="username">Tên đăng nhập của tài khoản cần lấy thông tin</para>
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_Registration_by_Username_Password(string username, string password)
        {
            OleDbCommand cmd = new OleDbCommand("info_Registration_by_Username_Password");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}

