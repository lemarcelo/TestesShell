﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TesteShell.Views;

namespace TesteShell
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : Shell
    {
        public MainPage()
        {
            InitializeComponent();

            //Routing.RegisterRoute("Page1", typeof(Page1));
            //Routing.RegisterRoute("Page2", typeof(Page2));
            //Routing.RegisterRoute("Page3", typeof(Page3));
            Routing.RegisterRoute("LoginPage", typeof(LoginPage));
        }
    }
}
