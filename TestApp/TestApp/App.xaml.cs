using System;
using TestApp.Services;
using TestApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        // has the app started?
        protected override void OnStart()
        {
        }

        // is the app asleep?
        protected override void OnSleep()
        {
        }

        // is the app resumed?
        protected override void OnResume()
        {
        }
    }
}
