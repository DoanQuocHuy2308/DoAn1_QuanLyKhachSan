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
    public partial class GUI_DichVu : Form
    {
        BLL_DichVu blldv = new BLL_DichVu();
        BLL_LoaiDichVu bllldv = new BLL_LoaiDichVu();
        DTO_LoaiDichVu dto_ldv = new DTO_LoaiDichVu();
        DTO_DichVu dto_dv = new DTO_DichVu();

        public GUI_DichVu()
        {
            InitializeComponent();
            HienThiDichVu();
            HienThiIDLoaiDichVu();
            HienThiLoaiDichVu();
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
        private void HienThiLoaiDichVu()
        {
            dtgvloaidichvu.Columns[0].DataPropertyName = "ID_LoaiDichVu";
            dtgvloaidichvu.Columns[1].DataPropertyName = "Ten_LoaiDichVu";
            dtgvloaidichvu.DataSource = bllldv.HienThiDuLieuLoaiDichVu();
        }
        private void HienThiIDLoaiDichVu()
        {
            cboidloaidichvu.ValueMember = "ID_LoaiDichVu";
            cboidloaidichvu.DataSource = blldv.HienThiDuLieuLoaiDichVu();
            cboidloaidichvu.DisplayMember = "ID_LoaiDichVu";
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

        private void btnthoat_Click(object sender, EventArgs e)
        {
            GUI_TrangChuAdmin trangChuAdmin = new GUI_TrangChuAdmin();
            this.Hide();
            trangChuAdmin.ShowDialog();
        }

        private void btnthemdv_Click(object sender, EventArgs e)
        {
            dto_dv.Ten_DichVu = txttendichvu.Text; 
            dto_dv.ID_LoaiDichVu = int.Parse(cboidloaidichvu.Text);
            dto_dv.Gia_DichVu= decimal.Parse(txtgiadichvu.Text);
            if (string.IsNullOrEmpty(dto_dv.Ten_DichVu) || string.IsNullOrEmpty(dto_dv.ID_LoaiDichVu.ToString()) || string.IsNullOrEmpty(dto_dv.Gia_DichVu.ToString()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                blldv.ADD(dto_dv);
                MessageBox.Show("Thêm dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDichVu();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Thêm dịch vụ thất bại. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsuadv_Click(object sender, EventArgs e)
        {
            dto_dv.ID_DichVu = int.Parse(txtiddichvu.Text);
            dto_dv.Ten_DichVu = txttendichvu.Text;
            dto_dv.ID_LoaiDichVu = int.Parse(cboidloaidichvu.Text);
            dto_dv.Gia_DichVu = decimal.Parse(txtgiadichvu.Text);
            if (string.IsNullOrEmpty(dto_dv.ID_DichVu.ToString()))
            {
                MessageBox.Show("Vui lòng nhập mã dịch vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                blldv.UPDATE(dto_dv);
                MessageBox.Show("Sửa dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDichVu();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sửa dịch vụ thất bại. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgvdichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvdichvu.Rows[e.RowIndex];
                txtiddichvu.Text = row.Cells["ID_DichVu"].Value.ToString();
                txttendichvu.Text = row.Cells["Ten_DichVu"].Value.ToString();
                cboidloaidichvu.SelectedValue = row.Cells["ID_LDV"].Value.ToString();
                txtloaidichvu.Text = row.Cells["Ten_LDV"].Value.ToString();
                txtgiadichvu.Text = row.Cells["Gia_DichVu"].Value.ToString();
            }
        }

        private void btnxoadv_Click(object sender, EventArgs e)
        {
            int.TryParse(txtiddichvu.Text, out int idDichVu);
            dto_dv.ID_DichVu = idDichVu;
            if (blldv.KTIDTonTai(dto_dv))
            {
                MessageBox.Show("Không thể xóa dịch vụ vì còn tồn tại khóa ngoại liên quan.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult kt = MessageBox.Show("Bạn chắc chắn muốn xóa", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (kt == DialogResult.OK)
                {
                    blldv.Delete(dto_dv);
                    MessageBox.Show("Xóa dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDichVu();
                }
            }
        }

        private void btntimkiemdichvu_Click(object sender, EventArgs e)
        {
            string search = txttimkiem.Text;
            int? idDichVu = null;
            int? idLoaiDichVu = null;
            decimal? GiaDichVu = null;
            if (!int.TryParse(txtiddichvu.Text, out int iddv))
            {
                idDichVu = iddv;
            }

            string tenDichVu = txttendichvu.Text;
            if (!int.TryParse(cboidloaidichvu.Text, out int idldv))
            {
                idLoaiDichVu = idldv;
            }
            if (!decimal.TryParse(txtgiadichvu.Text, out decimal gia))
            {
                GiaDichVu = gia;
            }
            DataTable dt = blldv.TimKiemDichVu(search, idDichVu, tenDichVu, idLoaiDichVu, GiaDichVu);
            dtgvdichvu.Columns[0].DataPropertyName = "ID_DichVu";
            dtgvdichvu.Columns[1].DataPropertyName = "Ten_DichVu";
            dtgvdichvu.Columns[2].DataPropertyName = "ID_LoaiDichVu";
            dtgvdichvu.Columns[3].DataPropertyName = "Ten_LoaiDichVu";
            dtgvdichvu.Columns[4].DataPropertyName = "Gia_DichVu";
            dtgvdichvu.DataSource = dt;
        }

        private void btnresetdv_Click(object sender, EventArgs e)
        {
            foreach (Control c in panelcndichvu.Controls)
            {
                if (c is Guna2TextBox)
                {
                    (c as Guna2TextBox).Text = "";
                }
                cboidloaidichvu.SelectedIndex=-1;
                txttimkiem.Text = "";
                HienThiIDLoaiDichVu();
                HienThiDichVu();
            }
        }

        private void dtgvloaidichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvloaidichvu.Rows[e.RowIndex];
                txtidloaidichvu.Text = row.Cells["ID_LoaiDichVu"].Value.ToString();
                txttenloaidichvu.Text = row.Cells["Ten_LoaiDichVu"].Value.ToString();
            }
        }

        private void btnthemldv_Click(object sender, EventArgs e)
        {
            dto_ldv.Ten_LoaiDichVu = txttenloaidichvu.Text;
            if (string.IsNullOrEmpty(dto_ldv.Ten_LoaiDichVu))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                bllldv.ADD(dto_ldv);
                MessageBox.Show("Thêm loại dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiLoaiDichVu();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Thêm loại dịch vụ thất bại. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsualdv_Click(object sender, EventArgs e)
        {
            dto_ldv.ID_LoaiDichVu = int.Parse(txtidloaidichvu.Text);
            dto_ldv.Ten_LoaiDichVu = txttenloaidichvu.Text;
            if (string.IsNullOrEmpty(dto_ldv.ID_LoaiDichVu.ToString()))
            {
                MessageBox.Show("Vui lòng nhập mã loại dịch vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                bllldv.Update(dto_ldv);
                MessageBox.Show("Sửa loại dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiLoaiDichVu();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sửa loại dịch vụ thất bại. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoaldv_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtidloaidichvu.Text, out int idLoaiDichVu))
            {
                dto_ldv.ID_LoaiDichVu = idLoaiDichVu;
            }
            if (blldv.KTIDTonTai(dto_dv))
            {
                MessageBox.Show("Không thể xóa loại dịch vụ vì còn tồn tại khóa ngoại liên quan.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult kt = MessageBox.Show("Bạn chắc chắn muốn xóa", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (kt == DialogResult.OK)
                {
                    bllldv.Delete(dto_ldv);
                    MessageBox.Show("Xóa loại dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiLoaiDichVu();
                }
            }
        }

        private void btnresetldv_Click(object sender, EventArgs e)
        {
            foreach (Control c in panelcnloaidichvu.Controls)
            {
                if (c is Guna2TextBox)
                {
                    (c as Guna2TextBox).Text = "";
                }
                txttimkiem.Text = "";
                HienThiLoaiDichVu();
            }
        }

        private void btntimkiemldv_Click(object sender, EventArgs e)
        {
            int.TryParse(txtidloaidichvu.Text, out int idLoaiDichVu);
            dto_ldv.ID_LoaiDichVu = idLoaiDichVu;
            dto_ldv.Ten_LoaiDichVu = txttenloaidichvu.Text;
            DataTable dt = bllldv.TimKiemLoaiDichVu(txttimkiemldv.Text, dto_ldv);
            dtgvloaidichvu.Columns[0].DataPropertyName = "ID_LoaiDichVu";
            dtgvloaidichvu.Columns[1].DataPropertyName = "Ten_LoaiDichVu";
            dtgvloaidichvu.DataSource = dt;
        }
    }
}
