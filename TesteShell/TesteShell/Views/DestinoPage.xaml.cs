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
    [QueryProperty("_TextEntryDestino", "entryOrigem")]
    public partial class DestinoPage : ContentPage
    {
        public string _TextEntryDestino
        {
            set
            {
                EntryDestino.Text = Uri.UnescapeDataString(value);
            }
        }
            public DestinoPage()
        {
            InitializeComponent();
        }
    }
}