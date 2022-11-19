using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IMCApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalcularIMCPage : ContentPage
    {
        public IMC imc;
        public CalcularIMCPage()
        {
            InitializeComponent();

            imc = new IMC {
                peso = 0.0,
                talla = 0.0,
                resultado = 0.0
            };

            this.BindingContext = imc;

        }        
    }
}