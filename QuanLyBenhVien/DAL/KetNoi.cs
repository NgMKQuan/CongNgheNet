using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBenhVien.DAL
{
    public class KetNoi
    {
        private string chuoiKetNoi = System.Configuration.ConfigurationManager.
    ConnectionStrings["QLBenhVienDb"].ConnectionString;

        private SqlConnection conn;
        public KetNoi()
        {
            conn = new SqlConnection(chuoiKetNoi);
        }

        public DataTable DocDuLieu(string sql)
        {
            DataTable ketQua = new DataTable();
            if (conn.State != ConnectionState.Open)
                conn.Open();
            string query = sql;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(ketQua);
            }
            catch (Exception)
            {
            }
            cmd.Dispose();
            conn.Close();
            da.Dispose();
            return ketQua;
        }

        public bool ThucThiLenh(string sql)
        {
            DataTable ketQua = new DataTable();
            if (conn.State != ConnectionState.Open)
                conn.Open();
            string query = sql;
            SqlCommand cmd = new SqlCommand(query, conn);
            bool result = false;
            try
            {
                result = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                result = false;
            }
            cmd.Dispose();
            conn.Close();
            return result;
        }

        public int ThucThiLenhLayKetQua(string sql)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            string query = sql;
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = -1;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    result = (int)reader.GetDecimal(0);
                }
            }
            catch (Exception)
            {

            }
            cmd.Dispose();
            conn.Close();
            return result;
        }

        public bool KiemTraTonTai(string sql)
        {
            bool result = false;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            string query = sql;
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                result = reader.HasRows;
            }
            catch (Exception)
            {
                result = false;
            }
            cmd.Dispose();
            conn.Close();
            return result;
        }
    }
}
