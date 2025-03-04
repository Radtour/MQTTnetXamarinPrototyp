﻿using MQTTnetXamarinPrototyp.Services;
using MQTTnetXamarinPrototyp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MQTTnetXamarinPrototyp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            DependencyService.Register<MQTTClient>();
            MainPage = new AppShell();
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
