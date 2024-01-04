using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using _10a02mobile.Services;
using _10a02mobile.Views;

namespace _10a02mobile
{
    public partial class App : Application
    {

        public App ()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}
