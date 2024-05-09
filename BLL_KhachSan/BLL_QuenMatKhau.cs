using DAL_KhachSan;
using DTO_KhachSan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BLL_KhachSan
{
    public class BLL_QuenMatKhau
    {
        private DAL_QuenMatKhau qmk = new DAL_QuenMatKhau();
        Random random = new Random();
        public static int otp;
        public bool KiemTraEmailTonTai(DTO_TaiKhoan tk)
        {
            return qmk.KiemTraEmailTonTai(tk.Email_TaiKhoan);
        }
        public string KiemTraRoleTonTai(string email)
        {
            return qmk.KiemTraRole(email);
        }
        public void ThayDoiMatKhau(DTO_TaiKhoan tk)
        {
            qmk.ThayDoiMatKhau(tk);
        }
        public void GuiOTP(string email)
        {
            try
            {
                otp = random.Next(100000, 1000000);

                var emailguiotp = new MailAddress("quochuydoan2308@gmail.com");
                var emailnhan = new MailAddress(email);
                const string pass = "lgpefgduywpdbddk";
                const string subject = "OTP code";
                string body = otp.ToString();

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(emailguiotp.Address, pass),
                    Timeout = 20000
                };

                using (var message = new MailMessage(emailguiotp, emailnhan)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }

                Console.WriteLine("Mã OTP đã được gửi đến email của bạn.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi gửi mã OTP: " + ex.Message);
            }
        }
    }
}
