﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalAPP_Hasaki.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalAPP_Hasaki.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThongBao : ContentPage
    {
        public ThongBao()
        {
            InitializeComponent();
            if (NguoiDung.nguoidung.MAKH > 0)
            {
                Title = "hehe";
            }
        }

        private async void tesst_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("tb", NguoiDung.nguoidung.MAKH.ToString(), "ok");
        }
    }
}