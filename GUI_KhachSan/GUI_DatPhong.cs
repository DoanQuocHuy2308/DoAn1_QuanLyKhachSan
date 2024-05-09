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
    public partial class GUI_DatPhong : Form
    {
        public GUI_DatPhong()
        {
            InitializeComponent();
            HienThiPhong();
            HienThiDatPhong();
        }
        BLL_DatPhong blldp = new BLL_DatPhong();
        BLL_Phong bllp = new BLL_Phong();
        DTO_DatPhong dp = new DTO_DatPhong();
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
        private void HienThiPhong()
        {
            dtgvphong.Columns[0].DataPropertyName = "ID_Phong";
            dtgvphong.Columns[1].DataPropertyName = "Ten_Phong";
            dtgvphong.Columns[2].DataPropertyName = "ID_LoaiPhong";
            dtgvphong.Columns[3].DataPropertyName = "Ten_LoaiPhong";
            dtgvphong.Columns[4].DataPropertyName = "SucChua";
            dtgvphong.Columns[5].DataPropertyName = "Gia_Phong";
            dtgvphong.DataSource = bllp.HienThiDuLieuPhong();
        }
        private void HienThiDatPhong()
        {
            dtgvdatphong.Columns[0].DataPropertyName = "ID_DatPhong";
            dtgvdatphong.Columns[1].DataPropertyName = "ID_NhanVien";
            dtgvdatphong.Columns[2].DataPropertyName = "ID_KhachHang";
            dtgvdatphong.Columns[3].DataPropertyName = "ID_Phong";
            dtgvdatphong.Columns[4].DataPropertyName = "ID_KhuyenMai";
            dtgvdatphong.Columns[5].DataPropertyName = "Check_In";
            dtgvdatphong.Columns[6].DataPropertyName = "Check_Out";
            dtgvdatphong.Columns[7].DataPropertyName = "TienCoc";
            dtgvdatphong.Columns[8].DataPropertyName = "TongTien";
            dtgvdatphong.Columns[9].DataPropertyName = "TrangThai";
            dtgvdatphong.Columns[10].DataPropertyName = "HinhThucThanhToan";
            dtgvdatphong.Columns[11].DataPropertyName = "KetQua";
            dtgvdatphong.DataSource = blldp.DuLieuDatPhong();
        }
        private void btnthemdp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtidnhanvien.Text) ||
                string.IsNullOrEmpty(txtidkhachhang.Text) ||
                string.IsNullOrEmpty(txtidphong.Text) ||
                string.IsNullOrEmpty(txtidkhuyenmai.Text) ||
                string.IsNullOrEmpty(txttiencoc.Text) ||
                string.IsNullOrEmpty(cbotrangthai.Text) ||
                string.IsNullOrEmpty(cbohinhthucthanhtoan.Text) ||
                string.IsNullOrEmpty(cboketqua.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dp.ID_DatPhong = int.Parse(txtiddatphong.Text);
            dp.ID_NhanVien = int.Parse(txtidnhanvien.Text); ;
            dp.ID_KhachHang = int.Parse(txtidkhachhang.Text);
            dp.ID_Phong = int.Parse(txtidphong.Text);
            dp.ID_KhuyenMai = int.Parse(txtidkhuyenmai.Text); 
            dp.Check_In = dtpkcheckin.Value;
            dp.Check_Out = dtpkcheckout.Value;
            dp.TienCoc = decimal.Parse(txttiencoc.Text);
            decimal tongTien = blldp.TinhTongTienDatPhong(dp);
            txttongtien.Text = tongTien.ToString();
            dp.TrangThai = cbotrangthai.Text;
            dp.HinhThucThanhToan = cbohinhthucthanhtoan.Text;
            dp.KetQua = cboketqua.Text;

            try
            {
                if (blldp.KTMaKH(dp))
                {
                    MessageBox.Show("Khách hàng này đã đặt phòng với thời gian này rồi. Vui lòng chọn phòng hoặc thời giản khác ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (blldp.KTMaP(dp))
                {
                    MessageBox.Show("Phòng này đã được đặt với thời gian này rồi , Vui lòng chọn phòng hoặc thời giản khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                blldp.CheckIn(dp);
                MessageBox.Show("Check In thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDatPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Check In thất bại. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btncheckdp_Click(object sender, EventArgs e)
        {
            dp.Check_In = dtpkcheckin.Value;
            dp.Check_Out = dtpkcheckout.Value;
            DataTable dt = blldp.KTPhongTrong(dp);
            if (dt != null && dt.Rows.Count > 0)
            {
                dtgvphong.Columns[0].DataPropertyName = "ID_Phong";
                dtgvphong.Columns[1].DataPropertyName = "Ten_Phong";
                dtgvphong.Columns[2].DataPropertyName = "ID_LoaiPhong";
                dtgvphong.Columns[3].DataPropertyName = "Ten_LoaiPhong";
                dtgvphong.Columns[4].DataPropertyName = "SucChua";
                dtgvphong.Columns[5].DataPropertyName = "Gia_Phong";
                dtgvphong.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Hiện không còn phòng trống trong khoảng thời gian đã chọn.", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            }
        }

        private void dtgvdatphong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvdatphong.Rows[e.RowIndex];
                txtiddatphong.Text = row.Cells["ID_DatPhong"].Value.ToString();
                txtidnhanvien.Text = row.Cells["ID_NhanVien"].Value.ToString();
                txtidkhachhang.Text = row.Cells["ID_KhachHang"].Value.ToString();
                txtidphong.Text = row.Cells["ID_Phong"].Value.ToString();
                txtidkhuyenmai.Text = row.Cells["ID_KhuyenMai"].Value.ToString();
                dtpkcheckin.Value = Convert.ToDateTime(row.Cells["Check_In"].Value);
                dtpkcheckout.Value = Convert.ToDateTime(row.Cells["Check_Out"].Value);
                txttiencoc.Text = row.Cells["TienCoc"].Value.ToString();
                txttongtien.Text = row.Cells["TongTien"].Value.ToString();
                cbotrangthai.SelectedItem = row.Cells["TrangThai"].Value.ToString();
                cbohinhthucthanhtoan.SelectedItem = row.Cells["HinhThucThanhToan"].Value.ToString();
                cboketqua.SelectedItem = row.Cells["KetQua"].Value.ToString();
            }
        }

        private void btnresetdp_Click(object sender, EventArgs e)
        {
            foreach (Control c in panelchucnang.Controls)
            {
                if (c is Guna2TextBox)
                {
                    (c as Guna2TextBox).Text = "";
                }
                if(c is Guna2ComboBox)
                {
                    (c as Guna2ComboBox).SelectedIndex = -1;
                }
                HienThiDatPhong();
            }
        }

        private void btnsuadp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtiddatphong.Text) ||
                string.IsNullOrEmpty(txtidnhanvien.Text) ||
                string.IsNullOrEmpty(txtidkhachhang.Text) || 
                string.IsNullOrEmpty(txtidkhuyenmai.Text) ||
                string.IsNullOrEmpty(txtidphong.Text) ||
                string.IsNullOrEmpty(txttiencoc.Text) ||
                string.IsNullOrEmpty(cbotrangthai.Text) ||
                string.IsNullOrEmpty(cbohinhthucthanhtoan.Text) ||
                string.IsNullOrEmpty(cboketqua.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dp.ID_DatPhong = int.Parse(txtiddatphong.Text);
            dp.ID_NhanVien = int.Parse(txtidnhanvien.Text); ;
            dp.ID_KhachHang = int.Parse(txtidkhachhang.Text); 
            dp.ID_Phong = int.Parse(txtidphong.Text);
            dp.ID_KhuyenMai = int.Parse(txtidkhuyenmai.Text);
            dp.Check_In = dtpkcheckin.Value;
            dp.Check_Out = dtpkcheckout.Value;
            dp.TienCoc = decimal.Parse(txttiencoc.Text);
            decimal tongTien = blldp.TinhTongTienDatPhong(dp);
            txttongtien.Text = tongTien.ToString();
            dp.TrangThai = cbotrangthai.Text;
            dp.HinhThucThanhToan = cbohinhthucthanhtoan.Text;
            dp.KetQua = cboketqua.Text;

            try
            {
                blldp.UPDATE(dp);
                MessageBox.Show("Sửa Thông Tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDatPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sửa Thông Tin thất bại. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoadp_Click(object sender, EventArgs e)
        {
            dp.ID_DatPhong = int.Parse(txtiddatphong.Text);
            if(string.IsNullOrEmpty(dp.ID_DatPhong.ToString()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                blldp.CheckOut(dp);
                MessageBox.Show("Check Out thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDatPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Check Out thất bại. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
