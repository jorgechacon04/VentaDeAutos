using ProyectoFinal.ViewModel;
using System.ComponentModel;

using Xamarin.Forms;

namespace ProyectoFinal
{
    [DesignTimeVisible(false)]
    public partial class RegistrarUsuario : ContentPage
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
            this.BindingContext = new RegistrarUsuarioViewModel();
        }

        private void btnCancelar_Clicked(object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Login());
        }
    }
}