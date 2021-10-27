using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LopezExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string usuario, string clave)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario conectado: "+usuario;
            
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtMontoInicial.Text))
                {
                    double monto = double.Parse(txtMontoInicial.Text);
                    if (monto > 1800)
                    {
                        DisplayAlert("Mensaje de advertencia", "El monto inicial no puede ser mayor a 1800$", "ok");
                 
                    }
                    else if (monto <= 0)
                    {
                        DisplayAlert("Mensaje de advertencia", "El monto inicial tiene que ser mayor a 0$", "ok");
                        
                    }
                    else
                    {
                        double pagoMensual = (((1800 - monto) / 3) * 1.05);
                        txtPagoMensual.Text = pagoMensual.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de advertencia", ex.Message, "ok");
            }


        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            try
            {
                string usuario = lblUsuario.Text;
                string nombreEstudiante = txtNombreEstudiante.Text;
                string montoInicial = txtMontoInicial.Text;
                string pagoMensual = txtPagoMensual.Text;

                await Navigation.PushAsync(new Resumen(usuario, nombreEstudiante, montoInicial, pagoMensual));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Mensaje de advertencia", ex.Message, "ok");
            }
        }
    }
}