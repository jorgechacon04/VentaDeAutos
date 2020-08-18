using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void btnEditarPerfil_Clicked(object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new EditarUsuario());
        }

        private void btnComprar_Clicked(object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new BuscarVehiculo2());
        }

        private void btnVender_Clicked(object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new RegistrarVehiculo());
        }

        private void btnCerrarSession_Clicked(object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Login());
        }
    }
}