using BLL_KhachSan;
using DTO_KhachSan;
using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;

namespace GUI_KhachSan
{
    public partial class GUI_DangKy : Form
    {
        BLL_NhanVien bllnv = new BLL_NhanVien();
        BLL_DangKy dk = new BLL_DangKy();
        DTO_TaiKhoan tk = new DTO_TaiKhoan();
        DTO_NhanVien nv = new DTO_NhanVien();
        public GUI_DangKy()
        {
            InitializeComponent();
            txtmatkhau.UseSystemPasswordChar = true;
            cbovaitro.SelectedIndex = 0;
        }

        private void linkdangnhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GUI_DangNhap dn = new GUI_DangNhap();
            this.Hide();
            dn.ShowDialog();
        }

        private void chkhien_CheckedChanged(object sender, EventArgs e)
        {
            if (chkhien.Checked)
            {
                txtmatkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtmatkhau.UseSystemPasswordChar = true;
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            foreach (Control c in PanelDangKy.Controls)
            {
                if (c is Guna2TextBox)
                {
                    (c as Guna2TextBox).Text = "";
                }
                cbovaitro.SelectedIndex = 0;
            }
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

        private void btndangky_Click(object sender, EventArgs e)
        {
            tk.Pass_TaiKhoan = txtmatkhau.Text;
            tk.Role_TaiKhoan = cbovaitro.Text;
            tk.Email_TaiKhoan = txtemailtaikhoan.Text;
            nv.Ten_NhanVien = txttennhanvien.Text;
            nv.CMND_NhanVien = txtcmnd.Text;
            nv.GioiTinh_NhanVien = cbogioitinh.Text;
            nv.Email_NhanVien = txtemailtaikhoan.Text;
            nv.SDT_NhanVien = txtsodienthoai.Text;
            nv.DiaChi_NhanVien = txtdiachi.Text;
            nv.Role_NhanVien = txtchucvu.Text;
            if (string.IsNullOrEmpty(tk.Email_TaiKhoan) || string.IsNullOrEmpty(tk.Pass_TaiKhoan) || string.IsNullOrEmpty(tk.Role_TaiKhoan))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng ký.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(nv.Ten_NhanVien) || string.IsNullOrEmpty(nv.CMND_NhanVien) || string.IsNullOrEmpty(nv.GioiTinh_NhanVien) || string.IsNullOrEmpty(nv.SDT_NhanVien) || string.IsNullOrEmpty(nv.DiaChi_NhanVien) || string.IsNullOrEmpty(nv.Role_NhanVien))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!nv.SDT_NhanVien.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại bắt đầu từ số 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (nv.SDT_NhanVien.Length < 10 || nv.SDT_NhanVien.Length > 10)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại đúng yêu cầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dk.KiemTraEmailTonTai(tk))
            {
                MessageBox.Show("Email đã tồn tại trong hệ thống. Vui lòng sử dụng email khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (bllnv.KTEmail(nv))
            {
                MessageBox.Show("Email đã tồn tại trong hệ thống. Vui lòng sử dụng email khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Check.nguoidung = txttennhanvien.Text;
                Check.check = cbovaitro.Text;
                dk.DangKyTaiKhoan(tk);
                bllnv.ThemNhanVien(nv);
                MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GUI_TrangChuNhanVien tc = new GUI_TrangChuNhanVien();
                this.Hide();
                tc.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đăng ký tài khoản thất bại. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtsodienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtcmnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            GUI_DangNhap dn = new GUI_DangNhap();
            this.Hide();
            dn.ShowDialog();
        }
    }
}

