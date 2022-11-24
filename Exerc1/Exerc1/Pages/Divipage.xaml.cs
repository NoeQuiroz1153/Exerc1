using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exerc1.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Divipage : ContentPage
    {
        public Divipage(double y, double z)
        {
            InitializeComponent();
            Num1.Text = Convert.ToString(y);
            Num2.Text = Convert.ToString(z);
            double x = Convert.ToDouble(Num1.Text) / Convert.ToDouble(Num2.Text);

            resul.Text = "Resultado = " + Convert.ToString(x);
        }
    }
}