using BLL_KhachSan;
using DTO_KhachSan;
using Guna.UI2.WinForms;
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
    public partial class GUI_DangNhap : Form
    {
        private BLL_DangNhap dn = new BLL_DangNhap();
        public GUI_DangNhap()
        {
            InitializeComponent();
        }
        private void DangNhap(string role)
        {
            if (role == "Admin")
            {
                Check.check = cbovaitro.Text;
                GUI_TrangChuAdmin tcadmin = new GUI_TrangChuAdmin();
                this.Hide();
                tcadmin.ShowDialog();
            }
            else if (role == "Nhân Viên")
            {
                Check.check = cbovaitro.Text;
                GUI_TrangChuNhanVien tcnv = new GUI_TrangChuNhanVien();
                this.Hide();
                tcnv.ShowDialog();
            }
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string Email_TaiKhoan = txtemail.Text;
            string Pass_TaiKhoan = txtmatkhau.Text;
            string Role_TaiKhoan = cbovaitro.Text;
            DTO_TaiKhoan tk = dn.DangNhap(Email_TaiKhoan, Pass_TaiKhoan, Role_TaiKhoan);
            if (string.IsNullOrEmpty(Email_TaiKhoan) || string.IsNullOrEmpty(Pass_TaiKhoan) || string.IsNullOrEmpty(Role_TaiKhoan))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tk != null)
            {
                if (tk.Ban_TaiKhoan == 1)
                {
                    MessageBox.Show("Tài khoản của bạn đã bị khóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tk.Ban_TaiKhoan == 0)
                {
                    Check.nguoidung = txtemail.Text;
                    DangNhap(tk.Role_TaiKhoan);
                }
            }
            else
            {
                MessageBox.Show("Tài khoản và mật khẩu không chính xác hoặc vai trò không hợp lệ, vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GUI_DangNhap_Load(object sender, EventArgs e)
        {
            txtemail.Focus();
            cbovaitro.SelectedIndex = 0;
            txtmatkhau.UseSystemPasswordChar = true;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                if (c is Guna2TextBox)
                {
                    (c as Guna2TextBox).Text = "";
                }
                cbovaitro.SelectedIndex = -1;
                chkhien.Checked = false;
            }
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

        private void linkdangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GUI_DangKy dk = new GUI_DangKy();
            this.Hide();
            dk.ShowDialog();
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
            this.WindowState= FormWindowState.Minimized;
        }
        private void linkquenmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GUI_QuenMatKhau qmk = new GUI_QuenMatKhau();
            this.Hide();
            qmk.ShowDialog();
            this.Show();
        }
    }
}
