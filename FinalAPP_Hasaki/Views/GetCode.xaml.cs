using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net;
using System.Net.Mail;
namespace FinalAPP_Hasaki.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GetCode : ContentPage
    {
        string randomCode;
        public static string to;
        public GetCode()
        {
            InitializeComponent();
        }

        private async void click_getcode(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (Email_entry.Text).ToString();
            from = "uitcarshop@gmail.com";
            pass = "joucvfymmvauhjxm";
            messageBody = "Mã code để thay đổi mật khẩu của bạn là: " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Code thay đổi mật khẩu";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                await DisplayAlert("Thông báo", "Vui lòng kiểm tra Email", "OK");
            }
            catch(Exception ex)
            {
                await DisplayAlert("Thông báo", ex.Message, "OK");
            }
        }

        private async void click_check_code(object sender, EventArgs e)
        {
            if(randomCode== Code_entry.Text.ToString())
            {
                to = Email_entry.Text;
                Navigation.PushAsync(new QuenMatKhau());
            }    
            else
            {
                await DisplayAlert("Thông báo", "Mã code không đúng", "OK");
            }    
        }
    }
}