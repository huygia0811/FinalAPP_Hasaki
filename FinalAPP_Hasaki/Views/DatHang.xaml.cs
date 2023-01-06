using FinalAPP_Hasaki.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalAPP_Hasaki.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatHang : ContentPage
    {
        public DatHang()
        {
            InitializeComponent();
            HienThiDiaChi();
        }
        async public void HienThiDiaChi()
        {
            HttpClient httpClient = new HttpClient();
            var subjectlist = await httpClient.GetStringAsync(IPaddress.url + "GetInfoKhachHang?MAKH=" + currentNguoiDung.MAKH.ToString());
            var subjectlistConverted = JsonConvert.DeserializeObject<List<ThongTinKhachHang>>(subjectlist);
            lstdiachi.ItemsSource = subjectlistConverted;
        }
        private void lstdiachi_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        async private void dathang_Clicked(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            await httpClient.GetStringAsync(IPaddress.url + "DatHang?MAKH=" + currentNguoiDung.MAKH.ToString());
            await DisplayAlert("Thông báo", "Bạn đã đặt hàng thành công", "OK");
            Navigation.PopAsync();
        }
    }
}