# Build a Xamarin.Forms Application with XAML

In this project we'll take existing XAML pages and wire them together into an application using the common page types of navigation, tabbed, Carousel, and modal as well as add some basic styling to create a presentable application.

# Setup the Application

## Using Visual Studio
If you want to use Visual Studio _(highly recommended)_ follow the following steps:
-   If you already have Visual Studio installed make sure you have .NET Core installed by running the "Visual Studio Installer" and making sure ".NET Core cross-platform development" is checked.
-   If you need to install Visual Studio download it at https://visualstudio.microsoft.com/ by selecting "Community 2019" from the "Dowload Visual Studio" drop down list. _(If you're using Windows you'll want to check "ASP.NET" and ".NET Core cross-platform development" on the workloads screen during installation.)_
-   Open the .sln file in Visual Studio.
-   To run the application simply press the Start Debug button _(green arrow)_ or press F5.
-   If you're using Visual Studio on Windows, to run tests open the Test menu, click Run, then click on Run all tests. _(results will show up in the Test Explorer)_
-   If you're using Visual Studio on macOS, to run tests select the `XAMLInXamarinFormsTests` Project, then go to the Run menu, then click on Run Unit Tests. _(results will show up in the Unit Tests panel)_

_(Note: All tests should fail at this point. This is by design. As you progress through the project, more and more tests will pass. All tests should pass upon completion of the project.)_

## Using a Tool Other Than Visual Studio
If you would rather use something other than Visual Studio:
-   Install the .NET Core SDK from https://dotnet.microsoft.com/download once that installation completes, you're ready to get started!
-   To run the application go into the `XAMLInXamarinForms` project folder and type `dotnet run`.
-   To run the tests go into the `XAMLInXamarinFormsTests` project folder and type `dotnet test`.

# Features you will implement

- A Navigation Page
- A Tabbed Page
- A Carousel Page
- Basic Styling
- A Modal

## Tasks necessary to complete implementation

__Note:__ This isn't the only way to accomplish implementation. However, this is what the project's tests are expecting. Implementing the features in a different way will likely result in being marked as incomplete / incorrect.

- [ ] Create a new `TabbedPage` in the `Views/Nutrition` folder with the name `NutritionView`.
    - [ ] When you create the `TabbedPage` in Visual Studio (or similiar) the following code should be generated for you, if not you'll need to add it yourself.
      - The first line should be the `xml` tag `<?xml version="1.0" encoding="utf-8" ?>`.
      - The second line should be an opening `TabbedPage` tag with the following attributes:
        - `xmlns="http://xamarin.com/schemas/2014/forms"`
        - `xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"`
        - `xmlns:d="http://xamarin.com/schemas/2014/forms/design"`
        - `xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"`
        - `mc:Ignorable="d"`
        - `x:Class="XAMLInXamarinForms.Views.Nutrition.NutritionView"`
      - The last line should be the closing `TabbedPage` tag.
    - [ ] In our `TabbedPage`'s opening tag add an attribute `xlmns:nutritionviews` with a value `"clr-namespace:XAMLInXamarinForms.Views.Nutrition"`.
    - [ ] Between the `TabbedPage` tags, add opening and closing `TabbedPage.Title` tags containing the value `Nutrition`.
    - [ ] After the closing `TabbedPage.Title` tag, add a new self closing tag with the of type `nutritionviews:BreakfastView`.
    - [ ] After the `nutritionviews:BreakfastView` tag, add a new self closing tag with the type `nutritionviews:LunchView`.
    - [ ] After the `nutritionviews:LunchView` tag, add a new self closing tag with the type `nutritionviews:DinnerView`.
    - [ ] After the `nutritionviews:DinnerView` tag, add a new self closing tag with the type `nutritionviews:SnackView`.
- [ ] Create a new `CarouselPage` in the `Views/Fitness` folder with the name `FitnessView`.
  - [ ] When you create the `CarouselPage` in Visual Studio (or similiar)the following code should be generated for you, if not you'll need to add it yourself.
  - [ ] - The first line should be the `xml` tag `<?xml version="1.0" encoding="utf-8" ?>`.
      - The second line should be an opening `CarouselPage` tag with the following attributes:
        - `xmlns="http://xamarin.com/schemas/2014/forms"`
        - `xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"`
        - `xmlns:d="http://xamarin.com/schemas/2014/forms/design"`
        - `xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"`
        - `mc:Ignorable="d"`
        - `x:Class="XAMLInXamarinForms.Views.Fitness.FitnessView"`
      - The last line should be the closing `CarouselPage` tag.
      - [ ] In our `CarouselPage`'s opening tag add an attribute `xlmns:fitnessviews` with a value `"clr-namespace:XAMLInXamarinForms.Views.Fitness"`.
      - [ ] Between the `CarouselPage` tags, add opening and closing `CarouselPage.Title` tags containing the value `Fitness`.
      - [ ] After the closing `CarouselPage.Title` tag, add a new self closing tag with the of type `fitnessviews:SundayView`.
      - [ ] After the `fitnessviews:SundayView` tag, add a new self closing tag with the of type `fitnessviews:MondayView`.
      - [ ] After the `fitnessviews:MondayView` tag, add a new self closing tag with the of type `fitnessviews:TuesdayView`.
      - [ ] After the `fitnessviews:TuesdayView` tag, add a new self closing tag with the of type `fitnessviews:WednesdayView`.
      - [ ] After the `fitnessviews:WednesdayView` tag, add a new self closing tag with the of type `fitnessviews:ThursdayView`.
      - [ ] After the `fitnessviews:ThursdayView` tag, add a new self closing tag with the of type `fitnessviews:FridayView`.
      - [ ] After the `fitnessviews:FridayView` tag, add a new self closing tag with the of type `fitnessviews:SaturdayView`.
- [ ] Setup navigation to the `FitnessView` and `NutritionView` on the `Views/NavigationPageView`.
  - Add click events to our `Views/NavigationPageView.xaml.cs` file by adding the following methods.
    - [ ] Add `using` directives for `XAMLInXamarinForms.Views.Fitness` and `XAMLInXamarinForms.Views.Nutrition`.
    - [ ] Create a new `private` `async` method with a return type of `void` named `FitnessButton_Clicked` that accepts arguments of type `object` named `sender` and `EventArgs` named `e`.
      - This method should contain only one line of code that calls `Navigation.PushAsync` method on `this` with an argument of newly instantiated `FitnessView`. Don't forget to `await`!
    - [ ] Create a new `private` `async` method with a return type of `void` named `NutritionButton_Clicked` that accepts arguments of type `object` named `sender` and `EventArgs` named `e`.
      - This method should contain only one line of code that calls `Navigation.PushAsync` method on `this` with an argument of newly instantiated `NutritionView`. Don't forget to `await`!
  - Wire up buttons on our `Views/NavigationPageView.xaml` to our newly created methods.
    - [ ] On our button with the `Text` attribute with a value of `{Binding Fitness}` add a new `Clicked` attribute with the value `"FitnessButton_Clicked"`.
    - [ ] On our button with the `Text` attribute with a value of `{Binding Nutrition}` add a new `Clicked` attribute with the value `"NutritionButton_Clicked"`.
- [ ] In our `Views/NavigationPageView.xaml.cs` file, wire up our `PrivacyModal` to be presented when the page loads.
  - [ ] Create a new `private` `async` method with a return type of `void` named `PopModal` that accepts no arguments.
    - This method should contain only one line of code that calls `Navigation.PushModalAsync` with arguments of a newly instantiated `PrivacyModal`, and `true`. Don`t forget to `await`!
  - [ ] In our `NavigationPageView`'s constructor after we call `InitializeComponent` call the newly created `PopModal` method.
- [ ] In our `Views/NavigationPageView.xaml` file, add basic styling to dramatically improve the application's presentation.
  - [ ] Between our `ContentPage` tags and before our `ContentPage.Content` tags add an opening and closing `ContentPage.Resources` tags.
  - [ ] Between our `ContentPage.Resources` tags add an opening and closing `ResourceDictionary` tags.
  - [ ] Between our `ResourceDictionary` tags add a new opening and closing `Style` tag with the attribute `TargetType` with a value of `"Button"`, contained between these `Style` tags should be the following.
    - opening and closing `Setter` tags with the attribute `Property` with a value of `"Font"`, that have `Calibri` between these tags.
    - opening and closing `Setter` tags with the attribute `Property` with a value of `"BackgroundColor"`, that have `White` between these tags.
    - opening and closing `Setter` tags with the attribute `Property` with a value of `"Margin"`, that have `5` between these tags.
    - opening and closing `Setter` tags with the attribute `Property` with a value of `"HorizontalOptions"`, that have `FillAndExpand` between these tags.
  - [ ] After our previously added `Style` tags add a new opening and closing `Style` tag with the attribute `TargetType` with a value of `"Label"`, contained between these `Style` tags should be the following.
    - opening and closing `Setter` tags with the attribute `Property` with a value of `"Font"`, that have `Calibri` between these tags.
    - opening and closing `Setter` tags with the attribute `Property` with a value of `"BackgroundColor"`, that have `White` between these tags.
    - opening and closing `Setter` tags with the attribute `Property` with a value of `"HorizontalTextAlignment"`, that have `Center` between these tags.
    - opening and closing `Setter` tags with the attribute `Property` with a value of `"Padding"`, that have `10` between these tags.
    - opening and closing `Setter` tags with the attribute `Property` with a value of `"HorizontalOptions"`, that have `FillAndExpand` between these tags.
      
## What Now?

Now is a good time to continue on with other Xamarin courses to expand your understanding of the Xamarin framework. You could also look at the Microsoft Azure for Developers path as Azure is often used with Xamarin applications.