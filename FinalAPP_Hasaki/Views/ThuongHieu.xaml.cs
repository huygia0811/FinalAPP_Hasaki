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
    public partial class ThuongHieu : ContentPage
    {
        public ThuongHieu()
        {
            InitializeComponent();
            hienthihang();
        }
        async void hienthihang()
        {
            HttpClient httpClient = new HttpClient();
            //192.168.1.13
            var subjectlist = await httpClient.GetStringAsync("http://192.168.1.6/webapifinalhasaki/api/ServiceController/GetHang");
            var subjectlistConverted = JsonConvert.DeserializeObject<List<Hang>>(subjectlist);
            Thuonghieu_noibat.ItemsSource = subjectlistConverted;
        }
    }
}