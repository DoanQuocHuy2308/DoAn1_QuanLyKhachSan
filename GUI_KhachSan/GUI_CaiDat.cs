﻿using BLL_KhachSan;
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
    public partial class GUI_CaiDat : Form
    {
        public GUI_CaiDat()
        {
            InitializeComponent();
            txtpass.UseSystemPasswordChar = true;
        }
        DTO_TaiKhoan tk = new DTO_TaiKhoan();
        DTO_NhanVien nv = new DTO_NhanVien();
        BLL_CaiDat bllcd =  new BLL_CaiDat();
        private void panelchucnang_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            GUI_TrangChuNhanVien trangChunv = new GUI_TrangChuNhanVien();
            this.Hide();
            trangChunv.ShowDialog();
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn chắc chắn muốn đóng", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (check == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnresettk_Click(object sender, EventArgs e)
        {
            foreach (Control c in panelchucnangtk.Controls)
            {
                if (c is Guna2TextBox)
                {
                    (c as Guna2TextBox).Text = "";
                }
                txtcheckemail.Text = "";
            }
        }

        private void chkhien_CheckedChanged(object sender, EventArgs e)
        {
            if(chkhien.Checked)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtcheckcmnd_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtidtaikhoan_KeyPress(object sender, KeyPressEventArgs e)
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
        private void HienThiTaiKhoan()
        {
            tk.Email_TaiKhoan = txtcheckemail.Text;
            dtgvtaikhoan.Columns[0].DataPropertyName = "ID_TaiKhoan";
            dtgvtaikhoan.Columns[1].DataPropertyName = "Email_TaiKhoan";
            dtgvtaikhoan.Columns[2].DataPropertyName = "Pass_TaiKhoan";
            dtgvtaikhoan.Columns[3].DataPropertyName = "Role_TaiKhoan";
            dtgvtaikhoan.Columns[4].DataPropertyName = "Ban_TaiKhoan";
            dtgvtaikhoan.DataSource = bllcd.HienEmail(tk);
        }
        private void HienThiNhanVien()
        {
            nv.CMND_NhanVien = txtcheckcmnd.Text;
            dtgvnhanvien.Columns[0].DataPropertyName = "ID_NhanVien";
            dtgvnhanvien.Columns[1].DataPropertyName = "Ten_NhanVien";
            dtgvnhanvien.Columns[2].DataPropertyName = "CMND_NhanVien";
            dtgvnhanvien.Columns[3].DataPropertyName = "GioiTinh_NhanVien";
            dtgvnhanvien.Columns[4].DataPropertyName = "SDT_NhanVien";
            dtgvnhanvien.Columns[5].DataPropertyName = "Email_NhanVien";
            dtgvnhanvien.Columns[6].DataPropertyName = "DiaChi_NhanVien";
            dtgvnhanvien.Columns[7].DataPropertyName = "Role_NhanVien";
            dtgvnhanvien.DataSource = bllcd.HienCMND(nv);
        }
        private void btnemail_Click(object sender, EventArgs e)
        {
            tk.Email_TaiKhoan = txtcheckemail.Text;
            dtgvtaikhoan.Columns[0].DataPropertyName = "ID_TaiKhoan";
            dtgvtaikhoan.Columns[1].DataPropertyName = "Email_TaiKhoan";
            dtgvtaikhoan.Columns[2].DataPropertyName = "Pass_TaiKhoan";
            dtgvtaikhoan.Columns[3].DataPropertyName = "Role_TaiKhoan";
            dtgvtaikhoan.Columns[4].DataPropertyName = "Ban_TaiKhoan";
            dtgvtaikhoan.DataSource = bllcd.HienEmail(tk);
        }

        private void btncmnd_Click(object sender, EventArgs e)
        {
            nv.CMND_NhanVien = txtcheckcmnd.Text;
            dtgvnhanvien.Columns[0].DataPropertyName = "ID_NhanVien";
            dtgvnhanvien.Columns[1].DataPropertyName = "Ten_NhanVien";
            dtgvnhanvien.Columns[2].DataPropertyName = "CMND_NhanVien";
            dtgvnhanvien.Columns[3].DataPropertyName = "GioiTinh_NhanVien";
            dtgvnhanvien.Columns[4].DataPropertyName = "SDT_NhanVien";
            dtgvnhanvien.Columns[5].DataPropertyName = "Email_NhanVien";
            dtgvnhanvien.Columns[6].DataPropertyName = "DiaChi_NhanVien";
            dtgvnhanvien.Columns[7].DataPropertyName = "Role_NhanVien";
            dtgvnhanvien.DataSource = bllcd.HienCMND(nv);
        }

        private void dtgvtaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvtaikhoan.Rows[e.RowIndex];
                txtidtaikhoan.Text = row.Cells["ID_TaiKhoan"].Value.ToString();
                txtemailtk.Text = row.Cells["Email_TaiKhoan"].Value.ToString();
                txtpass.Text = row.Cells["Pass_TaiKhoan"].Value.ToString();
                txtvaitrotk.Text = row.Cells["Role_TaiKhoan"].Value.ToString();
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

        private void btncapnhattk_Click(object sender, EventArgs e)
        {
            tk.ID_TaiKhoan = int.Parse(txtidtaikhoan.Text);
            tk.Pass_TaiKhoan = txtpass.Text;
            tk.Email_TaiKhoan = txtemailtk.Text;
            if (string.IsNullOrEmpty(tk.ID_TaiKhoan.ToString()) || string.IsNullOrEmpty(tk.Pass_TaiKhoan) || string.IsNullOrEmpty(tk.Email_TaiKhoan))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                bllcd.CapNhatTaiKhoan(tk);
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiTaiKhoan();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"cập nhật thất bại. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnresetnv_Click(object sender, EventArgs e)
        {
            foreach (Control c in panelchucnangnv.Controls)
            {
                if (c is Guna2TextBox)
                {
                    (c as Guna2TextBox).Text = "";
                }
                txtcheckcmnd.Text = "";
            }
        }

        private void btncapnhatnv_Click(object sender, EventArgs e)
        {
            nv.ID_NhanVien = int.Parse(txtidnhanvien.Text);
            nv.Ten_NhanVien = txttennhanvien.Text;
            nv.CMND_NhanVien = txtcmnd.Text;
            nv.GioiTinh_NhanVien = cbogioitinh.Text;
            nv.SDT_NhanVien = txtsodienthoai.Text;
            nv.Email_NhanVien = txtemailtk.Text;
            nv.DiaChi_NhanVien = txtdiachi.Text;
            nv.Role_NhanVien = txtchucvu.Text;
            if (string.IsNullOrEmpty(nv.ID_NhanVien.ToString()) || string.IsNullOrEmpty(nv.Ten_NhanVien) || string.IsNullOrEmpty(nv.CMND_NhanVien) || string.IsNullOrEmpty(nv.GioiTinh_NhanVien) || string.IsNullOrEmpty(nv.SDT_NhanVien) || string.IsNullOrEmpty(nv.Email_NhanVien) || string.IsNullOrEmpty(nv.DiaChi_NhanVien) || string.IsNullOrEmpty(nv.Role_NhanVien))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                bllcd.CapNhatNhanVien(nv);
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"cập nhật thất bại. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}