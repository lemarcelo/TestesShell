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
        public UsuarioModel UsuarioParam = new UsuarioModel();
        public LoginPage2()
        {
            InitializeComponent();
        }

        private void Button_Clicked1(object sender, EventArgs e)
        {
            UsuarioParam.Nome = Nome.Text;
            UsuarioParam.Data = Data.Date;
            var param = JsonConvert.SerializeObject(UsuarioParam);
            Shell.Current.GoToAsync($"DestinoPage2?UsuarioParam={param}");
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