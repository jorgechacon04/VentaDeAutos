using ProyectoFinal.Model;
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
          // var image = new Image { Source = "Carro.jpg" };
           // var image2 = new Image { Source = ".../audi.jpg" };
            List<Vehiculo> vehiculos = new List<Vehiculo>{
                new Vehiculo{Nombre="Bmw", Precio="200", ImageURL="http://lorempixel.com/400/200/"},
                new Vehiculo{Nombre="Audio", Precio="200", ImageURL="http://lorempixel.com/400/200/sports/"},
                new Vehiculo{Nombre="Honda", Precio="200", ImageURL="http://lorempixel.com/400/200/sports/"},
                new Vehiculo{Nombre="Hyundai", Precio="200", ImageURL="http://lorempixel.com/400/200/sports/"},
                new Vehiculo{Nombre="Mazda", Precio="200", ImageURL="http://lorempixel.com/400/200/sports/"},
                new Vehiculo{Nombre="Toyota", Precio="200", ImageURL="http://lorempixel.com/400/200/sports/"},
            };
            lsView.ItemsSource = vehiculos;
        }

        private void srcBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}