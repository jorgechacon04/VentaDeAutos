using System;
using System.Collections.Generic;
using System.Text;
using ProyectoFinal.Dto;
using ProyectoFinal.Model;
using Xamarin.Forms;

namespace ProyectoFinal.ViewModel
{
    public class EditarUsuarioViewModel
    {
        private RestService restService;

        public User user { get; set; }
        public Command OperationCommand { get; set; }

        public EditarUsuarioViewModel()
        {
            restService = new RestService();
            var userDetails = restService.GetUserInfo().Result;

            user = new User() { 
                name = userDetails.name,
                email = userDetails.email,
                firstLastName = userDetails.firstLastName,
                secondLastName = userDetails.secondLastName,
                identification = userDetails.identification,
                phone = userDetails.phone,
                state = userDetails.state,
                city = userDetails.city,
                neighborhood = userDetails.neighborhood
            };

            OperationCommand = new Command(register);
        }

        public async void register()
        {
            user.address = user.state + " ," + user.city;
            var response = restService.UpdateUser(user).Result.data;
            if (null != response.name)
            {
                await Application.Current.MainPage.DisplayAlert("Confirmation", "Usuario Actualizado Satisfactoriamente", "Ok");
                Application.Current.MainPage = new NavigationPage(new Menu());
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "No se pudo actualizar el usuario por favor intente de nuevo", "Ok");
            }
        }
    }
}
