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
    public partial class DonHang : ContentPage
    {
        public DonHang()
        {
            InitializeComponent();
        }

        private void tapped_tatca(object sender, EventArgs e)
        {
            hienthidonhang(1);
        }

        private void tapped_cho_thanh_toan(object sender, EventArgs e)
        {
            hienthidonhang(1);
        }

        private void tapped_dang_xu_ly(object sender, EventArgs e)
        {
            hienthidonhang(2);

        }

        private void tapped_thanh_cong(object sender, EventArgs e)
        {
            hienthidonhang(3);
        }

        private void tapped_da_huy(object sender, EventArgs e)
        {
            hienthidonhang(4);
        }
        async void hienthidonhang(int trangthai)
        {
            
            HttpClient httpClient = new HttpClient();
            //192.168.1.13
            var product_info_trangthai = await httpClient.GetStringAsync(IPaddress.url + "Show_Trangthai_Info?trangthai=" + trangthai.ToString()+"&makh="+ currentNguoiDung.MAKH.ToString());
            var product_info_trangthai_Converted = JsonConvert.DeserializeObject<List<Info_trangthai>>(product_info_trangthai);
            info_trangthai.ItemsSource = product_info_trangthai_Converted;
        }

        private void button_mualai(object sender, EventArgs e)
        {
         
        }
    }
}