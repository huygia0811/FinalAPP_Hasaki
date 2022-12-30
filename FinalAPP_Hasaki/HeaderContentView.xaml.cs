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
            content();
        }
        void content()
        {
            Grid layout = new Grid();
            layout.ColumnDefinitions.Add(new ColumnDefinition());
            layout.ColumnDefinitions.Add(new ColumnDefinition());
    
            if (NguoiDung.nguoidung.MAKH > 0)
            {
                Label lbusername = new Label();
                lbusername.Text = NguoiDung.nguoidung.MAKH.ToString();
                layout.Children.Add(lbusername, 0, 0);
            }    
            else
            {
                Label lbdangnhap = new Label();
                lbdangnhap.Text = "Đăng nhập";
                layout.Children.Add(lbdangnhap, 0, 0);

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
    }
}