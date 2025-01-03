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

        private static BLL_SinhVien instance;
        public static BLL_SinhVien Instance
        {
            get { if (instance == null) instance = new BLL_SinhVien(); return instance; }
            private set => instance = value;
        }
        private BLL_SinhVien() { }

        public DataTable DanhSach()
        {
            return BLL_Khoa.Instance.DanhSach();
        }

        public bool Them(string makhoa, string tenkhoa)
        {
            return BLL_Khoa.Instance.Them(makhoa, tenkhoa);
        }

        public bool Sua(string makhoa, string tenkhoa, int id)
        {
            return BLL_Khoa.Instance.Sua(makhoa, tenkhoa, id);
        }

        public bool Xoa(int id)
        {
            return BLL_Khoa.Instance.Xoa(id);
        }
    }
}
