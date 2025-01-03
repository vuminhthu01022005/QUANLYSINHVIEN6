using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSINHVIEN6.BLL
{
    internal class BLL_HocPhi
    {
        public BLL_HocPhi()
        {
            DAL_HocPhi = new DAL_HocPhi();
        }

        public DataTable GetAllHocPhi()
        {
            return DAL_HocPhi.GetAllHocPhi();
        }

        public bool Them(string MaSV, string MaHP, float HocPhi, DateTime NgayThanhToan)
        {
            if (string.IsNullOrEmpty(MaSV) || string.IsNullOrEmpty(MaHP) || HocPhi < 0)
                return false;
            return DAL_HocPhi.Them(MaSV, MaHP, HocPhi, NgayThanhToan);
        }

        public bool Sua(string MaSV, string MaHP, float HocPhi, DateTime NgayThanhToan)
        {
            if (string.IsNullOrEmpty(MaSV) || string.IsNullOrEmpty(MaHP) || HocPhi < 0)
                return false;
            return DAL_HocPhi.Sua(MaSV, MaHP, HocPhi, NgayThanhToan);
        }

        public bool Xoa(string MaSV, string MaHP)
        {
            if (string.IsNullOrEmpty(MaSV) || string.IsNullOrEmpty(MaHP))
                return false;
            return DAL_HocPhi.Xoa(MaSV, MaHP);
        }
        public bool Lammoi(string MaSV, string MaHP, float HocPhi, DateTime NgayThanhToan)
        {
            if (string.IsNullOrEmpty(MaSV) || string.IsNullOrEmpty(MaHP) || HocPhi < 0)
                return false;
            return DAL_HocPhi.Lammoi(MaSV, MaHP, HocPhi, NgayThanhToan);

        }
    }
}

