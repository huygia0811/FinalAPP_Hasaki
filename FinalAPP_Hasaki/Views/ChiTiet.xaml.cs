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
    public partial class ChiTiet : ContentPage
    {
        public ChiTiet()
        {
            InitializeComponent();
        }
        public ChiTiet(Product product)
        {
            InitializeComponent();
            GetDetailsProduct(product.MASP);
        }
        async void GetDetailsProduct(int product_id)
        {
            HttpClient httpClient = new HttpClient();
            //192.168.1.13
            var product_details = await httpClient.GetStringAsync("http://192.168.1.6/webapifinalhasaki/api/ServiceController/GetDetailSP?masp=" + product_id.ToString());
            var product_details_Converted = JsonConvert.DeserializeObject<List<Product>>(product_details);
            Product_details.ItemsSource= product_details_Converted;
        }
    }
}