using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System.IO;
using System.Linq;
using XAMLInXamarinForms.Tests.Helpers;
using Xunit;

namespace XAMLInXamarinForms.Tests
{
    public class NavigationPageViewCodeBehindTests
    {
        static string userCodeFile = "Views" + Path.DirectorySeparatorChar + "NavigationPageView.xaml.cs";
        static SyntaxNode ast = TestHelpers.GetUserAst(userCodeFile);

        [Fact(DisplayName = "Add Using Directives @add-using-directives")]
        public void AddUsingDirectives()
        {
            var usingDirectives = TestHelpers.GetUsingDirectives(ast);
            var fitnessUsingDirective = usingDirectives.FirstOrDefault(e => e.ToString().Contains("XAMLInXamarinForms.Views.Fitness"));
            var nutritionUsingDirective = usingDirectives.FirstOrDefault(e => e.ToString().Contains("XAMLInXamarinForms.Views.Nutrition"));
            Assert.True(fitnessUsingDirective != null, "`NavigationPageView.xaml.cs` does not appear to contain a using directive for `XAMLInXamarinForms.Views.Fitness`.");
            Assert.True(nutritionUsingDirective != null, "`NavigationPageView.xaml.cs` does not appear to contain a using directive for `XAMLInXamarinForms.Views.Nutrition`.");
        }

        [Fact(DisplayName = "Add Fitness Button Click Event @add-fitness-button-click-event")]
        public void AddFitnessButtonClickEvent()
        {
            var methods = TestHelpers.GetMethods(ast);
            var method = methods?.FirstOrDefault(x => x.ToString().Contains("FitnessButton_Clicked"));
            Assert.True(method != null, "`NavigationPageView.xaml.cs` does not appear to contain a `private` `async` method `FitnessButton_Clicked` with a `void` return type and accepts parameters of type `object` named `sender` and of type `EventArgs` named `e`.");
            Assert.True(method.Modifiers.Any(SyntaxKind.PrivateKeyword), "`NavigationPageView.xaml.cs`'s `FitnessButton_Click` method does not appear have the `private` modifier.");
            Assert.True(method.Modifiers.Any(SyntaxKind.AsyncKeyword), "`NavigationPageView.xaml.cs`'s `FitnessButton_Click` method does not appear have the `async` modifier.");
            Assert.True(method.ReturnType.ToString().Contains("void"), "`NavigationPageView.xaml.cs`'s `FitnessButton_Click` method does not appear have a return type of `void`.");
            Assert.True(method.ParameterList.Parameters.Count() == 2 && method.ParameterList.Parameters.Any(e => e.Type.ToString() == "object") && method.ParameterList.Parameters.Any(e => e.Type.ToString() == "EventArgs"), "`NavigationPageView.xaml.cs`'s `FitnessButton_Clicked` method does not appear to have parameters of type `object` named `sender` and of type `EventArgs` named `e`.");

            var firstExpression = TestHelpers.GetExpressions(method).FirstOrDefault();
            Assert.True(firstExpression.ToString().Contains("Navigation.PushAsync"), "`NavigationPageView.xaml.cs`'s `FitnessButton_Click` method does not contain a call to `Navigation.PushAsync` with an argument of a newly instantiated `FitnessView`.");
            Assert.True(firstExpression.ToString().Contains("await"), "`NavigationPageView.xaml.cs`'s `FitnessButton_Click` method's call to `Navigation.PushAsync` needs to be preceded with an `await`.");
            Assert.True(firstExpression.ToString().Contains("FitnessView"), "`NavigationPageView.xaml.cs`'s `FitnessButton_Click` method's call to `Navigation.PushAsync` should accept a newly instantiated `new FitnessView`.");
        }

        [Fact(DisplayName = "Add Nutrition Button Click Event @add-nutrition-button-click-event")]
        public void AddNutritionButtonClickEvent()
        {
            var methods = TestHelpers.GetMethods(ast);
            var method = methods?.FirstOrDefault(x => x.ToString().Contains("NutritionButton_Clicked"));
            Assert.True(method != null, "`NavigationPageView.xaml.cs` does not appear to contain a `private` `async` method `NutritionButton_Clicked` with a `void` return type and accepts parameters of type `object` named `sender` and of type `EventArgs` named `e`.");
            Assert.True(method.Modifiers.Any(SyntaxKind.PrivateKeyword), "`NavigationPageView.xaml.cs`'s `NutritionButton_Click` method does not appear have the `private` modifier.");
            Assert.True(method.Modifiers.Any(SyntaxKind.AsyncKeyword), "`NavigationPageView.xaml.cs`'s `NutritionButton_Click` method does not appear have the `async` modifier.");
            Assert.True(method.ReturnType.ToString().Contains("void"), "`NavigationPageView.xaml.cs`'s `NutritionButton_Click` method does not appear have a return type of `void`.");
            Assert.True(method.ParameterList.Parameters.Count() == 2 && method.ParameterList.Parameters.Any(e => e.Type.ToString() == "object") && method.ParameterList.Parameters.Any(e => e.Type.ToString() == "EventArgs"), "`NavigationPageView.xaml.cs`'s `NutritionButton_Clicked` method does not appear to have parameters of type `object` named `sender` and of type `EventArgs` named `e`.");

            var firstExpression = TestHelpers.GetExpressions(method).FirstOrDefault();
            Assert.True(firstExpression.ToString().Contains("Navigation.PushAsync"), "`NavigationPageView.xaml.cs`'s `NutritionButton_Click` method does not contain a call to `Navigation.PushAsync` with an argument of a newly instantiated `NutritionView`.");
            Assert.True(firstExpression.ToString().Contains("await"), "`NavigationPageView.xaml.cs`'s `NutritionButton_Click` method's call to `Navigation.PushAsync` needs to be preceded with an `await`.");
            Assert.True(firstExpression.ToString().Contains("NutritionView"), "`NavigationPageView.xaml.cs`'s `NutritionButton_Click` method's call to `Navigation.PushAsync` should accept a newly instantiated `new NutritionView`.");
        }

        [Fact(DisplayName = "Add Privacy Modal @add-privacy-modal")]
        public void AddPrivacyModal()
        {
            var methods = TestHelpers.GetMethods(ast);
            var method = methods?.FirstOrDefault(x => x.ToString().Contains("PopModal"));
            Assert.True(method != null, "`NavigationPageView.xaml.cs` does not appear to contain a `private` `async` method `PopModal` with a `void` return type and has no parameters.");
            Assert.True(method.Modifiers.Any(SyntaxKind.PrivateKeyword), "`NavigationPageView.xaml.cs`'s `PopModal` method does not appear have the `private` modifier.");
            Assert.True(method.Modifiers.Any(SyntaxKind.AsyncKeyword), "`NavigationPageView.xaml.cs`'s `PopModal` method does not appear have the `async` modifier.");
            Assert.True(method.ReturnType.ToString().Contains("void"), "`NavigationPageView.xaml.cs`'s `PopModal` method does not appear have a return type of `void`.");

            var firstExpression = TestHelpers.GetExpressions(method).FirstOrDefault();
            Assert.True(firstExpression.ToString().Contains("Navigation.PushModalAsync"), "`NavigationPageView.xaml.cs`'s `PopModal` method does not contain a call to `Navigation.PushModalAsync` with an argument of a newly instantiated `PrivacyModal`.");
            Assert.True(firstExpression.ToString().Contains("await"), "`NavigationPageView.xaml.cs`'s `PopModal` method's call to `Navigation.PushModalAsync` needs to be preceded with an `await`.");
            Assert.True(firstExpression.ToString().Contains("PrivacyModal"), "`NavigationPageView.xaml.cs`'s `PopModal` method's call to `Navigation.PushModalAsync` should accept a newly instantiated `new PrivacyModal`.");

            var constructor = TestHelpers.GetConstructors(ast).FirstOrDefault();
            Assert.True(constructor.ToString().Contains("PopModal"), "`NavigationPageView.xaml.cs`'s constructor does not contain a call to `PopModal` after it's call to `InitializeComponent`.");
        }
    }
}
