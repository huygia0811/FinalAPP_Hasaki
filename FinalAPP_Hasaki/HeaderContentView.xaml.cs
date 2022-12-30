using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalAPP_Hasaki.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FinalAPP_Hasaki.Models;
namespace FinalAPP_Hasaki
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HeaderContentView : ContentView
    {
        public HeaderContentView()
        {
            InitializeComponent();         
        }
        private void Link_dang_nhap(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DangNhap());
        }

        private void Link_dang_ky(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DangKy());
        }
    }
}