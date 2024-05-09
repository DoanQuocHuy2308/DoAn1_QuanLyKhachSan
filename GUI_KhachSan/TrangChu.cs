using System;
using System.Windows.Forms;

namespace GUI_KhachSan
{
    public partial class TrangChu : UserControl
    {
        public TrangChu()
        {
            InitializeComponent();
            radphong1.Checked = true;
            raddichvu1.Checked = true;
        }
        private void videotrangchu_Enter(object sender, EventArgs e)
        {
            string videoPath = "D:\\VisualStudio\\Project\\DoAn1_QuanLyKhachSan\\IMG\\Trang Chủ\\02.mp4";
            if (System.IO.File.Exists(videoPath))
            {
                videotrangchu.URL = videoPath;
                videotrangchu.Ctlcontrols.play();
            }
            else
            {
                MessageBox.Show("Không thể tìm thấy file video.");
            }
        }

        private void radphong1_CheckedChanged(object sender, EventArgs e)
        {
            if (radphong1.Checked)
            {
                pckPhong.Image = Properties.Resources.IMG_8960_2000;
            }
        }

        private void radphong2_CheckedChanged(object sender, EventArgs e)
        {
            if (radphong2.Checked)
            {
                pckPhong.Image = Properties.Resources.Bedroom1_2000;
            }
        }

        private void radphong3_CheckedChanged(object sender, EventArgs e)
        {
            if (radphong3.Checked)
            {
                pckPhong.Image = Properties.Resources.Bedroom_2_2000__1_;
            }
        }

        private void radphong4_CheckedChanged(object sender, EventArgs e)
        {
            if (radphong4.Checked)
            {
                pckPhong.Image = Properties.Resources.Grand_Deluxe_Double_2000;
            }
        }

        private void radphong5_CheckedChanged(object sender, EventArgs e)
        {
            if (radphong5.Checked)
            {
                pckPhong.Image = Properties.Resources.Premier_Deluxe_Twin1_2000_1;
            }
        }

        private void raddichvu1_CheckedChanged(object sender, EventArgs e)
        {
            if(raddichvu1.Checked)
            {
                pckdichvu.Image = Properties.Resources.Spa_3_2000;
            }
        }

        private void raddichvu2_CheckedChanged(object sender, EventArgs e)
        {
            if(raddichvu2.Checked)
            {
                pckdichvu.Image = Properties.Resources.Gym_2_2000;
            }
        }

        private void raddichvu3_CheckedChanged(object sender, EventArgs e)
        {
            if(raddichvu3.Checked)
            {
                pckdichvu.Image = Properties.Resources.DSC_3362_2000;
            }
        }

        private void raddichvu4_CheckedChanged(object sender, EventArgs e)
        {
            if (raddichvu4.Checked)
            {
                pckdichvu.Image = Properties.Resources.Restaurant_Details_1_2000;
            }
        }

        private void raddichvu5_CheckedChanged(object sender, EventArgs e)
        {
            if (raddichvu5.Checked)
            {
                pckdichvu.Image = Properties.Resources.Infinity_Pool_4_2000;
            }
        }

        private void TrangChu_Leave(object sender, EventArgs e)
        {
            if (videotrangchu.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                videotrangchu.Ctlcontrols.stop();
            }
        }
    }
}
