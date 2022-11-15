using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Maytinh
{

    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();  
        }
      
       private void Btn_Menu_clicked(object sender, EventArgs e)
       {
            App.Current.MainPage = new ChucNang();
       }
       
       // private void btn_quiz_clicked(object sender, EventArgs e)
       // {
      //      App.Current.MainPage = new Quiz();
        //}

    }
}
