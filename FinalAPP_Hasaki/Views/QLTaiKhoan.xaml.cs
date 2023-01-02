using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FinalAPP_Hasaki.Models;
namespace FinalAPP_Hasaki.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QLTaiKhoan : ContentPage
    {
        public QLTaiKhoan()
        {
            InitializeComponent();
            
        }
       
        private void Testdangky_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DangKy());
        }

        private void Testdangnhap_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DangNhap());
        }

        private void click_to_donhang(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DonHang());
        }
    }
}