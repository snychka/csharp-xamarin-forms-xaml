using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XAMLInXamarinForms.Views.Nutrition
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NutritionView : TabbedPage
    {
        public NutritionView()
        {
            InitializeComponent();
        }
    }
}