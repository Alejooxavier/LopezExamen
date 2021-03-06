using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LopezExamen
{
    public partial class MainPage : ContentPage
    {
        string hardUsuario = "estudiante2021";
        string hardPassword = "uisrael2021";
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text;
                string clave = txtClave.Text;

                if(string.Compare(hardUsuario, usuario) == 0 && string.Compare(hardPassword, clave) == 0)
                {
                    await Navigation.PushAsync(new Registro(usuario, clave));
                }
                else
                {
                    //await DisplayAlert("Mensaje de advertencia", "Usuario o contraseña incorrectos", "ok");

                    //TOAST

                    var mensaje = "Usuario o contraseña incorrectos";
                    DependencyService.Get<Mensaje>().longAlert(mensaje);

                }
                
            }
            catch (Exception ex)
            {
                await DisplayAlert("Mensaje de advertencia", ex.Message, "ok");
            }
        }
    }
}
