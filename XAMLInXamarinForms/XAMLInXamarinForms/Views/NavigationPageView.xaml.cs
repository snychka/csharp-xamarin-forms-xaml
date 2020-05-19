using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XAMLInXamarinForms.ViewModels;

namespace XAMLInXamarinForms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationPageView : ContentPage
    {
        public PlannerViewModel model = new PlannerViewModel();

        public NavigationPageView()
        {
            InitializeComponent();
        }
    }
}