using QUANLYSINHVIEN6.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static QUANLYSINHVIEN6.BLL.BLL_Sinhvien;

namespace QUANLYSINHVIEN6.BLL
{
    public class BLL_Sinhvien
    {

        public class BLL_SinhVien
        {
            private static BLL_SinhVien Instance;
            public static BLL_SinhVien Instance
            {
                get { if (Instance == null) Instance = new BLL_SinhVien(); return Instance; }
                private set => Instance = value;
            }
            private BLL_SinhVien() { }

            public DataTable DanhSach()
            {
                return DAL_SinhVien.Instance.DanhSach();
            }
            public bool Them(string MaSV, string TenSV, string NgaySinh, string GioiTinh, string QueQuan, string NgayNhapHoc, string MaLop, string MaKhoa, string MaCVHT)
            {
                return DAL_SinhVien.Instance.Them(MaSV, TenSV, GioiTinh, QueQuan, NgayNhapHoc, MaLop, MaKhoa, MaCVHT);
            }


            public bool Sua(string MaSV, string TenSV, string NgaySinh, string QueQuan, string NgayNhapHoc, string MaLop, string MaKhoa, string MaCVHT, int id)
            {


                return DAL_SinhVien.Instance.Sua(MaSV, TenSV, GioiTinh, QueQuan, NgayNhapHoc, MaLop, MaKhoa, MaCVHT, id);
            }

            public bool Xoa(int id)
            {
                string sql = "delete from SinhVien where id = @id";
                return DAL_SinhVien.Instance.Xoa(id);
            }
        }
    }
}
