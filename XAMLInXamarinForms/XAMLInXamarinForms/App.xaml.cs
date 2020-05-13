using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XAMLInXamarinForms.Views;

namespace XAMLInXamarinForms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new NavigationPageView());
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
