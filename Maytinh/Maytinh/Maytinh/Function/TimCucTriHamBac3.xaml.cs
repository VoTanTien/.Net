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
    public partial class TimCucTriHamBac3 : ContentPage
    {
        public TimCucTriHamBac3()
        {
            InitializeComponent();
        }


        private void BtnTinh_Clicked(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = double.Parse(txtC.Text);
                double d = double.Parse(txtD.Text);
                double delta = Math.Pow(b, 2) - 3 * a * c;
                if (delta <= 0)
                {
                    lbKetQua1.Text = "khong co cuc tri";
                }
                else
                {
                    //3ax^2 + bx + c = 0
                    handle(3 * a, 2 * b, c);
                }
            }
            catch
            {
                lbKetQua1.Text = "Lỗi biểu thức";
            }
        }
        public void handle(double a, double b, double c)
        {
            double delta = (b * b) - (4 * a * c);
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            if(x1 < x2)
            {
                lbKetQua1.Text = "Ham so dat cuc dai tai x = " + x2.ToString() + " va cuc tieu tai " + x1.ToString();
            }
            else
            {
                lbKetQua1.Text = "Ham so dat cuc dai tai x = " + x1.ToString() + " va cuc tieu tai " + x2.ToString();

            }
        }
        private void BtnLamMoi_Clicked(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = "";
            lbKetQua1.Text = "";
        }
        private void BtnThoat_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new ChucNang();
        }
    }
}