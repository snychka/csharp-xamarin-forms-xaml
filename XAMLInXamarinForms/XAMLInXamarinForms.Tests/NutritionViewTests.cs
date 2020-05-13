using System.IO;
using Xunit;
using System.Xml;

namespace XAMLInXamarinForms.Tests
{
    public class NutritionViewTests
    {
        

        [Fact(DisplayName = "Create Nutrition View @create-nutrition-view")]
        public void CreateNutritionView()
        {
            var filePath = ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + "XAMLInXamarinForms" + Path.DirectorySeparatorChar + "Views" + Path.DirectorySeparatorChar + "Nutrition" + Path.DirectorySeparatorChar + "NutritionView.xaml";
            Assert.True(File.Exists(filePath), "`NutritionView` was not found in the `Views" + Path.DirectorySeparatorChar + "Nutrition` directory.");

            var xml = File.ReadAllText(filePath);
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);

            // is the first line `<?xml version = "1.0" encoding="utf-8" ?>`
            var firstChild = xmlDocument.FirstChild;
            Assert.True(firstChild != null, "`NutritionView` does not appear to contain any xaml code.");
            Assert.True(firstChild.NodeType == XmlNodeType.XmlDeclaration, @"`NutritionView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Name == "xml", @"`NutritionView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Value.Contains("encoding") && xmlDocument.FirstChild.Value.Contains("utf-8"), @"`NutritionView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");

            // The second line is the openning `TabbedPage` tag including xmls, mc, and class declarations
            var tabbedPage = xmlDocument.DocumentElement;
            Assert.True(tabbedPage != null, "`NutritionView` does not appear to contain any xaml code.");
            Assert.True(tabbedPage.GetAttribute("xmlns") == @"http://xamarin.com/schemas/2014/forms", @"`NurtritionView`'s `TabbedPage` tag didn't contain the attribute `xmlns` with a value of `""http://xamarin.com/schemas/2014/forms""`");
            Assert.True(tabbedPage.GetAttribute("xmlns:x") == @"http://schemas.microsoft.com/winfx/2009/xaml", @"`NurtritionView`'s `TabbedPage` tag didn't contain the attribute `xmlns:x` with a value of `""http://schemas.microsoft.com/winfx/2009/xaml""`");
            Assert.True(tabbedPage.GetAttribute("xmlns:d") == @"http://xamarin.com/schemas/2014/forms/design", @"`NurtritionView`'s `TabbedPage` tag didn't contain the attribute `xmlns:d` with a value of `""http://xamarin.com/schemas/2014/forms/design""`");
            Assert.True(tabbedPage.GetAttribute("xmlns:mc") == @"http://schemas.openxmlformats.org/markup-compatibility/2006", @"`NurtritionView`'s `TabbedPage` tag didn't contain the attribute `xmlns:mc` with a value of `""http://schemas.openxmlformats.org/markup-compatibility/2006""`");
            Assert.True(tabbedPage.GetAttribute("mc:Ignorable") == @"d", @"`NurtritionView`'s `TabbedPage` tag didn't contain the attribute `mc:Ignorable` with a value of `""d""`");
            Assert.True(tabbedPage.GetAttribute("x:Class") == @"XAMLInXamarinForms.Views.Nutrition.NutritionView", @"`NurtritionView`'s `TabbedPage` tag didn't contain the attribute `x:Class` with a value of `""XAMLInXamarinForms.Views.Nutrition.NutritionView""`");
        }

        [Fact(DisplayName = "Add NutritionViews Reference @add-nutritionviews-reference")]
        public void AddNutritionViewsReferenceTest()
        {
            var filePath = ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + "XAMLInXamarinForms" + Path.DirectorySeparatorChar + "Views" + Path.DirectorySeparatorChar + "Nutrition" + Path.DirectorySeparatorChar + "NutritionView.xaml";
            Assert.True(File.Exists(filePath), "`NutritionView` was not found in the `Views" + Path.DirectorySeparatorChar + "Nutrition` directory.");

            var xml = File.ReadAllText(filePath);
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);

            // is the first line `<?xml version = "1.0" encoding="utf-8" ?>`
            var firstChild = xmlDocument.FirstChild;
            Assert.True(firstChild != null, "`NutritionView` does not appear to contain any xaml code.");
            Assert.True(firstChild.NodeType == XmlNodeType.XmlDeclaration, @"`NutritionView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Name == "xml", @"`NutritionView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Value.Contains("encoding") && xmlDocument.FirstChild.Value.Contains("utf-8"), @"`NutritionView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");

            // The second line is the openning `TabbedPage` tag including xmls, mc, and class declarations
            var tabbedPage = xmlDocument.DocumentElement;
            Assert.True(tabbedPage != null, "`NutritionView` does not appear to contain any xaml code.");
            Assert.True(tabbedPage.GetAttribute("xmlns:nutritionviews") == @"clr-namespace:XAMLInXamarinForms.Views.Nutrition", @"`NurtritionView`'s `TabbedPage` tag didn't contain the attribute `xmlns:nutritionviews` with a value of `""clr-namespace:XAMLInXamarinForms.Views.Nutrition""`");
        }

        [Fact(DisplayName = "Add TabbedPage Title @add-tabbedpage-title")]
        public void AddTabbedPageTitle()
        {
            var filePath = ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + "XAMLInXamarinForms" + Path.DirectorySeparatorChar + "Views" + Path.DirectorySeparatorChar + "Nutrition" + Path.DirectorySeparatorChar + "NutritionView.xaml";
            Assert.True(File.Exists(filePath), "`NutritionView` was not found in the `Views" + Path.DirectorySeparatorChar + "Nutrition` directory.");

            var xml = File.ReadAllText(filePath);
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);

            // is the first line `<?xml version = "1.0" encoding="utf-8" ?>`
            var firstChild = xmlDocument.FirstChild;
            Assert.True(firstChild != null, "`NutritionView` does not appear to contain any xaml code.");
            Assert.True(firstChild.NodeType == XmlNodeType.XmlDeclaration, @"`NutritionView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Name == "xml", @"`NutritionView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Value.Contains("encoding") && xmlDocument.FirstChild.Value.Contains("utf-8"), @"`NutritionView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");

            // The second line is the openning `TabbedPage` tag including xmls, mc, and class declarations
            var tabbedPage = xmlDocument.DocumentElement;
            Assert.True(tabbedPage != null, "`NutritionView` does not appear to contain any xaml code.");

            // Ensure `TabbedPage` contains a `TabbedPage.Title` tag with the contents "Nutrition"
            XmlElement tabbedPageTitle = null;
            foreach(XmlElement child in tabbedPage.ChildNodes)
            {
                if(child.Name == "TabbedPage.Title")
                    tabbedPageTitle = child;
            }
            Assert.True(tabbedPageTitle != null, "`NutritionView` does not appear to have `TabbedPage.Title` tags containing `Nutrition` between it's `TabbedPage` tags.");
            //Ignore the "use `Assert.Contains` warning, Contains does not allow custom messages so doesn't support our usecase.
            Assert.True(tabbedPageTitle.InnerText.Contains("Nutrition"), "`NutritionView`'s `TabbedPage.Title` open ond close tags do not appear to have the value `Nutrition` between them.");
        }

        [Fact(DisplayName = "Add Breakfast View @add-breakfast-view")]
        public void AddBreakfastView()
        {
            var filePath = ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + "XAMLInXamarinForms" + Path.DirectorySeparatorChar + "Views" + Path.DirectorySeparatorChar + "Nutrition" + Path.DirectorySeparatorChar + "NutritionView.xaml";
            Assert.True(File.Exists(filePath), "`NutritionView` was not found in the `Views" + Path.DirectorySeparatorChar + "Nutrition` directory.");

            var xml = File.ReadAllText(filePath);
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);

            // is the first line `<?xml version = "1.0" encoding="utf-8" ?>`
            var firstChild = xmlDocument.FirstChild;
            Assert.True(firstChild != null, "`NutritionView` does not appear to contain any xaml code.");
            Assert.True(firstChild.NodeType == XmlNodeType.XmlDeclaration, @"`NutritionView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Name == "xml", @"`NutritionView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Value.Contains("encoding") && xmlDocument.FirstChild.Value.Contains("utf-8"), @"`NutritionView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");

            // The second line is the openning `TabbedPage` tag including xmls, mc, and class declarations
            var tabbedPage = xmlDocument.DocumentElement;
            Assert.True(tabbedPage != null, "`NutritionView` does not appear to contain any xaml code.");

            // Ensure `TabbedPage` contains a `nutritionviews:BreakfastView` tag
            XmlElement breakfastView = null;
            foreach (XmlElement child in tabbedPage.ChildNodes)
            {
                if (child.Name == "nutritionviews:BreakfastView")
                    breakfastView = child;
            }
            Assert.True(breakfastView != null, "`NutritionView` does not appear to have a `nutritionviews:BreakfastView` tag.");
        }

        [Fact(DisplayName = "Add Lunch View @add-lunch-view")]
        public void AddLunchView()
        {
            var filePath = ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + "XAMLInXamarinForms" + Path.DirectorySeparatorChar + "Views" + Path.DirectorySeparatorChar + "Nutrition" + Path.DirectorySeparatorChar + "NutritionView.xaml";
            Assert.True(File.Exists(filePath), "`NutritionView` was not found in the `Views" + Path.DirectorySeparatorChar + "Nutrition` directory.");

            var xml = File.ReadAllText(filePath);
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);

            // is the first line `<?xml version = "1.0" encoding="utf-8" ?>`
            var firstChild = xmlDocument.FirstChild;
            Assert.True(firstChild != null, "`NutritionView` does not appear to contain any xaml code.");
            Assert.True(firstChild.NodeType == XmlNodeType.XmlDeclaration, @"`NutritionView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Name == "xml", @"`NutritionView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Value.Contains("encoding") && xmlDocument.FirstChild.Value.Contains("utf-8"), @"`NutritionView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");

            // The second line is the openning `TabbedPage` tag including xmls, mc, and class declarations
            var tabbedPage = xmlDocument.DocumentElement;
            Assert.True(tabbedPage != null, "`NutritionView` does not appear to contain any xaml code.");

            // Ensure `TabbedPage` contains a `nutritionviews:LunchView` tag
            XmlElement lunchView = null;
            foreach (XmlElement child in tabbedPage.ChildNodes)
            {
                if (child.Name == "nutritionviews:LunchView")
                    lunchView = child;
            }
            Assert.True(lunchView != null, "`NutritionView` does not appear to have a `nutritionviews:LunchView` tag.");
        }

        [Fact(DisplayName = "Add Dinner View @add-dinner-view")]
        public void AddDinnerView()
        {
            var filePath = ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + "XAMLInXamarinForms" + Path.DirectorySeparatorChar + "Views" + Path.DirectorySeparatorChar + "Nutrition" + Path.DirectorySeparatorChar + "NutritionView.xaml";
            Assert.True(File.Exists(filePath), "`NutritionView` was not found in the `Views" + Path.DirectorySeparatorChar + "Nutrition` directory.");

            var xml = File.ReadAllText(filePath);
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);

            // is the first line `<?xml version = "1.0" encoding="utf-8" ?>`
            var firstChild = xmlDocument.FirstChild;
            Assert.True(firstChild != null, "`NutritionView` does not appear to contain any xaml code.");
            Assert.True(firstChild.NodeType == XmlNodeType.XmlDeclaration, @"`NutritionView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Name == "xml", @"`NutritionView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Value.Contains("encoding") && xmlDocument.FirstChild.Value.Contains("utf-8"), @"`NutritionView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");

            // The second line is the openning `TabbedPage` tag including xmls, mc, and class declarations
            var tabbedPage = xmlDocument.DocumentElement;
            Assert.True(tabbedPage != null, "`NutritionView` does not appear to contain any xaml code.");

            // Ensure `TabbedPage` contains a `nutritionviews:DinnerView` tag
            XmlElement dinnerView = null;
            bool afterLunch = false;
            foreach (XmlElement child in tabbedPage.ChildNodes)
            {
                if (child.Name == "nutritionviews:LunchView")
                    afterLunch = true;
                if (child.Name == "nutritionviews:DinnerView")
                {
                    dinnerView = child;
                    break;
                }
            }
            Assert.True(dinnerView != null, "`NutritionView` does not appear to have a `nutritionviews:DinnerView` tag.");
            Assert.True(afterLunch, "`NutritionView`'s `nutritionviews:DinnerView` tag does not appear to come after the `nutritionviews:LunchView` tag.");
        }

        [Fact(DisplayName = "Add Snack View @add-snack-view")]
        public void AddSnackView()
        {
            var filePath = ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + "XAMLInXamarinForms" + Path.DirectorySeparatorChar + "Views" + Path.DirectorySeparatorChar + "Nutrition" + Path.DirectorySeparatorChar + "NutritionView.xaml";
            Assert.True(File.Exists(filePath), "`NutritionView` was not found in the `Views" + Path.DirectorySeparatorChar + "Nutrition` directory.");

            var xml = File.ReadAllText(filePath);
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);

            // is the first line `<?xml version = "1.0" encoding="utf-8" ?>`
            var firstChild = xmlDocument.FirstChild;
            Assert.True(firstChild != null, "`NutritionView` does not appear to contain any xaml code.");
            Assert.True(firstChild.NodeType == XmlNodeType.XmlDeclaration, @"`NutritionView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Name == "xml", @"`NutritionView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Value.Contains("encoding") && xmlDocument.FirstChild.Value.Contains("utf-8"), @"`NutritionView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");

            // The second line is the openning `TabbedPage` tag including xmls, mc, and class declarations
            var tabbedPage = xmlDocument.DocumentElement;
            Assert.True(tabbedPage != null, "`NutritionView` does not appear to contain any xaml code.");

            // Ensure `TabbedPage` contains a `nutritionviews:SnackView` tag
            XmlElement snackView = null;
            bool afterDinner = false;
            foreach (XmlElement child in tabbedPage.ChildNodes)
            {
                if (child.Name == "nutritionviews:DinnerView")
                    afterDinner = true;
                if(child.Name == "nutritionviews:SnackView")
                {
                    snackView = child;
                    break;
                }
            }
            Assert.True(snackView != null, "`NutritionView` does not appear to have a `nutritionviews:SnackView` tag.");
            Assert.True(afterDinner, "`NutritionView`'s `nutritionviews:SnackView` tag does not appear to come after the `nutritionviews:DinnerView` tag.");
        }
    }
}
