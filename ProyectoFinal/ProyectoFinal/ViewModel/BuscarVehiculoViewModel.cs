using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ProyectoFinal.Dto;
using ProyectoFinal.Model;
using Xamarin.Forms;

namespace ProyectoFinal.ViewModel
{
    public class BuscarVehiculoViewModel
    {
        private RestService restService;
        public Command OperationCommand { get; set; }
        public CarList cars { get; set; }

        public BuscarVehiculoViewModel()
        {
            restService = new RestService();
            cars = new CarList();
            this.fetchCars();
        }

        public ICommand PerformSearch => new Command<string>((string query) =>
        {
            filtercars(query);
        });

        public async void fetchCars()
        {
            var response = restService.GetAllCars().Result;
            if (null == response)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "No se obtuvo ningun resultado", "Ok");
            }
            else
            {
                cars.SeachResults = response;
            }
        }

        private void filtercars(string query)
        {
            query = query.ToUpper();
            if (query != null & query != "")
            {
                List<CarListDTO> filtered = cars.SeachResults.FindAll(e => (e.brand.ToUpper() == query) | (e.model.ToUpper() == query) | (e.year.ToString() == query));
                cars.SeachResults = filtered;
            }
        }
    }
}
