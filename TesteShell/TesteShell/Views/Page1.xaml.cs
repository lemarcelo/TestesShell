﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteShell.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Shell.Current.Navigation.PushModalAsync(new LoginPage());
            Shell.Current.GoToAsync("LoginPage");
        }
    }
}