using System.IO;
using System.Xml;
using Xunit;

namespace XAMLInXamarinForms.Tests
{
    public class NavigationPageViewTests
    {
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
                    if(child.GetAttribute("Clicked") == "FitnessButton_Clicked")
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


        [Fact(DisplayName = "Add Button Styles @add-button-styles")]
        public void AddButtonStyles()
        {
            var filePath = ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + "XAMLInXamarinForms" + Path.DirectorySeparatorChar + "Views" + Path.DirectorySeparatorChar + "NavigationPageView.xaml";
            Assert.True(File.Exists(filePath), "`NavigationPageView` was not found in the `Views" + Path.DirectorySeparatorChar + "Fitness` directory.");

            var xml = File.ReadAllText(filePath);
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);

            var contentPage = xmlDocument.DocumentElement;
            Assert.True(contentPage != null, "`NavigationPageView` does not appear to contain any xaml code.");

            XmlNodeList children = contentPage.ChildNodes[1]?.ChildNodes[0]?.ChildNodes;
            if (contentPage.ChildNodes.Count != 2)
                Assert.True(false, "`NavigationPageView`'s `ContentPage` tag should contain both `ContentPage.Resources` and `ContentPage.Content` tags.");

            XmlElement resources = (XmlElement)contentPage.ChildNodes[0];
            Assert.True(resources.Name == "ContentPage.Resources","`NavigationPageView`'s `ContentPage` tag should start with a set of `ContentPage.Resources` tags.");
            Assert.True(resources.ChildNodes.Count == 1, "`NavigationPageView`'s `ContentPage.Resources` tag should contain a `ResourceDictionary` tag.");
            
            XmlElement resourceDictionary = (XmlElement)resources.ChildNodes[0];
            Assert.True(resourceDictionary.Name == "ResourceDictionary", "`NavigationPageView`'s `ContentPage.Resources` tag should contain a `ResourceDictionary` tag.");
            Assert.True(resourceDictionary.ChildNodes.Count == 1 || resourceDictionary.ChildNodes.Count == 2, "`NavigationPageView`'s `ResourceDictionary` tag should contain `Style` tags.");

            XmlElement buttonStyle = (XmlElement)resourceDictionary.ChildNodes[0];
            Assert.True(buttonStyle.GetAttribute("TargetType") == "Button", @"`NavigationPageView`'s `ResourceDictionary`'s first `Style` tag should have a `TargetType` attribute with a value of `""Button""`.");
            Assert.True(buttonStyle.ChildNodes.Count > 0 && buttonStyle.ChildNodes.Count <= 4, "`NavigationPageView`'s `Style` tag for `button`s should contain `setters`.");

            bool buttonFontSet = false;
            bool buttonBackgroundSet = false;
            bool buttonMarginSet = false;
            bool buttonHorizontalOptionsSet = false;
            foreach(XmlElement setter in buttonStyle.ChildNodes)
            {
                if (setter.Name != "Setter")
                    continue;
                if(setter.GetAttribute("Property") == "Font" && setter.InnerText == "Calibri")
                    buttonFontSet = true;
                if (setter.GetAttribute("Property") == "BackgroundColor" && setter.InnerText == "White")
                    buttonBackgroundSet = true;
                if (setter.GetAttribute("Property") == "Margin" && setter.InnerText == "5")
                    buttonMarginSet = true;
                if (setter.GetAttribute("Property") == "HorizontalOptions" && setter.InnerText == "FillAndExpand")
                    buttonHorizontalOptionsSet = true;
            }

            Assert.True(buttonFontSet, @"`NavigationPageView`'s `Style` tag for `button`s should contain a `setter` with a `Property` attribute with a value of `""Font""` and `Calibri` between it's opening and closing tags.");
            Assert.True(buttonBackgroundSet, @"`NavigationPageView`'s `Style` tag for `button`s should contain a `setter` with a `Property` attribute with a value of `""BackgroundColor""` and `White` between it's opening and closing tags.");
            Assert.True(buttonMarginSet, @"`NavigationPageView`'s `Style` tag for `button`s should contain a `setter` with a `Property` attribute with a value of `""Margin""` and `5` between it's opening and closing tags.");
            Assert.True(buttonHorizontalOptionsSet, @"`NavigationPageView`'s `Style` tag for `button`s should contain a `setter` with a `Property` attribute with a value of `""HorizontalOptions""` and `FillAndExpand` between it's opening and closing tags.");
        }


        [Fact(DisplayName = "Add Label Styles @add-label-styles")]
        public void AddLabelStyles()
        {
            var filePath = ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + "XAMLInXamarinForms" + Path.DirectorySeparatorChar + "Views" + Path.DirectorySeparatorChar + "NavigationPageView.xaml";
            Assert.True(File.Exists(filePath), "`NavigationPageView` was not found in the `Views" + Path.DirectorySeparatorChar + "Fitness` directory.");

            var xml = File.ReadAllText(filePath);
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);

            var contentPage = xmlDocument.DocumentElement;
            Assert.True(contentPage != null, "`NavigationPageView` does not appear to contain any xaml code.");

            XmlNodeList children = contentPage.ChildNodes[1]?.ChildNodes[0]?.ChildNodes;
            if (contentPage.ChildNodes.Count != 2)
                Assert.True(false, "`NavigationPageView`'s `ContentPage` tag should contain both `ContentPage.Resources` and `ContentPage.Content` tags.");

            XmlElement resources = (XmlElement)contentPage.ChildNodes[0];
            Assert.True(resources.Name == "ContentPage.Resources", "`NavigationPageView`'s `ContentPage` tag should start with a set of `ContentPage.Resources` tags.");
            Assert.True(resources.ChildNodes.Count == 1, "`NavigationPageView`'s `ContentPage.Resources` tag should contain a `ResourceDictionary` tag.");

            XmlElement resourceDictionary = (XmlElement)resources.ChildNodes[0];
            Assert.True(resourceDictionary.Name == "ResourceDictionary", "`NavigationPageView`'s `ContentPage.Resources` tag should contain a `ResourceDictionary` tag.");
            Assert.True(resourceDictionary.ChildNodes.Count == 2, "`NavigationPageView`'s `ResourceDictionary` tag should contain `Style` tags.");

            XmlElement labelStyle = (XmlElement)resourceDictionary.ChildNodes[1];
            Assert.True(labelStyle.GetAttribute("TargetType") == "Label", @"`NavigationPageView`'s `ResourceDictionary`'s first `Style` tag should have a `TargetType` attribute with a value of `""Label""`.");
            Assert.True(labelStyle.ChildNodes.Count > 0 && labelStyle.ChildNodes.Count <= 5, "`NavigationPageView`'s `Style` tag for `label`s should contain `setters`.");

            bool labelFontSet = false;
            bool labelBackgroundSet = false;
            bool labelPaddingSet = false;
            bool labelHorizontalTextAlignmentSet = false;
            bool labelHorizontalOptionsSet = false;
            foreach (XmlElement setter in labelStyle.ChildNodes)
            {
                if (setter.Name != "Setter")
                    continue;
                if (setter.GetAttribute("Property") == "Font" && setter.InnerText == "Calibri")
                    labelFontSet = true;
                if (setter.GetAttribute("Property") == "BackgroundColor" && setter.InnerText == "White")
                    labelBackgroundSet = true;
                if (setter.GetAttribute("Property") == "Padding" && setter.InnerText == "10")
                    labelPaddingSet = true;
                if (setter.GetAttribute("Property") == "HorizontalTextAlignment" && setter.InnerText == "Center")
                    labelHorizontalTextAlignmentSet = true;
                if (setter.GetAttribute("Property") == "HorizontalOptions" && setter.InnerText == "FillAndExpand")
                    labelHorizontalOptionsSet = true;
            }

            Assert.True(labelFontSet, @"`NavigationPageView`'s `Style` tag for `label`s should contain a `setter` with a `Property` attribute with a value of `""Font""` and `Calibri` between it's opening and closing tags.");
            Assert.True(labelBackgroundSet, @"`NavigationPageView`'s `Style` tag for `label`s should contain a `setter` with a `Property` attribute with a value of `""BackgroundColor""` and `White` between it's opening and closing tags.");
            Assert.True(labelHorizontalTextAlignmentSet, @"`NavigationPageView`'s `Style` tag for `label`s should contain a `setter` with a `Property` attribute with a value of `""HorizontalTextAlignment""` and `Center` between it's opening and closing tags.");
            Assert.True(labelPaddingSet, @"`NavigationPageView`'s `Style` tag for `label`s should contain a `setter` with a `Property` attribute with a value of `""Padding""` and `10` between it's opening and closing tags.");
            Assert.True(labelHorizontalOptionsSet, @"`NavigationPageView`'s `Style` tag for `label`s should contain a `setter` with a `Property` attribute with a value of `""HorizontalOptions""` and `FillAndExpand` between it's opening and closing tags.");
        }
    }
}
