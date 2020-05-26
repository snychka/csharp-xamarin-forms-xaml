using System.IO;
using System.Xml;
using Xunit;

namespace XAMLInXamarinForms.Tests
{
    public class NavigationPageViewStylingTests
    {
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
