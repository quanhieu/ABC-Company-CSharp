using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace abcompany
{
    /// <summary>
    /// Summary description for GroupAds
    /// </summary>
    public class GroupAds
    {
        #region Phương thức xóa GroupAds theo mã GroupAds truyền vào
        /// <summary>
        /// Phương thức xóa GroupAds theo mã GroupAds truyền vào
        /// </summary>
        /// <param name="groupadsid"></param>
        public static void GroupAds_Delete(string groupadsid)
        {
            OleDbCommand cmd = new OleDbCommand("GroupAds_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@groupadsid", groupadsid);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới GroupAds vào GroupAds
        /// <summary>
        /// Phương thức thêm mới GroupAds vào GroupAds
        /// </summary>
        /// <param name="groupadsname"></param>
        /// <param name="locationga"></param>
        /// <param name="numorderga"></param>
        /// <param name="avatarga"></param>
        /// <param name="ret"></param>
        public static void GroupAds_Inser(string groupadsname,string locationga,string numorderga,string avatarga, string ret)
        {
            OleDbCommand cmd = new OleDbCommand("GroupAds_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@groupadsname", groupadsname);
            cmd.Parameters.AddWithValue("@locationga", locationga);
            cmd.Parameters.AddWithValue("@numorderga", numorderga);
            cmd.Parameters.AddWithValue("@avatarga", avatarga);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một GroupAds
        /// <summary>
        ///  Phương thức chỉnh sửa thông tin một GroupAds
        /// </summary>
        /// <param name="groupadsid"></param>
        /// <param name="groupadsname"></param>
        /// <param name="locationga"></param>
        /// <param name="numorderga"></param>
        /// <param name="avatarga"></param>
        public static void GroupAds_Update(string groupadsid,string groupadsname,string locationga,string numorderga,string avatarga)
        {
            OleDbCommand cmd = new OleDbCommand("GroupAds_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@groupadsid", groupadsid);
            cmd.Parameters.AddWithValue("@groupadsname", groupadsname);
            cmd.Parameters.AddWithValue("@locationga", locationga);
            cmd.Parameters.AddWithValue("@numorderga", numorderga);
            cmd.Parameters.AddWithValue("@avatarga", avatarga);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả GroupAds
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả GroupAds
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_GroupAds()
        {
            OleDbCommand cmd = new OleDbCommand("info_GroupAds");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin nhóm quảng cáo theo id nhóm quảng cáo
        /// <summary>
        /// Phương thức lấy ra thông tin nhóm quảng cáo theo id nhóm quảng cáo
        /// <para name="groupadsid">Mã của nhóm quảng cáo cần lấy thông tin</para>
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_GroupAds_by_id(string groupadsid)
        {
            OleDbCommand cmd = new OleDbCommand("info_GroupAds_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@groupadsid", groupadsid);
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra nhóm quảng cáo theo vị trí
        public static DataTable Info_GroupAds_by_locationga(string locationga)
        {
            OleDbCommand cmd = new OleDbCommand("info_GroupAds_by_locationga");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@locationga", locationga);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
