﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Celulas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new Menu.Master());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
