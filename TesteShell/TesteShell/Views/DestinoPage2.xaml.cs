using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteShell.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteShell.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty("UsuarioRecebido", "UsuarioParam")]
    public partial class DestinoPage2 : ContentPage
    {
        UsuarioModel Usuariorecebido = new UsuarioModel();
        public DestinoPage2()
        {
            InitializeComponent();
            Nome.Text = Usuariorecebido.Nome;
            Data.Date = Usuariorecebido.Data;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}