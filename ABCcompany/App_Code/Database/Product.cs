using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
//using System.Linq;
using System.Web;

namespace abcompany
{
    /// <summary>
    /// Class thuc hien cac truy van lien quan den bang SAN PHAM
    /// </summary>
    public class Product
    {

        #region Phuong thuc xoa san pham theo ma san pham duoc truyen vao
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productid">Ma san pham can xoa</param>
        public static void Products_delete(string productid)
        {
            OleDbCommand cmd = new OleDbCommand("Products_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@productid", productid);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Thuc hien them moi du lieu vao bang san pham
        /// <summary>
        /// Thuc hien them moi du lieu vao bang san pham
        /// </summary>
        /// <param name="productname"></param>
        /// <param name="statusid"></param>
        /// <param name="supplyid"></param>

        /// <param name="imagep"></param>
        /// <param name="quantityp"></param>
        /// <param name="pricep"></param>
        /// <param name="describep"></param>
        /// <param name="datecreated"></param>
        /// <param name="datecancel"></param>
        /// <param name="categoryid"></param>
        /// <param name="groupid"></param>
        /// <param name="ret"></param>
        public static void Products_Inser(string productname, string statusid, string supplyid, string imagep, string quantityp, string pricep, string describep, string datecreated, string datecancel, string categoryid, string groupid, string ret)
        {
            OleDbCommand cmd = new OleDbCommand("Products_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@productname", productname);
            cmd.Parameters.AddWithValue("@statusid", statusid);
            cmd.Parameters.AddWithValue("@supplyid", supplyid);
            cmd.Parameters.AddWithValue("@imagep", imagep);

            cmd.Parameters.AddWithValue("@quantityp", quantityp);
            cmd.Parameters.AddWithValue("@pricep", pricep);
            cmd.Parameters.AddWithValue("@describep", describep);
            cmd.Parameters.AddWithValue("@datecreated", datecreated);
            cmd.Parameters.AddWithValue("@datecancel", datecancel);

            cmd.Parameters.AddWithValue("@categoryid", categoryid);
            cmd.Parameters.AddWithValue("@groupid", groupid);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phuong thuc cap nhat thong tin san pham
        /// <summary>
        /// Phuong thuc cap nhat thong tin san pham
        /// </summary>
        /// <param name="productid"></param>
        /// <param name="productname"></param>
        /// <param name="statusid"></param>
        /// <param name="supplyid"></param>

        /// <param name="imagep"></param>
        /// <param name="quantityp"></param>
        /// <param name="pricep"></param>
        /// <param name="describep"></param>
        /// <param name="datecreated"></param>
        /// <param name="datecancel"></param>
        /// <param name="categoryid"></param>
        /// <param name="groupid"></param>
        public static void Products_Update(string productid, string productname, string statusid, string supplyid, string imagep, string quantityp, string pricep, string describep,
            string datecreated, string datecancel, string categoryid, string groupid)
        {
            OleDbCommand cmd = new OleDbCommand("Products_update");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("productid", productid);
            cmd.Parameters.AddWithValue("productname", productname);
            cmd.Parameters.AddWithValue("statusid", statusid);
            cmd.Parameters.AddWithValue("supplyid", supplyid);
           
            cmd.Parameters.AddWithValue("imagep", imagep);
            cmd.Parameters.AddWithValue("quantityp", quantityp);
            cmd.Parameters.AddWithValue("pricep", pricep);
            cmd.Parameters.AddWithValue("describep", describep);
            cmd.Parameters.AddWithValue("datecreated", datecreated);
            cmd.Parameters.AddWithValue("datecancel", datecancel);
            cmd.Parameters.AddWithValue("categoryid", categoryid);
            cmd.Parameters.AddWithValue("groupid", groupid);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phuong thuc lay ra danh sach tat ca san pham
        /// <summary>
        /// Phuong thuc lay ra danh sach tat ca san pham
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_Products()
        {
            OleDbCommand cmd = new OleDbCommand("info_Products");
            cmd.CommandType = CommandType.StoredProcedure;


            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra sản phẩm theo ID sản phẩm
        /// <summary>
        /// Phương thức lấy ra thông tin sản phẩm theo mã sản phẩm
        /// </summary>
        /// <param name="productid"></param>
        /// <returns></returns>
        public static DataTable Info_Products_by_id(string productid)
        {
            OleDbCommand cmd = new OleDbCommand("info_Products_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@productid", productid);

            return SQLDatabase.GetData(cmd);
        }
        #endregion


        #region Lấy danh sách sản phẩm theo nhóm id
        public static DataTable Info_Products_by_GroupID(string groupid, string NumShow)
        {
            OleDbCommand cmd = new OleDbCommand("info_Products_by_GroupID1");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@groupid", groupid);
            cmd.Parameters.AddWithValue("@NumShow", NumShow);

            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Lấy danh sách sản phẩm theo mã danh mục - chỉ lấy 3 sản phẩm đầu
        public static DataTable Info_Products_by_CategoryID(string categoryid)
        {
            OleDbCommand cmd = new OleDbCommand("info_Products_by_CategoryID");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@categoryid", categoryid);


            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Lấy danh sách sản phẩm theo mã danh mục - lấy tất cả sản phẩm trong 1 danh mục
        public static DataTable Info_Products_by_CategoryID_all(string categoryid)
        {
            OleDbCommand cmd = new OleDbCommand("info_Products_by_CategoryID_all");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@categoryid", categoryid);


            return SQLDatabase.GetData(cmd);
        }
        #endregion


        #region Lấy sản phẩm theo keyword
        public static DataTable Info_Products_by_keyword(string KeyWord)
        {
            OleDbCommand cmd = new OleDbCommand("info_Products_by_keyword");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@KeyWord", KeyWord);

            return SQLDatabase.GetData(cmd);
        }
        #endregion


        #region Phuong thuc sort price product 
        /// <summary>
        ///  money  >   PriceP
        ///   PriceP < money
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public static DataTable Info_Products_by_sort(string money)
        {
            OleDbCommand cmd = new OleDbCommand("info_Products_by_sort");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@money", money);

            return SQLDatabase.GetData(cmd);
        }
        /// <summary>
        /// 0 - 300
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_Products_by_sort1()
        {
            OleDbCommand cmd = new OleDbCommand("info_Products_by_sort1");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQLDatabase.GetData(cmd);
        }

        /// <summary>
        /// 300 - 800
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_Products_by_sort2()
        {
            OleDbCommand cmd = new OleDbCommand("info_Products_by_sort2");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQLDatabase.GetData(cmd);
        }

        /// <summary>
        /// 800 - 2000
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_Products_by_sort3()
        {
            OleDbCommand cmd = new OleDbCommand("info_Products_by_sort3");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQLDatabase.GetData(cmd);
        }

        /// <summary>
        /// more 2000
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_Products_by_sort4()
        {
            OleDbCommand cmd = new OleDbCommand("info_Products_by_sort4");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQLDatabase.GetData(cmd);
        }
        #endregion

    }

}
