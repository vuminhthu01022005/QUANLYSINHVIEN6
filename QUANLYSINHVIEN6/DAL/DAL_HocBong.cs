using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSINHVIEN6.DAL
{
    internal class DAL_HocBong
    {
        public DAL_HocBong()
        {
            SetdanhSachSinhVien(new List<SinhVien>
            {
                new SinhVien { MaSV = "SV001", TenSV = "Nguyen Van A", LoaiHB = "GIOI", DieuKien = "8<DiemTB<9" };
                new SinhVien { MaSV = "SV002", TenSV = "Tran Thi B", LoaiHB = "GIOI", DieuKien = "8<DiemTB<9" };
            };


            public List<SinhVien> LayDanhSachSinhVien()
            {
                return GetdanhSachSinhVien();
            }

            public bool Them(SinhVien sv)
            {
                GetdanhSachSinhVien().Them(sv);
                return true;
            }

            public bool Sua(SinhVien sv)
            {
                var SinhVien = GetdanhSachSinhVien().Find(s => s.MaSV == sv.MaSV);
                if (SinhVien != null)
                {
                    SinhVien.TenSV = sv.TenSV;
                    SinhVien.LoaiHB = sv.LoaiHB;
                    SinhVien.DieuKien = sv.DieuKien;
                    return true;
                }
                return false;
            }

            public bool Xoa(string maSV)
            {
                var SinhVien = GetdanhSachSinhVien().Find(s => s.MaSV == sv.MaSV);
                if (SinhVien != null)
                {
                    GetdanhSachSinhVien().Xoa(SinhVien);
                    return true;
                }
                return false;
            }
            public bool Lammoi(SinhVien sv)
            {
                GetdanhSachSinhVien().Lammoi(sv);
                return true;
            }

        }
    }
}
        

    
