using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace abcompany
{
    /// <summary>
    /// Class thực hiện truy vấn liên quan đế bảng News
    /// </summary>
    public class News
    {
        #region Phương thức xóa tin tức theo mã tin tức truyền vào
        /// <summary>
        /// Phương thức xóa tin tức theo mã tin tức truyền vào
        /// </summary>
        /// <param name="NewsID">mã tin tức cần xóa</param>
        public static void News_Delete(string NewsID)
        {
            OleDbCommand cmd = new OleDbCommand("News_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NewsID", NewsID);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới một tin tức vào bảng tin tức
        /// <summary>
        /// Phương thức thêm mới một tin tức vào bảng tin tức
        /// </summary>
        /// <param name="Title"></param>
        /// <param name="Describe"></param>
        /// <param name="PostDate"></param>
        /// <param name="Views"></param>
        /// <param name="Detail"></param>
        /// <param name="NumOrder"></param>
        /// <param name="NewsCode"></param>
        public static void News_Inser(
            string Title, string Avatar, string Describe,
            string PostDate, string Views, string Detail,
            string NumOrder, string NewsCode)
        {
            OleDbCommand cmd = new OleDbCommand("News_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Title", Title);
            cmd.Parameters.AddWithValue("@Avatar", Avatar);
            cmd.Parameters.AddWithValue("@Describe", Describe);
            cmd.Parameters.AddWithValue("@PostDate", PostDate);
            cmd.Parameters.AddWithValue("@Views", Views);
            cmd.Parameters.AddWithValue("@Detail", Detail);

            cmd.Parameters.AddWithValue("@NumOrder", NumOrder);
            cmd.Parameters.AddWithValue("@NewsCode", NewsCode);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }

        #endregion

        #region  Phương thức chỉnh sửa thông tin một tin tức
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một tin tức
        /// </summary>
        /// <param name="NewsID"></param>
        /// <param name="Title"></param>
        /// <param name="Avatar"></param>
        /// <param name="Describe"></param>
        /// <param name="PostDate"></param>
        /// <param name="Views"></param>
        /// <param name="Detail"></param>
        /// <param name="NumOrder"></param>
        /// <param name="NewsCode"></param>
        public static void News_Update(string NewsID, string Title, string Avatar, string Describe, string PostDate, string Views, string Detail, string NumOrder, string NewsCode)
        {
            OleDbCommand cmd = new OleDbCommand("News_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NewsID", NewsID);
            cmd.Parameters.AddWithValue("@Title", Title);
            cmd.Parameters.AddWithValue("@Avatar", Avatar);
            cmd.Parameters.AddWithValue("@Describe", Describe);
            cmd.Parameters.AddWithValue("@PostDate", PostDate);
            cmd.Parameters.AddWithValue("@Views", Views);
            cmd.Parameters.AddWithValue("@Detail", Detail);

            cmd.Parameters.AddWithValue("@NumOrder", NumOrder);
            cmd.Parameters.AddWithValue("@NewsCode", NewsCode);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả tin tức
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả tin tức
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_News()
        {
            OleDbCommand cmd = new OleDbCommand("info_News");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra một tin tức theo id tin tức
        /// <summary>
        /// Phương thức lấy ra một tin tức theo id tin tức
        /// <para name="NewsID">Mã của Tin cần lấy thông tin</para>
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_News_by_id(string NewsID)
        {
            OleDbCommand cmd = new OleDbCommand("info_News_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NewsID", NewsID);
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Lấy danh sách tin tức theo mã danh mục - chỉ lấy 6 tin đầu
        public static DataTable Info_News_by_NewsCode(string NewsCode)
        {
            OleDbCommand cmd = new OleDbCommand("info_News_by_NewsCode");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NewsCode", NewsCode);
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Lấy danh sách tin tức theo mã danh mục - lấy tất cả tin
        public static DataTable Info_News_by_NewsCode_all(string NewsCode)
        {
            OleDbCommand cmd = new OleDbCommand("info_News_by_NewsCode_all");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NewsCode", NewsCode);
            return SQLDatabase.GetData(cmd);
        }
        #endregion


        #region Thủ tục cập nhật lượt xem tin tức
        public static void UpdateNewsView(string id)
        {
            OleDbCommand cmd = new OleDbCommand("UpdateNewsView");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion
    }
}
