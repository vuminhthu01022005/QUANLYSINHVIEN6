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
    public partial class fThongTinChiTiet : Form
    {
        public fThongTinChiTiet()
        {
            InitializeComponent();
        }

        public object HeThong { get; private set; }

        private void fThongTinChiTiet_load(object sender, EventArgs e)
        {
            txbTenDangNhap.Text = HeThong.TENDANGNHAP;
            txbLoaiTaiKhoan.Text = HeThong.LOAITAIKHOAN;

        }
    }
}
