using QUANLYSINHVIEN6.BLL;
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
    public partial class fQuanLiTaiKhoan : Form
    {
        public fQuanLiTaiKhoan()
        {
            InitializeComponent();
        }

        private void fQuanLiTaiKhoan_Load(object sender, EventArgs e)
        {
            public fQuanLiTaiKhoan()
            {
                InitializeComponent();
            }


            private void btnThem_Click(object sender, EventArgs e)
            {
                string tendangnhap = txbTenDangNhap.Text.Trim();
                string matkhau = txbMatKhau.Text.Trim();
                string loaitaikhoan = cmbLoaiTaiKhoan.SelectedItem.ToString();

                if (tandangnhap.Length > 0 && matkhau.Length > 6 && loaiTK.Length > 0
                {
                    try
                    {
                        if (BLL_TaiKhoan.Instance.Them(tendangnhap, matkhau, loaitaikhoan) == true)
                            btnLamMoi.PerformClick(); // bấm lại btnLamMoi
                    }
                    catch
                    {
                        MessageBox.Show("Tên đăng nhập bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu không được dưới 6 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }
            private void btnSua_Click(object sender, EventArgs e)
            {
                int id = int.Parse(txbID.Text);
                string tendangnhap = txbTenDangNhap.Text.Trim();
                string matkhau = txbMatKhau.Text.Trim();
                string loaitaikhoan = cmbLoaiTaiKhoan.SelectedItem.ToString();

                if (tandangnhap.Length > 0 && loaiTK.Length > 0
                {
                    try
                    {
                        //Không sửa mật khẩu 
                        if (matkhau.Length == 0)
                        {
                            if (BLL_TaiKhoan.Instance.KhongSuaMatKhau(tendangnhap, loaitaikhoan, id) == true)
                                btnLamMoi.PerformClick(); // bấm lại btnLamMoi
                        }
                        // Sửa mật khẩu
                        else
                        {
                            if (BLL_TaiKhoan.Instance.SuaHet(tendangnhap, matkhau, loaitaikhoan, id) == true)
                                btnLamMoi.PerformClick(); // bấm lại btnLamMoi
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Tên đăng nhập bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu không được dưới 6 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            private void btnXoa_Click(object sender, EventArgs e)
            {
                int id = int.Parse(dgvTaiKhoan.CurentRow.Cells[0].Value.ToString();
                string ten = dvgTaiKhoan_CeLLClick().CurenRow.Cells[1].value.ToString().Trim();

                if (MessageBox).Show("Bạn có muốn xóa tài khoản " + ten + "không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                    try
                    {
                        ìf(BLL_TaiKhoan.Instance.Xoa(id) == true)
                            btnLamMoi.PerformClick();
                    }
                    catch
                    {
                        MessageBox.Show("Phát sinh lỗi khi xóa...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            private void btnLamMoi_Click(object sender, EventArgs e)
            {
                dgvTaiKhoan.DataSource = BLL_TaiKhoan.Instance.DanhSach();
            }
            private void fQuanLyTaiKhoan_Load(object sender, EventArgs e)
            {
                btnLamMoi.PerformClick(); // bấm lại btnLamMoi
                cbmLoaiTaiKhoan.SelectedIndex = 0;
            }
            private void dvgTaiKhoan_CeLLClick(object sender, DataGridViewCellEventArgs e)
            {
                txbID.Text = dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString().Trim();
                txbTenDangNhap.Text = dgvTenDangNhap.CurrentRow.Cells[0].Value.ToString().Trim();
                txbMatKhau.Text = dgvMatKhau.CurrentRow.Cells[0].Value.ToString().Trim();
                cbmLoaiTaiKhoan.SelectedItem = dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString().Trim();
            }

        }
    }
}
