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
    public partial class dgvLop : Form
    {
        public dgvLop()
        {
            InitializeComponent();
        }
        private void fQuanLyLop_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvLop.DataSource = BLL_Lop.Instance.DanhSach();
            cmbMaKhoa.DataSource = BLL_Khoa.Instance.DanhSach();
            cmbMaKhoa.DisplayMember = "TenKhoa";
            cmbMaKhoa.ValueMember = "MaKhoa";
            if (BLL_Khoa.Instance.DanhSach().Rows.Count > 0)
                cmdMaKhoa.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string malop = txbMaLop.Text;
            string tenlop = txbTenLop.Text;
            string makhoa = cmbMaKhoa.SelectedValue.ToString().Trim();
            int soluong = (int)numSoLuong.Value;
            if (malop.Length > 0 && tenlop.Length > 0)
            {
                try
                {
                    if (BLL_Lop.Instance.Them(malop, tenlop, soluong, makhoa) == true)
                        btnLamMoi.PerformClick();
                }
                catch
                {
                    MessageBox.Show("Mã lớp đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxButtons.Warning);
                }
            }
            else
                MessageBox.Show("Vui lòng không bỏ trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxButtons.Warning);
        }
        private void dgvLop_CellClick(object, DataGirdViewCellEvenArgs e)
        {
            txbID.Text = dgvLop.CurrentRow.Cells[0].Value.ToString().Trim();
            txbMaLop.Text = dgvLop.CurrentRow.Cells[1].Value.ToString().Trim();
            txbTenLop.Text = dgvLop.CurrentRow.Cells[2].Value.ToString().Trim();
            numSoLuong.Value = (int)dgvLop.CurrentRow.Cells[3].Value;
            cmbMaKhoa.SelectedValue = dgvLop.CurrentRow.cell[4].Value.ToString().Trim();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string tenlop = txbTenLop.Text;
            if (MessageBox.Show("Bạn có muốn xóa lớp" + tenlop + " không ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxButtons.Question) == DialogResult.Yes)
            {
                try
                {
                    if (BLL_Lop.Instance.Xoa(id) == true)
                        btnLamMoi.PerformClick();
                }
                catch
                {
                    MessageBox.Show("Lớp đang được sử dụng.", "Thông báo", MessageBoxButtons.OK, MessageBoxButtons.Warning);
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string malop = txbMaLop.Text;
            string tenlop = txbTenLop.Text;
            string makhoa = cmbMaKhoa.SelectedValue.ToString().Trim();
            int soluong = (int)numSoLuong.Value;
            if (malop.Length > 0 && tenlop.Length > 0)
            {
                try
                {
                    if (BLL_Lop.Instance.Sua(malop, tenlop, soluong, makhoa, id) == true)
                        btnLamMoi.PerformClick();
                }
                catch
                {
                    MessageBox.Show("Mã lớp đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxButtons.Warning);
                }
            }
            else
                MessageBox.Show("Vui lòng không bỏ trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxButtons.Warning);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
