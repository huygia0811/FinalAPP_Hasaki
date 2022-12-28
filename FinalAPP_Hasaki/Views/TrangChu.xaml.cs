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
            //192.168.1.13
            var subjectlist = await httpClient.GetStringAsync("http://192.168.1.6/webapifinalhasaki/api/ServiceController/GetSPByLoai?maloai=5");
            var subjectlistConverted = JsonConvert.DeserializeObject<List<Product>>(subjectlist);
            Homeproduct1.ItemsSource = subjectlistConverted;
            var subjectlist2 = await httpClient.GetStringAsync("http://192.168.1.6/webapifinalhasaki/api/ServiceController/GetSPByLoai?maloai=6");
            var subjectlistConverted2 = JsonConvert.DeserializeObject<List<Product>>(subjectlist2);
            Homeproduct2.ItemsSource = subjectlistConverted2;
            var subjectlist3 = await httpClient.GetStringAsync("http://192.168.1.6/webapifinalhasaki/api/ServiceController/GetSPByLoai?maloai=7");
            var subjectlistConverted3 = JsonConvert.DeserializeObject<List<Product>>(subjectlist3);
            Homeproduct3.ItemsSource = subjectlistConverted3;
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

        private void Homeproduct1_selection_changed(object sender, SelectionChangedEventArgs e)
        {
            Product product = (Product)e.CurrentSelection.FirstOrDefault();
            if(product!=null)
            {
                Navigation.PushAsync(new ChiTiet(product));
            }    
            
            Homeproduct1.SelectedItem = null;
        }

        private void Homeproduct2_selection_changed(object sender, SelectionChangedEventArgs e)
        {
            Product product = (Product)e.CurrentSelection.FirstOrDefault();
            if (product != null)
            {
                Navigation.PushAsync(new ChiTiet(product));
            }

            Homeproduct2.SelectedItem = null;
        }

        private void Homeproduct3_selection_changed(object sender, SelectionChangedEventArgs e)
        {
            Product product = (Product)e.CurrentSelection.FirstOrDefault();
            if (product != null)
            {
                Navigation.PushAsync(new ChiTiet(product));
            }

            Homeproduct3.SelectedItem = null;
        }
    }
}