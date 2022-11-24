using Exerc1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Exerc1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sumpage : ContentPage
    {
        public Sumpage(int y,int z)
        {
            InitializeComponent();
            Num1.Text = Convert.ToString(y);
            Num2.Text = Convert.ToString(z);
            int x = Convert.ToInt32(Num1.Text) + Convert.ToInt32(Num2.Text);
            
            resul.Text = "Resultado = "+Convert.ToString(x);
        }

      

      
    }
}