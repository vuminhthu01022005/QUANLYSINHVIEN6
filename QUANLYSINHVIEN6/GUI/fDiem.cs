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
    public partial class fDiem : Form
    {
        public fDiem()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);

            if     MessageBox.Show("Bạn có muốn xóa điểm có ID.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (BLL_Diem.Instance.Xoa(id) == true)
                    btnLamMoi.PerformClick();
            }
        }
    }

    private void button4_Click(object sender, EventArgs e)
    {
        dgvDiem.DataSource = BLL_Diem.Instance();
        cmbMaSV.DataSource = BLL_SinhVien.Instance.DanhSach();
        cmbMaSV.DisplayMember = "TenSV";
        cmbMaSV.ValueMember = "MaSV";
        cmbMaMH.DataSource = BLL_MonHoc.Instance.DanhSach();
        cmb.DisplayMember = "TenMH";
        cmbMaMH.ValueMember = "MaMh";

    }

    private void panel3_Paint(object sender, PaintEventArgs e)
    {

    }

    private void btnSua_Click(object sender, EventArgs e)
    {
        int id = int.Parse(txbID.Text)
            string masv = cmbMaSV.SelectedValue.ToString();
        string mamh = cmbMaMH.SelectedValue.ToString();
        int phantramlop = (int)numPhanTramLop.Value;
        int phantramthi = (int)numPhanTramThi.Value;
        float diemlop = float.Parse(txbDiemLop.Text);
        float diemthi = float.Parse(txbDiemThi.Text);
        float diemtb = float.Parse(txbDiemTB.Text);
        string loai = cmbLoai.SelectedItem.ToString();
        int nam = DateTime.Now.Year;

        if (BLL_Diem.Instance.Sua(masv, mamh, phantramlop, phantramthi, diemlop, diemtb, loai, nam, id) == true)
            btnLamMoi.PerformClick();

    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        string masv = cmbMaSV.SelectedValue.ToString();
        string mamh = cmbMaMH.SelectedValue.ToString();
        int phantramlop = (int)numPhanTramLop.Value;
        int phantramthi = (int)numPhanTramThi.Value;
        float diemlop = float.Parse(txbDiemLop.Text);
        float diemthi = float.Parse(txbDiemThi.Text);
        float diemtb = float.Parse(txbDiemTB.Text);
        string loai = cmbLoai.SelectedItem.ToString();
        int nam = DateTime.Now.Year;

        if (BLL_Diem.Instance.Them(masv, mamh, phantramtrenlop, phantramthi, diemlop, diemtb, loai, nam) == true;
        btnLamMoi.PerformClick();


    }

    private void btnXoa_MouseClick(object sender, MouseEventArgs e)
    {

    }

    private void dgvDiem(object sender, EventArgs e)
    {

    }

    private void dgvDiem_(object sender, EventArgs e)

    {
        txbID.Text = dgvDiem.CurrentRow.Cells[0].Value.ToString();
        cmbMaSV.SelectedValue = dgvDiem().CurentRow.Cells[1].Value.ToString();
        cmbMaMH.SelectedValue = dgvDiem().CurentRow.Cells[2].Value.ToString();
        numPhamTramLop.Value = int.Parse(dgvDiem().CurentRow.Cellss[3].Value.ToString());
        numPhamTramThi.Value = int.Parse(dgvDiem().CurentRow.Cellss[4].Value.ToString());
        txbDiemLop.Text = dgvDiem().CurentRow.Cell[5].Value.ToString();
        txbDiemThi.Text = dgvDiem().CurentRow.Cell[6].Value.ToString();
        txbDiemTB.Text = dgvDiem().CurentRow.Cell[7].Value.ToString();
        cmbLoai.SelectItem = dgvDiem().CurentRow.Cell[8].Value.ToString.Trim();


    }
}

