using System.IO;
using Xunit;
using System.Xml;

namespace XAMLInXamarinForms.Tests
{
    public class FitnessViewTests
    {
        

        [Fact(DisplayName = "Create Fitness View @create-fitness-view")]
        public void CreateFitnessView()
        {
            var filePath = ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + "XAMLInXamarinForms" + Path.DirectorySeparatorChar + "Views" + Path.DirectorySeparatorChar + "Fitness" + Path.DirectorySeparatorChar + "FitnessView.xaml";
            Assert.True(File.Exists(filePath), "`FitnessView` was not found in the `Views" + Path.DirectorySeparatorChar + "Fitness` directory.");

            var xml = File.ReadAllText(filePath);
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);

            // is the first line `<?xml version = "1.0" encoding="utf-8" ?>`
            var firstChild = xmlDocument.FirstChild;
            Assert.True(firstChild != null, "`FitnessView` does not appear to contain any xaml code.");
            Assert.True(firstChild.NodeType == XmlNodeType.XmlDeclaration, @"`FitnessView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Name == "xml", @"`FitnessView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Value.Contains("encoding") && xmlDocument.FirstChild.Value.Contains("utf-8"), @"`FitnessView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");

            // The second line is the openning `CarouselPage` tag including xmls, mc, and class declarations
            var carouselPage = xmlDocument.DocumentElement;
            Assert.True(carouselPage != null, "`FitnessView` does not appear to contain any xaml code.");
            Assert.True(carouselPage.GetAttribute("xmlns") == @"http://xamarin.com/schemas/2014/forms", @"`FitnessView`'s `CarouselPage` tag didn't contain the attribute `xmlns` with a value of `""http://xamarin.com/schemas/2014/forms""`");
            Assert.True(carouselPage.GetAttribute("xmlns:x") == @"http://schemas.microsoft.com/winfx/2009/xaml", @"`FitnessView`'s `CarouselPage` tag didn't contain the attribute `xmlns:x` with a value of `""http://schemas.microsoft.com/winfx/2009/xaml""`");
            Assert.True(carouselPage.GetAttribute("xmlns:d") == @"http://xamarin.com/schemas/2014/forms/design", @"`FitnessView`'s `CarouselPage` tag didn't contain the attribute `xmlns:d` with a value of `""http://xamarin.com/schemas/2014/forms/design""`");
            Assert.True(carouselPage.GetAttribute("xmlns:mc") == @"http://schemas.openxmlformats.org/markup-compatibility/2006", @"`FitnessView`'s `CarouselPage` tag didn't contain the attribute `xmlns:mc` with a value of `""http://schemas.openxmlformats.org/markup-compatibility/2006""`");
            Assert.True(carouselPage.GetAttribute("mc:Ignorable") == @"d", @"`FitnessView`'s `CarouselPage` tag didn't contain the attribute `mc:Ignorable` with a value of `""d""`");
            Assert.True(carouselPage.GetAttribute("x:Class") == @"XAMLInXamarinForms.Views.Fitness.FitnessView", @"`FitnessView`'s `CarouselPage` tag didn't contain the attribute `x:Class` with a value of `""XAMLInXamarinForms.Views.Fitness.FitnessView""`");
        }

        [Fact(DisplayName = "Add FitnessViews Reference @add-fitnessviews-reference")]
        public void AddFitnessViewsReferenceTest()
        {
            var filePath = ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + "XAMLInXamarinForms" + Path.DirectorySeparatorChar + "Views" + Path.DirectorySeparatorChar + "Fitness" + Path.DirectorySeparatorChar + "FitnessView.xaml";
            Assert.True(File.Exists(filePath), "`FitnessView` was not found in the `Views" + Path.DirectorySeparatorChar + "Fitness` directory.");

            var xml = File.ReadAllText(filePath);
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);

            // is the first line `<?xml version = "1.0" encoding="utf-8" ?>`
            var firstChild = xmlDocument.FirstChild;
            Assert.True(firstChild != null, "`FitnessView` does not appear to contain any xaml code.");
            Assert.True(firstChild.NodeType == XmlNodeType.XmlDeclaration, @"`FitnessView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Name == "xml", @"`FitnessView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Value.Contains("encoding") && xmlDocument.FirstChild.Value.Contains("utf-8"), @"`FitnessView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");

            // The second line is the openning `CarouselPage` tag including xmls, mc, and class declarations
            var carouselPage = xmlDocument.DocumentElement;
            Assert.True(carouselPage != null, "`FitnessView` does not appear to contain any xaml code.");
            Assert.True(carouselPage.GetAttribute("xmlns:fitnessviews") == @"clr-namespace:XAMLInXamarinForms.Views.Fitness", @"`NurtritionView`'s `CarouselPage` tag didn't contain the attribute `xmlns:fitnessviews` with a value of `""clr-namespace:XAMLInXamarinForms.Views.Fitness""`");
        }

        [Fact(DisplayName = "Add CarouselPage Title @add-carouselpage-title")]
        public void AddCarouselPageTitle()
        {
            var filePath = ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + "XAMLInXamarinForms" + Path.DirectorySeparatorChar + "Views" + Path.DirectorySeparatorChar + "Fitness" + Path.DirectorySeparatorChar + "FitnessView.xaml";
            Assert.True(File.Exists(filePath), "`FitnessView` was not found in the `Views" + Path.DirectorySeparatorChar + "Fitness` directory.");

            var xml = File.ReadAllText(filePath);
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);

            // is the first line `<?xml version = "1.0" encoding="utf-8" ?>`
            var firstChild = xmlDocument.FirstChild;
            Assert.True(firstChild != null, "`FitnessView` does not appear to contain any xaml code.");
            Assert.True(firstChild.NodeType == XmlNodeType.XmlDeclaration, @"`FitnessView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Name == "xml", @"`FitnessView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Value.Contains("encoding") && xmlDocument.FirstChild.Value.Contains("utf-8"), @"`FitnessView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");

            // The second line is the openning `CarouselPage` tag including xmls, mc, and class declarations
            var carouselPage = xmlDocument.DocumentElement;
            Assert.True(carouselPage != null, "`FitnessView` does not appear to contain any xaml code.");

            // Ensure `CarouselPage` contains a `CarouselPage.Title` tag with the contents "Fitness"
            XmlElement carouselPageTitle = null;
            foreach (XmlElement child in carouselPage.ChildNodes)
            {
                if (child.Name == "CarouselPage.Title")
                    carouselPageTitle = child;
            }
            Assert.True(carouselPageTitle != null, "`FitnessView` does not appear to have `CarouselPage.Title` tags containing `Fitness` between it's `CarouselPage` tags.");
            //Ignore the "use `Assert.Contains` warning, Contains does not allow custom messages so doesn't support our usecase.
            Assert.True(carouselPageTitle.InnerText.Contains("Fitness"), "`FitnessView`'s `CarouselPage.Title` open ond close tags do not appear to have the value `Fitness` between them.");
        }

        [Fact(DisplayName = "Add Sunday View @add-sunday-view")]
        public void AddSundayView()
        {
            var filePath = ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + "XAMLInXamarinForms" + Path.DirectorySeparatorChar + "Views" + Path.DirectorySeparatorChar + "Fitness" + Path.DirectorySeparatorChar + "FitnessView.xaml";
            Assert.True(File.Exists(filePath), "`FitnessView` was not found in the `Views" + Path.DirectorySeparatorChar + "Fitness` directory.");

            var xml = File.ReadAllText(filePath);
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);

            // is the first line `<?xml version = "1.0" encoding="utf-8" ?>`
            var firstChild = xmlDocument.FirstChild;
            Assert.True(firstChild != null, "`FitnessView` does not appear to contain any xaml code.");
            Assert.True(firstChild.NodeType == XmlNodeType.XmlDeclaration, @"`FitnessView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Name == "xml", @"`FitnessView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Value.Contains("encoding") && xmlDocument.FirstChild.Value.Contains("utf-8"), @"`FitnessView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");

            // The second line is the openning `CarouselPage` tag including xmls, mc, and class declarations
            var carouselPage = xmlDocument.DocumentElement;
            Assert.True(carouselPage != null, "`FitnessView` does not appear to contain any xaml code.");

            // Ensure `CarouselPage` contains a `fitnessviews:SundayView` tag
            XmlElement sundayView = null;
            foreach (XmlElement child in carouselPage.ChildNodes)
            {
                if (child.Name == "fitnessviews:SundayView")
                    sundayView = child;
            }
            Assert.True(sundayView != null, "`FitnessView` does not appear to have a `fitnessviews:SundayView` tag.");
        }

        [Fact(DisplayName = "Add Monday View @add-monday-view")]
        public void AddMondayView()
        {
            var filePath = ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + "XAMLInXamarinForms" + Path.DirectorySeparatorChar + "Views" + Path.DirectorySeparatorChar + "Fitness" + Path.DirectorySeparatorChar + "FitnessView.xaml";
            Assert.True(File.Exists(filePath), "`FitnessView` was not found in the `Views" + Path.DirectorySeparatorChar + "Fitness` directory.");

            var xml = File.ReadAllText(filePath);
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);

            // is the first line `<?xml version = "1.0" encoding="utf-8" ?>`
            var firstChild = xmlDocument.FirstChild;
            Assert.True(firstChild != null, "`FitnessView` does not appear to contain any xaml code.");
            Assert.True(firstChild.NodeType == XmlNodeType.XmlDeclaration, @"`FitnessView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Name == "xml", @"`FitnessView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Value.Contains("encoding") && xmlDocument.FirstChild.Value.Contains("utf-8"), @"`FitnessView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");

            // The second line is the openning `CarouselPage` tag including xmls, mc, and class declarations
            var carouselPage = xmlDocument.DocumentElement;
            Assert.True(carouselPage != null, "`FitnessView` does not appear to contain any xaml code.");

            // Ensure `CarouselPage` contains a `fitnessviews:MondayView` tag
            XmlElement mondayView = null;
            bool afterSunday = false;
            foreach (XmlElement child in carouselPage.ChildNodes)
            {
                if (child.Name == "fitnessviews:SundayView")
                    afterSunday = true;
                if (child.Name == "fitnessviews:MondayView")
                {
                    mondayView = child;
                    break;
                }
            }
            Assert.True(mondayView != null, "`FitnessView` does not appear to have a `fitnessviews:MondayView` tag.");
            Assert.True(afterSunday, "`FitnessView`'s `fitnessviews:MondayView` tag does not appear to come after the `fitnessviews:SundayView` tag.");
        }

        [Fact(DisplayName = "Add Tuesday View @add-tuesday-view")]
        public void AddTuesdayView()
        {
            var filePath = ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + "XAMLInXamarinForms" + Path.DirectorySeparatorChar + "Views" + Path.DirectorySeparatorChar + "Fitness" + Path.DirectorySeparatorChar + "FitnessView.xaml";
            Assert.True(File.Exists(filePath), "`FitnessView` was not found in the `Views" + Path.DirectorySeparatorChar + "Fitness` directory.");

            var xml = File.ReadAllText(filePath);
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);

            // is the first line `<?xml version = "1.0" encoding="utf-8" ?>`
            var firstChild = xmlDocument.FirstChild;
            Assert.True(firstChild != null, "`FitnessView` does not appear to contain any xaml code.");
            Assert.True(firstChild.NodeType == XmlNodeType.XmlDeclaration, @"`FitnessView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Name == "xml", @"`FitnessView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Value.Contains("encoding") && xmlDocument.FirstChild.Value.Contains("utf-8"), @"`FitnessView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");

            // The second line is the openning `CarouselPage` tag including xmls, mc, and class declarations
            var carouselPage = xmlDocument.DocumentElement;
            Assert.True(carouselPage != null, "`FitnessView` does not appear to contain any xaml code.");

            // Ensure `CarouselPage` contains a `fitnessviews:TuesdayView` tag
            XmlElement tuesdayView = null;
            bool afterMonday = false;
            foreach (XmlElement child in carouselPage.ChildNodes)
            {
                if (child.Name == "fitnessviews:MondayView")
                    afterMonday = true;
                if (child.Name == "fitnessviews:TuesdayView")
                {
                    tuesdayView = child;
                    break;
                }
            }
            Assert.True(tuesdayView != null, "`FitnessView` does not appear to have a `fitnessviews:TuesdayView` tag.");
            Assert.True(afterMonday, "`FitnessView`'s `fitnessviews:TuesdayView` tag does not appear to come after the `fitnessviews:MondayView` tag.");
        }

        [Fact(DisplayName = "Add Wednesday View @add-wednesday-view")]
        public void AddWednesdayView()
        {
            var filePath = ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + "XAMLInXamarinForms" + Path.DirectorySeparatorChar + "Views" + Path.DirectorySeparatorChar + "Fitness" + Path.DirectorySeparatorChar + "FitnessView.xaml";
            Assert.True(File.Exists(filePath), "`FitnessView` was not found in the `Views" + Path.DirectorySeparatorChar + "Fitness` directory.");

            var xml = File.ReadAllText(filePath);
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);

            // is the first line `<?xml version = "1.0" encoding="utf-8" ?>`
            var firstChild = xmlDocument.FirstChild;
            Assert.True(firstChild != null, "`FitnessView` does not appear to contain any xaml code.");
            Assert.True(firstChild.NodeType == XmlNodeType.XmlDeclaration, @"`FitnessView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Name == "xml", @"`FitnessView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Value.Contains("encoding") && xmlDocument.FirstChild.Value.Contains("utf-8"), @"`FitnessView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");

            // The second line is the openning `CarouselPage` tag including xmls, mc, and class declarations
            var carouselPage = xmlDocument.DocumentElement;
            Assert.True(carouselPage != null, "`FitnessView` does not appear to contain any xaml code.");

            // Ensure `CarouselPage` contains a `fitnessviews:WednesdayView` tag
            XmlElement wednesdayView = null;
            bool afterTuesday = false;
            foreach (XmlElement child in carouselPage.ChildNodes)
            {
                if (child.Name == "fitnessviews:TuesdayView")
                    afterTuesday = true;
                if (child.Name == "fitnessviews:WednesdayView")
                {
                    wednesdayView = child;
                    break;
                }
            }
            Assert.True(wednesdayView != null, "`FitnessView` does not appear to have a `fitnessviews:WednesdayView` tag.");
            Assert.True(afterTuesday, "`FitnessView`'s `fitnessviews:WednesdayView` tag does not appear to come after the `fitnessviews:TuesdayView` tag.");
        }

        [Fact(DisplayName = "Add Thursday View @add-thursday-view")]
        public void AddThursdayView()
        {
            var filePath = ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + "XAMLInXamarinForms" + Path.DirectorySeparatorChar + "Views" + Path.DirectorySeparatorChar + "Fitness" + Path.DirectorySeparatorChar + "FitnessView.xaml";
            Assert.True(File.Exists(filePath), "`FitnessView` was not found in the `Views" + Path.DirectorySeparatorChar + "Fitness` directory.");

            var xml = File.ReadAllText(filePath);
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);

            // is the first line `<?xml version = "1.0" encoding="utf-8" ?>`
            var firstChild = xmlDocument.FirstChild;
            Assert.True(firstChild != null, "`FitnessView` does not appear to contain any xaml code.");
            Assert.True(firstChild.NodeType == XmlNodeType.XmlDeclaration, @"`FitnessView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Name == "xml", @"`FitnessView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Value.Contains("encoding") && xmlDocument.FirstChild.Value.Contains("utf-8"), @"`FitnessView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");

            // The second line is the openning `CarouselPage` tag including xmls, mc, and class declarations
            var carouselPage = xmlDocument.DocumentElement;
            Assert.True(carouselPage != null, "`FitnessView` does not appear to contain any xaml code.");

            // Ensure `CarouselPage` contains a `fitnessviews:ThursdayView` tag
            XmlElement thursdayView = null;
            bool afterWednesday = false;
            foreach (XmlElement child in carouselPage.ChildNodes)
            {
                if (child.Name == "fitnessviews:WednesdayView")
                    afterWednesday = true;
                if (child.Name == "fitnessviews:ThursdayView")
                {
                    thursdayView = child;
                    break;
                }
            }
            Assert.True(thursdayView != null, "`FitnessView` does not appear to have a `fitnessviews:ThursdayView` tag.");
            Assert.True(afterWednesday, "`FitnessView`'s `fitnessviews:ThursdayView` tag does not appear to come after the `fitnessviews:WednesdayView` tag.");
        }

        [Fact(DisplayName = "Add Friday View @add-friday-view")]
        public void AddFridayView()
        {
            var filePath = ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + "XAMLInXamarinForms" + Path.DirectorySeparatorChar + "Views" + Path.DirectorySeparatorChar + "Fitness" + Path.DirectorySeparatorChar + "FitnessView.xaml";
            Assert.True(File.Exists(filePath), "`FitnessView` was not found in the `Views" + Path.DirectorySeparatorChar + "Fitness` directory.");

            var xml = File.ReadAllText(filePath);
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);

            // is the first line `<?xml version = "1.0" encoding="utf-8" ?>`
            var firstChild = xmlDocument.FirstChild;
            Assert.True(firstChild != null, "`FitnessView` does not appear to contain any xaml code.");
            Assert.True(firstChild.NodeType == XmlNodeType.XmlDeclaration, @"`FitnessView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Name == "xml", @"`FitnessView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Value.Contains("encoding") && xmlDocument.FirstChild.Value.Contains("utf-8"), @"`FitnessView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");

            // The second line is the openning `CarouselPage` tag including xmls, mc, and class declarations
            var carouselPage = xmlDocument.DocumentElement;
            Assert.True(carouselPage != null, "`FitnessView` does not appear to contain any xaml code.");

            // Ensure `CarouselPage` contains a `fitnessviews:FridayView` tag
            XmlElement fridayView = null;
            bool afterThursday = false;
            foreach (XmlElement child in carouselPage.ChildNodes)
            {
                if (child.Name == "fitnessviews:ThursdayView")
                    afterThursday = true;
                if (child.Name == "fitnessviews:FridayView")
                {
                    fridayView = child;
                    break;
                }
            }
            Assert.True(fridayView != null, "`FitnessView` does not appear to have a `fitnessviews:FridayView` tag.");
            Assert.True(afterThursday, "`FitnessView`'s `fitnessviews:FridayView` tag does not appear to come after the `fitnessviews:ThursdayView` tag.");
        }

        [Fact(DisplayName = "Add Saturday View @add-saturday-view")]
        public void AddSaturdayView()
        {
            var filePath = ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + "XAMLInXamarinForms" + Path.DirectorySeparatorChar + "Views" + Path.DirectorySeparatorChar + "Fitness" + Path.DirectorySeparatorChar + "FitnessView.xaml";
            Assert.True(File.Exists(filePath), "`FitnessView` was not found in the `Views" + Path.DirectorySeparatorChar + "Fitness` directory.");

            var xml = File.ReadAllText(filePath);
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);

            // is the first line `<?xml version = "1.0" encoding="utf-8" ?>`
            var firstChild = xmlDocument.FirstChild;
            Assert.True(firstChild != null, "`FitnessView` does not appear to contain any xaml code.");
            Assert.True(firstChild.NodeType == XmlNodeType.XmlDeclaration, @"`FitnessView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Name == "xml", @"`FitnessView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");
            Assert.True(firstChild.Value.Contains("encoding") && xmlDocument.FirstChild.Value.Contains("utf-8"), @"`FitnessView` does not appear to start with the tag `<?xml version = ""1.0"" encoding=""utf-8"" ?>`");

            // The second line is the openning `CarouselPage` tag including xmls, mc, and class declarations
            var carouselPage = xmlDocument.DocumentElement;
            Assert.True(carouselPage != null, "`FitnessView` does not appear to contain any xaml code.");

            // Ensure `CarouselPage` contains a `fitnessviews:SaturdayView` tag
            XmlElement saturdayView = null;
            bool afterFriday = false;
            foreach (XmlElement child in carouselPage.ChildNodes)
            {
                if (child.Name == "fitnessviews:FridayView")
                    afterFriday = true;
                if (child.Name == "fitnessviews:SaturdayView")
                {
                    saturdayView = child;
                    break;
                }
            }
            Assert.True(saturdayView != null, "`FitnessView` does not appear to have a `fitnessviews:SaturdayView` tag.");
            Assert.True(afterFriday, "`FitnessView`'s `fitnessviews:SaturdayView` tag does not appear to come after the `fitnessviews:FridayView` tag.");
        }
    }
}
