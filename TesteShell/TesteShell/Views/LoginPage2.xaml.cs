using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TesteShell.Models;

namespace TesteShell.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage2 : ContentPage
    {
        public UsuarioModel UsuarioP = new UsuarioModel();
        public LoginPage2()
        {
            InitializeComponent();
        }

        private void Button_Clicked1(object sender, EventArgs e)
        {
            UsuarioP.Nome = Nome.Text;
            UsuarioP.Data = Data.Date;
            var UsuarioParam = JsonConvert.SerializeObject(UsuarioP);
            Shell.Current.GoToAsync($"DestinoPage2?UsuarioParam={UsuarioParam}");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Shell.Current.FlyoutIsPresented = false;
        }
    }
}