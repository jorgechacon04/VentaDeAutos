using ProyectoFinal.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ProyectoFinal.ViewModel
{
    public class RegistrarVehiculoViewModel
    {
        private RestService restService;

        public Car car { get; set; }
        public Command OperationCommand { get; set; }

        public RegistrarVehiculoViewModel()
        {
            restService = new RestService();
            car = new Car();
            OperationCommand = new Command(register);
        }

        public async void register()
        {
            var userId = restService.GetUserInfo().Result._id.oid;

            car.user = userId;

            var response = restService.RegisterCar(car).Result.data;
            if (null != response.brand)
            {
                await Application.Current.MainPage.DisplayAlert("Confirmation", "Vehiculo Registrado Satisfactoriamente", "Ok");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "No se pudo registrar el vehiculo por favor intente de nuevo", "Ok");
            }
        }
    }
}
