using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TesteShell.Views;
using System.Windows.Input;
using System.Threading.Tasks;

namespace TesteShell
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : Shell
    {
        /*Cria o comando utilizado no item do menu lateral e define um método para realizar a navegação para a pagina correspondente*/
        public ICommand MenuItemCommand => new Command(NavegarMenuItem);
        public ICommand MenuItem2Command => new Command(NavegarMenuItem2);

        private async void NavegarMenuItem()
        {
            ShellNavigationState AtualContainer = Shell.Current.CurrentState;
            await Shell.Current.GoToAsync($"{AtualContainer.Location}/MenuItemPage");
        }
        private async void NavegarMenuItem2()
        {
            ShellNavigationState AtualContainer = Shell.Current.CurrentState;
            await Shell.Current.GoToAsync($"{AtualContainer.Location}/MenuItem2Page");
        }

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            Routing.RegisterRoute("LoginPage", typeof(LoginPage));
            Routing.RegisterRoute("DestinoPage", typeof(DestinoPage));
            Routing.RegisterRoute("MenuItemPage", typeof(MenuItemPage));
            Routing.RegisterRoute("MenuItem2Page", typeof(MenuItem2Page));
        }
    }
}
