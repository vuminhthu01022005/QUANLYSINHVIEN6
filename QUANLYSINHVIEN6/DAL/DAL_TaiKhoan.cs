﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSINHVIEN6.DAL
{
    internal class DAL_TaiKhoan
    {
        private static DAL_TaiKhoan instance; // ctr + r + e
        public static DAL_TaiKhoan Instace
        {
            get { if (instance == null) instance = new DAL_TaiKhoan(); return instance; }
            private set => instance = value;
        }
        private DAL_TaiKhoan() { }
        public bool Them(string ten, string matkhau, stringQƯ loai)
        {
            string sql = "insert into TaiKhoan(TenDangNhap, MatKhau, LoaiTaiKhoan) values( @TenDangNhap, @MatKhau, @LoaiTaiKhoan )";
            return KetNoi.Instace.ExcuteNonQuery(sql, new object[] { ten, matkhau, loai });
        }
        public bool Sua_Het(string ten, string matkhau, string loai, int id)
        {
            string sql = "update TaiKhoan set TenDangNhap = @TenDangNhap , MatKhau = @MatKhau , LoaiTaiKhoan = @LoaiTaiKhoan where id = @id";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { ten, matkhau, loai, id });
        }
        public bool KhongSuaMatKhau(string ten, string loai, int id)
        {
            string sql = "update TaiKhoan set TenDangNhap = @TenDangNhap , LoaiTaiKhoan = @LoaiTaiKhoan where id = @id";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { ten, loai, id });
        }
        public bool Xoa(int id)
        {
            string sql = "delete from TaiKhoan where id = @id)";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { id });
        }
        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExcuteQuery("select * from TaiKhoan");

        }
        public DataTable DangNhap(string ten, string matkhau)
        {
            string sql = "select * from TaiKhoan where TenDangNhap = @TenDangNhap and MatKhau = @MatKhau";
            return KetNoi.Instance.ExcuteQuery(sql, new object[] { ten, matkhau });

        }
    }
}

