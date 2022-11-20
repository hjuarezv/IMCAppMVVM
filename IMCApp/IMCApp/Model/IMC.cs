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
