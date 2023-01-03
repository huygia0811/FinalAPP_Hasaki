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
    public partial class GioHang : ContentPage
    {
        public GioHang()
        {
            InitializeComponent();
            HienThiGioHang();
        }
        async public void HienThiGioHang()
        {
            HttpClient httpClient = new HttpClient();
            var subjectlist = await httpClient.GetStringAsync(IPaddress.url + "SelectGioHang?MAKH=1");
            var subjectlistConverted = JsonConvert.DeserializeObject<List<classGioHang>>(subjectlist);
            CV_GioHang.ItemsSource= subjectlistConverted;
        }
    }
}