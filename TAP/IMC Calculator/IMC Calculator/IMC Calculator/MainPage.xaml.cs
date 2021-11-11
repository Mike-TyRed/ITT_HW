using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IMC_Calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Calcular_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Altura.Text) && !string.IsNullOrEmpty(Peso.Text))
            {
                var altura = double.Parse(Altura.Text);
                var peso = double.Parse(Peso.Text);

                var imc = peso / (altura * altura);
                IMC.Text = imc.ToString();
                string traduce = "";

                if (imc < 18.5)
                {
                    traduce = "Bajo peso";
                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    traduce = "Peso es normal";
                }
                else if (imc >= 25 && imc <= 29.9)
                {
                    traduce = "Sobrepeso";
                }
                else if (imc >= 30 && imc <= 34.9)
                {
                    traduce = "Obesidad tipo 1";
                }
                else if (imc >= 35 && imc <= 39.9)
                {
                    traduce = "Obesidad tipo 2";
                }
                else if (imc >= 39.9)
                {
                    traduce = "Obesidad tipo 3";
                }
                DisplayAlert("Resultado", traduce, "Ok");
            }
            else
            {
                DisplayAlert("Datos incompletos", "Favor de revisar la " + "información introducida", "Ok");
            }
        }
        private void Limpiar_Clicked(object sender, EventArgs e)
        {
            Altura.Text = "";
            Peso.Text = "";
            IMC.Text = "";
        }
    }
}