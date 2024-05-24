using System;

namespace GUI_KhachSan
{
    partial class TrangChu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            this.panelchinh = new Guna.UI2.WinForms.Guna2Panel();
            this.panelanh = new Guna.UI2.WinForms.Guna2Panel();
            this.raddichvu5 = new System.Windows.Forms.RadioButton();
            this.radphong5 = new System.Windows.Forms.RadioButton();
            this.raddichvu4 = new System.Windows.Forms.RadioButton();
            this.radphong4 = new System.Windows.Forms.RadioButton();
            this.raddichvu3 = new System.Windows.Forms.RadioButton();
            this.radphong3 = new System.Windows.Forms.RadioButton();
            this.raddichvu2 = new System.Windows.Forms.RadioButton();
            this.radphong2 = new System.Windows.Forms.RadioButton();
            this.raddichvu1 = new System.Windows.Forms.RadioButton();
            this.radphong1 = new System.Windows.Forms.RadioButton();
            this.pckdichvu = new System.Windows.Forms.PictureBox();
            this.pckPhong = new System.Windows.Forms.PictureBox();
            this.panelvideo = new Guna.UI2.WinForms.Guna2Panel();
            this.videotrangchu = new AxWMPLib.AxWindowsMediaPlayer();
            this.panelchinh.SuspendLayout();
            this.panelanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pckdichvu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pckPhong)).BeginInit();
            this.panelvideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videotrangchu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelchinh
            // 
            this.panelchinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(76)))));
            this.panelchinh.BorderColor = System.Drawing.Color.Gold;
            this.panelchinh.BorderRadius = 20;
            this.panelchinh.BorderThickness = 2;
            this.panelchinh.Controls.Add(this.panelanh);
            this.panelchinh.Controls.Add(this.panelvideo);
            this.panelchinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelchinh.Location = new System.Drawing.Point(0, 0);
            this.panelchinh.Name = "panelchinh";
            this.panelchinh.Size = new System.Drawing.Size(1472, 693);
            this.panelchinh.TabIndex = 1;
            this.panelchinh.Leave += new System.EventHandler(this.TrangChu_Leave);
            // 
            // panelanh
            // 
            this.panelanh.BorderColor = System.Drawing.Color.White;
            this.panelanh.BorderRadius = 20;
            this.panelanh.BorderThickness = 2;
            this.panelanh.Controls.Add(this.raddichvu5);
            this.panelanh.Controls.Add(this.radphong5);
            this.panelanh.Controls.Add(this.raddichvu4);
            this.panelanh.Controls.Add(this.radphong4);
            this.panelanh.Controls.Add(this.raddichvu3);
            this.panelanh.Controls.Add(this.radphong3);
            this.panelanh.Controls.Add(this.raddichvu2);
            this.panelanh.Controls.Add(this.radphong2);
            this.panelanh.Controls.Add(this.raddichvu1);
            this.panelanh.Controls.Add(this.radphong1);
            this.panelanh.Controls.Add(this.pckdichvu);
            this.panelanh.Controls.Add(this.pckPhong);
            this.panelanh.Location = new System.Drawing.Point(935, 13);
            this.panelanh.Name = "panelanh";
            this.panelanh.Size = new System.Drawing.Size(523, 667);
            this.panelanh.TabIndex = 1;
            // 
            // raddichvu5
            // 
            this.raddichvu5.Location = new System.Drawing.Point(415, 633);
            this.raddichvu5.Name = "raddichvu5";
            this.raddichvu5.Size = new System.Drawing.Size(20, 20);
            this.raddichvu5.TabIndex = 1;
            this.raddichvu5.TabStop = true;
            this.raddichvu5.UseVisualStyleBackColor = true;
            this.raddichvu5.CheckedChanged += new System.EventHandler(this.raddichvu5_CheckedChanged);
            // 
            // radphong5
            // 
            this.radphong5.Location = new System.Drawing.Point(415, 306);
            this.radphong5.Name = "radphong5";
            this.radphong5.Size = new System.Drawing.Size(20, 20);
            this.radphong5.TabIndex = 1;
            this.radphong5.TabStop = true;
            this.radphong5.UseVisualStyleBackColor = true;
            this.radphong5.CheckedChanged += new System.EventHandler(this.radphong5_CheckedChanged);
            // 
            // raddichvu4
            // 
            this.raddichvu4.Location = new System.Drawing.Point(342, 633);
            this.raddichvu4.Name = "raddichvu4";
            this.raddichvu4.Size = new System.Drawing.Size(20, 20);
            this.raddichvu4.TabIndex = 1;
            this.raddichvu4.TabStop = true;
            this.raddichvu4.UseVisualStyleBackColor = true;
            this.raddichvu4.CheckedChanged += new System.EventHandler(this.raddichvu4_CheckedChanged);
            // 
            // radphong4
            // 
            this.radphong4.Location = new System.Drawing.Point(342, 306);
            this.radphong4.Name = "radphong4";
            this.radphong4.Size = new System.Drawing.Size(20, 20);
            this.radphong4.TabIndex = 1;
            this.radphong4.TabStop = true;
            this.radphong4.UseVisualStyleBackColor = true;
            this.radphong4.CheckedChanged += new System.EventHandler(this.radphong4_CheckedChanged);
            // 
            // raddichvu3
            // 
            this.raddichvu3.Location = new System.Drawing.Point(266, 633);
            this.raddichvu3.Name = "raddichvu3";
            this.raddichvu3.Size = new System.Drawing.Size(20, 20);
            this.raddichvu3.TabIndex = 1;
            this.raddichvu3.TabStop = true;
            this.raddichvu3.UseVisualStyleBackColor = true;
            this.raddichvu3.CheckedChanged += new System.EventHandler(this.raddichvu3_CheckedChanged);
            // 
            // radphong3
            // 
            this.radphong3.Location = new System.Drawing.Point(266, 306);
            this.radphong3.Name = "radphong3";
            this.radphong3.Size = new System.Drawing.Size(20, 20);
            this.radphong3.TabIndex = 1;
            this.radphong3.TabStop = true;
            this.radphong3.UseVisualStyleBackColor = true;
            this.radphong3.CheckedChanged += new System.EventHandler(this.radphong3_CheckedChanged);
            // 
            // raddichvu2
            // 
            this.raddichvu2.Location = new System.Drawing.Point(187, 633);
            this.raddichvu2.Name = "raddichvu2";
            this.raddichvu2.Size = new System.Drawing.Size(20, 20);
            this.raddichvu2.TabIndex = 1;
            this.raddichvu2.TabStop = true;
            this.raddichvu2.UseVisualStyleBackColor = true;
            this.raddichvu2.CheckedChanged += new System.EventHandler(this.raddichvu2_CheckedChanged);
            // 
            // radphong2
            // 
            this.radphong2.Location = new System.Drawing.Point(187, 306);
            this.radphong2.Name = "radphong2";
            this.radphong2.Size = new System.Drawing.Size(20, 20);
            this.radphong2.TabIndex = 1;
            this.radphong2.TabStop = true;
            this.radphong2.UseVisualStyleBackColor = true;
            this.radphong2.CheckedChanged += new System.EventHandler(this.radphong2_CheckedChanged);
            // 
            // raddichvu1
            // 
            this.raddichvu1.Location = new System.Drawing.Point(104, 633);
            this.raddichvu1.Name = "raddichvu1";
            this.raddichvu1.Size = new System.Drawing.Size(20, 20);
            this.raddichvu1.TabIndex = 1;
            this.raddichvu1.TabStop = true;
            this.raddichvu1.UseVisualStyleBackColor = true;
            this.raddichvu1.CheckedChanged += new System.EventHandler(this.raddichvu1_CheckedChanged);
            // 
            // radphong1
            // 
            this.radphong1.Location = new System.Drawing.Point(104, 306);
            this.radphong1.Name = "radphong1";
            this.radphong1.Size = new System.Drawing.Size(20, 20);
            this.radphong1.TabIndex = 1;
            this.radphong1.TabStop = true;
            this.radphong1.UseVisualStyleBackColor = true;
            this.radphong1.CheckedChanged += new System.EventHandler(this.radphong1_CheckedChanged);
            // 
            // pckdichvu
            // 
            this.pckdichvu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pckdichvu.Location = new System.Drawing.Point(24, 354);
            this.pckdichvu.Name = "pckdichvu";
            this.pckdichvu.Size = new System.Drawing.Size(475, 274);
            this.pckdichvu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pckdichvu.TabIndex = 0;
            this.pckdichvu.TabStop = false;
            // 
            // pckPhong
            // 
            this.pckPhong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pckPhong.Location = new System.Drawing.Point(24, 26);
            this.pckPhong.Name = "pckPhong";
            this.pckPhong.Size = new System.Drawing.Size(475, 274);
            this.pckPhong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pckPhong.TabIndex = 0;
            this.pckPhong.TabStop = false;
            // 
            // panelvideo
            // 
            this.panelvideo.BorderColor = System.Drawing.Color.White;
            this.panelvideo.BorderRadius = 20;
            this.panelvideo.BorderThickness = 2;
            this.panelvideo.Controls.Add(this.videotrangchu);
            this.panelvideo.Location = new System.Drawing.Point(12, 13);
            this.panelvideo.Name = "panelvideo";
            this.panelvideo.Size = new System.Drawing.Size(917, 667);
            this.panelvideo.TabIndex = 0;
            // 
            // videotrangchu
            // 
            this.videotrangchu.Enabled = true;
            this.videotrangchu.Location = new System.Drawing.Point(13, 14);
            this.videotrangchu.Name = "videotrangchu";
            this.videotrangchu.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videotrangchu.OcxState")));
            this.videotrangchu.Size = new System.Drawing.Size(886, 641);
            this.videotrangchu.TabIndex = 1;
            this.videotrangchu.Enter += new System.EventHandler(this.videotrangchu_Enter);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelchinh);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TrangChu";
            this.Size = new System.Drawing.Size(1472, 693);
            this.Leave += new System.EventHandler(this.TrangChu_Leave);
            this.panelchinh.ResumeLayout(false);
            this.panelanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pckdichvu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pckPhong)).EndInit();
            this.panelvideo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.videotrangchu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelchinh;
        private Guna.UI2.WinForms.Guna2Panel panelanh;
        private System.Windows.Forms.RadioButton raddichvu5;
        private System.Windows.Forms.RadioButton radphong5;
        private System.Windows.Forms.RadioButton raddichvu4;
        private System.Windows.Forms.RadioButton radphong4;
        private System.Windows.Forms.RadioButton raddichvu3;
        private System.Windows.Forms.RadioButton radphong3;
        private System.Windows.Forms.RadioButton raddichvu2;
        private System.Windows.Forms.RadioButton radphong2;
        private System.Windows.Forms.RadioButton raddichvu1;
        private System.Windows.Forms.RadioButton radphong1;
        private System.Windows.Forms.PictureBox pckdichvu;
        private System.Windows.Forms.PictureBox pckPhong;
        private Guna.UI2.WinForms.Guna2Panel panelvideo;
        private AxWMPLib.AxWindowsMediaPlayer videotrangchu;
    }
}
