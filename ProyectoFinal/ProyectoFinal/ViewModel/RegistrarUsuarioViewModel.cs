using ProyectoFinal.Dto;
using ProyectoFinal.Model;
using Xamarin.Forms;

namespace ProyectoFinal.ViewModel
{
    public class RegistrarUsuarioViewModel
    {
        private RestService restService;

        public User user { get; set; }
        public Command OperationCommand { get; set; }

        public RegistrarUsuarioViewModel()
        {
            restService = new RestService();
            user = new User();
            OperationCommand = new Command(register);
        }

        public async void register()
        {
            user.address = user.state + " ," + user.city;
            var response = restService.CreateUser(user).Result.data;
            if (null != response.name)
            {
                await Application.Current.MainPage.DisplayAlert("Confirmation", "Usuario Creado Satisfactoriamente", "Ir al Login");
                Application.Current.MainPage = new NavigationPage(new Login());
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "No se pudo crear el usuario por favor intente de nuevo", "Ok");
            }
        }
    }
}