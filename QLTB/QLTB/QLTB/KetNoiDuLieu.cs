using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//thu vien
using System.Data;
using System.Data.SqlClient;

namespace QLTB
{
     class KetNoiDuLieu
    {
        public SqlConnection ketnoi;
        public SqlDataAdapter docghi;
        public SqlCommand lenh;
        public SqlCommandBuilder capnhat;

        public KetNoiDuLieu()
        {
            ketnoi = new SqlConnection();
            string chuoiketnoi = "Data Source=DESKTOP-Q2CQI0V\\SQLEXPRESS;Initial Catalog=QLTB4;Integrated Security=true";
            ketnoi.ConnectionString = chuoiketnoi;
        }

        public DataTable DocDuLieu(string sql)
        {
            ketnoi.Open();
            docghi = new SqlDataAdapter(sql, ketnoi);
            DataTable bangtam = new DataTable();
            docghi.Fill(bangtam);
            ketnoi.Close();

            return bangtam;
        }

        public void ThaoTacDuLieu(string sql) // danh cho cau lenh insert/update/delete
        {
            ketnoi.Open();
            lenh = new SqlCommand(sql, ketnoi);
            lenh.ExecuteNonQuery();
            ketnoi.Close() ;
        }

        public void CapNhatDuLieu(SqlDataAdapter bdg, DataTable dt) // khong can cau lenh insert/update/delete
        {
            capnhat = new SqlCommandBuilder(bdg);
            bdg.Update(dt);
        }
    }
}
