namespace GUI_KhachSan
{
    partial class TrangChuNhanVien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChuNhanVien));
            this.panelchinh = new Guna.UI2.WinForms.Guna2Panel();
            this.videotrangchu = new AxWMPLib.AxWindowsMediaPlayer();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelchinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videotrangchu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelchinh
            // 
            this.panelchinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.panelchinh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelchinh.BackgroundImage")));
            this.panelchinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelchinh.BorderColor = System.Drawing.Color.White;
            this.panelchinh.BorderRadius = 20;
            this.panelchinh.BorderThickness = 3;
            this.panelchinh.Controls.Add(this.label6);
            this.panelchinh.Controls.Add(this.label5);
            this.panelchinh.Controls.Add(this.label4);
            this.panelchinh.Controls.Add(this.label3);
            this.panelchinh.Controls.Add(this.label2);
            this.panelchinh.Controls.Add(this.label1);
            this.panelchinh.Controls.Add(this.videotrangchu);
            this.panelchinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelchinh.Location = new System.Drawing.Point(0, 0);
            this.panelchinh.Name = "panelchinh";
            this.panelchinh.Size = new System.Drawing.Size(1472, 693);
            this.panelchinh.TabIndex = 0;
            // 
            // videotrangchu
            // 
            this.videotrangchu.Enabled = true;
            this.videotrangchu.Location = new System.Drawing.Point(14, 185);
            this.videotrangchu.Name = "videotrangchu";
            this.videotrangchu.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videotrangchu.OcxState")));
            this.videotrangchu.Size = new System.Drawing.Size(692, 433);
            this.videotrangchu.TabIndex = 7;
            this.videotrangchu.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            this.videotrangchu.Leave += new System.EventHandler(this.videotrangchu_Leave);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(712, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(5, 488);
            this.label6.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(718, 511);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(737, 107);
            this.label5.TabIndex = 4;
            this.label5.Text = resources.GetString("label5.Text");
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(723, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(727, 125);
            this.label4.TabIndex = 3;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(718, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(737, 121);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(246, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1184, 69);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peridot Grand Luxury Boutique Hotel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(551, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "- Chào mừng bạn đến với -";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // TrangChuNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelchinh);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TrangChuNhanVien";
            this.Size = new System.Drawing.Size(1472, 693);
            this.panelchinh.ResumeLayout(false);
            this.panelchinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videotrangchu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelchinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private AxWMPLib.AxWindowsMediaPlayer videotrangchu;
        private System.Windows.Forms.Label label6;
    }
}
