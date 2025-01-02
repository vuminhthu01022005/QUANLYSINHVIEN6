using QUANLYSINHVIEN6.BLL;
using System.Windows.Forms;
using System;

namespace QUANLYSINHVIEN6
{
    partial class fDangNhap
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            string tendangnhap = txbTenDangNhap.Text;
            string matkhau = txbMatKhau.Text;

            if (BLL_TaiKhoan.Instance.DangNhap(tendangnhap, matkhau) == true)
            {
                txbMatKhau.Clear();
                fSinhVien f = new fSinhVien();
                this.Hide();
                f.showDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng...", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

