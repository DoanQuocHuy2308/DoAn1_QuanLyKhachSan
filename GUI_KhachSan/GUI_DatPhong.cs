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
    public partial class GUI_DatPhong : Form
    {
        public GUI_DatPhong()
        {
            InitializeComponent();
            HienThiPhong();
            HienThiDatPhong();
            dtgvdatphong.DefaultCellStyle.ForeColor = Color.Black;
            dtgvphong.DefaultCellStyle.ForeColor = Color.Black;
        }
        BLL_DatPhong blldp = new BLL_DatPhong();
        BLL_Phong bllp = new BLL_Phong();
        BLL_In bllin = new BLL_In();
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
            dp.ID_NhanVien = int.Parse(txtidnhanvien.Text); ;
            dp.ID_KhachHang = int.Parse(txtidkhachhang.Text);
            dp.ID_Phong = int.Parse(txtidphong.Text);
            dp.ID_KhuyenMai = txtidkhuyenmai.Text; 
            dp.Check_In = dtpkcheckin.Value;
            dp.Check_Out = dtpkcheckout.Value;
            dp.TienCoc = decimal.Parse(txttiencoc.Text);
            decimal tongTien = blldp.TinhTongTienDatPhong(dp);
            txttongtien.Text = tongTien.ToString();
            dp.TrangThai = cbotrangthai.Text;
            dp.HinhThucThanhToan = cbohinhthucthanhtoan.Text;
            dp.KetQua = cboketqua.Text;
            if(dp.Check_In > dp.Check_Out)
            {
                MessageBox.Show("Ngày Check In không được lớn hơn ngày Check Out.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                txttimkiem.Text = "Tìm Kiếm Mã Đặt Phòng";
                dtpkcheckin.Value = DateTime.Now;
                dtpkcheckout.Value = DateTime.Now;
                HienThiDatPhong();
                HienThiPhong();
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
            dp.ID_KhuyenMai = txtidkhuyenmai.Text;
            dp.Check_In = dtpkcheckin.Value;
            dp.Check_Out = dtpkcheckout.Value;
            dp.TienCoc = decimal.Parse(txttiencoc.Text);
            decimal tongTien = blldp.TinhTongTienDatPhong(dp);
            txttongtien.Text = tongTien.ToString();
            dp.TrangThai = cbotrangthai.Text;
            dp.HinhThucThanhToan = cbohinhthucthanhtoan.Text;
            dp.KetQua = cboketqua.Text;
            if (dp.Check_In > dp.Check_Out)
            {
                MessageBox.Show("Ngày Check In không được lớn hơn ngày Check Out.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
            DataTable dt = bllin.InDonDatPhong(dp);
            if (string.IsNullOrEmpty(dp.ID_DatPhong.ToString()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                DialogResult kt = MessageBox.Show("Bạn chắc chắn muốn check out", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (kt == DialogResult.OK)
                {
                    blldp.CheckOut(dp);
                    MessageBox.Show("Check Out thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDatPhong();
                    InHoaDonDatPhong incheckout = new InHoaDonDatPhong();
                    incheckout.SetDataSource(dt);
                    GUI_InHoaDon inhd = new GUI_InHoaDon();
                    inhd.frmInHoaDon.ReportSource = incheckout;
                    this.Hide();
                    inhd.ShowDialog();
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Check Out thất bại. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btntimkiemdp_Click(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "Tìm Kiếm Mã Đặt Phòng")
            {
                txttimkiem.Text = "";
            }
            int.TryParse(txtiddatphong.Text, out int iddp);
            dp.ID_DatPhong = iddp;
            int.TryParse(txtidnhanvien.Text, out int idnv);
            dp.ID_NhanVien = idnv;
            int.TryParse(txtidkhachhang.Text, out int idkh);
            dp.ID_KhachHang = idkh;
            int.TryParse(txtidphong.Text, out int idp);
            dp.ID_Phong = idp;
            dp.ID_KhuyenMai = txtidkhuyenmai.Text;
            dp.Check_In = dtpkcheckin.Value;
            dp.Check_Out = dtpkcheckout.Value;
            decimal.TryParse(txttiencoc.Text, out decimal tiencoc);
            dp.TienCoc = tiencoc;
            dp.TrangThai = cbotrangthai.Text;
            dp.HinhThucThanhToan = cbohinhthucthanhtoan.Text;
            dp.KetQua = cboketqua.Text;
            DataTable dt = blldp.TimKiem(txttimkiem.Text, dp);
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
            dtgvdatphong.DataSource = dt;
        }

        private void btnindp_Click(object sender, EventArgs e)
        {
            dp.ID_DatPhong = int.Parse(txtiddatphong.Text);
            if (string.IsNullOrEmpty(txtiddatphong.Text))
            {
                MessageBox.Show("Vui lòng nhập mã đặt phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable dt = bllin.InPhongDat(dp);
            InPhongDat i = new InPhongDat();
            i.SetDataSource(dt);
            GUI_InHoaDon inhd = new GUI_InHoaDon();
            inhd.frmInHoaDon.ReportSource = i;
            this.Hide();
            inhd.ShowDialog();
            this.Show();
        }

        private void txttimkiem_Leave(object sender, EventArgs e)
        {
            if(txttimkiem.Text == "")
            {
                txttimkiem.Text = "Tìm Kiếm Mã Đặt Phòng";
            }
        }

        private void txttimkiem_Enter(object sender, EventArgs e)
        {
            if(txttimkiem.Text == "Tìm Kiếm Mã Đặt Phòng")
            {
                txttimkiem.Text = "";
            }
        }

        private void txtiddatphong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txttiencoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtidphong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txttongtien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtidnhanvien_KeyPress(object sender, KeyPressEventArgs e)
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

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
