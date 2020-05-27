using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System.IO;
using System.Linq;
using XAMLInXamarinForms.Tests.Helpers;
using Xunit;

namespace XAMLInXamarinForms.Tests
{
    public class NavigationPageViewModalTests
    {
        static string userCodeFile = "Views" + Path.DirectorySeparatorChar + "NavigationPageView.xaml.cs";
        static SyntaxNode ast = TestHelpers.GetUserAst(userCodeFile);

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
