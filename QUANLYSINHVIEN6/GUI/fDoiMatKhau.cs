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
    public partial class fDoiMatKhau : Form
    {
        public fDoiMatKhau()
        {
            InitializeComponent();
        }
    private void btnCapNhap_Click(object sender, EventArgs e)
     {
            string matkhau_cu = txbMatKhauCu.Text;
            string matkhau_moi = txbMatKhauMoi.Text;

            if (matkhau_cu.Length == 0 && matkhau_moi.Length == 0)
                MessageBox.Show("Vui lòng điền đầy đủ thông tin ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (BLL_TaiKhoan.Instace.DoiMatKhau(HeThong.TENDANGNHAP, matkhau_moi, matkhau_cu) == true)
                    MessageBox.Show("Đổi mật khẩu thành công  ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information0);
                else
                    MessageBox.Show("Đổi mật khẩu thất bại  ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
     }
    }
}
