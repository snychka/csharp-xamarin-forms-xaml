using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System.IO;
using System.Linq;
using System.Xml;
using XAMLInXamarinForms.Tests.Helpers;
using Xunit;

namespace XAMLInXamarinForms.Tests
{
    public class NavigationPageViewTests
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

        [Fact(DisplayName = "Add Click Events To View @add-click-events-to-view")]
        public void AddClickEventsToView()
        {
            var filePath = ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + "XAMLInXamarinForms" + Path.DirectorySeparatorChar + "Views" + Path.DirectorySeparatorChar + "NavigationPageView.xaml";
            Assert.True(File.Exists(filePath), "`NavigationPageView` was not found in the `Views" + Path.DirectorySeparatorChar + "Fitness` directory.");

            var xml = File.ReadAllText(filePath);
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);

            var contentPage = xmlDocument.DocumentElement;
            Assert.True(contentPage != null, "`NavigationPageView` does not appear to contain any xaml code.");

            bool fitnessClickEvent = false;
            bool fitnessFound = false;
            bool nutritionClickEvent = false;
            bool nutritionFound = false;

            XmlNodeList children = contentPage.ChildNodes; // supressing unassigned variable error
            if (contentPage.ChildNodes.Count == 1)
                children = contentPage.ChildNodes[0]?.ChildNodes[0]?.ChildNodes;
            else if (contentPage.ChildNodes.Count == 2)
                children = contentPage.ChildNodes[1]?.ChildNodes[0]?.ChildNodes;
            else
                Assert.True(false, "`NavigationPageView`'s `ContentPage` tag should contain only `ContentPage.Content` and `ContentPage.Resources` tags.");

            foreach (XmlElement child in children)
            {
                if (child.GetAttribute("x:Name") == "FitnessButton")
                {
                    fitnessFound = true;
                    if (child.GetAttribute("Clicked") == "FitnessButton_Clicked")
                        fitnessClickEvent = true;
                }

                if (child.GetAttribute("x:Name") == "NutritionButton")
                {
                    nutritionFound = true;
                    if (child.GetAttribute("Clicked") == "NutritionButton_Clicked")
                        nutritionClickEvent = true;
                }
            }

            Assert.True(fitnessFound, @"`NavigationPageView`'s `FitnessButton` could not be found it should be nested in the `ContentPage` tag's `ContentPage.Content` (this test will fail if you move where the button is located)");
            Assert.True(fitnessClickEvent, @"`NavigationPageView`'s `FitnessButton` does not appear to have an attribute `Clicked` with a value of ""FitnessButton_Clicked"".");
            Assert.True(nutritionFound, @"`NavigationPageView`'s `NutritionButton` could not be found it should be nested in the `ContentPage` tag's `ContentPage.Content` (this test will fail if you move where the button is located)");
            Assert.True(nutritionClickEvent, @"`NavigationPageView`'s `NutritionButton` does not appear to have an attribute `Clicked` with a value of ""NutritionButton_Clicked"".");
        }
    }
}
