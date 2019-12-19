using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;


namespace abcompany
{
    /// <summary>
    /// Summary description for Ads
    /// </summary>
    public class Ads
    {
        #region Phương thức xóa Ads theo mã Ads truyền vào
        /// <summary>
        /// Phương thức xóa Ads theo mã Ads truyền vào
        /// </summary>
        /// <param name="adsid">mã Ads cần xóa</param>
        public static void Ads_Delete(string adsid)
        {
            OleDbCommand cmd = new OleDbCommand("Ads_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@adsid", adsid);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới Ads vào bảng Ads
        /// <summary>
        /// Phương thức thêm mới Ads vào bảng Ads
        /// </summary>
        /// <param name="adsname"></param>
        /// <param name="typeads"></param>
        /// <param name="imageads"></param>
        /// <param name="link"></param>
        /// <param name="numorderads"></param>
        /// <param name="groupadsid"></param>
        /// <param name="ret"></param>
        public static void Ads_Inser(string adsname, string typeads, string imageads, 
            string link, string numorderads, string groupadsid, string ret)
        {
            OleDbCommand cmd = new OleDbCommand("Ads_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@adsname", adsname);
            cmd.Parameters.AddWithValue("@typeads", typeads);
            cmd.Parameters.AddWithValue("@imageads", imageads);
            cmd.Parameters.AddWithValue("@link", link);
            cmd.Parameters.AddWithValue("@numorderads", numorderads);

            cmd.Parameters.AddWithValue("@groupadsid", groupadsid);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một Quảng Cáo
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một Quảng Cáo
        /// </summary>
        /// <param name="adsid"></param>
        /// <param name="adsname"></param>
        /// <param name="typeads"></param>
        /// <param name="imageads"></param>
        /// <param name="link"></param>
        /// <param name="numorderads"></param>
        /// <param name="groupadsid"></param>
      
        public static void Ads_Update(string adsid,string adsname,string typeads,string imageads,string link,string numorderads,string groupadsid)
        {
            OleDbCommand cmd = new OleDbCommand("Ads_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@adsid", adsid);
            cmd.Parameters.AddWithValue("@adsname", adsname);
            cmd.Parameters.AddWithValue("@typeads", typeads);
            cmd.Parameters.AddWithValue("@imageads", imageads);
            cmd.Parameters.AddWithValue("@link", link);
            cmd.Parameters.AddWithValue("@numorderads", numorderads);

            cmd.Parameters.AddWithValue("@groupadsid", groupadsid);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả Ads
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả Ads
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_Ads()
        {
            OleDbCommand cmd = new OleDbCommand("info_Ads");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin quảng cáo theo id quảng cáo
        /// <summary>
        /// Phương thức lấy ra thông tin quảng cáo theo id quảng cáo
        /// <para name="adsid">Mã quảng cáo cần lấy thông tin</para>
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_Ads_by_id(string adsid)
        {
            OleDbCommand cmd = new OleDbCommand("info_Ads_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@adsid", adsid);
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra quảng cáo theo id của nhóm quảng cáo
        public static DataTable Info_Ads_by_GroupAdsID(string groupadsid)
        {
            OleDbCommand cmd = new OleDbCommand("info_Ads_by_GroupAdsID");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@groupadsid", groupadsid);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
