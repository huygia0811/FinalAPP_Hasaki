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
			HttpClient http = new HttpClient();
			if (Matkhau_entry.Text != Matkhau_confirm_entry.Text)
			{
				await DisplayAlert("Thông báo", "Mật khẩu nhập lại không đúng", "OK");
				return;
			}
			else if(Email_entry.Text==null || Matkhau_entry.Text==null || SDT_entry.Text==null)
            {
				await DisplayAlert("Thông báo", "Vui lòng nhập đầy đủ", "OK");
				return;
			}				
			NguoiDung nd = new NguoiDung {MATKHAU = Matkhau_entry.Text, SODIENTHOAI = SDT_entry.Text, EMAIL = Email_entry.Text };
			string jsonlh = JsonConvert.SerializeObject(nd);
			StringContent httcontent = new StringContent(jsonlh, Encoding.UTF8, "application/json");
			HttpResponseMessage kq = await http.PostAsync(IPaddress.url + "DangKy", httcontent);
			var kqtv = await kq.Content.ReadAsStringAsync();
			nd = JsonConvert.DeserializeObject<NguoiDung>(kqtv);
			if (nd.MAKH > 0)
            {
				await DisplayAlert("Thông báo", "Tạo tài khoản thành công.", "OK");
				Navigation.PushAsync(new DangNhap());
			}				
			else
				await DisplayAlert("Thông báo", "Tên số điện thoại " +nd.SODIENTHOAI +" Đã tồn tại.", "OK");

		}

        private void Dang_Nhap_Clicked(object sender, EventArgs e)
        {
			Navigation.PushAsync(new DangNhap());
        }
    }
}