using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace abcompany
{
    /// <summary>
    /// Summary description for Customer
    /// </summary>
    public class Customer
    {
        #region Phương thức xóa Customer theo mã Customer truyền vào
        /// <summary>
        /// / Phương thức xóa Customer theo mã Customer truyền vào
        /// </summary>
        /// <param name="customerid"></param>
        public static void Customer_Delete(string customerid)
        {
            OleDbCommand cmd = new OleDbCommand("Customer_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@customerid", customerid);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới Customer vào Customer
        /// <summary>
        /// Phương thức thêm mới Customer vào Customer
        /// </summary>
        /// <param name="customerna"></param>
        /// <param name="addresscus"></param>
        /// <param name="callNumcus"></param>
        /// <param name="emailcus"></param>
        /// <param name="password"></param>
        /// <param name="ret"></param>
        public static void Customer_Inser(string customerna ,string addresscus ,string callNumcus ,string emailcus ,string password, string ret)
        {
            OleDbCommand cmd = new OleDbCommand("Customer_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@customerna", customerna);
            cmd.Parameters.AddWithValue("@addresscus", addresscus);
            cmd.Parameters.AddWithValue("@callNumcus", callNumcus);
            cmd.Parameters.AddWithValue("@emailcus", emailcus);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một Customer
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một Customer
        /// </summary>
        /// <param name="customerid"></param>
        /// <param name="customerna"></param>
        /// <param name="addresscus"></param>
        /// <param name="callNumcus"></param>
        /// <param name="emailcus"></param>
        /// <param name="password"></param>
        public static void Customer_Update(string customerid ,string customerna,string addresscus ,string callNumcus ,string emailcus, string password)
        {
            OleDbCommand cmd = new OleDbCommand("Customer_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@customerid", customerid);
            cmd.Parameters.AddWithValue("@customerna", customerna);
            cmd.Parameters.AddWithValue("@addresscus", addresscus);
            cmd.Parameters.AddWithValue("@callNumcus", callNumcus);
            cmd.Parameters.AddWithValue("@emailcus", emailcus);
            cmd.Parameters.AddWithValue("@password", password);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả Customer
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả Customer
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_Customer()
        {
            OleDbCommand cmd = new OleDbCommand("info_Customer");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra danh sách tất cả Customer theo email
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả Customer
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_Customer_by_emailcus(string emailcus)
        {
            OleDbCommand cmd = new OleDbCommand("info_Customer_by_emailcus");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@emailcus", emailcus);
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra danh sách tất cả Customer theo mã KH
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả Customer
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_Customer_by_customerid(string customerid)
        {
            OleDbCommand cmd = new OleDbCommand("info_Customer_by_customerid");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@customerid", customerid);
            return SQLDatabase.GetData(cmd);
        }
        #endregion


        #region Phương thức lấy ra danh sách tất cả Customer theo email và mật khẩu
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả Customer
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_Customer_by_emailcus_password(string emailcus, string password)
        {
            OleDbCommand cmd = new OleDbCommand("info_Customer_by_emailcus_password");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@emailcus", emailcus);
            cmd.Parameters.AddWithValue("@password", password);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
