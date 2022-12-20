using System;
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
    public partial class TrangChu : ContentPage
    {
        public TrangChu()
        {
            InitializeComponent();
            hienthiproduct();
        }

        private void TIKTDH_Clicked(object sender, EventArgs e)
        {

        }

        private void TIgiohang_Clicked(object sender, EventArgs e)
        {

        }
        List<Product> DSProducts;
        void hienthiproduct()
        {
            DSProducts = Product.KhoitaoProducts();
            Homeproduct1.ItemsSource = DSProducts;
            Homeproduct2.ItemsSource = DSProducts;
           

        }
    }
}