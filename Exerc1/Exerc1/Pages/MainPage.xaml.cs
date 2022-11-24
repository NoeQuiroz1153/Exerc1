using Exerc1.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exerc1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           
        }

        private async void Btnsumar_Clicked(object sender, EventArgs e)
        {
           int w = Convert.ToInt32(num1.Text);  
           int x = Convert.ToInt32(num2.Text);
            await Navigation.PushAsync(new Sumpage(w,x));
        }

        private async void Btnrestar_Clicked(object sender, EventArgs e)
        {
            int w = Convert.ToInt32(num1.Text);
            int x = Convert.ToInt32(num2.Text);
            await Navigation.PushAsync(new Restpage(w,x));
        }

        private async void Btnmulti_Clicked(object sender, EventArgs e)
        {
            int w = Convert.ToInt32(num1.Text);
            int x = Convert.ToInt32(num2.Text);
            await Navigation.PushAsync(new Multipage(w,x));
        }

        private async void Btndivir_Clicked(object sender, EventArgs e)
        {
            double w = Convert.ToDouble(num1.Text);
            double x = Convert.ToDouble(num2.Text);
            await Navigation.PushAsync(new Divipage(w,x));
        }
    }
}
