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
    public partial class fHocPhi : Form
    {
        public fHocPhi()
        {
            dataGridViewHocPhi.DataSource = BLL_HocPhi.GetAllHocPhi();
            ClearInputFields();
        }
    }

        private void btnThem_Click(object sender, EventArgs e)
        {
        string MaSV = txtMaSV.Text;
        string MaHP = txtMaHP.Text;
        float HocPhi;
        DateTime NgayThanhToan = dateTimePickerNgayThanhToan.Value;

        if (string.IsNullOrEmpty(MaSV) || string.IsNullOrEmpty(MaHP) || !float.TryParse(txtHocPhi.Text, out HocPhi))
        {
            MessageBox.Show("Dien thong tin");
            return;
        }

        if (BLL_HocPhi.Them(MaSV, MaHP, HocPhi, NgayThanhToan))
        {
            MessageBox.Show("THANH CONG");
            LoadData();
        }
        else
        {
            MessageBox.Show("THAT BAI");
        }
    }
}
    }
}
