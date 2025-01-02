using QUANLYSINHVIEN6.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSINHVIEN6.BLL
{
    internal class BLL_Diem
    {
        private static DAL_Diem instance;
        public static DAL_Diem Instance
        {
            get { if (instance == null) instance = new DAL_Diem(); return instance; }
            private set => instance = value;
        }
        private DAL_Diem() { }
        public bool Them(string MaSV, string MaMH, int PhanTramTrenLop, int PhanTramThi, float DiemLop, float DiemTB, string Loai, int NamHoc)
        {
            string sql = "insert into Diem(MaSV, MaMH, PhanTramTrenLop, PhanTramThi, DiemTrenLop, DiemThi, DiemTB, Loai, NamHoc) values (@MaSV , @MaMH , @PhanTramTrenLop , @PhanTramThi , @DiemTrenLop , @DiemThi , @DiemTB , @Loai , @NamHoc )";

            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { MaSV, MaMH, PhanTramTrenLop, PhanTramThi, DiemTrenLop, DiemThi, DiemTB, Loai, NamHoc });
        }
        public bool Sua(string MaSV, string MaMH, int PhanTramTrenLop, int PhanTramThi, float DiemLop, float DiemTB, string Loai, int NamHoc, int id)
        {
            string sql = "update Diem set MaSV = @MaSV , MaMH  = @MaMH , PhanTramTrenLop = @PhanTramTrenLop , PhanTramThi = @PhanTramThi , DiemTrenLop =@DiemTrenLop , DiemThi = @DiemThi , DiemTB = @DiemTB , Loai = @Loai , NamHoc = @NamHoc , where id = @id";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { MaSV, MaMH, PhanTramTrenLop, PhanTramThi, DiemTrenLop, DiemThi, DiemTB, Loai, NamHoc, id });
        }
        public bool Xoa(int id)
        {
            string sql = "delete from Diem  where id = @id";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { id });
        }
        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExcuteNonQuery("select * from Diem");
        }
    }
}
