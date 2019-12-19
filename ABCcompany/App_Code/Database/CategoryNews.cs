using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace abcompany
{
    /// <summary>
    /// Class thực hiện truy vấn liên quan đế bảng Danh mục tin
    /// </summary>
    public class CategoryNews
    {
        #region Phương thức xóa danh mục tin theo mã danh mục tin truyền vào
        /// <summary>
        /// Phương thức xóa danh mục theo mã danh mục truyền vào
        /// </summary>
        /// <param name="newscode"></param>
        public static void CategoryNews_Delete(string newscode)
        {
            OleDbCommand cmd = new OleDbCommand("CategoryNews_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@newscode", newscode);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới danh mục tin vào bảng danh mục tin
        /// <summary>
        /// Phương thức thêm mới danh mục vào bảng danh mục tin
        /// </summary>
        /// <param name="newsname"></param>
        /// <param name="avatar"></param>
        /// <param name="numorder"></param>
        /// <param name="newscodefar"></param>
        /// <param name="ret"></param>
        public static void CategoryNews_Inser(string newsname, string avatar, string numorder, string newscodefar, string ret)
        {
            OleDbCommand cmd = new OleDbCommand("CategoryNews_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@newsname", newsname);
            cmd.Parameters.AddWithValue("@avatar", avatar);
            cmd.Parameters.AddWithValue("@numorder", numorder);
            cmd.Parameters.AddWithValue("@newscodefar", newscodefar);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một danh mục tin
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một danh mục tin
        /// </summary>
        /// <param name="newscode"></param>
        /// <param name="newsname"></param>
        /// <param name="avatar"></param>
        /// <param name="numorder"></param>
        /// <param name="newscodefar"></param>
        public static void CategoryNews_Update(string newscode, string newsname, string avatar, string numorder, string newscodefar)
        {
            OleDbCommand cmd = new OleDbCommand("CategoryNews_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@newscode", newscode);
            cmd.Parameters.AddWithValue("@newsname", newsname);
            cmd.Parameters.AddWithValue("@avatar", avatar);
            cmd.Parameters.AddWithValue("@numorder", numorder);
            cmd.Parameters.AddWithValue("@newscodefar", newscodefar);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả danh mục tin
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả danh mục
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_CategoryNews()
        {
            OleDbCommand cmd = new OleDbCommand("info_CategoryNews");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin danh mục tin theo id danh mục tin
        /// <summary>
        /// Phương thức lấy ra thông tin danh mục theo id danh mục tin
        /// <para name="newscode">Mã của danh mục tin cần lấy thông tin</para>
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_CategoryNews_by_id(string newscode)
        {
            OleDbCommand cmd = new OleDbCommand("info_CategoryNews_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@newscode", newscode);
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin danh mục tin theo id danh mục cha
        /// <summary>
        /// Phương thức lấy ra thông tin danh mục tin theo id danh mục cha
        /// <para name="newscodefar">Mã danh mục cha cần lấy thông tin</para>
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_CategoryNews_by_newscodefar(string newscodefar)
        {
            OleDbCommand cmd = new OleDbCommand("info_CategoryNews_by_newscodefar");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@newscodefar", newscodefar);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
