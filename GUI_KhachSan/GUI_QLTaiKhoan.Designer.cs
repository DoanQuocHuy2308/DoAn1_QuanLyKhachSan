namespace GUI_KhachSan
{
    partial class GUI_QLTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_QLTaiKhoan));
            this.panelchinh = new Guna.UI2.WinForms.Guna2Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btntimkiemtk = new Guna.UI2.WinForms.Guna2Button();
            this.txttimkiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelchucnang = new Guna.UI2.WinForms.Guna2Panel();
            this.txtemailtaikhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnresettk = new Guna.UI2.WinForms.Guna2Button();
            this.btnxoatk = new Guna.UI2.WinForms.Guna2Button();
            this.btnsuatk = new Guna.UI2.WinForms.Guna2Button();
            this.btnthemtk = new Guna.UI2.WinForms.Guna2Button();
            this.cboban = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cborole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtidtaikhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnminimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnthoat = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.panelduieu = new Guna.UI2.WinForms.Guna2Panel();
            this.dtgvtaikhoan = new System.Windows.Forms.DataGridView();
            this.ID_TaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_TaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pass_TaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role_TaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ban_TaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelchinh.SuspendLayout();
            this.panelchucnang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelduieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvtaikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // panelchinh
            // 
            this.panelchinh.BorderColor = System.Drawing.Color.Cyan;
            this.panelchinh.BorderRadius = 20;
            this.panelchinh.BorderThickness = 2;
            this.panelchinh.Controls.Add(this.label8);
            this.panelchinh.Controls.Add(this.btntimkiemtk);
            this.panelchinh.Controls.Add(this.txttimkiem);
            this.panelchinh.Controls.Add(this.label2);
            this.panelchinh.Controls.Add(this.panelchucnang);
            this.panelchinh.Controls.Add(this.btnminimize);
            this.panelchinh.Controls.Add(this.btnthoat);
            this.panelchinh.Controls.Add(this.pictureBox1);
            this.panelchinh.Controls.Add(this.btnclose);
            this.panelchinh.Controls.Add(this.panelduieu);
            this.panelchinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelchinh.Location = new System.Drawing.Point(0, 0);
            this.panelchinh.Name = "panelchinh";
            this.panelchinh.Size = new System.Drawing.Size(1348, 770);
            this.panelchinh.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Copperplate Gothic Bold", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(243, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(375, 67);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tài Khoản";
            // 
            // btntimkiemtk
            // 
            this.btntimkiemtk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btntimkiemtk.BackgroundImage")));
            this.btntimkiemtk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btntimkiemtk.BorderColor = System.Drawing.Color.White;
            this.btntimkiemtk.BorderRadius = 10;
            this.btntimkiemtk.BorderThickness = 2;
            this.btntimkiemtk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btntimkiemtk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btntimkiemtk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btntimkiemtk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btntimkiemtk.FillColor = System.Drawing.Color.Transparent;
            this.btntimkiemtk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btntimkiemtk.ForeColor = System.Drawing.Color.White;
            this.btntimkiemtk.Location = new System.Drawing.Point(1269, 125);
            this.btntimkiemtk.Name = "btntimkiemtk";
            this.btntimkiemtk.Size = new System.Drawing.Size(67, 44);
            this.btntimkiemtk.TabIndex = 2;
            this.btntimkiemtk.Click += new System.EventHandler(this.btntimkiemtk_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.BorderColor = System.Drawing.Color.White;
            this.txttimkiem.BorderRadius = 10;
            this.txttimkiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttimkiem.DefaultText = "Tìm Kiếm Tài Khoản";
            this.txttimkiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttimkiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttimkiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(76)))));
            this.txttimkiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.ForeColor = System.Drawing.Color.White;
            this.txttimkiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttimkiem.Location = new System.Drawing.Point(907, 125);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.PasswordChar = '\0';
            this.txttimkiem.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txttimkiem.PlaceholderText = "";
            this.txttimkiem.SelectedText = "";
            this.txttimkiem.Size = new System.Drawing.Size(355, 44);
            this.txttimkiem.TabIndex = 1;
            this.txttimkiem.Enter += new System.EventHandler(this.txttimkiem_Enter);
            this.txttimkiem.Leave += new System.EventHandler(this.txttimkiem_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(920, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Search :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelchucnang
            // 
            this.panelchucnang.BorderColor = System.Drawing.Color.Gold;
            this.panelchucnang.BorderRadius = 20;
            this.panelchucnang.BorderThickness = 2;
            this.panelchucnang.Controls.Add(this.txtemailtaikhoan);
            this.panelchucnang.Controls.Add(this.label3);
            this.panelchucnang.Controls.Add(this.btnresettk);
            this.panelchucnang.Controls.Add(this.btnxoatk);
            this.panelchucnang.Controls.Add(this.btnsuatk);
            this.panelchucnang.Controls.Add(this.btnthemtk);
            this.panelchucnang.Controls.Add(this.cboban);
            this.panelchucnang.Controls.Add(this.cborole);
            this.panelchucnang.Controls.Add(this.txtpass);
            this.panelchucnang.Controls.Add(this.txtidtaikhoan);
            this.panelchucnang.Controls.Add(this.label7);
            this.panelchucnang.Controls.Add(this.label6);
            this.panelchucnang.Controls.Add(this.label5);
            this.panelchucnang.Controls.Add(this.label1);
            this.panelchucnang.Location = new System.Drawing.Point(907, 176);
            this.panelchucnang.Name = "panelchucnang";
            this.panelchucnang.Size = new System.Drawing.Size(430, 582);
            this.panelchucnang.TabIndex = 0;
            // 
            // txtemailtaikhoan
            // 
            this.txtemailtaikhoan.BorderColor = System.Drawing.Color.White;
            this.txtemailtaikhoan.BorderRadius = 15;
            this.txtemailtaikhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemailtaikhoan.DefaultText = "";
            this.txtemailtaikhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtemailtaikhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtemailtaikhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemailtaikhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemailtaikhoan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(76)))));
            this.txtemailtaikhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemailtaikhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemailtaikhoan.ForeColor = System.Drawing.Color.White;
            this.txtemailtaikhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemailtaikhoan.Location = new System.Drawing.Point(36, 125);
            this.txtemailtaikhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtemailtaikhoan.Name = "txtemailtaikhoan";
            this.txtemailtaikhoan.PasswordChar = '\0';
            this.txtemailtaikhoan.PlaceholderText = "";
            this.txtemailtaikhoan.SelectedText = "";
            this.txtemailtaikhoan.Size = new System.Drawing.Size(347, 38);
            this.txtemailtaikhoan.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email Tài Khoản:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnresettk
            // 
            this.btnresettk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnresettk.BackgroundImage")));
            this.btnresettk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnresettk.BorderColor = System.Drawing.Color.White;
            this.btnresettk.BorderRadius = 15;
            this.btnresettk.BorderThickness = 2;
            this.btnresettk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnresettk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnresettk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnresettk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnresettk.FillColor = System.Drawing.Color.Transparent;
            this.btnresettk.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresettk.ForeColor = System.Drawing.Color.White;
            this.btnresettk.ImageSize = new System.Drawing.Size(40, 40);
            this.btnresettk.Location = new System.Drawing.Point(229, 527);
            this.btnresettk.Name = "btnresettk";
            this.btnresettk.Size = new System.Drawing.Size(145, 45);
            this.btnresettk.TabIndex = 9;
            this.btnresettk.Click += new System.EventHandler(this.btnresettk_Click);
            // 
            // btnxoatk
            // 
            this.btnxoatk.BorderColor = System.Drawing.Color.White;
            this.btnxoatk.BorderRadius = 15;
            this.btnxoatk.BorderThickness = 2;
            this.btnxoatk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnxoatk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnxoatk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnxoatk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnxoatk.FillColor = System.Drawing.Color.Transparent;
            this.btnxoatk.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoatk.ForeColor = System.Drawing.Color.White;
            this.btnxoatk.Image = ((System.Drawing.Image)(resources.GetObject("btnxoatk.Image")));
            this.btnxoatk.ImageSize = new System.Drawing.Size(30, 30);
            this.btnxoatk.Location = new System.Drawing.Point(57, 527);
            this.btnxoatk.Name = "btnxoatk";
            this.btnxoatk.Size = new System.Drawing.Size(145, 45);
            this.btnxoatk.TabIndex = 8;
            this.btnxoatk.Text = "&Xóa";
            this.btnxoatk.Click += new System.EventHandler(this.btnxoatk_Click);
            // 
            // btnsuatk
            // 
            this.btnsuatk.BorderColor = System.Drawing.Color.White;
            this.btnsuatk.BorderRadius = 15;
            this.btnsuatk.BorderThickness = 2;
            this.btnsuatk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsuatk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsuatk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsuatk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsuatk.FillColor = System.Drawing.Color.Transparent;
            this.btnsuatk.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuatk.ForeColor = System.Drawing.Color.White;
            this.btnsuatk.Image = ((System.Drawing.Image)(resources.GetObject("btnsuatk.Image")));
            this.btnsuatk.ImageSize = new System.Drawing.Size(30, 30);
            this.btnsuatk.Location = new System.Drawing.Point(229, 464);
            this.btnsuatk.Name = "btnsuatk";
            this.btnsuatk.Size = new System.Drawing.Size(145, 45);
            this.btnsuatk.TabIndex = 7;
            this.btnsuatk.Text = "&Sửa";
            this.btnsuatk.Click += new System.EventHandler(this.btnsuatk_Click);
            // 
            // btnthemtk
            // 
            this.btnthemtk.BorderColor = System.Drawing.Color.White;
            this.btnthemtk.BorderRadius = 15;
            this.btnthemtk.BorderThickness = 2;
            this.btnthemtk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthemtk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthemtk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthemtk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthemtk.FillColor = System.Drawing.Color.Transparent;
            this.btnthemtk.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemtk.ForeColor = System.Drawing.Color.White;
            this.btnthemtk.Image = ((System.Drawing.Image)(resources.GetObject("btnthemtk.Image")));
            this.btnthemtk.Location = new System.Drawing.Point(57, 464);
            this.btnthemtk.Name = "btnthemtk";
            this.btnthemtk.Size = new System.Drawing.Size(145, 45);
            this.btnthemtk.TabIndex = 6;
            this.btnthemtk.Text = "&Thêm";
            this.btnthemtk.Click += new System.EventHandler(this.btnthemtk_Click);
            // 
            // cboban
            // 
            this.cboban.BackColor = System.Drawing.Color.Transparent;
            this.cboban.BorderColor = System.Drawing.Color.White;
            this.cboban.BorderRadius = 15;
            this.cboban.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboban.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(76)))));
            this.cboban.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboban.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboban.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cboban.ForeColor = System.Drawing.Color.White;
            this.cboban.ItemHeight = 30;
            this.cboban.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cboban.Location = new System.Drawing.Point(36, 410);
            this.cboban.Name = "cboban";
            this.cboban.Size = new System.Drawing.Size(186, 36);
            this.cboban.TabIndex = 5;
            // 
            // cborole
            // 
            this.cborole.BackColor = System.Drawing.Color.Transparent;
            this.cborole.BorderColor = System.Drawing.Color.White;
            this.cborole.BorderRadius = 15;
            this.cborole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cborole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cborole.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(76)))));
            this.cborole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cborole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cborole.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cborole.ForeColor = System.Drawing.Color.White;
            this.cborole.ItemHeight = 30;
            this.cborole.Items.AddRange(new object[] {
            "Admin",
            "Nhân Viên"});
            this.cborole.Location = new System.Drawing.Point(36, 317);
            this.cborole.Name = "cborole";
            this.cborole.Size = new System.Drawing.Size(258, 36);
            this.cborole.TabIndex = 4;
            // 
            // txtpass
            // 
            this.txtpass.BorderColor = System.Drawing.Color.White;
            this.txtpass.BorderRadius = 15;
            this.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpass.DefaultText = "";
            this.txtpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(76)))));
            this.txtpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.White;
            this.txtpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpass.Location = new System.Drawing.Point(36, 218);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '\0';
            this.txtpass.PlaceholderText = "";
            this.txtpass.SelectedText = "";
            this.txtpass.Size = new System.Drawing.Size(347, 38);
            this.txtpass.TabIndex = 3;
            // 
            // txtidtaikhoan
            // 
            this.txtidtaikhoan.BorderColor = System.Drawing.Color.White;
            this.txtidtaikhoan.BorderRadius = 15;
            this.txtidtaikhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtidtaikhoan.DefaultText = "";
            this.txtidtaikhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtidtaikhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtidtaikhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtidtaikhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtidtaikhoan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(76)))));
            this.txtidtaikhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtidtaikhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidtaikhoan.ForeColor = System.Drawing.Color.White;
            this.txtidtaikhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtidtaikhoan.Location = new System.Drawing.Point(36, 34);
            this.txtidtaikhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtidtaikhoan.Name = "txtidtaikhoan";
            this.txtidtaikhoan.PasswordChar = '\0';
            this.txtidtaikhoan.PlaceholderText = "";
            this.txtidtaikhoan.SelectedText = "";
            this.txtidtaikhoan.Size = new System.Drawing.Size(153, 38);
            this.txtidtaikhoan.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(46, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ban:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(46, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Vai Trò:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(46, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mật Khẩu:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Tài Khoản:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnminimize.Location = new System.Drawing.Point(1249, 12);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(41, 36);
            this.btnminimize.TabIndex = 10;
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
            this.btnthoat.Location = new System.Drawing.Point(13, 12);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(41, 36);
            this.btnthoat.TabIndex = 9;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(587, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
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
            this.btnclose.Location = new System.Drawing.Point(1296, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(41, 36);
            this.btnclose.TabIndex = 7;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // panelduieu
            // 
            this.panelduieu.BorderColor = System.Drawing.Color.Gold;
            this.panelduieu.BorderRadius = 20;
            this.panelduieu.BorderThickness = 2;
            this.panelduieu.Controls.Add(this.dtgvtaikhoan);
            this.panelduieu.Location = new System.Drawing.Point(12, 176);
            this.panelduieu.Name = "panelduieu";
            this.panelduieu.Size = new System.Drawing.Size(889, 582);
            this.panelduieu.TabIndex = 0;
            // 
            // dtgvtaikhoan
            // 
            this.dtgvtaikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvtaikhoan.BackgroundColor = System.Drawing.Color.White;
            this.dtgvtaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvtaikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_TaiKhoan,
            this.Email_TaiKhoan,
            this.Pass_TaiKhoan,
            this.Role_TaiKhoan,
            this.Ban_TaiKhoan});
            this.dtgvtaikhoan.GridColor = System.Drawing.Color.Black;
            this.dtgvtaikhoan.Location = new System.Drawing.Point(14, 19);
            this.dtgvtaikhoan.Name = "dtgvtaikhoan";
            this.dtgvtaikhoan.RowHeadersWidth = 51;
            this.dtgvtaikhoan.RowTemplate.Height = 24;
            this.dtgvtaikhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvtaikhoan.Size = new System.Drawing.Size(863, 544);
            this.dtgvtaikhoan.TabIndex = 0;
            this.dtgvtaikhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvtaikhoan_CellClick);
            // 
            // ID_TaiKhoan
            // 
            this.ID_TaiKhoan.HeaderText = "ID";
            this.ID_TaiKhoan.MinimumWidth = 6;
            this.ID_TaiKhoan.Name = "ID_TaiKhoan";
            this.ID_TaiKhoan.ReadOnly = true;
            // 
            // Email_TaiKhoan
            // 
            this.Email_TaiKhoan.HeaderText = "Email";
            this.Email_TaiKhoan.MinimumWidth = 6;
            this.Email_TaiKhoan.Name = "Email_TaiKhoan";
            this.Email_TaiKhoan.ReadOnly = true;
            // 
            // Pass_TaiKhoan
            // 
            this.Pass_TaiKhoan.HeaderText = "PassWord";
            this.Pass_TaiKhoan.MinimumWidth = 6;
            this.Pass_TaiKhoan.Name = "Pass_TaiKhoan";
            this.Pass_TaiKhoan.ReadOnly = true;
            // 
            // Role_TaiKhoan
            // 
            this.Role_TaiKhoan.HeaderText = "Role";
            this.Role_TaiKhoan.MinimumWidth = 6;
            this.Role_TaiKhoan.Name = "Role_TaiKhoan";
            this.Role_TaiKhoan.ReadOnly = true;
            // 
            // Ban_TaiKhoan
            // 
            this.Ban_TaiKhoan.HeaderText = "Ban";
            this.Ban_TaiKhoan.MinimumWidth = 6;
            this.Ban_TaiKhoan.Name = "Ban_TaiKhoan";
            this.Ban_TaiKhoan.ReadOnly = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // GUI_QLTaiKhoan
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
            this.Name = "GUI_QLTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_QLTaiKhoan";
            this.panelchinh.ResumeLayout(false);
            this.panelchinh.PerformLayout();
            this.panelchucnang.ResumeLayout(false);
            this.panelchucnang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelduieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvtaikhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelchinh;
        private Guna.UI2.WinForms.Guna2Panel panelduieu;
        private Guna.UI2.WinForms.Guna2Button btnminimize;
        private Guna.UI2.WinForms.Guna2Button btnthoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private Guna.UI2.WinForms.Guna2Panel panelchucnang;
        private Guna.UI2.WinForms.Guna2Button btntimkiemtk;
        private Guna.UI2.WinForms.Guna2TextBox txttimkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtpass;
        private Guna.UI2.WinForms.Guna2TextBox txtidtaikhoan;
        private Guna.UI2.WinForms.Guna2ComboBox cborole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnresettk;
        private Guna.UI2.WinForms.Guna2Button btnxoatk;
        private Guna.UI2.WinForms.Guna2Button btnsuatk;
        private Guna.UI2.WinForms.Guna2Button btnthemtk;
        private System.Windows.Forms.DataGridView dtgvtaikhoan;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtemailtaikhoan;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cboban;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_TaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass_TaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role_TaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ban_TaiKhoan;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}