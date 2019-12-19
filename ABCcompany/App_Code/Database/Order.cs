using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace abcompany
{
    /// <summary>
    /// Summary description for Order
    /// </summary>
    public class Order
    {
        #region Phương thức xóa đơn đặt hàng theo mã đơn đặt hàng truyền vào
        /// <summary>
        /// Phương thức xóa đơn đặt hàng theo mã đơn đặt hàng truyền vào
        /// </summary>
        /// <param name="orderid"></param>
        public static void Order_Delete(string orderid)
        {
            OleDbCommand cmd = new OleDbCommand("Order_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@orderid", orderid);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới đơn đặt hàng vào bảng đơn đặt hàng
        /// <summary>
        ///  Phương thức thêm mới đơn đặt hàng vào bảng đơn đặt hàng
        /// </summary>
        /// <param name="datecreated"></param>
        /// <param name="ordermoney"></param>
        /// <param name="orderpay"></param>
        /// <param name="customerid"></param>
        /// <param name="customerna"></param>
        /// <param name="callnumcus"></param>
        /// <param name="emailcus"></param> 
        /// <param name="orderdetail"></param>
        /// <param name="ret"></param>
        public static void Order_Inser(string datecreated, string ordermoney, string orderpay, string customerid, string customerna, string callnumcus, string emailcus, string orderdetail, string ret)
        {
            OleDbCommand cmd = new OleDbCommand("Order_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@datecreated", datecreated);
            cmd.Parameters.AddWithValue("@ordermoney", ordermoney);
            cmd.Parameters.AddWithValue("@orderpay", orderpay);
            cmd.Parameters.AddWithValue("@customerid", customerid);
            cmd.Parameters.AddWithValue("@customerna", customerna);

            cmd.Parameters.AddWithValue("@callnumcus", callnumcus);
            cmd.Parameters.AddWithValue("@emailcus", emailcus);
            cmd.Parameters.AddWithValue("@orderdetail", orderdetail);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một đơn đặt hàng
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một đơn đặt hàng
        /// </summary>
        /// <param name="orderid"></param>
        /// <param name="datecreated"></param>
        /// <param name="ordermoney"></param>
        /// <param name="orderpay"></param>
        /// <param name="customerid"></param>
        /// <param name="customerna"></param>
        /// <param name="callnumcus"></param>
        /// <param name="emailcus"></param>
        public static void Order_Update(string orderid, string datecreated, string ordermoney, string orderpay, string customerid, string customerna, string callnumcus, string emailcus, string orderdetail)
        {
            OleDbCommand cmd = new OleDbCommand("Order_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@orderid", orderid);
            cmd.Parameters.AddWithValue("@datecreated", datecreated);
            cmd.Parameters.AddWithValue("@ordermoney", ordermoney);
            cmd.Parameters.AddWithValue("@orderpay", orderpay);
            cmd.Parameters.AddWithValue("@customerid", customerid);
            cmd.Parameters.AddWithValue("@customerna", customerna);

            cmd.Parameters.AddWithValue("@callnumcus", callnumcus);
            cmd.Parameters.AddWithValue("@emailcus", emailcus);
            cmd.Parameters.AddWithValue("@orderdetail", orderdetail);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả đơn đặt hàng
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả đơn đặt hàng
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_Order()
        {
            OleDbCommand cmd = new OleDbCommand("info_Order");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }


        /// <summary>
        /// Lấy ra thông tin đơn đặt hàng theo mã
        /// </summary>
        /// <param name="orderid"></param>
        /// <returns></returns>
        public static DataTable Info_Order_by_id(string orderid)
        {
            OleDbCommand cmd = new OleDbCommand("info_Order_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@orderid", orderid);
            return SQLDatabase.GetData(cmd);
        }


        public static DataTable Info_Order_by_OrderPay(string orderpay)
        {
            OleDbCommand cmd = new OleDbCommand("info_Order_by_OrderPay");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@orderpay", orderpay);
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra danh sách tất cả đơn đặt hàng từ mới tới cũ
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả đơn đặt hàng từ mới tới cũ
        /// </summary>
        /// <returns></returns>
        public static DataTable Info_Order_Desc()
        {
            OleDbCommand cmd = new OleDbCommand("info_Order_desc");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}
