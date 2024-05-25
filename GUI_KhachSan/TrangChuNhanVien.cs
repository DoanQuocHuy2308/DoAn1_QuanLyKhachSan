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
    public partial class TrangChuNhanVien : UserControl
    {
        public TrangChuNhanVien()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            string videoPath = "D:\\VisualStudio\\Project\\DoAn1_QuanLyKhachSan\\IMG\\Trang Chủ\\02.mp4";
            if (System.IO.File.Exists(videoPath))
            {
                videotrangchu.URL = videoPath;
                videotrangchu.settings.autoStart = true;
            }
            else
            {
                MessageBox.Show("Không thể tìm thấy file video.");
            }
        }

        private void videotrangchu_Leave(object sender, EventArgs e)
        {
            if (videotrangchu.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                videotrangchu.Ctlcontrols.stop();
            }
        }
    }
}
