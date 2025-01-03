
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYSINHVIEN6.BLL;

namespace Quản_Lí_Sinh_Viên_02.GUI
{
    public partial class frmDangnhap : Form
    {
        private object txbTenDangNhap;
        private object txbMatKhau;

        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            string tendangnhap = txbTenDangNhap.Text;
            string matkhau = txbMatKhau.Text;

            if (BLL_TaiKhoan.Instace.DangNhap(tendangnhap, matkhau) == true)
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