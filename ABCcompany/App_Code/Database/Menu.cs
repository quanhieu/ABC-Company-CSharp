using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace abcompany
{
    /// <summary>
    /// Summary description for Menu
    /// </summary>
    public class Menu
    {
        #region Phương thức xóa menu theo mã menu truyền vào
        /// <summary>
        /// Phương thức xóa menu theo mã menu truyền vào
        /// </summary>
        /// <param name="menuid"></param>
        public static void Menu_Delete(string menuid)
        {
            OleDbCommand cmd = new OleDbCommand("menu_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@menuid", menuid);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới menu vào bảng menu
        /// <summary>
        /// Phương thức thêm mới menu vào bảng menu
        /// </summary>
        /// <param name="menuname"></param>
        /// <param name="link"></param>
        /// <param name="menuidfar"></param>
        /// <param name="numordermenu"></param>
        /// <param name="ret"></param>
        public static void Menu_Inser(string menuname,string link,string menuidfar,string numordermenu, string ret)        {
            OleDbCommand cmd = new OleDbCommand("menu_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@menuname", menuname);
            cmd.Parameters.AddWithValue("@link", link);
            cmd.Parameters.AddWithValue("@menuidfar", menuidfar);
            cmd.Parameters.AddWithValue("@numordermenu", numordermenu);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một menu
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một menu
        /// </summary>
        /// <param name="menuid"></param>
        /// <param name="menuname"></param>
        /// <param name="link"></param>
        /// <param name="menuidfar"></param>
        /// <param name="numordermenu"></param>
        public static void Menu_Update(string menuid,string menuname,string link,string menuidfar,string numordermenu)
        {
            OleDbCommand cmd = new OleDbCommand("menu_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@menuid", menuid);
            cmd.Parameters.AddWithValue("@menuname", menuname);
            cmd.Parameters.AddWithValue("@link", link);
            cmd.Parameters.AddWithValue("@menuidfar", menuidfar);
            cmd.Parameters.AddWithValue("@numordermenu", numordermenu);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả menu
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả menu
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_Menu()
        {
            OleDbCommand cmd = new OleDbCommand("info_menu");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra danh sách thông tin menu theo mã menu
        /// <summary>
        /// Phương thức lấy ra danh sách thông tin menu theo mã menu
        /// </summary>
        /// <param name="menuid"></param>
        /// <returns></returns>
        public static DataTable Info_Menu_by_id(string menuid)
        {
            OleDbCommand cmd = new OleDbCommand("info_menu_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@menuid", menuid);
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin menu theo mã menu cha
        /// <summary>
        /// Phương thức lấy ra thông tin menu theo mã menu cha
        /// </summary>
        /// <param name="MenuIDFar"></param>
        /// <returns></returns>
        public static DataTable Info_Menu_by_menuidfar(string MenuIDFar)
        {
            OleDbCommand cmd = new OleDbCommand("info_menu_by_@MenuIDFar");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@menuidfar", MenuIDFar);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
