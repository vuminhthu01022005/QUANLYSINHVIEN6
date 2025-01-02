﻿using QUANLYSINHVIEN6.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYSINHVIEN6.GUI
{
    public partial class fQuanLyKhoa : Form
    {
        public fQuanLyKhoa()
        {
            InitializeComponent();
        }

        private void fQuanLyKhoa_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvKhoa.DataSource = BLL_Khoa.Instance.DanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string makhoa = txbMaKhoa.Text;
            string tenkhoa = txbTenKhoa.Text;

            if (makhoa.Length == 0 && tenkhoa.Length == 0)
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxButtons.Warning);
            else
            {
                try
                {
                    if (BLL_Khoa.Instance.Them(makhoa, tenkhoa) == true)
                        btnLamMoi.PerformClick();
                }
                catch
                {
                    MessageBox.Show("Mã khoa đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxButtons.Warning);
                }
            }
        }
        private void dgvKhoa_CellClick(object sender, DataGirdViewCellEventArgs e)
        {
            txbID.Text = dgvKhoa.CurrentRow.Cells[0].Value.ToString().Trim();
            txbMaKhoa.Text = dgvKhoa.CurrentRow.Cells[1].Value.ToString().Trim();
            txbTenKhoa.Text = dgvKhoa.CurrentRow.Cells[2].Value.ToString().Trim();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbUD.Text);
            string makhoa = txbMaKhoa.Text;
            string tenkhoa = txbTenKhoa.Text;

            if (makhoa.Length == 0 && tenkhoa.Length == 0)
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxButtons.Warning);
            else
            {
                try
                {
                    if (BLL_Khoa.Instance.Sua(makhoa, tenkhoa, id) == true)
                        btnLamMoi.PerformClick();
                }
                catch
                {
                    MessageBox.Show("Mã khoa đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxButtons.Warning);
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text)
           string tenkhoa = txbTenKhoa.Text;

            if (MessageBox.Show("Bạn có muốn xóa khoa " + tenkhoa + "không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxButtons.Question == DialogResult.Yes)
                {
                if (BLL_Khoa.Instance.Xoa(id) == true)
                    btnLamMoi.PerformClick();
            }
        }

    }
}
