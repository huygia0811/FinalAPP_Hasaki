using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalAPP_Hasaki.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using Newtonsoft.Json;
namespace FinalAPP_Hasaki.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DangKy : ContentPage
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private async void dangky_buttonclick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(HoTen_Entry.Text) || string.IsNullOrWhiteSpace(SDT_entry.Text) || string.IsNullOrWhiteSpace(Matkhau_entry.Text))
            {
                await DisplayAlert("Thông báo", "Làm ơn nhập đầy đủ dữ liệu", "OK");
            }
            else
            {
                Khachhang kh = new Khachhang { HOTEN = HoTen_Entry.Text, SODIENTHOAI = SDT_entry.Text, MATKHAU = Matkhau_entry.Text };
                HttpClient http = new HttpClient();

                string json = JsonConvert.SerializeObject(kh);
                HttpContent httpContent = new StringContent(json);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var response = http.PostAsync("", httpContent);
                var mystring = response.GetAwaiter().GetResult();

               
            }
                    
        }
    }
}