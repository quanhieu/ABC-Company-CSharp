using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
namespace abcompany
{
    /// <summary>
    /// Class thực hiện truy vấn liên quan đế bảng Supply
    /// </summary>
    public class Supply
    {
        #region Phương thức xóa Supply
        /// Phương thức xóa Supply theo mã Supply truyền vào
        /// </summary>
        /// <param name="masp">mã Supply cần xóa</param>
        public static void Supply_Delete(string supplyid)
        {
            OleDbCommand cmd = new OleDbCommand("Supply_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@supplyid", supplyid);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới Supply vào bảng Supply
        /// <summary>
        /// Phương thức thêm mới Supply vào bảng Supply
        /// </summary>
        /// <param name="supplyname"></param>
        
        public static void Supply_Inser(string supplyname, string ret)
        {
            OleDbCommand cmd = new OleDbCommand("Supply_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@supplyname", supplyname);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một Supply
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một Supply
        /// </summary>
        /// <param name="supplyid"></param>
        /// <param name="supplyname"></param>
       
        public static void Supply_Update(string supplyid, string supplyname)
        {
            OleDbCommand cmd = new OleDbCommand("Supply_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@supplyid", supplyid);
            cmd.Parameters.AddWithValue("@supplyname", supplyname);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả Supply
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả Supply
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_Supply()
        {
            OleDbCommand cmd = new OleDbCommand("info_Supply");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin Supply theo id Supply
        /// <summary>
        /// Phương thức lấy ra thông tin Supply theo id Supply
        /// <para name="supplyid">Mã của Supply cần lấy thông tin</para>
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_Supply_by_id(string supplyid)
        {
            OleDbCommand cmd = new OleDbCommand("info_Supply_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@supplyid", supplyid);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
