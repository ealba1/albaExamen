using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace albaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina2 : ContentPage
    {
        public Pagina2(string usuario, string clave)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            lblContraseña.Text = clave;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double monto = Convert.ToDouble(txtMontoI.Text);
            double costoC = 1800;
            double cuotaCos = 0.05;

            if (costoC > monto)
            {
                double resta = costoC - monto;
                double cuotas = resta / 3;
                double total1 = (cuotas + (cuotas * 0.05));
                txtPagoM.Text = total1.ToString();
            }
            else
            {
                DisplayAlert("error", "Su cuota ingresada supera al monto", "ok");
            }
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string usuario = lblUsuario.Text;
            string nombre = txtNombre.Text;
            double total = Convert.ToDouble(txtPagoM.Text);

            if ((txtNombre.Text != "") || (Convert.ToDouble(txtMontoI.Text) != 0))
            {
                DisplayAlert("Alerta", "Su registro a sido Guardado con Exito", "ok");
                await Navigation.PushAsync(new Pagina3(usuario, nombre, total));
            }
            else
            {
                DisplayAlert("Error", "No se aceptan Campos Vacios", "ok");
            }
        }
    }
}