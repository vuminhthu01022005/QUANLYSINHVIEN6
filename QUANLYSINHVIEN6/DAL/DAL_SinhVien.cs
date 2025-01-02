using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSINHVIEN6.DAL
{
  
        public class DAL_SinhVien
        {
            private static DAL_SinhVien instance;
            public static DAL_SinhVien Instance
            {
                get { if (instance == null) instance = new DAL_SinhVien(); return instance; }
                private set => instance = value;
            }
            private DAL_SinhVien() { }
            public bool Them(string MaSV, string TenSV, string NgaySinh, string GioiTinh, string QueQuan, string NgayNhapHoc, string MaLop, string MaKhoa, string MaCVHT)
            {
                string sql = "insert into SinhVien(MaSV, TenSV, NgaySinh, GioiTinh, QueQuan, NgayNhapHoc, MaLop, MaKhoa, MaCVHT) values( @MaSV, @TenSV, @NgaySinh, @GioiTinh, @QueQuan, @NgayNhapHoc, @MaLop, @MaKhoa, @MaCVHT)";



                return KetNoi.Instance.ExcuteNonQuerry(sql, new object[] { MaSV, TenSV, NgaySinh, GioiTinh, QueQuan, NgayNhapHoc, MaLop, MaKhoa, MaCVHT });

            }
            public bool Sua(string MaSV, string TenSV, string NgaySinh, string QueQuan, string NgayNhapHoc, string MaLop, string MaKhoa, string MaCVHT, int id)
            {

                string sql = "update SinhVien set MaSV = @MaSV, TenSV = @TenSV , NgaySinh = @NgaySinh , GioiTinh = @GioiTinh , QueQuan = @QueQuan , NgayNhapHoc = @NgayNhapHoc , MaLop = @MaLop , MaKhoa = @MaKhoa , MaCVHT = @MaCVHT where id = @id";
                return KetNoi..Instance.ExcuteNonQuerry(sql, new object[] { MaSV, TenSV, GioiTinh, QueQuan, NgayNhapHoc, MaLop, MaKhoa, MaCVHT, id });
            }
            public bool Xoa(int id)
            {
                string sql = "delete from SinhVien where id = @id";
                return KetNoi.Instance.ExcuteNonQuerry(sql, new object[] { id });
            }
            public frmQUANLYSINHVIEN()
            {
                InitializeComponent();
            }

            private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
            {
                return KetNoi.Instance.ExcuteNonQuerry("select * from SinhVien");

            }
        }
    }

