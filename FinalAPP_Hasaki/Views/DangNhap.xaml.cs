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
    public partial class DangNhap : ContentPage
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private async void Dang_nhap_clicked(object sender, EventArgs e)
        {
            HttpClient http = new HttpClient();
            var kq = await http.GetStringAsync(IPaddress.url + "DangNhap?SODIENTHOAI=" + Entry_Sodienthoai.Text + "&&MATKHAU=" + Entry_Matkhau.Text);
            var nd = JsonConvert.DeserializeObject<NguoiDung>(kq);
            if (nd.SODIENTHOAI != "" && nd.MATKHAU != null)
            {
                await DisplayAlert("Thông báo", "test dang nhaopaj đúng " + nd.SODIENTHOAI, "OK");
                NguoiDung.nguoidung = nd;
                await DisplayAlert("TB", "test makh :" + NguoiDung.nguoidung.SODIENTHOAI, "OK");

            }
            else
                await DisplayAlert("TB", " Đăng Nhập Sai :", "OK");

        }

        private void Dang_Ky_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DangKy());
        }
    }
}