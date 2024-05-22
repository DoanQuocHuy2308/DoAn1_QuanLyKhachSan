namespace GUI_KhachSan
{
    partial class GUI_TrangChuNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_TrangChuNhanVien));
            this.panelchinh = new Guna.UI2.WinForms.Guna2Panel();
            this.txtTenDangNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.btntrangchu = new Guna.UI2.WinForms.Guna2Button();
            this.btntrangchunv = new Guna.UI2.WinForms.Guna2Button();
            this.btnminimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.paneldulieu = new Guna.UI2.WinForms.Guna2Panel();
            this.panelchucnang = new Guna.UI2.WinForms.Guna2Panel();
            this.btnkhuyenmai = new Guna.UI2.WinForms.Guna2Button();
            this.btnthoat = new Guna.UI2.WinForms.Guna2Button();
            this.btnCaiDat = new Guna.UI2.WinForms.Guna2Button();
            this.btnthongke = new Guna.UI2.WinForms.Guna2Button();
            this.btnKhachHang = new Guna.UI2.WinForms.Guna2Button();
            this.btndatdichvu = new Guna.UI2.WinForms.Guna2Button();
            this.btnDatPhong = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelchinh.SuspendLayout();
            this.panelchucnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelchinh
            // 
            this.panelchinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(76)))));
            this.panelchinh.BorderColor = System.Drawing.Color.Cyan;
            this.panelchinh.BorderRadius = 20;
            this.panelchinh.BorderThickness = 2;
            this.panelchinh.Controls.Add(this.txtTenDangNhap);
            this.panelchinh.Controls.Add(this.btntrangchu);
            this.panelchinh.Controls.Add(this.btntrangchunv);
            this.panelchinh.Controls.Add(this.btnminimize);
            this.panelchinh.Controls.Add(this.btnclose);
            this.panelchinh.Controls.Add(this.paneldulieu);
            this.panelchinh.Controls.Add(this.panelchucnang);
            this.panelchinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelchinh.Location = new System.Drawing.Point(0, 0);
            this.panelchinh.Name = "panelchinh";
            this.panelchinh.Size = new System.Drawing.Size(1498, 811);
            this.panelchinh.TabIndex = 2;
            this.panelchinh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelchinh_MouseDown);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BorderColor = System.Drawing.Color.Gold;
            this.txtTenDangNhap.BorderRadius = 10;
            this.txtTenDangNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDangNhap.DefaultText = "";
            this.txtTenDangNhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenDangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenDangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDangNhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDangNhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(76)))));
            this.txtTenDangNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDangNhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.White;
            this.txtTenDangNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDangNhap.Location = new System.Drawing.Point(17, 9);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.PasswordChar = '\0';
            this.txtTenDangNhap.PlaceholderText = "";
            this.txtTenDangNhap.ReadOnly = true;
            this.txtTenDangNhap.SelectedText = "";
            this.txtTenDangNhap.Size = new System.Drawing.Size(344, 25);
            this.txtTenDangNhap.TabIndex = 9;
            this.txtTenDangNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTenDangNhap.TextChanged += new System.EventHandler(this.txtTenDangNhap_TextChanged);
            // 
            // btntrangchu
            // 
            this.btntrangchu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btntrangchu.BackgroundImage")));
            this.btntrangchu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btntrangchu.BorderColor = System.Drawing.Color.Gold;
            this.btntrangchu.BorderRadius = 10;
            this.btntrangchu.BorderThickness = 2;
            this.btntrangchu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btntrangchu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btntrangchu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btntrangchu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btntrangchu.FillColor = System.Drawing.Color.Transparent;
            this.btntrangchu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btntrangchu.ForeColor = System.Drawing.Color.White;
            this.btntrangchu.Location = new System.Drawing.Point(403, 5);
            this.btntrangchu.Name = "btntrangchu";
            this.btntrangchu.Size = new System.Drawing.Size(30, 29);
            this.btntrangchu.TabIndex = 8;
            this.btntrangchu.Click += new System.EventHandler(this.btntrangchu_Click);
            // 
            // btntrangchunv
            // 
            this.btntrangchunv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btntrangchunv.BackgroundImage")));
            this.btntrangchunv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btntrangchunv.BorderColor = System.Drawing.Color.Gold;
            this.btntrangchunv.BorderRadius = 10;
            this.btntrangchunv.BorderThickness = 2;
            this.btntrangchunv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btntrangchunv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btntrangchunv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btntrangchunv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btntrangchunv.FillColor = System.Drawing.Color.Transparent;
            this.btntrangchunv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btntrangchunv.ForeColor = System.Drawing.Color.White;
            this.btntrangchunv.Location = new System.Drawing.Point(367, 5);
            this.btntrangchunv.Name = "btntrangchunv";
            this.btntrangchunv.Size = new System.Drawing.Size(30, 29);
            this.btntrangchunv.TabIndex = 2;
            this.btntrangchunv.Click += new System.EventHandler(this.btntrangchunv_Click);
            // 
            // btnminimize
            // 
            this.btnminimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnminimize.BackgroundImage")));
            this.btnminimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnminimize.BorderColor = System.Drawing.Color.Transparent;
            this.btnminimize.BorderRadius = 10;
            this.btnminimize.BorderThickness = 2;
            this.btnminimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnminimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnminimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnminimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnminimize.FillColor = System.Drawing.Color.Transparent;
            this.btnminimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnminimize.ForeColor = System.Drawing.Color.White;
            this.btnminimize.Location = new System.Drawing.Point(1406, 3);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(37, 31);
            this.btnminimize.TabIndex = 7;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclose.BackgroundImage")));
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnclose.BorderColor = System.Drawing.Color.Transparent;
            this.btnclose.BorderRadius = 10;
            this.btnclose.BorderThickness = 2;
            this.btnclose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclose.FillColor = System.Drawing.Color.Transparent;
            this.btnclose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(1449, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(37, 31);
            this.btnclose.TabIndex = 1;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // paneldulieu
            // 
            this.paneldulieu.BorderColor = System.Drawing.Color.Gold;
            this.paneldulieu.BorderRadius = 20;
            this.paneldulieu.BorderThickness = 2;
            this.paneldulieu.Location = new System.Drawing.Point(14, 105);
            this.paneldulieu.Name = "paneldulieu";
            this.paneldulieu.Size = new System.Drawing.Size(1472, 693);
            this.paneldulieu.TabIndex = 2;
            this.paneldulieu.Paint += new System.Windows.Forms.PaintEventHandler(this.paneldulieu_Paint);
            // 
            // panelchucnang
            // 
            this.panelchucnang.BorderColor = System.Drawing.Color.Gold;
            this.panelchucnang.BorderRadius = 15;
            this.panelchucnang.BorderThickness = 2;
            this.panelchucnang.Controls.Add(this.btnkhuyenmai);
            this.panelchucnang.Controls.Add(this.btnthoat);
            this.panelchucnang.Controls.Add(this.btnCaiDat);
            this.panelchucnang.Controls.Add(this.btnthongke);
            this.panelchucnang.Controls.Add(this.btnKhachHang);
            this.panelchucnang.Controls.Add(this.btndatdichvu);
            this.panelchucnang.Controls.Add(this.btnDatPhong);
            this.panelchucnang.Location = new System.Drawing.Point(14, 36);
            this.panelchucnang.Name = "panelchucnang";
            this.panelchucnang.Size = new System.Drawing.Size(1472, 62);
            this.panelchucnang.TabIndex = 0;
            // 
            // btnkhuyenmai
            // 
            this.btnkhuyenmai.BorderColor = System.Drawing.Color.White;
            this.btnkhuyenmai.BorderRadius = 10;
            this.btnkhuyenmai.BorderThickness = 3;
            this.btnkhuyenmai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnkhuyenmai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnkhuyenmai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnkhuyenmai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnkhuyenmai.FillColor = System.Drawing.Color.Transparent;
            this.btnkhuyenmai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkhuyenmai.ForeColor = System.Drawing.Color.Gold;
            this.btnkhuyenmai.Image = ((System.Drawing.Image)(resources.GetObject("btnkhuyenmai.Image")));
            this.btnkhuyenmai.ImageSize = new System.Drawing.Size(30, 30);
            this.btnkhuyenmai.Location = new System.Drawing.Point(728, 11);
            this.btnkhuyenmai.Name = "btnkhuyenmai";
            this.btnkhuyenmai.Size = new System.Drawing.Size(186, 41);
            this.btnkhuyenmai.TabIndex = 3;
            this.btnkhuyenmai.Text = "Khuyến Mại";
            this.btnkhuyenmai.Click += new System.EventHandler(this.btnkhuyenmai_Click);
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
            this.btnthoat.Location = new System.Drawing.Point(1382, 12);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(56, 40);
            this.btnthoat.TabIndex = 0;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.BackColor = System.Drawing.Color.Transparent;
            this.btnCaiDat.BorderColor = System.Drawing.Color.White;
            this.btnCaiDat.BorderRadius = 10;
            this.btnCaiDat.BorderThickness = 3;
            this.btnCaiDat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCaiDat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCaiDat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCaiDat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCaiDat.FillColor = System.Drawing.Color.Transparent;
            this.btnCaiDat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnCaiDat.ForeColor = System.Drawing.Color.Gold;
            this.btnCaiDat.Image = ((System.Drawing.Image)(resources.GetObject("btnCaiDat.Image")));
            this.btnCaiDat.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCaiDat.Location = new System.Drawing.Point(1163, 11);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Size = new System.Drawing.Size(186, 41);
            this.btnCaiDat.TabIndex = 0;
            this.btnCaiDat.Text = "&Cài Đặt";
            this.btnCaiDat.Click += new System.EventHandler(this.btnCaiDat_Click);
            // 
            // btnthongke
            // 
            this.btnthongke.BackColor = System.Drawing.Color.Transparent;
            this.btnthongke.BorderColor = System.Drawing.Color.White;
            this.btnthongke.BorderRadius = 10;
            this.btnthongke.BorderThickness = 3;
            this.btnthongke.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthongke.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthongke.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthongke.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthongke.FillColor = System.Drawing.Color.Transparent;
            this.btnthongke.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnthongke.ForeColor = System.Drawing.Color.Gold;
            this.btnthongke.Image = ((System.Drawing.Image)(resources.GetObject("btnthongke.Image")));
            this.btnthongke.ImageSize = new System.Drawing.Size(30, 30);
            this.btnthongke.Location = new System.Drawing.Point(948, 10);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(186, 41);
            this.btnthongke.TabIndex = 0;
            this.btnthongke.Text = "Thống Kê";
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.btnKhachHang.BorderColor = System.Drawing.Color.White;
            this.btnKhachHang.BorderRadius = 10;
            this.btnKhachHang.BorderThickness = 3;
            this.btnKhachHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKhachHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKhachHang.FillColor = System.Drawing.Color.Transparent;
            this.btnKhachHang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.Color.Gold;
            this.btnKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.Image")));
            this.btnKhachHang.ImageSize = new System.Drawing.Size(30, 30);
            this.btnKhachHang.Location = new System.Drawing.Point(473, 11);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(218, 41);
            this.btnKhachHang.TabIndex = 0;
            this.btnKhachHang.Text = "&Khách Hàng";
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btndatdichvu
            // 
            this.btndatdichvu.BackColor = System.Drawing.Color.Transparent;
            this.btndatdichvu.BorderColor = System.Drawing.Color.White;
            this.btndatdichvu.BorderRadius = 10;
            this.btndatdichvu.BorderThickness = 3;
            this.btndatdichvu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndatdichvu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndatdichvu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndatdichvu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndatdichvu.FillColor = System.Drawing.Color.Transparent;
            this.btndatdichvu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btndatdichvu.ForeColor = System.Drawing.Color.Gold;
            this.btndatdichvu.Image = ((System.Drawing.Image)(resources.GetObject("btndatdichvu.Image")));
            this.btndatdichvu.ImageSize = new System.Drawing.Size(30, 30);
            this.btndatdichvu.Location = new System.Drawing.Point(259, 11);
            this.btndatdichvu.Name = "btndatdichvu";
            this.btndatdichvu.Size = new System.Drawing.Size(184, 41);
            this.btndatdichvu.TabIndex = 0;
            this.btndatdichvu.Text = "Đặt Dịch Vụ";
            this.btndatdichvu.Click += new System.EventHandler(this.btndatdichvu_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BackColor = System.Drawing.Color.Transparent;
            this.btnDatPhong.BorderColor = System.Drawing.Color.White;
            this.btnDatPhong.BorderRadius = 10;
            this.btnDatPhong.BorderThickness = 3;
            this.btnDatPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDatPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDatPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDatPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDatPhong.FillColor = System.Drawing.Color.Transparent;
            this.btnDatPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnDatPhong.ForeColor = System.Drawing.Color.Gold;
            this.btnDatPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnDatPhong.Image")));
            this.btnDatPhong.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDatPhong.Location = new System.Drawing.Point(32, 10);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(197, 41);
            this.btnDatPhong.TabIndex = 0;
            this.btnDatPhong.Text = "Đặt &Phòng";
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // GUI_TrangChuNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 811);
            this.Controls.Add(this.panelchinh);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUI_TrangChuNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_TrangChuNhanVien";
            this.panelchinh.ResumeLayout(false);
            this.panelchucnang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelchinh;
        private Guna.UI2.WinForms.Guna2Button btnminimize;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private Guna.UI2.WinForms.Guna2Panel paneldulieu;
        private Guna.UI2.WinForms.Guna2Panel panelchucnang;
        private Guna.UI2.WinForms.Guna2Button btnthoat;
        private Guna.UI2.WinForms.Guna2Button btnCaiDat;
        private Guna.UI2.WinForms.Guna2Button btnthongke;
        private Guna.UI2.WinForms.Guna2Button btnKhachHang;
        private Guna.UI2.WinForms.Guna2Button btndatdichvu;
        private Guna.UI2.WinForms.Guna2Button btnDatPhong;
        private Guna.UI2.WinForms.Guna2Button btntrangchunv;
        private Guna.UI2.WinForms.Guna2Button btnkhuyenmai;
        private Guna.UI2.WinForms.Guna2Button btntrangchu;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDangNhap;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}