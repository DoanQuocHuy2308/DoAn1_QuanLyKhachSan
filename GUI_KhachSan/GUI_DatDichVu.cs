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
    public partial class GUI_DatDichVu : Form
    {
        BLL_DichVu blldv = new BLL_DichVu();
        BLL_DatDichVu bllddv = new BLL_DatDichVu();
        DTO_DatDichVu ddv = new DTO_DatDichVu();
        public GUI_DatDichVu()
        {
            InitializeComponent();
            HienThiDichVu();
            HienThiDatDichVu();
            dtgvdatdichvu.DefaultCellStyle.ForeColor = Color.Black;
            dtgvdichvu.DefaultCellStyle.ForeColor = Color.Black;
        }
        private void HienThiDichVu()
        {
            dtgvdichvu.Columns[0].DataPropertyName = "ID_DichVu";
            dtgvdichvu.Columns[1].DataPropertyName = "Ten_DichVu";
            dtgvdichvu.Columns[2].DataPropertyName = "ID_LoaiDichVu";
            dtgvdichvu.Columns[3].DataPropertyName = "Ten_LoaiDichVu";
            dtgvdichvu.Columns[4].DataPropertyName = "Gia_DichVu";
            dtgvdichvu.DataSource = blldv.HienThiDuLieuDichVu();
        }
        private void HienThiDatDichVu()
        {
            dtgvdatdichvu.Columns[0].DataPropertyName = "ID_DatDichVu";
            dtgvdatdichvu.Columns[1].DataPropertyName = "ID_NhanVien";
            dtgvdatdichvu.Columns[2].DataPropertyName = "ID_KhachHang";
            dtgvdatdichvu.Columns[3].DataPropertyName = "ID_DichVu";
            dtgvdatdichvu.Columns[4].DataPropertyName = "ID_KhuyenMai";
            dtgvdatdichvu.Columns[5].DataPropertyName = "SoLuong";
            dtgvdatdichvu.Columns[6].DataPropertyName = "NgayDat";
            dtgvdatdichvu.Columns[7].DataPropertyName = "TongTien";
            dtgvdatdichvu.Columns[8].DataPropertyName = "TrangThai";
            dtgvdatdichvu.Columns[9].DataPropertyName = "HinhThucThanhToan";
            dtgvdatdichvu.Columns[10].DataPropertyName = "KetQua";
            dtgvdatdichvu.DataSource = bllddv.DuLieuDatDichVu();
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            GUI_TrangChuNhanVien tcnv = new GUI_TrangChuNhanVien();
            this.Hide();
            tcnv.ShowDialog();
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

        private void btnthemddv_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtidnhanvien.Text) ||
               string.IsNullOrEmpty(txtidkhachhang.Text) ||
               string.IsNullOrEmpty(txtiddichvu.Text) ||
               string.IsNullOrEmpty(txtidkhuyenmai.Text) ||
               string.IsNullOrEmpty(txtsoluong.Text) ||
               string.IsNullOrEmpty(cbotrangthai.Text) ||
               string.IsNullOrEmpty(cbohinhthucthanhtoan.Text) ||
               string.IsNullOrEmpty(cboketqua.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ddv.ID_NhanVien = int.Parse(txtidnhanvien.Text); ;
            ddv.ID_KhachHang = int.Parse(txtidkhachhang.Text);
            ddv.ID_DichVu = int.Parse(txtiddichvu.Text);
            ddv.ID_KhuyenMai = txtidkhuyenmai.Text;
            ddv.SoLuong = int.Parse(txtsoluong.Text);
            ddv.NgayDat = dtpkngaydat.Value;
            decimal tongTien = bllddv.TinhTongTienDatDichVu(ddv);
            txttongtien.Text = tongTien.ToString();
            ddv.TrangThai = cbotrangthai.Text;
            ddv.HinhThucThanhToan = cbohinhthucthanhtoan.Text;
            ddv.KetQua = cboketqua.Text;

            try
            {
                bllddv.ThemDonDichVu(ddv);
                MessageBox.Show("Đặt dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDatDichVu();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Check In thất bại. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgvdatdichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvdatdichvu.Rows[e.RowIndex];
                txtiddatdichvu.Text = row.Cells["ID_DatDichVu"].Value.ToString();
                txtidnhanvien.Text = row.Cells["ID_NhanVien"].Value.ToString();
                txtidkhachhang.Text = row.Cells["ID_KhachHang"].Value.ToString();
                txtiddichvu.Text = row.Cells["ID_DichVu"].Value.ToString();
                txtidkhuyenmai.Text = row.Cells["ID_KhuyenMai"].Value.ToString();
                txtsoluong.Text = row.Cells["SoLuong"].Value.ToString();
                dtpkngaydat.Value = Convert.ToDateTime(row.Cells["NgayDat"].Value);
                txttongtien.Text = row.Cells["TongTien"].Value.ToString();
                cbotrangthai.SelectedItem = row.Cells["TrangThai"].Value.ToString();
                cbohinhthucthanhtoan.SelectedItem = row.Cells["HinhThucThanhToan"].Value.ToString();
                cboketqua.SelectedItem = row.Cells["KetQua"].Value.ToString();
            }
        }

        private void btnresetddv_Click(object sender, EventArgs e)
        {
            foreach (Control c in panelchucnang.Controls)
            {
                if (c is Guna2TextBox)
                {
                    (c as Guna2TextBox).Text = "";
                }
                if (c is Guna2ComboBox)
                {
                    (c as Guna2ComboBox).SelectedIndex = -1;
                }
                dtpkngaydat.Value = DateTime.Now;
                HienThiDatDichVu();
                HienThiDichVu();
            }
        }

        private void btnsuaddv_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(txtiddatdichvu.Text) ||
                string.IsNullOrEmpty(txtidnhanvien.Text) ||
               string.IsNullOrEmpty(txtidkhachhang.Text) ||
               string.IsNullOrEmpty(txtiddichvu.Text) ||
               string.IsNullOrEmpty(txtidkhuyenmai.Text) ||
               string.IsNullOrEmpty(txtsoluong.Text) ||
               string.IsNullOrEmpty(cbotrangthai.Text) ||
               string.IsNullOrEmpty(cbohinhthucthanhtoan.Text) ||
               string.IsNullOrEmpty(cboketqua.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ddv.ID_DatDichVu = int.Parse(txtiddatdichvu.Text);
            ddv.ID_NhanVien = int.Parse(txtidnhanvien.Text); ;
            ddv.ID_KhachHang = int.Parse(txtidkhachhang.Text);
            ddv.ID_DichVu = int.Parse(txtiddichvu.Text);
            ddv.ID_KhuyenMai = txtidkhuyenmai.Text;
            ddv.SoLuong = int.Parse(txtsoluong.Text);
            ddv.NgayDat = dtpkngaydat.Value;
            decimal tongTien = bllddv.TinhTongTienDatDichVu(ddv);
            txttongtien.Text = tongTien.ToString();
            ddv.TrangThai = cbotrangthai.Text;
            ddv.HinhThucThanhToan = cbohinhthucthanhtoan.Text;
            ddv.KetQua = cboketqua.Text;

            try
            {
                bllddv.UPDATE(ddv);
                MessageBox.Show("Sửa Thông Tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDatDichVu();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sửa Thông Tin thất bại. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoaddv_Click(object sender, EventArgs e)
        {
            ddv.ID_DatDichVu = int.Parse(txtiddatdichvu.Text);
            if (string.IsNullOrEmpty(ddv.ID_DatDichVu.ToString()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                DialogResult kt = MessageBox.Show("Bạn chắc chắn muốn xóa", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (kt == DialogResult.OK)
                {
                    bllddv.DELETE(ddv);
                    MessageBox.Show("Xóa đơn đặt dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDatDichVu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xóa đơn đặt dịch vụ thất bại. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btntimkiemddv_Click(object sender, EventArgs e)
        {
            int.TryParse(txtiddatdichvu.Text, out int idddv);
            ddv.ID_DatDichVu = idddv;
            int.TryParse(txtidnhanvien.Text, out int idnv);
            ddv.ID_NhanVien = idnv;
            int.TryParse(txtidkhachhang.Text, out int idkh);
            ddv.ID_KhachHang = idkh;
            int.TryParse(txtiddichvu.Text, out int iddv);
            ddv.ID_DichVu = iddv;
            ddv.ID_KhuyenMai = txtidkhuyenmai.Text;
            int.TryParse(txtsoluong.Text, out int soluong);
            ddv.SoLuong = soluong;
            ddv.NgayDat = dtpkngaydat.Value;
            ddv.TrangThai = cbotrangthai.Text;
            ddv.HinhThucThanhToan = cbohinhthucthanhtoan.Text;
            ddv.KetQua = cboketqua.Text;
            DataTable dt = bllddv.TimKiem(txttimkiem.Text, ddv);
            dtgvdatdichvu.Columns[0].DataPropertyName = "ID_DatDichVu";
            dtgvdatdichvu.Columns[1].DataPropertyName = "ID_NhanVien";
            dtgvdatdichvu.Columns[2].DataPropertyName = "ID_KhachHang";
            dtgvdatdichvu.Columns[3].DataPropertyName = "ID_DichVu";
            dtgvdatdichvu.Columns[4].DataPropertyName = "ID_KhuyenMai";
            dtgvdatdichvu.Columns[5].DataPropertyName = "SoLuong";
            dtgvdatdichvu.Columns[6].DataPropertyName = "NgayDat";
            dtgvdatdichvu.Columns[7].DataPropertyName = "TongTien";
            dtgvdatdichvu.Columns[8].DataPropertyName = "TrangThai";
            dtgvdatdichvu.Columns[9].DataPropertyName = "HinhThucThanhToan";
            dtgvdatdichvu.Columns[10].DataPropertyName = "KetQua";
            dtgvdatdichvu.DataSource = dt;
        }
    }
}
