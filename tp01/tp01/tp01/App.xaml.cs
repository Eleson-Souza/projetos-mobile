﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using tp01.Pages;

namespace tp01
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Login();
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
