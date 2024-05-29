using BLL_KhachSan;
using DTO_KhachSan;
using Guna.UI2.WinForms;
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
    public partial class GUI_NhanVien : Form
    {
        BLL_NhanVien bllnv = new BLL_NhanVien();
        DTO_NhanVien nv = new DTO_NhanVien();
        public GUI_NhanVien()
        {
            InitializeComponent();
            HienThiNhanVien();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            GUI_TrangChuAdmin trangChuAdmin = new GUI_TrangChuAdmin();
            this.Hide();
            trangChuAdmin.ShowDialog();
        }
        private void HienThiNhanVien()
        {
            dtgvnhanvien.Columns[0].DataPropertyName = "ID_NhanVien";
            dtgvnhanvien.Columns[1].DataPropertyName = "Ten_NhanVien";
            dtgvnhanvien.Columns[2].DataPropertyName = "CMND_NhanVien";
            dtgvnhanvien.Columns[3].DataPropertyName = "GioiTinh_NhanVien";
            dtgvnhanvien.Columns[4].DataPropertyName = "SDT_NhanVien";
            dtgvnhanvien.Columns[5].DataPropertyName = "Email_NhanVien";
            dtgvnhanvien.Columns[6].DataPropertyName = "DiaChi_NhanVien";
            dtgvnhanvien.Columns[7].DataPropertyName = "Role_NhanVien";
            dtgvnhanvien.DataSource = bllnv.HienThiDuLieuNhanVien();
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

        private void dtgvnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvnhanvien.Rows[e.RowIndex];
                txtidnhanvien.Text = row.Cells["ID_NhanVien"].Value.ToString();
                txttennhanvien.Text = row.Cells["Ten_NhanVien"].Value.ToString();
                txtcmnd.Text = row.Cells["CMND_NhanVien"].Value.ToString();
                cbogioitinh.SelectedItem = row.Cells["GioiTinh_NhanVien"].Value.ToString();
                txtsodienthoai.Text = row.Cells["SDT_NhanVien"].Value.ToString();
                txtemail.Text = row.Cells["Email_NhanVien"].Value.ToString();
                txtdiachi.Text = row.Cells["DiaChi_NhanVien"].Value.ToString();
                txtchucvu.Text = row.Cells["Role_NhanVien"].Value.ToString();
            }
        }

        private void btnthemnv_Click(object sender, EventArgs e)
        {
            nv.Ten_NhanVien=txttennhanvien.Text;
            nv.CMND_NhanVien = txtcmnd.Text;
            nv.GioiTinh_NhanVien=cbogioitinh.Text;
            nv.SDT_NhanVien=txtsodienthoai.Text;
            nv.Email_NhanVien=txtemail.Text;
            nv.DiaChi_NhanVien = txtdiachi.Text;
            nv.Role_NhanVien=txtchucvu.Text;
            if (string.IsNullOrEmpty(nv.Ten_NhanVien) || string.IsNullOrEmpty(nv.CMND_NhanVien) || string.IsNullOrEmpty(nv.GioiTinh_NhanVien) || string.IsNullOrEmpty(nv.SDT_NhanVien) || string.IsNullOrEmpty(nv.Email_NhanVien) || string.IsNullOrEmpty(nv.DiaChi_NhanVien) || string.IsNullOrEmpty(nv.Role_NhanVien))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (nv.SDT_NhanVien.Length < 10 || nv.SDT_NhanVien.Length > 10)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại đúng yêu cầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!nv.SDT_NhanVien.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại bắt đầu từ số 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (bllnv.KTEmail(nv))
                {
                    MessageBox.Show("Email này đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    bllnv.ThemNhanVien(nv);
                    MessageBox.Show("Thêm Nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiNhanVien();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Thêm Nhân viên thất bại. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsuanv_Click(object sender, EventArgs e)
        {
            nv.ID_NhanVien=int.Parse(txtidnhanvien.Text);
            nv.Ten_NhanVien = txttennhanvien.Text;
            nv.CMND_NhanVien = txtcmnd.Text;
            nv.GioiTinh_NhanVien = cbogioitinh.Text;
            nv.SDT_NhanVien = txtsodienthoai.Text;
            nv.Email_NhanVien = txtemail.Text;
            nv.DiaChi_NhanVien = txtdiachi.Text;
            nv.Role_NhanVien = txtchucvu.Text;
            if (string.IsNullOrEmpty(nv.ID_NhanVien.ToString()) || string.IsNullOrEmpty(nv.Ten_NhanVien) || string.IsNullOrEmpty(nv.CMND_NhanVien) || string.IsNullOrEmpty(nv.GioiTinh_NhanVien) || string.IsNullOrEmpty(nv.SDT_NhanVien) || string.IsNullOrEmpty(nv.Email_NhanVien) || string.IsNullOrEmpty(nv.DiaChi_NhanVien) || string.IsNullOrEmpty(nv.Role_NhanVien))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (nv.SDT_NhanVien.Length < 10 || nv.SDT_NhanVien.Length > 10)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại đúng yêu cầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                bllnv.CapNhatNhanVien(nv);
                MessageBox.Show("Cập nhật thông tin Nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cập nhật thông tin Nhân viên thất bại. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtidnhanvien_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtsodienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnxoanv_Click(object sender, EventArgs e)
        {
            nv.ID_NhanVien=int.Parse(txtidnhanvien.Text);
            if (bllnv.KiemTraIDTonTai(nv))
            {
                MessageBox.Show("Vui lòng xóa mã nhân viên ở hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (bllnv.KiemTraEmailTonTai(nv))
            {
                MessageBox.Show("Vui lòng xóa Tài khoản nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult kt = MessageBox.Show("Bạn chắc chắn muốn xóa", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (kt == DialogResult.OK)
                {
                    bllnv.XoaNhanVien(nv);
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiNhanVien();
                }
            }
        }

        private void btnresetnv_Click(object sender, EventArgs e)
        {
            foreach (Control c in panelchucnang.Controls)
            {
                if (c is Guna2TextBox)
                {
                    (c as Guna2TextBox).Text = "";
                }
                txttimkiem.Text = "Tìm Kiếm Nhân Viên";
                cbogioitinh.SelectedIndex = -1;
                HienThiNhanVien();
            }
        }

        private void btntimkiemnv_Click(object sender, EventArgs e)
        {
            if(txttimkiem.Text=="Tìm Kiếm Nhân Viên")
            {
                txttimkiem.Text = "";
            }
            int.TryParse(txtidnhanvien.Text, out int IDNhanVien);
            nv.ID_NhanVien = IDNhanVien;
            nv.Ten_NhanVien = txttennhanvien.Text;
            nv.CMND_NhanVien = txtcmnd.Text;
            nv.GioiTinh_NhanVien = cbogioitinh.Text;
            nv.SDT_NhanVien = txtsodienthoai.Text;
            nv.Email_NhanVien = txtemail.Text;
            nv.DiaChi_NhanVien = txtdiachi.Text;
            nv.Role_NhanVien = txtchucvu.Text;
            DataTable dt = bllnv.TimKiemNhanVien(txttimkiem.Text, nv);
            dtgvnhanvien.Columns[0].DataPropertyName = "ID_NhanVien";
            dtgvnhanvien.Columns[1].DataPropertyName = "Ten_NhanVien";
            dtgvnhanvien.Columns[2].DataPropertyName = "CMND_NhanVien";
            dtgvnhanvien.Columns[3].DataPropertyName = "GioiTinh_NhanVien";
            dtgvnhanvien.Columns[4].DataPropertyName = "SDT_NhanVien";
            dtgvnhanvien.Columns[5].DataPropertyName = "Email_NhanVien";
            dtgvnhanvien.Columns[6].DataPropertyName = "DiaChi_NhanVien";
            dtgvnhanvien.Columns[7].DataPropertyName = "Role_NhanVien";
            dtgvnhanvien.DataSource = dt;
        }

        private void txttimkiem_Enter(object sender, EventArgs e)
        {
            if(txttimkiem.Text== "Tìm Kiếm Nhân Viên")
            {
                txttimkiem.Text = "";
            }
        }

        private void txttimkiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txttimkiem.Text == "")
            {
                txttimkiem.Text = "Tìm Kiếm Nhân Viên";
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
