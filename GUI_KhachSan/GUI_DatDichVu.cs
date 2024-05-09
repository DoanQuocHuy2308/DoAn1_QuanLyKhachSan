using BLL_KhachSan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_KhachSan
{
    public partial class GUI_DatDichVu : Form
    {
        BLL_DichVu blldv = new BLL_DichVu();
        public GUI_DatDichVu()
        {
            InitializeComponent();
            HienThiDichVu();
        }
        private void HienThiDichVu()
        {
            dtgvdichvu.Columns[0].DataPropertyName = "ID_DichVu";
            dtgvdichvu.Columns[1].DataPropertyName = "Ten_DichVu";
            dtgvdichvu.Columns[2].DataPropertyName = "ID_LoaiDichVu";
            dtgvdichvu.Columns[3].DataPropertyName = "Ten_LoaiDichVu";
            dtgvdichvu.Columns[4].DataPropertyName = "Gia_DichVu";
            dtgvdichvu.DataSource = blldv.HienThiDuLieuDichVu();
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            GUI_TrangChuNhanVien tcnv = new GUI_TrangChuNhanVien();
            this.Hide();
            tcnv.ShowDialog();
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn chắc chắn muốn đóng", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (check == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnthemddv_Click(object sender, EventArgs e)
        {

        }

    }
}
