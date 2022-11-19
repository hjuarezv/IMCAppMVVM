using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace IMCApp
{
    public class IMC : INotifyPropertyChanged
    {
        private double resultado1;
        private double peso1;
        private double talla1;
        private string foto_resultado1;

        public Command ComCalcularIMC { get; set; }

        public double talla
        {
            get => talla1; set
            {
                talla1 = value;
                NotifyPropertyChanged();
            }
        }
        public double peso
        {
            get => peso1; set
            {
                peso1 = value;
                NotifyPropertyChanged();
            }
        }
        public double resultado
        {
            get => resultado1;
            set
            {
                resultado1 = value;
                NotifyPropertyChanged();
            }
        }

        public string foto_resultado
        {
            get => foto_resultado1;
            set
            {
                foto_resultado1 = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public IMC()
        {
            ComCalcularIMC = new Command(Calcular);
        }

        public void Calcular()
        {
            resultado = Math.Round(peso / (talla * talla), 2);

            foto_resultado = "";

            if (resultado < 18.5)
            {
                foto_resultado = "desnutricion.jpg";                
            }
            else if (resultado >= 18.5 && resultado < 25)
            {
                foto_resultado = "saludable.jpg";                
            }
        }

        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
