namespace GUI_KhachSan
{
    partial class GUI_NhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_NhanVien));
            this.panelchinh = new Guna.UI2.WinForms.Guna2Panel();
            this.btntimkiemnv = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txttimkiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnminimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnthoat = new Guna.UI2.WinForms.Guna2Button();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.panelchucnang = new Guna.UI2.WinForms.Guna2Panel();
            this.cbogioitinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtchucvu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtdiachi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtsodienthoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtcmnd = new Guna.UI2.WinForms.Guna2TextBox();
            this.txttennhanvien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtidnhanvien = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnresetnv = new Guna.UI2.WinForms.Guna2Button();
            this.btnxoanv = new Guna.UI2.WinForms.Guna2Button();
            this.btnsuanv = new Guna.UI2.WinForms.Guna2Button();
            this.btnthemnv = new Guna.UI2.WinForms.Guna2Button();
            this.paneldulieu = new Guna.UI2.WinForms.Guna2Panel();
            this.dtgvnhanvien = new System.Windows.Forms.DataGridView();
            this.ID_NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_Nhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND_NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh_NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT_NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi_NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role_NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelchinh.SuspendLayout();
            this.panelchucnang.SuspendLayout();
            this.paneldulieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvnhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // panelchinh
            // 
            this.panelchinh.BorderColor = System.Drawing.Color.Cyan;
            this.panelchinh.BorderRadius = 20;
            this.panelchinh.BorderThickness = 2;
            this.panelchinh.Controls.Add(this.btntimkiemnv);
            this.panelchinh.Controls.Add(this.label1);
            this.panelchinh.Controls.Add(this.txttimkiem);
            this.panelchinh.Controls.Add(this.label10);
            this.panelchinh.Controls.Add(this.btnminimize);
            this.panelchinh.Controls.Add(this.btnthoat);
            this.panelchinh.Controls.Add(this.btnclose);
            this.panelchinh.Controls.Add(this.panelchucnang);
            this.panelchinh.Controls.Add(this.paneldulieu);
            this.panelchinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelchinh.Location = new System.Drawing.Point(0, 0);
            this.panelchinh.Name = "panelchinh";
            this.panelchinh.Size = new System.Drawing.Size(1348, 770);
            this.panelchinh.TabIndex = 0;
            this.panelchinh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelchinh_MouseDown);
            // 
            // btntimkiemnv
            // 
            this.btntimkiemnv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btntimkiemnv.BackgroundImage")));
            this.btntimkiemnv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btntimkiemnv.BorderColor = System.Drawing.Color.White;
            this.btntimkiemnv.BorderRadius = 10;
            this.btntimkiemnv.BorderThickness = 2;
            this.btntimkiemnv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btntimkiemnv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btntimkiemnv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btntimkiemnv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btntimkiemnv.FillColor = System.Drawing.Color.Transparent;
            this.btntimkiemnv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btntimkiemnv.ForeColor = System.Drawing.Color.White;
            this.btntimkiemnv.Location = new System.Drawing.Point(1281, 98);
            this.btntimkiemnv.Name = "btntimkiemnv";
            this.btntimkiemnv.Size = new System.Drawing.Size(55, 39);
            this.btntimkiemnv.TabIndex = 2;
            this.btntimkiemnv.Click += new System.EventHandler(this.btntimkiemnv_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(204, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txttimkiem
            // 
            this.txttimkiem.BorderColor = System.Drawing.Color.White;
            this.txttimkiem.BorderRadius = 10;
            this.txttimkiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttimkiem.DefaultText = "Tìm Kiếm Nhân Viên";
            this.txttimkiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttimkiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttimkiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(76)))));
            this.txttimkiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.ForeColor = System.Drawing.Color.White;
            this.txttimkiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttimkiem.Location = new System.Drawing.Point(985, 98);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.PasswordChar = '\0';
            this.txttimkiem.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txttimkiem.PlaceholderText = "";
            this.txttimkiem.SelectedText = "";
            this.txttimkiem.Size = new System.Drawing.Size(289, 39);
            this.txttimkiem.TabIndex = 1;
            this.txttimkiem.Enter += new System.EventHandler(this.txttimkiem_Enter);
            this.txttimkiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttimkiem_KeyPress);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(894, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 39);
            this.label10.TabIndex = 10;
            this.label10.Text = "Search :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnminimize
            // 
            this.btnminimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnminimize.BackgroundImage")));
            this.btnminimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnminimize.BorderColor = System.Drawing.Color.Gold;
            this.btnminimize.BorderRadius = 10;
            this.btnminimize.BorderThickness = 2;
            this.btnminimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnminimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnminimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnminimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnminimize.FillColor = System.Drawing.Color.Transparent;
            this.btnminimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnminimize.ForeColor = System.Drawing.Color.White;
            this.btnminimize.Location = new System.Drawing.Point(1248, 12);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(41, 36);
            this.btnminimize.TabIndex = 9;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthoat.BackgroundImage")));
            this.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnthoat.BorderColor = System.Drawing.Color.Gold;
            this.btnthoat.BorderRadius = 10;
            this.btnthoat.BorderThickness = 2;
            this.btnthoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthoat.FillColor = System.Drawing.Color.Transparent;
            this.btnthoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnthoat.ForeColor = System.Drawing.Color.White;
            this.btnthoat.Location = new System.Drawing.Point(12, 12);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(41, 36);
            this.btnthoat.TabIndex = 8;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclose.BackgroundImage")));
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnclose.BorderColor = System.Drawing.Color.Gold;
            this.btnclose.BorderRadius = 10;
            this.btnclose.BorderThickness = 2;
            this.btnclose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclose.FillColor = System.Drawing.Color.Transparent;
            this.btnclose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(1295, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(41, 36);
            this.btnclose.TabIndex = 7;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // panelchucnang
            // 
            this.panelchucnang.BorderColor = System.Drawing.Color.Gold;
            this.panelchucnang.BorderRadius = 20;
            this.panelchucnang.BorderThickness = 2;
            this.panelchucnang.Controls.Add(this.cbogioitinh);
            this.panelchucnang.Controls.Add(this.txtchucvu);
            this.panelchucnang.Controls.Add(this.txtdiachi);
            this.panelchucnang.Controls.Add(this.txtemail);
            this.panelchucnang.Controls.Add(this.txtsodienthoai);
            this.panelchucnang.Controls.Add(this.txtcmnd);
            this.panelchucnang.Controls.Add(this.txttennhanvien);
            this.panelchucnang.Controls.Add(this.txtidnhanvien);
            this.panelchucnang.Controls.Add(this.label9);
            this.panelchucnang.Controls.Add(this.label8);
            this.panelchucnang.Controls.Add(this.label7);
            this.panelchucnang.Controls.Add(this.label6);
            this.panelchucnang.Controls.Add(this.label5);
            this.panelchucnang.Controls.Add(this.label4);
            this.panelchucnang.Controls.Add(this.label3);
            this.panelchucnang.Controls.Add(this.label2);
            this.panelchucnang.Controls.Add(this.btnresetnv);
            this.panelchucnang.Controls.Add(this.btnxoanv);
            this.panelchucnang.Controls.Add(this.btnsuanv);
            this.panelchucnang.Controls.Add(this.btnthemnv);
            this.panelchucnang.Location = new System.Drawing.Point(891, 140);
            this.panelchucnang.Name = "panelchucnang";
            this.panelchucnang.Size = new System.Drawing.Size(445, 618);
            this.panelchucnang.TabIndex = 0;
            // 
            // cbogioitinh
            // 
            this.cbogioitinh.BackColor = System.Drawing.Color.Transparent;
            this.cbogioitinh.BorderColor = System.Drawing.Color.White;
            this.cbogioitinh.BorderRadius = 15;
            this.cbogioitinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbogioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbogioitinh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(76)))));
            this.cbogioitinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbogioitinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbogioitinh.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cbogioitinh.ForeColor = System.Drawing.Color.White;
            this.cbogioitinh.ItemHeight = 30;
            this.cbogioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbogioitinh.Location = new System.Drawing.Point(165, 194);
            this.cbogioitinh.Name = "cbogioitinh";
            this.cbogioitinh.Size = new System.Drawing.Size(169, 36);
            this.cbogioitinh.TabIndex = 4;
            // 
            // txtchucvu
            // 
            this.txtchucvu.BorderColor = System.Drawing.Color.White;
            this.txtchucvu.BorderRadius = 15;
            this.txtchucvu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtchucvu.DefaultText = "";
            this.txtchucvu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtchucvu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtchucvu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtchucvu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtchucvu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(76)))));
            this.txtchucvu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtchucvu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchucvu.ForeColor = System.Drawing.Color.White;
            this.txtchucvu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtchucvu.Location = new System.Drawing.Point(165, 442);
            this.txtchucvu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtchucvu.Name = "txtchucvu";
            this.txtchucvu.PasswordChar = '\0';
            this.txtchucvu.PlaceholderText = "";
            this.txtchucvu.SelectedText = "";
            this.txtchucvu.Size = new System.Drawing.Size(256, 38);
            this.txtchucvu.TabIndex = 8;
            // 
            // txtdiachi
            // 
            this.txtdiachi.BorderColor = System.Drawing.Color.White;
            this.txtdiachi.BorderRadius = 15;
            this.txtdiachi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdiachi.DefaultText = "";
            this.txtdiachi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdiachi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdiachi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdiachi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdiachi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(76)))));
            this.txtdiachi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdiachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.ForeColor = System.Drawing.Color.White;
            this.txtdiachi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdiachi.Location = new System.Drawing.Point(165, 376);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.PasswordChar = '\0';
            this.txtdiachi.PlaceholderText = "";
            this.txtdiachi.SelectedText = "";
            this.txtdiachi.Size = new System.Drawing.Size(256, 38);
            this.txtdiachi.TabIndex = 7;
            // 
            // txtemail
            // 
            this.txtemail.BorderColor = System.Drawing.Color.White;
            this.txtemail.BorderRadius = 15;
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.DefaultText = "";
            this.txtemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(76)))));
            this.txtemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.White;
            this.txtemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.Location = new System.Drawing.Point(165, 314);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.PlaceholderText = "";
            this.txtemail.SelectedText = "";
            this.txtemail.Size = new System.Drawing.Size(256, 38);
            this.txtemail.TabIndex = 6;
            // 
            // txtsodienthoai
            // 
            this.txtsodienthoai.BorderColor = System.Drawing.Color.White;
            this.txtsodienthoai.BorderRadius = 15;
            this.txtsodienthoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsodienthoai.DefaultText = "";
            this.txtsodienthoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsodienthoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsodienthoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsodienthoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsodienthoai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(76)))));
            this.txtsodienthoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsodienthoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsodienthoai.ForeColor = System.Drawing.Color.White;
            this.txtsodienthoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsodienthoai.Location = new System.Drawing.Point(165, 252);
            this.txtsodienthoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsodienthoai.Name = "txtsodienthoai";
            this.txtsodienthoai.PasswordChar = '\0';
            this.txtsodienthoai.PlaceholderText = "";
            this.txtsodienthoai.SelectedText = "";
            this.txtsodienthoai.Size = new System.Drawing.Size(256, 38);
            this.txtsodienthoai.TabIndex = 5;
            this.txtsodienthoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsodienthoai_KeyPress);
            // 
            // txtcmnd
            // 
            this.txtcmnd.BorderColor = System.Drawing.Color.White;
            this.txtcmnd.BorderRadius = 15;
            this.txtcmnd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcmnd.DefaultText = "";
            this.txtcmnd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcmnd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcmnd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcmnd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcmnd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(76)))));
            this.txtcmnd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcmnd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcmnd.ForeColor = System.Drawing.Color.White;
            this.txtcmnd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcmnd.Location = new System.Drawing.Point(161, 134);
            this.txtcmnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.PasswordChar = '\0';
            this.txtcmnd.PlaceholderText = "";
            this.txtcmnd.SelectedText = "";
            this.txtcmnd.Size = new System.Drawing.Size(256, 38);
            this.txtcmnd.TabIndex = 3;
            this.txtcmnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcmnd_KeyPress);
            // 
            // txttennhanvien
            // 
            this.txttennhanvien.BorderColor = System.Drawing.Color.White;
            this.txttennhanvien.BorderRadius = 15;
            this.txttennhanvien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttennhanvien.DefaultText = "";
            this.txttennhanvien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttennhanvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttennhanvien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttennhanvien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttennhanvien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(76)))));
            this.txttennhanvien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttennhanvien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttennhanvien.ForeColor = System.Drawing.Color.White;
            this.txttennhanvien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttennhanvien.Location = new System.Drawing.Point(161, 76);
            this.txttennhanvien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttennhanvien.Name = "txttennhanvien";
            this.txttennhanvien.PasswordChar = '\0';
            this.txttennhanvien.PlaceholderText = "";
            this.txttennhanvien.SelectedText = "";
            this.txttennhanvien.Size = new System.Drawing.Size(256, 38);
            this.txttennhanvien.TabIndex = 2;
            // 
            // txtidnhanvien
            // 
            this.txtidnhanvien.BorderColor = System.Drawing.Color.White;
            this.txtidnhanvien.BorderRadius = 15;
            this.txtidnhanvien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtidnhanvien.DefaultText = "";
            this.txtidnhanvien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtidnhanvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtidnhanvien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtidnhanvien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtidnhanvien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(76)))));
            this.txtidnhanvien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtidnhanvien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidnhanvien.ForeColor = System.Drawing.Color.White;
            this.txtidnhanvien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtidnhanvien.Location = new System.Drawing.Point(161, 19);
            this.txtidnhanvien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtidnhanvien.Name = "txtidnhanvien";
            this.txtidnhanvien.PasswordChar = '\0';
            this.txtidnhanvien.PlaceholderText = "";
            this.txtidnhanvien.SelectedText = "";
            this.txtidnhanvien.Size = new System.Drawing.Size(127, 38);
            this.txtidnhanvien.TabIndex = 1;
            this.txtidnhanvien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidnhanvien_KeyPress);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(68, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 38);
            this.label9.TabIndex = 0;
            this.label9.Text = "Chức Vụ :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(75, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 38);
            this.label8.TabIndex = 0;
            this.label8.Text = "Địa Chỉ :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(90, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 38);
            this.label7.TabIndex = 0;
            this.label7.Text = "Email :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(55, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giới Tính :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số Điện Thoại :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(71, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "CMND :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Nhân Viên :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Nhân Viên :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnresetnv
            // 
            this.btnresetnv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnresetnv.BackgroundImage")));
            this.btnresetnv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnresetnv.BorderColor = System.Drawing.Color.White;
            this.btnresetnv.BorderRadius = 15;
            this.btnresetnv.BorderThickness = 2;
            this.btnresetnv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnresetnv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnresetnv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnresetnv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnresetnv.FillColor = System.Drawing.Color.Transparent;
            this.btnresetnv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresetnv.ForeColor = System.Drawing.Color.Gold;
            this.btnresetnv.ImageSize = new System.Drawing.Size(40, 40);
            this.btnresetnv.Location = new System.Drawing.Point(238, 564);
            this.btnresetnv.Name = "btnresetnv";
            this.btnresetnv.Size = new System.Drawing.Size(145, 45);
            this.btnresetnv.TabIndex = 12;
            this.btnresetnv.Click += new System.EventHandler(this.btnresetnv_Click);
            // 
            // btnxoanv
            // 
            this.btnxoanv.BorderColor = System.Drawing.Color.White;
            this.btnxoanv.BorderRadius = 15;
            this.btnxoanv.BorderThickness = 2;
            this.btnxoanv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnxoanv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnxoanv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnxoanv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnxoanv.FillColor = System.Drawing.Color.Transparent;
            this.btnxoanv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoanv.ForeColor = System.Drawing.Color.White;
            this.btnxoanv.Image = ((System.Drawing.Image)(resources.GetObject("btnxoanv.Image")));
            this.btnxoanv.ImageSize = new System.Drawing.Size(30, 30);
            this.btnxoanv.Location = new System.Drawing.Point(66, 564);
            this.btnxoanv.Name = "btnxoanv";
            this.btnxoanv.Size = new System.Drawing.Size(145, 45);
            this.btnxoanv.TabIndex = 11;
            this.btnxoanv.Text = "&Xóa";
            this.btnxoanv.Click += new System.EventHandler(this.btnxoanv_Click);
            // 
            // btnsuanv
            // 
            this.btnsuanv.BorderColor = System.Drawing.Color.White;
            this.btnsuanv.BorderRadius = 15;
            this.btnsuanv.BorderThickness = 2;
            this.btnsuanv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsuanv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsuanv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsuanv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsuanv.FillColor = System.Drawing.Color.Transparent;
            this.btnsuanv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuanv.ForeColor = System.Drawing.Color.White;
            this.btnsuanv.Image = ((System.Drawing.Image)(resources.GetObject("btnsuanv.Image")));
            this.btnsuanv.ImageSize = new System.Drawing.Size(30, 30);
            this.btnsuanv.Location = new System.Drawing.Point(238, 501);
            this.btnsuanv.Name = "btnsuanv";
            this.btnsuanv.Size = new System.Drawing.Size(145, 45);
            this.btnsuanv.TabIndex = 10;
            this.btnsuanv.Text = "&Sửa";
            this.btnsuanv.Click += new System.EventHandler(this.btnsuanv_Click);
            // 
            // btnthemnv
            // 
            this.btnthemnv.BorderColor = System.Drawing.Color.White;
            this.btnthemnv.BorderRadius = 15;
            this.btnthemnv.BorderThickness = 2;
            this.btnthemnv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthemnv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthemnv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthemnv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthemnv.FillColor = System.Drawing.Color.Transparent;
            this.btnthemnv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemnv.ForeColor = System.Drawing.Color.White;
            this.btnthemnv.Image = ((System.Drawing.Image)(resources.GetObject("btnthemnv.Image")));
            this.btnthemnv.Location = new System.Drawing.Point(66, 501);
            this.btnthemnv.Name = "btnthemnv";
            this.btnthemnv.Size = new System.Drawing.Size(145, 45);
            this.btnthemnv.TabIndex = 9;
            this.btnthemnv.Text = "&Thêm";
            this.btnthemnv.Click += new System.EventHandler(this.btnthemnv_Click);
            // 
            // paneldulieu
            // 
            this.paneldulieu.BorderColor = System.Drawing.Color.Gold;
            this.paneldulieu.BorderRadius = 20;
            this.paneldulieu.BorderThickness = 2;
            this.paneldulieu.Controls.Add(this.dtgvnhanvien);
            this.paneldulieu.Location = new System.Drawing.Point(12, 140);
            this.paneldulieu.Name = "paneldulieu";
            this.paneldulieu.Size = new System.Drawing.Size(873, 618);
            this.paneldulieu.TabIndex = 1;
            // 
            // dtgvnhanvien
            // 
            this.dtgvnhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvnhanvien.BackgroundColor = System.Drawing.Color.White;
            this.dtgvnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvnhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_NhanVien,
            this.Ten_Nhanvien,
            this.CMND_NhanVien,
            this.GioiTinh_NhanVien,
            this.SDT_NhanVien,
            this.Email_NhanVien,
            this.DiaChi_NhanVien,
            this.Role_NhanVien});
            this.dtgvnhanvien.GridColor = System.Drawing.Color.Black;
            this.dtgvnhanvien.Location = new System.Drawing.Point(12, 12);
            this.dtgvnhanvien.Name = "dtgvnhanvien";
            this.dtgvnhanvien.RowHeadersWidth = 51;
            this.dtgvnhanvien.RowTemplate.Height = 24;
            this.dtgvnhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvnhanvien.Size = new System.Drawing.Size(848, 583);
            this.dtgvnhanvien.TabIndex = 1;
            this.dtgvnhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvnhanvien_CellClick);
            // 
            // ID_NhanVien
            // 
            this.ID_NhanVien.HeaderText = "Mã Nhân Viên";
            this.ID_NhanVien.MinimumWidth = 6;
            this.ID_NhanVien.Name = "ID_NhanVien";
            this.ID_NhanVien.ReadOnly = true;
            // 
            // Ten_Nhanvien
            // 
            this.Ten_Nhanvien.HeaderText = "Tên Nhân Viên";
            this.Ten_Nhanvien.MinimumWidth = 6;
            this.Ten_Nhanvien.Name = "Ten_Nhanvien";
            this.Ten_Nhanvien.ReadOnly = true;
            // 
            // CMND_NhanVien
            // 
            this.CMND_NhanVien.HeaderText = "CMND";
            this.CMND_NhanVien.MinimumWidth = 6;
            this.CMND_NhanVien.Name = "CMND_NhanVien";
            this.CMND_NhanVien.ReadOnly = true;
            // 
            // GioiTinh_NhanVien
            // 
            this.GioiTinh_NhanVien.HeaderText = "Giới Tính";
            this.GioiTinh_NhanVien.MinimumWidth = 6;
            this.GioiTinh_NhanVien.Name = "GioiTinh_NhanVien";
            this.GioiTinh_NhanVien.ReadOnly = true;
            // 
            // SDT_NhanVien
            // 
            this.SDT_NhanVien.HeaderText = "SĐT";
            this.SDT_NhanVien.MinimumWidth = 6;
            this.SDT_NhanVien.Name = "SDT_NhanVien";
            this.SDT_NhanVien.ReadOnly = true;
            // 
            // Email_NhanVien
            // 
            this.Email_NhanVien.HeaderText = "Email";
            this.Email_NhanVien.MinimumWidth = 6;
            this.Email_NhanVien.Name = "Email_NhanVien";
            this.Email_NhanVien.ReadOnly = true;
            // 
            // DiaChi_NhanVien
            // 
            this.DiaChi_NhanVien.HeaderText = "Địa Chỉ";
            this.DiaChi_NhanVien.MinimumWidth = 6;
            this.DiaChi_NhanVien.Name = "DiaChi_NhanVien";
            this.DiaChi_NhanVien.ReadOnly = true;
            // 
            // Role_NhanVien
            // 
            this.Role_NhanVien.HeaderText = "Chức Vụ";
            this.Role_NhanVien.MinimumWidth = 6;
            this.Role_NhanVien.Name = "Role_NhanVien";
            this.Role_NhanVien.ReadOnly = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // GUI_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1348, 770);
            this.Controls.Add(this.panelchinh);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GUI_NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_NhanVien";
            this.panelchinh.ResumeLayout(false);
            this.panelchucnang.ResumeLayout(false);
            this.paneldulieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvnhanvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelchinh;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel paneldulieu;
        private Guna.UI2.WinForms.Guna2Panel panelchucnang;
        private System.Windows.Forms.DataGridView dtgvnhanvien;
        private Guna.UI2.WinForms.Guna2Button btnminimize;
        private Guna.UI2.WinForms.Guna2Button btnthoat;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnresetnv;
        private Guna.UI2.WinForms.Guna2Button btnxoanv;
        private Guna.UI2.WinForms.Guna2Button btnsuanv;
        private Guna.UI2.WinForms.Guna2Button btnthemnv;
        private Guna.UI2.WinForms.Guna2TextBox txtchucvu;
        private Guna.UI2.WinForms.Guna2TextBox txtdiachi;
        private Guna.UI2.WinForms.Guna2TextBox txtemail;
        private Guna.UI2.WinForms.Guna2TextBox txtsodienthoai;
        private Guna.UI2.WinForms.Guna2TextBox txtcmnd;
        private Guna.UI2.WinForms.Guna2TextBox txttennhanvien;
        private Guna.UI2.WinForms.Guna2TextBox txtidnhanvien;
        private Guna.UI2.WinForms.Guna2ComboBox cbogioitinh;
        private Guna.UI2.WinForms.Guna2Button btntimkiemnv;
        private Guna.UI2.WinForms.Guna2TextBox txttimkiem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_Nhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND_NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh_NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT_NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi_NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role_NhanVien;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}