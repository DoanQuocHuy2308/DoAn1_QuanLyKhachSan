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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_KhachSan
{
    public partial class GUI_KhachHang : Form
    {
        public GUI_KhachHang()
        {
            InitializeComponent();
            HienThiKhachHang();
        }
        DTO_KhachHang kh = new DTO_KhachHang();
        BLL_KhachHang bllkh = new BLL_KhachHang();
        private void btnthoat_Click(object sender, EventArgs e)
        {
            GUI_TrangChuNhanVien tckh = new GUI_TrangChuNhanVien();
            this.Hide();
            tckh.ShowDialog();
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
        public void HienThiKhachHang()
        {
            dtgvkhachhang.Columns[0].DataPropertyName = "ID_KhachHang";
            dtgvkhachhang.Columns[1].DataPropertyName = "Ten_KhachHang";
            dtgvkhachhang.Columns[2].DataPropertyName = "Tuoi_KhachHang";
            dtgvkhachhang.Columns[3].DataPropertyName = "CMND_KhachHang";
            dtgvkhachhang.Columns[4].DataPropertyName = "GioiTinh_KhachHang";
            dtgvkhachhang.Columns[5].DataPropertyName = "Email_KhachHang";
            dtgvkhachhang.Columns[6].DataPropertyName = "SDT_KhachHang";
            dtgvkhachhang.Columns[7].DataPropertyName = "DiaChi_KhachHang";
            dtgvkhachhang.DataSource = bllkh.HienThiKhachHang();
        }
        private void btnthemkh_Click(object sender, EventArgs e)
        {
            kh.Ten_KhachHang = txttenkhachhang.Text;
            kh.Tuoi_KhachHang = int.Parse(txttuoikhachhang.Text);
            kh.CMND_KhachHang = txtCMND.Text;
            kh.GioiTinh_KhachHang = cbogioitinh.Text;
            kh.Email_KhachHang = txtEmail.Text;
            kh.SDT_KhachHang = txtsodienthoai.Text;
            kh.DiaChi_KhachHang = txtdiachi.Text;
            if (string.IsNullOrEmpty(kh.Ten_KhachHang) || string.IsNullOrEmpty(kh.Tuoi_KhachHang.ToString()) || string.IsNullOrEmpty(kh.CMND_KhachHang) || string.IsNullOrEmpty(kh.GioiTinh_KhachHang) || string.IsNullOrEmpty(kh.Email_KhachHang) || string.IsNullOrEmpty(kh.SDT_KhachHang) || string.IsNullOrEmpty(kh.DiaChi_KhachHang))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(kh.SDT_KhachHang.Length < 10 || kh.SDT_KhachHang.Length > 10)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại đúng yêu cầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!kh.SDT_KhachHang.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại bắt đầu từ số 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (bllkh.KTCMND(kh))
                {
                    MessageBox.Show("CMND này đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    bllkh.ADD(kh);
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiKhachHang();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Thêm khách hàng thất bại. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgvkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvkhachhang.Rows[e.RowIndex];
                txtidkhachhang.Text = row.Cells["ID_KhachHang"].Value.ToString();
                txttenkhachhang.Text = row.Cells["Ten_KhachHang"].Value.ToString();
                txttuoikhachhang.Text = row.Cells["Tuoi_KhachHang"].Value.ToString();
                txtCMND.Text = row.Cells["CMND_KhachHang"].Value.ToString();
                cbogioitinh.SelectedItem = row.Cells["GioiTinh_KhachHang"].Value.ToString();
                txtEmail.Text = row.Cells["Email_KhachHang"].Value.ToString();
                txtsodienthoai.Text = row.Cells["SDT_KhachHang"].Value.ToString();
                txtdiachi.Text = row.Cells["DiaChi_KhachHang"].Value.ToString();
            }
        }

        private void btnsuakh_Click(object sender, EventArgs e)
        {
            kh.ID_KhachHang = int.Parse(txtidkhachhang.Text);
            kh.Ten_KhachHang = txttenkhachhang.Text;
            kh.Tuoi_KhachHang = int.Parse(txttuoikhachhang.Text);
            kh.CMND_KhachHang = txtCMND.Text;
            kh.GioiTinh_KhachHang = cbogioitinh.Text;
            kh.Email_KhachHang = txtEmail.Text;
            kh.SDT_KhachHang = txtsodienthoai.Text;
            kh.DiaChi_KhachHang = txtdiachi.Text;
            if (string.IsNullOrEmpty(kh.ID_KhachHang.ToString()) || string.IsNullOrEmpty(kh.Ten_KhachHang) || string.IsNullOrEmpty(kh.Tuoi_KhachHang.ToString()) || string.IsNullOrEmpty(kh.CMND_KhachHang) || string.IsNullOrEmpty(kh.GioiTinh_KhachHang) || string.IsNullOrEmpty(kh.Email_KhachHang) || string.IsNullOrEmpty(kh.SDT_KhachHang) || string.IsNullOrEmpty(kh.DiaChi_KhachHang))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (kh.SDT_KhachHang.Length < 10 || kh.SDT_KhachHang.Length > 10)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại đúng yêu cầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                bllkh.Update(kh);
                MessageBox.Show("Sửa thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sửa thông tin khách hàng thất bại. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtsodienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txttuoikhachhang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtidkhachhang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnxoakh_Click(object sender, EventArgs e)
        {
            kh.ID_KhachHang = int.Parse(txtidkhachhang.Text);
            DialogResult check = MessageBox.Show("Bạn chắc chắn muốn xóa mọi thông tin về khách hàng này kể cả các dịch vụ và đặt phòng đã sử dụng ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (check == DialogResult.OK)
            {
                bllkh.Delete(kh);
                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiKhachHang();
            }
            else
            {
                HienThiKhachHang();
            }
        }

        private void btntimkiemtk_Click(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "Tìm Kiếm Khách Hàng")
            {
                txttimkiem.Text = "";
            }
            int.TryParse(txtidkhachhang.Text, out int id);
            kh.ID_KhachHang =id;
            kh.Ten_KhachHang = txttenkhachhang.Text;
            int.TryParse(txttuoikhachhang.Text, out int tuoi);
            kh.Tuoi_KhachHang = tuoi;
            kh.CMND_KhachHang = txtCMND.Text;
            kh.GioiTinh_KhachHang = cbogioitinh.Text;
            kh.Email_KhachHang = txtEmail.Text;
            kh.SDT_KhachHang = txtsodienthoai.Text;
            kh.DiaChi_KhachHang = txtdiachi.Text;
            DataTable dt = bllkh.TimKiemKhachHang(txttimkiem.Text, kh);
            dtgvkhachhang.Columns[0].DataPropertyName = "ID_KhachHang";
            dtgvkhachhang.Columns[1].DataPropertyName = "Ten_KhachHang";
            dtgvkhachhang.Columns[2].DataPropertyName = "Tuoi_KhachHang";
            dtgvkhachhang.Columns[3].DataPropertyName = "CMND_KhachHang";
            dtgvkhachhang.Columns[4].DataPropertyName = "GioiTinh_KhachHang";
            dtgvkhachhang.Columns[5].DataPropertyName = "Email_KhachHang";
            dtgvkhachhang.Columns[6].DataPropertyName = "SDT_KhachHang";
            dtgvkhachhang.Columns[7].DataPropertyName = "DiaChi_KhachHang";
            dtgvkhachhang.DataSource = dt;
        }

        private void btnresetkh_Click(object sender, EventArgs e)
        {
            foreach (Control c in panelchucnang.Controls)
            {
                if (c is Guna2TextBox)
                {
                    (c as Guna2TextBox).Text = "";
                }
                txttimkiem.Text = "Tìm Kiếm Khách Hàng";
                cbogioitinh.SelectedIndex = -1;
                HienThiKhachHang();
            }
        }

        private void txttimkiem_Enter(object sender, EventArgs e)
        {
            if(txttimkiem.Text=="Tìm Kiếm Khách Hàng")
            {
                txttimkiem.Text = "";
            }
        }

        private void txttimkiem_Leave(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "")
            {
                txttimkiem.Text = "Tìm Kiếm Khách Hàng";
            }
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
