using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calcular_Descuentos
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            valorinicial.Text = "";
            Valorfinal.Text = "";
            Valordescontado.Text = "";
            descuento.Text = "";
            eltotal.Text = "";
        }


               

        public async void Aplicar_Clicked(object sender, EventArgs e)
        {
           
            if (valorinicial.Text == "")
            {
                await DisplayAlert("Valor invalido", "Ingresa Valor inicial", "OK");
            }
            else if ( descuento.Text == "")
            {
                await DisplayAlert("Valor invalido", "Ingresa el monto a descontar", "OK");
            }
            else
            {
                Valordescontado.Text = (float.Parse(descuento.Text) * float.Parse(valorinicial.Text) / 100).ToString();
                Valorfinal.Text = "Total " + (float.Parse(valorinicial.Text)-float.Parse(Valordescontado.Text)).ToString();

                eltotal.Text = "El " + descuento.Text + "% de " + valorinicial.Text + " es: ";
            }            
        }

        private void Borrar_Clicked(object sender, EventArgs e)
        {
            valorinicial.Text = "";
            Valorfinal.Text = "";
            Valordescontado.Text = "";
            descuento.Text = "";
        }
    }
}
