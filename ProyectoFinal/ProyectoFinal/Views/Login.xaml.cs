using ProyectoFinal.ViewModel;
using System.ComponentModel;

using Xamarin.Forms;

namespace ProyectoFinal
{
    [DesignTimeVisible(false)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();

            this.BindingContext = new LoginPageViewModel();
        }

        private void btnNuevaCuenta_Clicked(object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new RegistrarUsuario());
        }
    }
}