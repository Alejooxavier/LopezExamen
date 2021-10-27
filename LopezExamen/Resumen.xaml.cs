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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombreEstudiante, string montoInicial, string total)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            lblNombreEstudiante.Text = "Estudiante registrado: "+ nombreEstudiante;
            lblMontoInicial.Text = "Pago inicial realizado: "+ montoInicial;
            lblTotal.Text = "Total a pagar: "+ total;
        }
    }
}