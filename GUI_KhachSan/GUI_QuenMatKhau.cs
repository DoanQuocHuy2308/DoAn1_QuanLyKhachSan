using BLL_KhachSan;
using DTO_KhachSan;
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
    public partial class GUI_QuenMatKhau : Form
    {
        public GUI_QuenMatKhau()
        {
            InitializeComponent();
            txtmatkhaumoi.UseSystemPasswordChar = true;
            txtxacthucmatkhaumoi.UseSystemPasswordChar=true;
            txtmaOTP.Enabled = false;
            grbmatkhaumoi.Enabled = false;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            GUI_DangNhap dn = new GUI_DangNhap();
            this.Hide();
            dn.ShowDialog();
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

        private void chkhien_CheckedChanged(object sender, EventArgs e)
        {
            if (chkhien.Checked)
            {
                txtmatkhaumoi.UseSystemPasswordChar = false;
                txtxacthucmatkhaumoi.UseSystemPasswordChar = false;
            }
            else
            {
                txtmatkhaumoi.UseSystemPasswordChar = true;
                txtxacthucmatkhaumoi.UseSystemPasswordChar = true;
            }
        }

        private void chklammoiemail_CheckedChanged(object sender, EventArgs e)
        {
            if(chklammoiemail.Checked)
            {
                txtemail.Text = "";
            }
        }

        private void chklammoiotp_CheckedChanged(object sender, EventArgs e)
        {
            if (chklammoiotp.Checked)
            {
                txtmaOTP.Text = "";
            }
        }

        private void chklammoimk_CheckedChanged(object sender, EventArgs e)
        {
            if (chklammoimk.Checked)
            {
                txtmatkhaumoi.Text = "";
                txtxacthucmatkhaumoi.Text = "";
            }
        }
        BLL_QuenMatKhau qmk = new BLL_QuenMatKhau();
        BLL_DangNhap dn = new BLL_DangNhap();
        DTO_TaiKhoan tk = new DTO_TaiKhoan();
        private void btnxacthucemail_Click(object sender, EventArgs e)
        {
            tk.Email_TaiKhoan = txtemail.Text;
            if (!string.IsNullOrEmpty(txtemail.Text))
            {
                if (qmk.KiemTraEmailTonTai(tk))
                {
                    MessageBox.Show($"Email: {txtemail.Text} có tồn tại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    txtmaOTP.Enabled = true;
                }
                else
                {
                    MessageBox.Show($"Email: {txtemail.Text} không tồn tại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập Email", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btnguiotp_Click(object sender, EventArgs e)
        {
            tk.Email_TaiKhoan=txtemail.Text;
            qmk.GuiOTP(tk.Email_TaiKhoan);
            MessageBox.Show("Mã OTP đã được gửi đến email của bạn.");
        }
        private void btnxacthucotp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmaOTP.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                if (BLL_QuenMatKhau.otp.ToString().Equals(txtmaOTP.Text))
                {
                    MessageBox.Show("Xác Minh Thành Công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    grbmatkhaumoi.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Xác Minh Không Thành Công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    grbmatkhaumoi.Enabled = false;
                }
            }
        }

        private void btntieptuc_Click(object sender, EventArgs e)
        {
            try
            {
                tk.Pass_TaiKhoan = txtxacthucmatkhaumoi.Text;
                string role = qmk.KiemTraRoleTonTai(tk.Email_TaiKhoan);

                if (role != null)
                {
                    if (tk.Pass_TaiKhoan.Equals(txtmatkhaumoi.Text))
                    {
                        string ten = dn.LayTenNhanVien(txtemail.Text);
                        Check.nguoidung = ten;

                        if (role == "Admin")
                        {
                            Check.check = role;
                            qmk.ThayDoiMatKhau(tk);
                            GUI_TrangChuAdmin admin = new GUI_TrangChuAdmin();
                            this.Hide();
                            admin.ShowDialog();
                        }
                        else if (role == "Nhân Viên")
                        {
                            Check.check = role;
                            qmk.ThayDoiMatKhau(tk);
                            GUI_TrangChuNhanVien nhanVien = new GUI_TrangChuNhanVien();
                            this.Hide();
                            nhanVien.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Vai trò không được xác định hoặc không hợp lệ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập đúng mật khẩu!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy vai trò cho người dùng!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
