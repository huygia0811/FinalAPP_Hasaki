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
            Device.StartTimer(new TimeSpan(0, 0, 1), () =>
            {
                // do something every 60 seconds
                Device.BeginInvokeOnMainThread(() =>
                {
                    HiddenLabel();

                    
                });
                return true; // runs again, or false to stop
            });
           
        }
        
        public void HiddenLabel()
        {
            if(currentNguoiDung.MAKH > 0)
            {
                lbdangnhap.IsVisible = false;
                lbdangky.IsVisible = false;
                string sdt = currentNguoiDung.SDT;
                string[] getdt = new string []{ sdt };
                getsdt.ItemsSource = getdt;
            }

        }
      
        private void Link_dang_nhap(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DangNhap());
        }

        private void Link_dang_ky(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DangKy());
        }

        private void Link_tai_khoan(object sender, EventArgs e)
        {

        }
    }
}