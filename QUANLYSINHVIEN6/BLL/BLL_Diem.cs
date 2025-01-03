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
        public class BLL_Diem
        {
            private static BLL_Diem instance;
            public static BLL_Diem Instance
            {
                get { if (instance == null) instance = new BLL_Diem(); return instance; }
                private set => instance = value;
            }
            private BLL_Diem() { }

            public DataTable DanhSach()
            {
                return DAL_Diem.Instance.DanhSach();
            }

            public bool Them(string MaSV, string MaMH, int PhanTramTrenLop, int PhanTramThi, float DiemLop, float DiemTB, string Loai, int NamHoc)
            {
                return DAL_Diem.Instance.Them(MaSV, MaMH, PhanTramTrenLop, PhanTramThi, DiemLop, DiemTB, Loai, NamHoc);
            }

            public bool Sua(string MaSV, string MaMH, int PhanTramTrenLop, int PhanTramThi, float DiemLop, float DiemTB, string Loai, int NamHoc, int id)
            {
                return DAL_Diem.Instance.Sua(MaSV, MaMH, PhanTramTrenLop, PhanTramThi, DiemLop, DiemTB, Loai, NamHoc, id);
            }

            public bool Xoa(int id)
            {
                return DAL_Khoa.Instance.Xoa(id);

            }
        }
    }
}
