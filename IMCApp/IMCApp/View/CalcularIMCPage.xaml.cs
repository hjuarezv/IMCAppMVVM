using IMCApp.ViewModel;
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
        
        public CalcularIMCPage()
        {
            InitializeComponent();

            this.BindingContext = new CalcularIMCPageViewModel();

        }        
    }
}