using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteShell.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public string text { get; set; }
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Shell.Current.Navigation.PopModalAsync();
        }

        private void Button_Clicked1(object sender, EventArgs e)
        {
            text = entryUsuario.Text;
            Shell.Current.GoToAsync($"DestinoPage?entryOrigem={text}");
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Shell.Current.FlyoutIsPresented = false;

        }
    }
}