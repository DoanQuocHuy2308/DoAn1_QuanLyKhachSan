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
    public partial class GUI_KhuyenMai : Form
    {
        public GUI_KhuyenMai()
        {
            InitializeComponent();
            HienThiKhuyenMai();
        }
        BLL_KhuyenMai bllkm = new BLL_KhuyenMai();
        DTO_KhuyenMai km = new DTO_KhuyenMai();
        private void btnthoat_Click(object sender, EventArgs e)
        {
            GUI_TrangChuNhanVien tcnv = new GUI_TrangChuNhanVien();
            this.Hide();
            tcnv.ShowDialog();
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
        public void HienThiKhuyenMai()
        {
            dtgvkhuyenmai.Columns[0].DataPropertyName = "ID_KhuyenMai";
            dtgvkhuyenmai.Columns[1].DataPropertyName = "Ten_KhuyenMai";
            dtgvkhuyenmai.Columns[2].DataPropertyName = "GiaTri";
            dtgvkhuyenmai.Columns[3].DataPropertyName = "MoTa";
            dtgvkhuyenmai.Columns[4].DataPropertyName = "NgayBatDau";
            dtgvkhuyenmai.Columns[5].DataPropertyName = "NgayKetThuc";
            dtgvkhuyenmai.DataSource = bllkm.DuLieuKhuyenMai();
        }
        private void btnthemkm_Click(object sender, EventArgs e)
        {
            km.ID_KhuyenMai = txtidkhuyenmai.Text;
            km.Ten_KhuyenMai = txttenkhuyenmai.Text;
            km.GiaTri = decimal.Parse(txtgiatri.Text);
            km.MoTa = txtmota.Text;
            km.NgayBatDau = dtpkngaybatdau.Value;
            km.NgayKetThuc = dtpkngayketthuc.Value;
            if(string.IsNullOrEmpty(km.Ten_KhuyenMai) || string.IsNullOrEmpty(km.GiaTri.ToString()) || string.IsNullOrEmpty(km.MoTa))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(km.NgayBatDau > km.NgayKetThuc)
            {
                MessageBox.Show("Vui lòng nhập lại thời gian khuyến mại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                bllkm.Add(km);
                MessageBox.Show("Thêm khuyến mại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiKhuyenMai();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Thêm khuyến mại thất bại. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgvkhuyenmai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvkhuyenmai.Rows[e.RowIndex];
                txtidkhuyenmai.Text = row.Cells["ID_KhuyenMai"].Value.ToString();
                txttenkhuyenmai.Text = row.Cells["Ten_KhuyenMai"].Value.ToString();
                txtgiatri.Text = row.Cells["GiaTri"].Value.ToString();
                txtmota.Text = row.Cells["MoTa"].Value.ToString();
                dtpkngaybatdau.Value = Convert.ToDateTime(row.Cells["NgayBatDau"].Value);
                dtpkngayketthuc.Value = Convert.ToDateTime(row.Cells["NgayKetThuc"].Value);
            }
        }

        private void btnresetkm_Click(object sender, EventArgs e)
        {
            foreach (Control c in panelchucnang.Controls)
            {
                if (c is Guna2TextBox)
                {
                    (c as Guna2TextBox).Text = "";
                }
                if(c is Guna2DateTimePicker)
                {
                    (c as Guna2DateTimePicker).Value= DateTime.Now;
                }
                txttimkiem.Text = "Tìm Kiếm Khuyến Mại";
                HienThiKhuyenMai();
            }
        }

        private void btnsuakm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtidkhuyenmai.Text) || string.IsNullOrEmpty(km.Ten_KhuyenMai) || string.IsNullOrEmpty(km.GiaTri.ToString()) || string.IsNullOrEmpty(km.MoTa))
            {
                MessageBox.Show("Vui lòng chọn một khuyến mại để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            km.ID_KhuyenMai = txtidkhuyenmai.Text;
            km.Ten_KhuyenMai = txttenkhuyenmai.Text;
            km.GiaTri = decimal.Parse(txtgiatri.Text);
            km.MoTa = txtmota.Text;
            km.NgayBatDau = dtpkngaybatdau.Value;
            km.NgayKetThuc = dtpkngayketthuc.Value;
            if (km.NgayBatDau > km.NgayKetThuc)
            {
                MessageBox.Show("Vui lòng nhập lại thời gian khuyến mại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    bllkm.Update(km);
                    MessageBox.Show("Sửa thông tin khuyến mại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiKhuyenMai();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Sửa thông tin khuyến mại thất bại. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnxoakm_Click(object sender, EventArgs e)
        {
            km.ID_KhuyenMai = txtidkhuyenmai.Text;
            if (string.IsNullOrEmpty(txtidkhuyenmai.Text))
            {
                MessageBox.Show("Vui lòng chọn một khuyến mại để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (bllkm.KTIDTonTaiDP(km))
                {
                    MessageBox.Show("Vẫn còn đơn đặt phòng sử dụng khuyến mại đó, vui lòng xóa các đơn đặt phòng đó trước khi xóa khuyến mại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (bllkm.KTIDTonTaiDDV(km))
                {
                    MessageBox.Show("Vẫn còn đơn đặt dịch vụ sử dụng khuyến mại đó, vui lòng xóa các đơn đặt phòng đó trước khi xóa khuyến mại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    DialogResult kt = MessageBox.Show("Bạn chắc chắn muốn xóa","Thông Báo",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (kt == DialogResult.OK)
                    {
                        bllkm.Delete(km);
                        MessageBox.Show("Xóa thông tin khuyến mại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiKhuyenMai();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xóa thông tin khuyến mại thất bại. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btntimkiemkm_Click(object sender, EventArgs e)
        {
            km.ID_KhuyenMai = txtidkhuyenmai.Text;
            if(txttimkiem.Text == "Tìm Kiếm Khuyến Mại")
            {
                txttimkiem.Text = "";
            }
            km.Ten_KhuyenMai = txttenkhuyenmai.Text;
            decimal.TryParse(txtgiatri.Text, out decimal giatri);
            km.GiaTri = giatri;
            km.MoTa = txtmota.Text;
            km.NgayBatDau = dtpkngaybatdau.Value;
            km.NgayKetThuc = dtpkngayketthuc.Value;
            DataTable dt = bllkm.TimKiem(txttimkiem.Text, km);
            dtgvkhuyenmai.Columns[0].DataPropertyName = "ID_KhuyenMai";
            dtgvkhuyenmai.Columns[1].DataPropertyName = "Ten_KhuyenMai";
            dtgvkhuyenmai.Columns[2].DataPropertyName = "GiaTri";
            dtgvkhuyenmai.Columns[3].DataPropertyName = "MoTa";
            dtgvkhuyenmai.Columns[4].DataPropertyName = "NgayBatDau";
            dtgvkhuyenmai.Columns[5].DataPropertyName = "NgayKetThuc";
            dtgvkhuyenmai.DataSource = dt;
        }

        private void txttimkiem_Enter(object sender, EventArgs e)
        {
            if(txttimkiem.Text == "Tìm Kiếm Khuyến Mại")
            {
                txttimkiem.Text = "";
            }
        }

        private void txttimkiem_Leave(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "")
            {
                txttimkiem.Text = "Tìm Kiếm Khuyến Mại";
            }
        }

        private void txtgiatri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btncheckkhuyenmai_Click(object sender, EventArgs e)
        {
            dtgvkhuyenmai.Columns[0].DataPropertyName = "ID_KhuyenMai";
            dtgvkhuyenmai.Columns[1].DataPropertyName = "Ten_KhuyenMai";
            dtgvkhuyenmai.Columns[2].DataPropertyName = "GiaTri";
            dtgvkhuyenmai.Columns[3].DataPropertyName = "MoTa";
            dtgvkhuyenmai.Columns[4].DataPropertyName = "NgayBatDau";
            dtgvkhuyenmai.Columns[5].DataPropertyName = "NgayKetThuc";
            dtgvkhuyenmai.DataSource = bllkm.KiemTraKhuyenMai();
        }
    }
}
