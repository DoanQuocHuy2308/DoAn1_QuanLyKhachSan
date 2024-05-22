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
    public partial class GUI_Phong : Form
    {
        public GUI_Phong()
        {
            InitializeComponent();
            HienThiPhong();
            HienThiIDLoaiPhong();
            HienThiLoaiPhong();
            txtidphong.Focus();
            cboidloaiphong.SelectedIndex = -1;
        }
        BLL_Phong p = new BLL_Phong();
        BLL_LoaiPhong lp = new BLL_LoaiPhong();
        DTO_Phong DTO_P = new DTO_Phong();
        DTO_LoaiPhong DTO_LP = new DTO_LoaiPhong();
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
            GUI_TrangChuAdmin trangChuAdmin = new GUI_TrangChuAdmin();
            this.Hide();
            trangChuAdmin.ShowDialog();
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void HienThiPhong()
        {
            dtgvphong.Columns[0].DataPropertyName = "ID_Phong";
            dtgvphong.Columns[1].DataPropertyName = "Ten_Phong";
            dtgvphong.Columns[2].DataPropertyName = "ID_LoaiPhong";
            dtgvphong.Columns[3].DataPropertyName = "Ten_LoaiPhong";
            dtgvphong.Columns[4].DataPropertyName = "SucChua";
            dtgvphong.Columns[5].DataPropertyName = "Gia_Phong";
            dtgvphong.DataSource = p.HienThiDuLieuPhong();
        }
        private void HienThiLoaiPhong()
        {
            dtgvloaiphong.Columns[0].DataPropertyName = "ID_LoaiPhong";
            dtgvloaiphong.Columns[1].DataPropertyName = "Ten_LoaiPhong";
            dtgvloaiphong.Columns[2].DataPropertyName = "SucChua";
            dtgvloaiphong.Columns[3].DataPropertyName = "Gia_Phong";
            dtgvloaiphong.DataSource = lp.HienThiDuLieuLoaiPhong();
        }
        private void btnthemphong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txttenphong.Text) || string.IsNullOrEmpty(cboidloaiphong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DTO_P.Ten_Phong = txttenphong.Text;
            DTO_P.ID_LoaiPhong = int.Parse(cboidloaiphong.Text);
            try
            {
                if (p.KTTrungTen(DTO_P))
                {
                    MessageBox.Show("Phòng này đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    p.ThemPhong(DTO_P);
                    MessageBox.Show("Thêm phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiPhong();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Thêm phòng thất bại. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgvphong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvphong.Rows[e.RowIndex];
                txtidphong.Text = row.Cells["ID_Phong"].Value.ToString();
                txttenphong.Text = row.Cells["Ten_Phong"].Value.ToString();
                cboidloaiphong.SelectedValue = row.Cells["ID_LP"].Value.ToString();
                txtloaiphong.Text = row.Cells["Ten_LP"].Value.ToString();
                txtsucchua.Text = row.Cells["SucChuaP"].Value.ToString();
                txtgiaphong.Text = row.Cells["Gia"].Value.ToString();
            }
        }
        private void HienThiIDLoaiPhong()
        {
            cboidloaiphong.ValueMember = "ID_LoaiPhong";
            cboidloaiphong.DataSource = lp.HienThiDuLieuIDLoaiPhong();
            cboidloaiphong.DisplayMember = "ID_LoaiPhong";
        }

        private void btnresetlp_Click(object sender, EventArgs e)
        {
            foreach (Control c in panelcnloaiphong.Controls)
            {
                if (c is Guna2TextBox)
                {
                    (c as Guna2TextBox).Text = "";
                }
                txttimkiemlp.Text = "Tìm Kiếm Loại Phòng";
                HienThiLoaiPhong();
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            foreach (Control c in panelcnphong.Controls)
            {
                if (c is Guna2TextBox)
                {
                    (c as Guna2TextBox).Text = "";
                }
                txttimkiem.Text = "Tìm Kiếm Phòng";
                HienThiIDLoaiPhong();
                HienThiPhong();
                cboidloaiphong.SelectedIndex = -1;
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtidphong.Text) || string.IsNullOrEmpty(txttenphong.Text) || string.IsNullOrEmpty(cboidloaiphong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DTO_P.ID_Phong = int.Parse(txtidphong.Text);
            DTO_P.Ten_Phong = txttenphong.Text;
            DTO_P.ID_LoaiPhong = int.Parse(cboidloaiphong.Text);
            try
            {
                p.Update(DTO_P);
                MessageBox.Show("Sửa phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sửa phòng thất bại. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtidphong.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int.TryParse(txtidloaiphong.Text, out int idPhong);
            DTO_P.ID_Phong = idPhong;
            if (p.KTIDTonTai(DTO_P))
            {
                MessageBox.Show("Không thể xóa phòng vì còn tồn tại khóa ngoại liên quan.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult kt = MessageBox.Show("Bạn chắc chắn muốn xóa", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (kt == DialogResult.OK)
                {
                    p.Delete(DTO_P);
                    MessageBox.Show("Xóa phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiPhong();
                }
            }
        }

        private void btntimkiemphong_Click(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "Tìm Kiếm Phòng")
            {
                txttimkiem.Text = "";
            }
            int.TryParse(txtidphong.Text, out int idPhong);
            DTO_P.ID_Phong=idPhong;
            DTO_P.Ten_Phong=txttenphong.Text;
            int.TryParse(cboidloaiphong.Text, out int idloaiphong);
            DTO_P.ID_LoaiPhong=idloaiphong;
            DataTable dt = p.TimKiemPhong(txttimkiem.Text,DTO_P);
            dtgvphong.Columns["ID_Phong"].DataPropertyName = "ID_Phong";
            dtgvphong.Columns["Ten_Phong"].DataPropertyName = "Ten_Phong";
            dtgvphong.Columns["ID_LP"].DataPropertyName = "ID_LoaiPhong";
            dtgvphong.Columns["Ten_LP"].DataPropertyName = "Ten_LoaiPhong";
            dtgvphong.Columns["SucChuaP"].DataPropertyName = "SucChua";
            dtgvphong.Columns["Gia"].DataPropertyName = "Gia_Phong";
            dtgvphong.DataSource = dt;
        }

        private void btnthemlp_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_LP.Ten_LoaiPhong = txttenloaiphong.Text;
                int.TryParse(txtsucchualp.Text, out int sucChua);
                DTO_LP.SucChua = sucChua;
                decimal.TryParse(txtgialp.Text, out decimal giaPhong);
                DTO_LP.Gia_Phong = giaPhong;
                if (string.IsNullOrEmpty(DTO_LP.Ten_LoaiPhong) || DTO_LP.SucChua == 0 || DTO_LP.Gia_Phong == 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (lp.KTTrungTen(DTO_LP))
                {
                    MessageBox.Show("Loại Phòng này đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    lp.ThemLoaiPhong(DTO_LP);
                    MessageBox.Show("Thêm loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiLoaiPhong();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtidphong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtsucchualp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtgialp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtidloaiphong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dtgvloaiphong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvloaiphong.Rows[e.RowIndex];
                txtidloaiphong.Text = row.Cells["ID_LoaiPhong"].Value.ToString();
                txttenloaiphong.Text = row.Cells["Ten_LoaiPhong"].Value.ToString();
                txtsucchualp.Text = row.Cells["SucChua"].Value.ToString();
                txtgialp.Text = row.Cells["Gia_Phong"].Value.ToString();
            }
        }

        private void btnsualp_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_LP.ID_LoaiPhong = int.Parse(txtidloaiphong.Text);
                DTO_LP.Ten_LoaiPhong = txttenloaiphong.Text;
                int.TryParse(txtsucchualp.Text, out int sucChua);
                DTO_LP.SucChua = sucChua;
                decimal.TryParse(txtgialp.Text, out decimal giaPhong);
                DTO_LP.Gia_Phong = giaPhong;
                if (string.IsNullOrEmpty(DTO_LP.ID_LoaiPhong.ToString()) || string.IsNullOrEmpty(DTO_LP.Ten_LoaiPhong) || string.IsNullOrEmpty(DTO_LP.SucChua.ToString()) || string.IsNullOrEmpty(DTO_LP.Gia_Phong.ToString()))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    lp.Update(DTO_LP);
                    MessageBox.Show("sửa thông tin loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiLoaiPhong();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoalp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtidloaiphong.Text))
            {
                MessageBox.Show("Vui lòng nhập mã loại phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int.TryParse(txtidloaiphong.Text, out int iDLoaiPhong);
            DTO_LP.ID_LoaiPhong=iDLoaiPhong;
            if (lp.KTIDTonTai(DTO_LP))
            {
                MessageBox.Show("Không thể xóa loại phòng vì còn tồn tại khóa ngoại liên quan.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lp.Delete(DTO_LP);
                MessageBox.Show("Xóa loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiLoaiPhong();
            }
        }
        private void btntimkiemlp_Click(object sender, EventArgs e)
        {
            if (txttimkiemlp.Text == "Tìm Kiếm Loại Phòng")
            {
                txttimkiemlp.Text = "";
            }
            int.TryParse(txtidloaiphong.Text, out int iDLoaiPhong);
            DTO_LP.ID_LoaiPhong = iDLoaiPhong;
            DTO_LP.Ten_LoaiPhong = txttenloaiphong.Text;
            int.TryParse(txtsucchualp.Text, out int succhua);
            DTO_LP.SucChua = succhua;
            decimal.TryParse(txtgialp.Text, out decimal iDgiaphong);
            DTO_LP.Gia_Phong = iDgiaphong;
            DataTable dt = lp.TimKiemLoaiPhong(txttimkiemlp.Text, DTO_LP);
            dtgvloaiphong.Columns[0].DataPropertyName = "ID_LoaiPhong";
            dtgvloaiphong.Columns[1].DataPropertyName = "Ten_LoaiPhong";
            dtgvloaiphong.Columns[2].DataPropertyName = "SucChua";
            dtgvloaiphong.Columns[3].DataPropertyName = "Gia_Phong";
            dtgvloaiphong.DataSource = dt;
        }

        private void txttimkiem_Leave(object sender, EventArgs e)
        {
            if(txttimkiem.Text == "")
            {
                txttimkiem.Text = "Tìm Kiếm Phòng";
            }
        }

        private void txttimkiem_Enter(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "Tìm Kiếm Phòng")
            {
                txttimkiem.Text = "";
            }
        }

        private void txttimkiemlp_Leave(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "")
            {
                txttimkiem.Text = "Tìm Kiếm Loại Phòng";
            }
        }

        private void txttimkiemlp_Enter(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "Tìm Kiếm Loại Phòng")
            {
                txttimkiem.Text = "";
            }
        }
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private void GUI_Phong_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
