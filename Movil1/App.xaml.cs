using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Movil1.Services;
using Movil1.Views;

namespace Movil1
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
