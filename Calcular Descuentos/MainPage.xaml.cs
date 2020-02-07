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
            porlotanto.IsVisible = false;
        }


               

        public async void Aplicar_Clicked(object sender, EventArgs e)
        {

           

            if (valorinicial.Text == "")
            {
                await DisplayAlert("Faltan Valores", "Ingresa un monto inicial", "OK");
            }
            else if ( descuento.Text == ""  )
            {
                await DisplayAlert("Faltan valores", "Ingresa un valor en Descuento", "OK");
            }
            else
            {
                int descuento2 = Int32.Parse(descuento.Text);
                if (descuento2 > 100 || descuento2 < 0)
                {
                    await DisplayAlert("Porcentaje invalido", "Ingresa una cantidad entre 0 a 100", "OK");
                }
                else
                {
                    if( valorinicial.Text.Length >= 6)
                    {
                        Valorfinal.FontSize = 36;
                        Valordescontado.Text = (float.Parse(descuento.Text) * float.Parse(valorinicial.Text) / 100).ToString("0.00");
                        Valorfinal.Text = "Total " + (float.Parse(valorinicial.Text) - float.Parse(Valordescontado.Text)).ToString("0.00");

                        eltotal.Text = "El " + descuento.Text + "% de " + valorinicial.Text + " es: ";
                    }                    
                        
                    Valordescontado.Text = (float.Parse(descuento.Text) * float.Parse(valorinicial.Text) / 100).ToString("0.00");
                    Valorfinal.Text = "Total " + (float.Parse(valorinicial.Text) - float.Parse(Valordescontado.Text)).ToString("0.00");

                    eltotal.Text = "El " + descuento.Text + "% de " + valorinicial.Text + " es: ";
                    porlotanto.IsVisible = true;
                }

                
            }            
        }

        private void Borrar_Clicked(object sender, EventArgs e)
        {
            valorinicial.Text = "";
            Valorfinal.Text = "";
            Valordescontado.Text = "";
            descuento.Text = "";
            eltotal.Text = "";
            porlotanto.Text = "";
        }
    }
}
