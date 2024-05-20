using BLL_KhachSan;
using DTO_KhachSan;
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
    public partial class GUI_ThongKe : Form
    {
        public GUI_ThongKe()
        {
            InitializeComponent();
            HienTenPhong();
            HienTenLoaiPhong();
            DuLieuDonDatPhong();
            HienTenDichVu();
            HienTenLoaiDichVu();
            DuLieuDonDatDichVu();
            dtpkngaybatdaudp.Value = DateTime.Now;
            dtpkngayketthucdp.Value = DateTime.Now;
            dtpkngaybatdauddv.Value = DateTime.Now;
            dtpkngayketthucddv.Value = DateTime.Now;
            TongTienDP();
            TongTienDDV();  
        }
        private BLL_ThongKe tk = new BLL_ThongKe();
        private DTO_LoaiPhong lp = new DTO_LoaiPhong();
        private DTO_Phong p = new DTO_Phong();
        private DTO_DatPhong dp = new DTO_DatPhong();
        private DTO_LoaiDichVu ldv = new DTO_LoaiDichVu();
        private DTO_DichVu dv = new DTO_DichVu();
        private DTO_DatDichVu ddv = new DTO_DatDichVu();
        private BLL_In bllin = new BLL_In();
        private DateTime ngayketthuc;
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

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (Check.check == "Admin")
            {
                GUI_TrangChuAdmin trangChuAdmin = new GUI_TrangChuAdmin();
                this.Hide();
                trangChuAdmin.ShowDialog();
            }
            else if (Check.check == "Nhân Viên")
            {
                GUI_TrangChuNhanVien tcnv = new GUI_TrangChuNhanVien();
                this.Hide();
                tcnv.ShowDialog();
            }
        }
        private void HienTenPhong()
        {
            cbotenphong.ValueMember = "Ten_Phong";
            cbotenphong.DataSource = tk.TenPhong();
            cbotenphong.DisplayMember = "Ten_Phong";
        }
        private void HienTenLoaiPhong()
        {
            cboloaiphong.ValueMember = "Ten_LoaiPhong";
            cboloaiphong.DataSource = tk.TenLoaiPhong();
            cboloaiphong.DisplayMember = "Ten_LoaiPhong";
        }
        private void DuLieuDonDatPhong()
        {
            dtgvthongkedp.Columns[0].DataPropertyName = "ID_DatPhong";
            dtgvthongkedp.Columns[1].DataPropertyName = "Ten_Phong";
            dtgvthongkedp.Columns[2].DataPropertyName = "Ten_LoaiPhong";
            dtgvthongkedp.Columns[3].DataPropertyName = "Ten_KhachHang";
            dtgvthongkedp.Columns[4].DataPropertyName = "SDT_KhachHang";
            dtgvthongkedp.Columns[5].DataPropertyName = "Check_In";
            dtgvthongkedp.Columns[6].DataPropertyName = "Check_Out";
            dtgvthongkedp.Columns[7].DataPropertyName = "TienCoc";
            dtgvthongkedp.Columns[8].DataPropertyName = "Ten_KhuyenMai";
            dtgvthongkedp.Columns[9].DataPropertyName = "TongTien";
            dtgvthongkedp.DataSource = tk.DuLieuDonDatPhong();
        }
        private void TongTienDP()
        {
            DataTable dt = tk.ThongKeDonDatPhong(dp, p, lp);
            dtgvthongkedp.Columns[0].DataPropertyName = "ID_DatPhong";
            dtgvthongkedp.Columns[1].DataPropertyName = "Ten_Phong";
            dtgvthongkedp.Columns[2].DataPropertyName = "Ten_LoaiPhong";
            dtgvthongkedp.Columns[3].DataPropertyName = "Ten_KhachHang";
            dtgvthongkedp.Columns[4].DataPropertyName = "SDT_KhachHang";
            dtgvthongkedp.Columns[5].DataPropertyName = "Check_In";
            dtgvthongkedp.Columns[6].DataPropertyName = "Check_Out";
            dtgvthongkedp.Columns[7].DataPropertyName = "TienCoc";
            dtgvthongkedp.Columns[8].DataPropertyName = "Ten_KhuyenMai";
            dtgvthongkedp.Columns[9].DataPropertyName = "TongTien";
            dtgvthongkedp.DataSource = dt;
            decimal TongTien = 0;
            foreach (DataRow row in dt.Rows)
            {
                TongTien += Convert.ToDecimal(row["TongTien"]);
            }
            txtTongTien.Text = $"{TongTien:N0} đ";
        }
        private void btnthongkedp_Click(object sender, EventArgs e)
        {
            dp.Check_In = dtpkngaybatdaudp.Value;
            dp.Check_Out = dtpkngayketthucdp.Value;
            p.Ten_Phong = cbotenphong.Text;
            lp.Ten_LoaiPhong = cboloaiphong.Text;
            if (dp.Check_In > dp.Check_Out)
            {
                MessageBox.Show("Ngày Check In Không Được Lớn Hơn Ngày Check Out, Vui lòng Nhập Lại", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            TongTienDP();
        }
        private void btnresetdp_Click(object sender, EventArgs e)
        {
            dtpkngaybatdaudp.Value = DateTime.Now;
            dtpkngayketthucdp.Value = DateTime.Now;
            HienTenLoaiPhong();
            HienTenPhong();
            DuLieuDonDatPhong();
            cboloaiphong.SelectedIndex = -1;
            cbotenphong.SelectedIndex = -1;
            TongTienDP();
        }
        private void dtgvthongkedp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvthongkedp.Rows[e.RowIndex];
                dtpkngaybatdaudp.Value = Convert.ToDateTime(row.Cells["Check_In"].Value);
                dtpkngayketthucdp.Value = Convert.ToDateTime(row.Cells["Check_Out"].Value);
                cbotenphong.Text = row.Cells["Ten_Phong"].Value.ToString();
                cboloaiphong.Text = row.Cells["Ten_LoaiPhong"].Value.ToString();
                txtTongTien.Text = row.Cells["TongTien"].Value.ToString();
            }
        }
        private void HienTenDichVu()
        {
            cbotendichvu.ValueMember = "Ten_DichVu";
            cbotendichvu.DataSource = tk.TenDichVu();
            cbotendichvu.DisplayMember = "Ten_DichVu";
        }
        private void HienTenLoaiDichVu()
        {
            cboloaidichvu.ValueMember = "Ten_LoaiDichVu";
            cboloaidichvu.DataSource = tk.TenLoaiDichVu();
            cboloaidichvu.DisplayMember = "Ten_LoaiDichVu";
        }
        private void DuLieuDonDatDichVu()
        {
            dtgvthongkeddv.Columns[0].DataPropertyName = "ID_DatDichVu";
            dtgvthongkeddv.Columns[1].DataPropertyName = "Ten_KhachHang";
            dtgvthongkeddv.Columns[2].DataPropertyName = "SDT_KhachHang";
            dtgvthongkeddv.Columns[3].DataPropertyName = "NgayDat";
            dtgvthongkeddv.Columns[4].DataPropertyName = "Ten_DichVu";
            dtgvthongkeddv.Columns[5].DataPropertyName = "Ten_LoaiDichVu";
            dtgvthongkeddv.Columns[6].DataPropertyName = "SoLuong";
            dtgvthongkeddv.Columns[7].DataPropertyName = "Ten_KhuyenMai";
            dtgvthongkeddv.Columns[8].DataPropertyName = "TongTien";
            dtgvthongkeddv.DataSource = tk.DuLieuDonDatDichVu();
        }
        private void TongTienDDV()
        {
            DataTable dt = tk.ThongKeDonDatDichVu(ddv, dv, ldv,ngayketthuc);
            dtgvthongkeddv.Columns[0].DataPropertyName = "ID_DatDichVu";
            dtgvthongkeddv.Columns[1].DataPropertyName = "Ten_KhachHang";
            dtgvthongkeddv.Columns[2].DataPropertyName = "SDT_KhachHang";
            dtgvthongkeddv.Columns[3].DataPropertyName = "NgayDat";
            dtgvthongkeddv.Columns[4].DataPropertyName = "Ten_DichVu";
            dtgvthongkeddv.Columns[5].DataPropertyName = "Ten_LoaiDichVu";
            dtgvthongkeddv.Columns[6].DataPropertyName = "SoLuong";
            dtgvthongkeddv.Columns[7].DataPropertyName = "Ten_KhuyenMai";
            dtgvthongkeddv.Columns[8].DataPropertyName = "TongTien";
            dtgvthongkeddv.DataSource = dt;
            decimal TongTien = 0;
            foreach (DataRow row in dt.Rows)
            {
                TongTien += Convert.ToDecimal(row["TongTien"]);
            }
            txttongtienddv.Text = $"{TongTien:N0} đ";
        }
        private void btnthongkeddv_Click(object sender, EventArgs e)
        {
            ddv.NgayDat = dtpkngaybatdauddv.Value;
            ngayketthuc = dtpkngayketthucddv.Value;
            dv.Ten_DichVu = cbotendichvu.Text;
            ldv.Ten_LoaiDichVu = cboloaidichvu.Text;
            if(ddv.NgayDat > ngayketthuc)
            {
                MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu , Vui lòng Nhập Lại","Thông Báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                return;
            }
            TongTienDDV();
        }

        private void btnresetddv_Click(object sender, EventArgs e)
        {
            dtpkngaybatdauddv.Value = DateTime.Now;
            dtpkngayketthucddv.Value = DateTime.Now;
            HienTenLoaiDichVu();
            HienTenDichVu();
            DuLieuDonDatDichVu();
            cboloaidichvu.SelectedIndex = -1;
            cbotendichvu.SelectedIndex = -1;
            TongTienDDV();
        }

        private void dtgvthongkeddv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvthongkeddv.Rows[e.RowIndex];
                dtpkngaybatdauddv.Value = Convert.ToDateTime(row.Cells["NgayDat"].Value);
                dtpkngayketthucddv.Value = DateTime.Now;
                cbotendichvu.Text = row.Cells["Ten_DichVu"].Value.ToString();
                cboloaidichvu.Text = row.Cells["Ten_LoaiDichVu"].Value.ToString();
                txttongtienddv.Text = row.Cells["TongTienddv"].Value.ToString();
            }
        }

        private void btnindp_Click(object sender, EventArgs e)
        {
            dp.Check_In = dtpkngaybatdaudp.Value;
            dp.Check_Out = dtpkngayketthucdp.Value;
            p.Ten_Phong = cbotenphong.Text;
            lp.Ten_LoaiPhong = cboloaiphong.Text;
            if (dp.Check_In > dp.Check_Out)
            {
                MessageBox.Show("Ngày Check In Không Được Lớn Hơn Ngày Check Out, Vui lòng Nhập Lại", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            DataTable dt = bllin.InThongKeDonDatPhong(dp ,p ,lp);
            InThongKeDonDatPhong i = new InThongKeDonDatPhong();
            i.SetDataSource(dt);
            GUI_InHoaDon inhd = new GUI_InHoaDon();
            inhd.frmInHoaDon.ReportSource = i;
            this.Hide();
            inhd.ShowDialog();
            this.Show();
        }

        private void btninddv_Click(object sender, EventArgs e)
        {
            ddv.NgayDat = dtpkngaybatdauddv.Value;
            ngayketthuc = dtpkngayketthucddv.Value;
            dv.Ten_DichVu = cbotendichvu.Text;
            ldv.Ten_LoaiDichVu = cboloaidichvu.Text;
            if (ddv.NgayDat > ngayketthuc)
            {
                MessageBox.Show("Thời Gian Bắt Đầu Không Được Lớn Hơn Thời Gian Kết Thúc , Vui lòng Nhập Lại", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            DataTable dt = bllin.InThongKeDonDatDichVu(ddv, dv, ldv,ngayketthuc);
            InThongKeDonDatDichVu i = new InThongKeDonDatDichVu();
            i.SetDataSource(dt);
            GUI_InHoaDon inhd = new GUI_InHoaDon();
            inhd.frmInHoaDon.ReportSource = i;
            this.Hide();
            inhd.ShowDialog();
            this.Show();
        }
    }
}
