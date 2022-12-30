using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FinalAPP_Hasaki.Models;
namespace FinalAPP_Hasaki
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            NguoiDung.nguoidung = new NguoiDung();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
