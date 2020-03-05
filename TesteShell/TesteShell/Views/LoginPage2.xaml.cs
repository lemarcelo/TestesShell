using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Shell.Current.GoToAsync($"DestinoPage2?UsuarioParam={UsuarioParam}");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}