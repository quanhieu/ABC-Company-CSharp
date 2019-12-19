using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace abcompany
{
    /// <summary>
    /// Summary description for DanhMuc
    /// </summary>
    public class Category
    {

        #region Phương thức xóa danh mục theo mã danh mục truyền vào
        /// <summary>
        /// Phương thức xóa danh mục theo mã danh mục truyền vào
        /// </summary>
        /// <param name="categoryid"></param>
        public static void Category_Delete(string categoryid)
        {
            OleDbCommand cmd = new OleDbCommand("Category_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@categoryid", categoryid);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới danh mục vào bảng danh mục
        /// <summary>
        /// Phương thức thêm mới danh mục vào bảng danh mục
        /// </summary>
        /// <param name="categoryname"></param>
        /// <param name="avatar"></param>
        /// <param name="numorder"></param>
        /// <param name="categoryidfar"></param>
        /// <param name="ret"></param>
        public static void Category_Inser(string categoryname, string avatar, string numorder, string categoryidfar, string ret)
        {
            OleDbCommand cmd = new OleDbCommand("Category_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@categoryname", categoryname);
            cmd.Parameters.AddWithValue("@avatar", avatar);
            cmd.Parameters.AddWithValue("@numorder", numorder);
            cmd.Parameters.AddWithValue("@categoryidfar", categoryidfar);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một danh mục
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một danh mục
        /// </summary>
        /// <param name="categoryid"></param>
        /// <param name="categoryname"></param>
        /// <param name="avatar"></param>
        /// <param name="numorder"></param>
        /// <param name="categoryidfar"></param>
        public static void Category_Update(string categoryid, string categoryname, string avatar, string numorder, string categoryidfar)
        {
            OleDbCommand cmd = new OleDbCommand("Category_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@categoryid", categoryid);
            cmd.Parameters.AddWithValue("@categoryname", categoryname);
            cmd.Parameters.AddWithValue("@avatar", avatar);
            cmd.Parameters.AddWithValue("@numorder", numorder);
            cmd.Parameters.AddWithValue("@categoryidfar", categoryidfar);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả danh mục
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả danh mục
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_Category()
        {
            OleDbCommand cmd = new OleDbCommand("info_Category");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin danh mục theo id danh mục
        /// <summary>
        /// Phương thức lấy ra thông tin danh mục theo id danh mục
        /// <para name="categoryid">Mã của danh mục cần lấy thông tin</para>
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_Category_by_id(string categoryid)
        {
            OleDbCommand cmd = new OleDbCommand("info_Category_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@categoryid", categoryid);
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin danh mục theo id danh mục cha
        /// <summary>
        /// Phương thức lấy ra thông tin danh mục theo id danh mục cha
        /// <para name="categoryidfar">Mã danh mục cha cần lấy thông tin</para>
        /// Ví dụ truyền vào số 0 để lấy các danh mục cấp cao nhất
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_Category_by_categoryidfar(string categoryidfar)
        {
            OleDbCommand cmd = new OleDbCommand("info_Category_by_categoryidfar");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@categoryidfar", categoryidfar);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}