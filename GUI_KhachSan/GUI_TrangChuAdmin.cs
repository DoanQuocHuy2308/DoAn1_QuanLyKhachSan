using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_KhachSan
{
    public partial class GUI_TrangChuAdmin : Form
    {
     
        public GUI_TrangChuAdmin()
        {
            InitializeComponent();
            txtTenDangNhap.Text = $"Wellcome : {Check.nguoidung}";
        }

        private void btntrangchu_Click(object sender, EventArgs e)
        {
            TrangChu tc = new TrangChu();
            paneldulieu.Controls.Add(tc);
            trangChu1.Visible= true;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {

            GUI_DangNhap dn = new GUI_DangNhap();
            this.Hide();
            dn.ShowDialog();
        }

        private void btntrogiup_Click(object sender, EventArgs e)
        {
            trangChu1.Visible = false;
            TroGiup tg = new TroGiup();
            paneldulieu.Controls.Add(tg);
        }

        private void GUI_TrangChuAdmin_Load(object sender, EventArgs e)
        {
            trangChu1.Visible = true;
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            GUI_Phong p = new GUI_Phong();
            trangChu1.Visible = false;
            this.Hide(); 
            p.ShowDialog();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn chắc chắn muốn đóng", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (check == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btndichvu_Click(object sender, EventArgs e)
        {
            GUI_DichVu dv = new GUI_DichVu();
            this.Hide();
            dv.ShowDialog();
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            GUI_NhanVien nv = new GUI_NhanVien();
            this.Hide();
            nv.ShowDialog();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            GUI_QLTaiKhoan tk = new GUI_QLTaiKhoan();
            this.Hide();
            tk.ShowDialog();
        }
        private void btnchuyen_Click(object sender, EventArgs e)
        {
            GUI_TrangChuNhanVien tcnv = new GUI_TrangChuNhanVien();
            this.Hide();
            tcnv.ShowDialog();
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            GUI_ThongKe tk = new GUI_ThongKe();
            this.Hide();
            tk.ShowDialog();
        }
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private void panelchinh_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
