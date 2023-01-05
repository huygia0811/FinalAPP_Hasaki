using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net;
using System.Net.Mail;

namespace FinalAPP_Hasaki.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuenMatKhau : ContentPage
    {
        string randomcode;
        public static string to;
        public QuenMatKhau()
        {
            InitializeComponent();
        }

        private void click_quenmatkhau(object sender, EventArgs e)
        {

        }
    }
}