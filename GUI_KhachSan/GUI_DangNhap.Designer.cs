namespace GUI_KhachSan
{
    partial class GUI_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_DangNhap));
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbovaitro = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmatkhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.btndangnhap = new Guna.UI2.WinForms.Guna2Button();
            this.linkdangky = new System.Windows.Forms.LinkLabel();
            this.panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.linkquenmk = new System.Windows.Forms.LinkLabel();
            this.chkhien = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.btnreset = new Guna.UI2.WinForms.Guna2Button();
            this.anh3 = new System.Windows.Forms.PictureBox();
            this.anh2 = new System.Windows.Forms.PictureBox();
            this.anh1 = new System.Windows.Forms.PictureBox();
            this.btnminimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anh3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anh2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anh1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(76)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(699, 406);
            this.label5.TabIndex = 1;
            this.label5.Text = "Log In";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label5_MouseDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vai Trò";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật Khẩu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tạo tài khoản ";
            // 
            // cbovaitro
            // 
            this.cbovaitro.BackColor = System.Drawing.Color.Transparent;
            this.cbovaitro.BorderColor = System.Drawing.Color.Black;
            this.cbovaitro.BorderRadius = 15;
            this.cbovaitro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbovaitro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbovaitro.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbovaitro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbovaitro.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cbovaitro.ForeColor = System.Drawing.Color.Black;
            this.cbovaitro.ItemHeight = 30;
            this.cbovaitro.Items.AddRange(new object[] {
            "Nhân Viên",
            "Admin"});
            this.cbovaitro.Location = new System.Drawing.Point(84, 55);
            this.cbovaitro.Name = "cbovaitro";
            this.cbovaitro.Size = new System.Drawing.Size(344, 36);
            this.cbovaitro.TabIndex = 1;
            // 
            // txtemail
            // 
            this.txtemail.BorderColor = System.Drawing.Color.Black;
            this.txtemail.BorderRadius = 15;
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.DefaultText = "";
            this.txtemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtemail.ForeColor = System.Drawing.Color.Black;
            this.txtemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.Location = new System.Drawing.Point(84, 152);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.PlaceholderText = "";
            this.txtemail.SelectedText = "";
            this.txtemail.Size = new System.Drawing.Size(344, 43);
            this.txtemail.TabIndex = 2;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.BorderColor = System.Drawing.Color.Black;
            this.txtmatkhau.BorderRadius = 15;
            this.txtmatkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmatkhau.DefaultText = "";
            this.txtmatkhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmatkhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmatkhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmatkhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmatkhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmatkhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhau.ForeColor = System.Drawing.Color.Black;
            this.txtmatkhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmatkhau.Location = new System.Drawing.Point(84, 259);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '\0';
            this.txtmatkhau.PlaceholderText = "";
            this.txtmatkhau.SelectedText = "";
            this.txtmatkhau.Size = new System.Drawing.Size(344, 43);
            this.txtmatkhau.TabIndex = 3;
            // 
            // btndangnhap
            // 
            this.btndangnhap.BorderRadius = 15;
            this.btndangnhap.BorderThickness = 1;
            this.btndangnhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndangnhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndangnhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndangnhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndangnhap.FillColor = System.Drawing.Color.Transparent;
            this.btndangnhap.FocusedColor = System.Drawing.Color.Transparent;
            this.btndangnhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btndangnhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(76)))));
            this.btndangnhap.Location = new System.Drawing.Point(84, 309);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(151, 45);
            this.btndangnhap.TabIndex = 5;
            this.btndangnhap.Text = "Đăng Nhập";
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // linkdangky
            // 
            this.linkdangky.AutoSize = true;
            this.linkdangky.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkdangky.LinkColor = System.Drawing.Color.Blue;
            this.linkdangky.Location = new System.Drawing.Point(263, 404);
            this.linkdangky.Name = "linkdangky";
            this.linkdangky.Size = new System.Drawing.Size(100, 26);
            this.linkdangky.TabIndex = 8;
            this.linkdangky.TabStop = true;
            this.linkdangky.Text = "Tại Đây !";
            this.linkdangky.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkdangky_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderColor = System.Drawing.Color.Black;
            this.panel1.BorderRadius = 20;
            this.panel1.BorderThickness = 2;
            this.panel1.Controls.Add(this.linkquenmk);
            this.panel1.Controls.Add(this.linkdangky);
            this.panel1.Controls.Add(this.chkhien);
            this.panel1.Controls.Add(this.btnreset);
            this.panel1.Controls.Add(this.btndangnhap);
            this.panel1.Controls.Add(this.txtmatkhau);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.cbovaitro);
            this.panel1.Controls.Add(this.anh3);
            this.panel1.Controls.Add(this.anh2);
            this.panel1.Controls.Add(this.anh1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 20, 20, 0);
            this.panel1.FillColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(93, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 444);
            this.panel1.TabIndex = 0;
            // 
            // linkquenmk
            // 
            this.linkquenmk.AutoSize = true;
            this.linkquenmk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkquenmk.Location = new System.Drawing.Point(187, 371);
            this.linkquenmk.Name = "linkquenmk";
            this.linkquenmk.Size = new System.Drawing.Size(125, 22);
            this.linkquenmk.TabIndex = 7;
            this.linkquenmk.TabStop = true;
            this.linkquenmk.Text = "Quên mật khẩu";
            this.linkquenmk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkquenmk_LinkClicked);
            // 
            // chkhien
            // 
            this.chkhien.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.chkhien.Image = ((System.Drawing.Image)(resources.GetObject("chkhien.Image")));
            this.chkhien.ImageOffset = new System.Drawing.Point(0, 0);
            this.chkhien.ImageRotate = 0F;
            this.chkhien.Location = new System.Drawing.Point(392, 269);
            this.chkhien.Name = "chkhien";
            this.chkhien.Size = new System.Drawing.Size(30, 22);
            this.chkhien.TabIndex = 4;
            this.chkhien.CheckedChanged += new System.EventHandler(this.chkhien_CheckedChanged);
            // 
            // btnreset
            // 
            this.btnreset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnreset.BorderRadius = 15;
            this.btnreset.BorderThickness = 1;
            this.btnreset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnreset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnreset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnreset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnreset.FillColor = System.Drawing.Color.Transparent;
            this.btnreset.FocusedColor = System.Drawing.Color.Transparent;
            this.btnreset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnreset.ForeColor = System.Drawing.Color.White;
            this.btnreset.Image = ((System.Drawing.Image)(resources.GetObject("btnreset.Image")));
            this.btnreset.ImageSize = new System.Drawing.Size(35, 35);
            this.btnreset.Location = new System.Drawing.Point(268, 309);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(154, 45);
            this.btnreset.TabIndex = 6;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // anh3
            // 
            this.anh3.Image = ((System.Drawing.Image)(resources.GetObject("anh3.Image")));
            this.anh3.Location = new System.Drawing.Point(96, 217);
            this.anh3.Name = "anh3";
            this.anh3.Size = new System.Drawing.Size(44, 34);
            this.anh3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.anh3.TabIndex = 1;
            this.anh3.TabStop = false;
            // 
            // anh2
            // 
            this.anh2.Image = ((System.Drawing.Image)(resources.GetObject("anh2.Image")));
            this.anh2.Location = new System.Drawing.Point(96, 111);
            this.anh2.Name = "anh2";
            this.anh2.Size = new System.Drawing.Size(44, 34);
            this.anh2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.anh2.TabIndex = 1;
            this.anh2.TabStop = false;
            // 
            // anh1
            // 
            this.anh1.Image = ((System.Drawing.Image)(resources.GetObject("anh1.Image")));
            this.anh1.Location = new System.Drawing.Point(96, 15);
            this.anh1.Name = "anh1";
            this.anh1.Size = new System.Drawing.Size(44, 34);
            this.anh1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.anh1.TabIndex = 1;
            this.anh1.TabStop = false;
            // 
            // btnminimize
            // 
            this.btnminimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(76)))));
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
            this.btnminimize.Location = new System.Drawing.Point(602, 12);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(41, 36);
            this.btnminimize.TabIndex = 2;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(76)))));
            this.btnclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclose.BackgroundImage")));
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnclose.BorderColor = System.Drawing.Color.Gold;
            this.btnclose.BorderRadius = 10;
            this.btnclose.BorderThickness = 2;
            this.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnclose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclose.FillColor = System.Drawing.Color.Transparent;
            this.btnclose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(649, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(41, 36);
            this.btnclose.TabIndex = 3;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(76)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(226, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(249, 142);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(199, 693);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.panel1;
            // 
            // GUI_DangNhap
            // 
            this.AcceptButton = this.btndangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(221)))));
            this.CancelButton = this.btnclose;
            this.ClientSize = new System.Drawing.Size(699, 812);
            this.Controls.Add(this.btnminimize);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUI_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_DangNhap";
            this.Load += new System.EventHandler(this.GUI_DangNhap_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GUI_DangNhap_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anh3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anh2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anh1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox anh1;
        private System.Windows.Forms.PictureBox anh2;
        private System.Windows.Forms.PictureBox anh3;
        private Guna.UI2.WinForms.Guna2ComboBox cbovaitro;
        private Guna.UI2.WinForms.Guna2TextBox txtemail;
        private Guna.UI2.WinForms.Guna2TextBox txtmatkhau;
        private Guna.UI2.WinForms.Guna2Button btndangnhap;
        private Guna.UI2.WinForms.Guna2Button btnreset;
        private Guna.UI2.WinForms.Guna2ImageCheckBox chkhien;
        private System.Windows.Forms.LinkLabel linkdangky;
        private Guna.UI2.WinForms.Guna2Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private Guna.UI2.WinForms.Guna2Button btnminimize;
        private System.Windows.Forms.LinkLabel linkquenmk;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}