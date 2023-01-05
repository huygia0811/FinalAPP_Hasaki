﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FinalAPP_Hasaki.Models;
using System.Net.Http;
using Newtonsoft.Json;
namespace FinalAPP_Hasaki.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QLTaiKhoan : ContentPage
    {
        public QLTaiKhoan()
        {
     
              InitializeComponent();
              qlnguoidung(currentNguoiDung.MAKH);

        }
        async void qlnguoidung(int makh)
        {

            HttpClient httpClient = new HttpClient();
            //192.168.1.13
            var khachhang = await httpClient.GetStringAsync(IPaddress.url + "GetInfoKhachHang?makh="+currentNguoiDung.MAKH.ToString());
            var khachhang_Converted = JsonConvert.DeserializeObject<List<ThongTinKhachHang>>(khachhang);
            QLtaikhoan_listview.ItemsSource = khachhang_Converted;
        }
        private void click_to_donhang(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DonHang());
        }

        private void tapped_dangcho(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DonHang(1));
        }

        private void tapped_thanhcong(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DonHang(2));
        }

        private void tapped_dahuy(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DonHang(3));
        }

        private void tapped_dangxuly(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DonHang(4));
        }

        private void tapped_tatca(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DonHang(1));
        }

        private void tapped_thongtintaikhoan(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageThongTinKhachHang());
           
        }

        private void tapped_capnhapdiachi(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page_Set_DiaChi());
        }
    }
}