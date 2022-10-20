using System;
using UnitConverterXamarin.Services;
using UnitConverterXamarin.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverterXamarin
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
