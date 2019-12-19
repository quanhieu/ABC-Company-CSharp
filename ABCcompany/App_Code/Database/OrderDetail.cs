using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace abcompany
{
    /// <summary>
    /// Summary description for OrderDetail
    /// </summary>
    public class OrderDetail
    {
        #region Phương thức xóa chi tiết đơn đặt hàng theo mã sản phẩm và mã đơn đặt hàng
        /// <summary>
        /// Phương thức xóa chi tiết đơn đặt hàng theo mã sản phẩm và mã đơn đặt hàng
        /// </summary>
        /// <param name="productid"></param>
        /// <param name="orderid"></param>
        public static void OrderDetail_Delete(string productid, string orderid)
        {
            OleDbCommand cmd = new OleDbCommand("OrderDetail_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@productid", productid);
            cmd.Parameters.AddWithValue("@orderid", orderid);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới chi tiết đơn đặt hàng vào bảng chi tiết đơn đặt hàng
       /// <summary>
        /// Phương thức thêm mới chi tiết đơn đặt hàng vào bảng chi tiết đơn đặt hàng
       /// </summary>
       /// <param name="productid"></param>
       /// <param name="orderid"></param>
       /// <param name="quantityorder"></param>
       /// <param name="priceorder"></param>
       /// <param name="ret"></param>
        public static void OrderDetail_Inser(string productid,string orderid,string quantityorder,string priceorder, string ret)
        {
            OleDbCommand cmd = new OleDbCommand("OrderDetail_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@productid", productid);
            cmd.Parameters.AddWithValue("@orderid", orderid);
            cmd.Parameters.AddWithValue("@quantityorder", quantityorder);
            cmd.Parameters.AddWithValue("@priceorder", priceorder);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một chi tiết đơn hàng
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một chi tiết đơn hàng
        /// </summary>
        /// <param name="productid"></param>
        /// <param name="orderid"></param>
        /// <param name="quantityorder"></param>
        /// <param name="priceorder"></param>
        public static void OrderDetail_Update(string productid, string orderid, string quantityorder, string priceorder)
        {
            OleDbCommand cmd = new OleDbCommand("OrderDetail_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@productid", productid);
            cmd.Parameters.AddWithValue("@orderid", orderid);
            cmd.Parameters.AddWithValue("@quantityorder", quantityorder);
            cmd.Parameters.AddWithValue("@priceorder", priceorder);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả các chi tiết đơn đặt hàng
        /// <summary>
        ///  Phương thức lấy ra danh sách tất cả các chi tiết đơn đặt hàng
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_OrderDetail()
        {
            OleDbCommand cmd = new OleDbCommand("info_OrderDetail");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra danh sách tất cả các chi tiết đơn đặt hàng theo mã đơn hàng
        /// <summary>
        ///  Phương thức lấy ra danh sách tất cả các chi tiết đơn đặt hàng theo mã đơn hàng
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_OrderDetail_by_Orderid(string orderid)
        {
            OleDbCommand cmd = new OleDbCommand("info_OrderDetail_by_Orderid");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@orderid", orderid);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
