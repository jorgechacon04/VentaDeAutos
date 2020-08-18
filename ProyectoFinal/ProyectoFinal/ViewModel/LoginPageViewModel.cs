
using ProyectoFinal.Dto;
using ProyectoFinal.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ProyectoFinal.ViewModel
{
    public class LoginPageViewModel
    {

        private RestService restService;

        public AuthUser authUser { get; set; }
        public Command OperationCommand { get; set; }

        public LoginPageViewModel() {
            restService = new RestService();
            authUser = new AuthUser();
            OperationCommand = new Command(authenticate);
        }

        public async void authenticate() {
           var auth = restService.AuntenticateUser(authUser);

            if (auth.Result.Result)
            {
                TokenTransporter.Instance.Token = auth.Result.Token;

                Application.Current.MainPage = new NavigationPage(new Menu());
            }
            else {
                await Application.Current.MainPage.DisplayAlert("Error", "Email o Contraseña Incorrectos", "OK");
            }
        }
    }
}
