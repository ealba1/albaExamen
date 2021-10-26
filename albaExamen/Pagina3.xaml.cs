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
    public partial class Pagina3 : ContentPage
    {
        public Pagina3(string usuario, string nombre, double total)
        {
            InitializeComponent();
            //Exam
            txtUsuarioR.Text = usuario;
            txtNombreR.Text = nombre;
            txtPagoR.Text = Convert.ToString(total);
        }
    }
}