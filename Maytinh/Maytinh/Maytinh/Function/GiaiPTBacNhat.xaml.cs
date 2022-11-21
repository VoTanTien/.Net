using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Maytinh.Function
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GiaiPTBacNhat : ContentPage
    {
        public GiaiPTBacNhat()
        {
            InitializeComponent();
        }
        private void BtnLamMoi_Clicked(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            lbKetQua.Text = "";
        }

        private void BtnTinh_Clicked(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                if (a == 0)
                {
                    if (b == 0) lbKetQua.Text = "Vô số nghiệm";
                    else lbKetQua.Text = "Vô nghiệm";
                }
                else lbKetQua.Text = "x = " + (-b / a).ToString();
            }
            catch
            {
                lbKetQua.Text = "Lỗi biểu thức";
            }
        }

        private void BtnThoat_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new ChucNang();
        }
    }
}