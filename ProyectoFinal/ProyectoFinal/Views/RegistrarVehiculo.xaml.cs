using ProyectoFinal.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal
{
    [DesignTimeVisible(false)]
    public partial class RegistrarVehiculo : ContentPage
    {
        public RegistrarVehiculo()
        {
            InitializeComponent();
            this.BindingContext = new RegistrarVehiculoViewModel();
        }

        private void btnCancelar_Clicked(object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Menu());
        }
    }
}