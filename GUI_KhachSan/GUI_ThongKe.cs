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
    public partial class GUI_ThongKe : Form
    {
        public GUI_ThongKe()
        {
            InitializeComponent();
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

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (Check.check == "Admin")
            {
                GUI_TrangChuAdmin trangChuAdmin = new GUI_TrangChuAdmin();
                this.Hide();
                trangChuAdmin.ShowDialog();
            }
            else if (Check.check == "Nhân Viên")
            {
                GUI_TrangChuNhanVien tcnv = new GUI_TrangChuNhanVien();
                this.Hide();
                tcnv.ShowDialog();
            }
        }

    }
}
