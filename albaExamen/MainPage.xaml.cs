using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace albaExamen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;

            //Abrir pantalla dos

            if ((usuario == "estudiante2021") && (clave == "uisrael2021"))
            {
                await Navigation.PushAsync(new Pagina2(usuario, clave));

            }
            else
            {
                lblMensaje.Text = "El usuario o password son incorrectos";
            }


        }
    }

      
    
}
