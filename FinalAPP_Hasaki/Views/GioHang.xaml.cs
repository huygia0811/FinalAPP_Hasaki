using FinalAPP_Hasaki.Models;
using Newtonsoft.Json;
using Syncfusion.SfNumericUpDown.XForms;
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
    public partial class GioHang : ContentPage
    {
        long TOTAL { get; set; } = 0;
        public GioHang()
        {
            InitializeComponent();
            HienThiGioHang();
            BindingContext = this;
        }
        async public void XuatTotal()
        {
            HttpClient httpClient = new HttpClient();
            var subjectlist = await httpClient.GetStringAsync(IPaddress.url + "TongTienGH?MAKH=" + currentNguoiDung.MAKH.ToString());
        }
        async public void HienThiGioHang()
        {
            HttpClient httpClient = new HttpClient();
            var subjectlist = await httpClient.GetStringAsync(IPaddress.url + "SelectGioHang?MAKH=" +currentNguoiDung.MAKH.ToString());
            var subjectlistConverted = JsonConvert.DeserializeObject<List<classGioHang>>(subjectlist);
            CV_GioHang.ItemsSource= subjectlistConverted;
        }
        async private void sfNumericUpDown_ValueChanged(object sender, Syncfusion.SfNumericUpDown.XForms.ValueEventArgs e)
        {
            SfNumericUpDown bt = (SfNumericUpDown)sender;
            classGioHang hc = (classGioHang)bt.BindingContext;
            int masp = hc.MASP;
            int value = Convert.ToInt32(e.Value);
            HttpClient httpClient = new HttpClient();
            await httpClient.GetStringAsync(IPaddress.url + "UpdateSLGioHang?MAKH="+currentNguoiDung.MAKH.ToString()+"&MASP="+masp.ToString()+"&sl_updated="+value.ToString());
        }

        async private void ImageButton_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Thông báo", "Bạn có muốn xóa sản phẩm này khỏi giỏ hàng?", "Có", "Không");
            if (answer)
            {
                ImageButton bt = (ImageButton)sender;
                classGioHang hc = (classGioHang)bt.BindingContext;
                int masp = hc.MASP;
                HttpClient httpClient = new HttpClient();
                await httpClient.GetStringAsync(IPaddress.url + "DropSPGioHang?MAKH=" + currentNguoiDung.MAKH.ToString() + "&MASP=" + masp.ToString());
            }   
        }

        async private void dathang_Clicked(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            await httpClient.GetStringAsync(IPaddress.url + "DatHang?MAKH=" + currentNguoiDung.MAKH.ToString());
            await DisplayAlert("Thông báo", "Bạn đã đặt hàng thành công", "OK");
        }
    }
}