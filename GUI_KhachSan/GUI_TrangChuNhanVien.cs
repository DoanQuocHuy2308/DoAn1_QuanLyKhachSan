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
    public partial class GUI_TrangChuNhanVien : Form
    {
        private static TrangChuNhanVien tcnv = new TrangChuNhanVien();
        private static TrangChu tc = new TrangChu();
        public GUI_TrangChuNhanVien()
        {
            InitializeComponent();
            tc.Visible = true;
            txtTenDangNhap.Text = $"Wellcome : {Check.nguoidung}";
        }

        private void btntrangchu_Click(object sender, EventArgs e)
        {
            
            TrangChu tc = new TrangChu();
            paneldulieu.Controls.Add(tc);
            tcnv.Visible = false;
            tc.Visible = true;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (Check.check == "Admin")
            {
                GUI_TrangChuAdmin trangChuAdmin = new GUI_TrangChuAdmin();
                this.Hide();
                trangChuAdmin.ShowDialog();
            }
            else
            {
                GUI_DangNhap dn = new GUI_DangNhap();
                this.Hide();
                dn.ShowDialog();
            }
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn chắc chắn muốn đóng", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (check == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            GUI_KhachHang kh = new GUI_KhachHang();
            this.Hide();
            kh.ShowDialog();
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            GUI_ThongKe tk = new GUI_ThongKe();
            this.Hide();
            tk.ShowDialog();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            GUI_DatPhong dp = new GUI_DatPhong();
            this.Hide();
            dp.ShowDialog();
        }

        private void paneldulieu_Paint(object sender, PaintEventArgs e)
        {
            paneldulieu.Controls.Add(tcnv);
        }

        private void btntrangchunv_Click(object sender, EventArgs e)
        {
            tc.Visible = false;
            tcnv.Visible = true;
        }

        private void btndatdichvu_Click(object sender, EventArgs e)
        {
            GUI_DatDichVu ddv = new GUI_DatDichVu();
            this.Hide();
            ddv.ShowDialog();
        }

        private void btnkhuyenmai_Click(object sender, EventArgs e)
        {
            GUI_KhuyenMai km = new GUI_KhuyenMai();
            this.Hide();
            km.ShowDialog();
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            GUI_CaiDat cd = new GUI_CaiDat();
            this.Hide();
            cd.ShowDialog();
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
