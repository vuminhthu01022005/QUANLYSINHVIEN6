using QUANLYSINHVIEN6.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSINHVIEN6.BLL
{
    internal class BLL_HocBong
    {
        BLL_HocBong = new BLL_HocBong();
    }
    public DataTable GetAllHocBong()
    {
        return DAL_HocBong.GetAllHocBong();
    }
    public bool Them(string MaSV, string TenSV, string LoaiHB, string DieuKien)
    {
        if (string.IsNullOrEmpty(MaSV) || string.IsNullOrEmpty(TenSV) || string.IsNullOrEmpty(LoaiHB) || string.IsNullOrEmpty(DieuKien))
            return false;
        return dalHocBong.Them(MaSV, TenSV, LoaiHB, DieuKien);
    }
    public bool Sua(string MaSV, string TenSV, string LoaiHB, string DieuKien)
    {
        if (string.IsNullOrEmpty(MaSV) || string.IsNullOrEmpty(TenSV) || string.IsNullOrEmpty(LoaiHB) || string.IsNullOrEmpty(DieuKien))
            return false;
        return dalHocBong.Sua(MaSV, TenSV, LoaiHB, DieuKien);
    }
    public bool Xoa(string MaSV, string TenSV, string LoaiHB, string DieuKien)
    {
        if (string.IsNullOrEmpty(MaSV) || string.IsNullOrEmpty(TenSV) || string.IsNullOrEmpty(LoaiHB) || string.IsNullOrEmpty(DieuKien))
            return false;
        return dalHocBong.Xoa(MaSV, TenSV, LoaiHB, DieuKien);
    }
    public bool Lammoi(string MaSV, string TenSV, string LoaiHB, string DieuKien)
    {
        if (string.IsNullOrEmpty(MaSV) || string.IsNullOrEmpty(TenSV) || string.IsNullOrEmpty(LoaiHB) || string.IsNullOrEmpty(DieuKien))
            return false;
        return dalHocBong.Lammoi(MaSV, TenSV, LoaiHB, DieuKien);
    }
}

