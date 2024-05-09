using BLL_KhachSan;
using DTO_KhachSan;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_KhachSan
{
    public partial class GUI_QLTaiKhoan : Form
    {
        public GUI_QLTaiKhoan()
        {
            InitializeComponent();
            HienThiTaiKhoan();
            cboban.SelectedItem = 0;
        }
        BLL_TaiKhoan blltk = new BLL_TaiKhoan();
        DTO_TaiKhoan tk = new DTO_TaiKhoan();   

        private void btnthoat_Click(object sender, EventArgs e)
        {
            GUI_TrangChuAdmin trangChuAdmin = new GUI_TrangChuAdmin();
            this.Hide();
            trangChuAdmin.ShowDialog();
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
        private void HienThiTaiKhoan()
        {
            dtgvtaikhoan.Columns[0].DataPropertyName = "ID_TaiKhoan";
            dtgvtaikhoan.Columns[1].DataPropertyName = "Email_TaiKhoan";
            dtgvtaikhoan.Columns[2].DataPropertyName = "Pass_TaiKhoan";
            dtgvtaikhoan.Columns[3].DataPropertyName = "Role_TaiKhoan";
            dtgvtaikhoan.Columns[4].DataPropertyName = "Ban_TaiKhoan";
            dtgvtaikhoan.DataSource = blltk.HienThiTaiKhoan();
        }
        private void btnthemtk_Click(object sender, EventArgs e)
        {
            tk.Pass_TaiKhoan = txtpass.Text;
            tk.Email_TaiKhoan = txtemailtaikhoan.Text;
            tk.Role_TaiKhoan = cborole.Text;
            tk.Ban_TaiKhoan = 0;
            if (string.IsNullOrEmpty(tk.Pass_TaiKhoan) || string.IsNullOrEmpty(tk.Email_TaiKhoan) || string.IsNullOrEmpty(tk.Role_TaiKhoan) )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (blltk.KTEmail(tk))
                {
                    MessageBox.Show("Email này đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    blltk.ADD(tk);
                    MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiTaiKhoan();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Thêm tài khoản thất bại. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgvtaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvtaikhoan.Rows[e.RowIndex];
                txtidtaikhoan.Text = row.Cells["ID_TaiKhoan"].Value.ToString();
                txtemailtaikhoan.Text = row.Cells["Email_TaiKhoan"].Value.ToString();
                txtpass.Text = row.Cells["Pass_TaiKhoan"].Value.ToString();
                cborole.SelectedItem = row.Cells["Role_TaiKhoan"].Value.ToString();
                cboban.SelectedItem = row.Cells["Ban_TaiKhoan"].Value.ToString();
            }
        }

        private void btnsuatk_Click(object sender, EventArgs e)
        {
            tk.ID_TaiKhoan = int.Parse(txtidtaikhoan.Text);
            tk.Pass_TaiKhoan = txtpass.Text;
            tk.Email_TaiKhoan = txtemailtaikhoan.Text;
            tk.Role_TaiKhoan = cborole.Text;
            tk.Ban_TaiKhoan = int.Parse(cboban.Text);
            if (string.IsNullOrEmpty(tk.ID_TaiKhoan.ToString()) || string.IsNullOrEmpty(tk.Pass_TaiKhoan) || string.IsNullOrEmpty(tk.Email_TaiKhoan) || string.IsNullOrEmpty(tk.Role_TaiKhoan))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                blltk.Update(tk);
                MessageBox.Show("Cập nhật thông tin tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiTaiKhoan();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"cập nhật tài khoản thất bại. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnresettk_Click(object sender, EventArgs e)
        {
            foreach (Control c in panelchucnang.Controls)
            {
                if (c is Guna2TextBox)
                {
                    (c as Guna2TextBox).Text = "";
                }
                txttimkiem.Text = "";
                cboban.SelectedIndex = -1;
                cborole.SelectedIndex = -1;
                HienThiTaiKhoan();
            }
        }

        private void btnxoatk_Click(object sender, EventArgs e)
        {
            tk.ID_TaiKhoan = int.Parse(txtidtaikhoan.Text);
            if (string.IsNullOrEmpty(tk.ID_TaiKhoan.ToString()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (tk != null)
                {
                    blltk.Delete(tk);
                    MessageBox.Show("Xóa tài khoản và nhân viên thành công!");
                    HienThiTaiKhoan();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một tài khoản để xóa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btntimkiemtk_Click(object sender, EventArgs e)
        {
            int.TryParse(txtidtaikhoan.Text, out int ID_TaiKhoan);
            tk.ID_TaiKhoan = ID_TaiKhoan;
            tk.Email_TaiKhoan = txtemailtaikhoan.Text;
            tk.Role_TaiKhoan = cborole.Text;
            int.TryParse(cboban.Text, out int ban);
            tk.Ban_TaiKhoan = ban;
            DataTable dt = blltk.TimKiemTaiKhoan(txttimkiem.Text, tk);
            dtgvtaikhoan.Columns[0].DataPropertyName = "ID_TaiKhoan";
            dtgvtaikhoan.Columns[1].DataPropertyName = "Pass_TaiKhoan";
            dtgvtaikhoan.Columns[2].DataPropertyName = "Email_TaiKhoan";
            dtgvtaikhoan.Columns[3].DataPropertyName = "Role_TaiKhoan";
            dtgvtaikhoan.Columns[4].DataPropertyName = "Ban_TaiKhoan";
            dtgvtaikhoan.DataSource = dt;
        }
    }
}
