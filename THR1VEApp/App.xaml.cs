using System;
using THR1VEApp.Services;
using THR1VEApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace THR1VEApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
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
