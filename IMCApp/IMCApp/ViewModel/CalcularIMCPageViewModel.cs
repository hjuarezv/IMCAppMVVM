using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace IMCApp.ViewModel
{
    class CalcularIMCPageViewModel
    {
        public IMC imc { get; set; }
        public Command ComCalcularIMC { get; set; }
        public CalcularIMCPageViewModel()
        {
            ComCalcularIMC = new Command(Calcular);

            imc = new IMC
            {
                peso = 0.0,
                talla = 0.0,
                resultado = 0.0
            };
        }

        public void Calcular()
        {
            if (imc.peso > 0 && imc.talla > 0)
            {

                imc.resultado = Math.Round(imc.peso / (imc.talla * imc.talla), 2);

                imc.foto_resultado = "";

                if (imc.resultado < 18.5)
                {
                    imc.foto_resultado = "desnutricion.jpg";
                }
                else if (imc.resultado >= 18.5 && imc.resultado < 25)
                {
                    imc.foto_resultado = "saludable.jpg";
                }
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Error", "Debes ingresar un peso y una talla válida", "OK");
            }
        }
    }
}
