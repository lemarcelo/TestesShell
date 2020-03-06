using Newtonsoft.Json;
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
        UsuarioModel UsuarioLocal = new UsuarioModel();
        public string UsuarioRecebido
        {
            set
            {
                UsuarioLocal = JsonConvert.DeserializeObject<UsuarioModel>(Uri.UnescapeDataString(value));
                Nome.Text = UsuarioLocal.Nome;
                Data.Date = UsuarioLocal.Data.Date;
            }
        }

        UsuarioModel UsuarioP = new UsuarioModel();
        public DestinoPage2()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}