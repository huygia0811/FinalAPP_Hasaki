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
    public partial class TrangChu : ContentPage
    {
        public TrangChu()
        {
            InitializeComponent();
            hienthiproduct();
        }

        private void TIKTDH_Clicked(object sender, EventArgs e)
        {

        }

        private void TIgiohang_Clicked(object sender, EventArgs e)
        {

        }
     
        async void hienthiproduct()
        {
            HttpClient httpClient = new HttpClient();
            var subjectlist = await httpClient.GetStringAsync("http://192.168.1.13/webapifinalhasaki/api/ServiceController/GetAllSanPham");
            var subjectlistConverted = JsonConvert.DeserializeObject<List<Product>>(subjectlist);
            Homeproduct1.ItemsSource = subjectlistConverted;
            Homeproduct2.ItemsSource = subjectlistConverted;
            Homeproduct3.ItemsSource = subjectlistConverted;
        }

        private void Ca_nhan_tapped(object sender, EventArgs e)
        {

        }

        private void Da_mat_tapped(object sender, EventArgs e)
        {

        }

        private void Toc_da_tapped(object sender, EventArgs e)
        {

        }

        private void Co_the_tapped(object sender, EventArgs e)
        {

        }

        private void My_pham_tapped(object sender, EventArgs e)
        {
            DisplayAlert("thong bao", "sadasdasd", "dong");
        }

        private void Nuoc_hoa_tapped(object sender, EventArgs e)
        {

        }

        private void Chuc_nang_tapped(object sender, EventArgs e)
        {

        }

        private void trang_diem_tapped(object sender, EventArgs e)
        {

        }
    }
}