using ProyectoFinal.Model;
using ProyectoFinal.ViewModel;
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
    public partial class BuscarVehiculo2 : ContentPage
    {
        public BuscarVehiculo2()
        {
            InitializeComponent();
            this.BindingContext = new BuscarVehiculoViewModel();
        }
    }
}