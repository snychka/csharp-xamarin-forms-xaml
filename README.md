# Build a Xamarin.Forms Application with XAML

In this project we’ll take an existing XAML pages and wire them together into an application using the common page types of navigation, tabbed, coursel, and modal as well as so basic stypling to create a presentable application.

# Setup the Application

## Using Visual Studio
If you want to use Visual Studio _(highly recommended)_ follow the following steps:
-   If you already have Visual Studio installed make sure you have .NET Core installed by running the "Visual Studio Installer" and making sure ".NET Core cross-platform development" is checked.
-   If you need to install Visual Studio download it at https://visualstudio.microsoft.com/ by selecting "Community 2019" from the "Dowload Visual Studio" drop down list. _(If you're using Windows you'll want to check "ASP.NET" and ".NET Core cross-platform development" on the workloads screen during installation.)_
-   Open the .sln file in Visual Studio.
-   To run the application simply press the Start Debug button _(green arrow)_ or press F5.
-   If you're using Visual Studio on Windows, to run tests open the Test menu, click Run, then click on Run all tests. _(results will show up in the Test Explorer)_
-   If you're using Visual Studio on macOS, to run tests select the XAMLInXamarinFormsTests Project, then go to the Run menu, then click on Run Unit Tests. _(results will show up in the Unit Tests panel)_

_(Note: All tests should fail at this point. This is by design. As you progress through the project, more and more tests will pass. All tests should pass upon completion of the project.)_

## Using a Tool Other Than Visual Studio
If you would rather use something other than Visual Studio:
-   Install the .NET Core SDK from https://dotnet.microsoft.com/download once that installation completes, you're ready to get started!
-   To run the application go into the XAMLInXamarinForms project folder and type `dotnet run`.
-   To run the tests go into the XAMLInXamarinFormsTests project folder and type `dotnet test`.

# Features you will implement

- A Navigation Page
- A Tabbed Page
- A Carousel Page
- Basic Styling
- A Modal

## Tasks necessary to complete implementation

__Note:__ This isn't the only way to accomplish implementation. However, this is what the project's tests are expecting. Implementing the features in a different way will likely result in being marked as incomplete / incorrect.

_The basis for validation in ASP.NET Core is DataAnnotations. They can be used to facilitate front end validation, ModelState validation, and database validation. As such, we'll make DataAnnotations available to our model, and setup properties that we want to be not-`null`._
- [ ] In our `Speaker` class at `ConferenceTracker/Entities/`, add `Required` attributes where appropriate. _Note: `Required` is part of `System.ComponentModel.DataAnnotations` which we already have a `using` directive for. Usually you'll need to add this yourself._
    - [ ] Add the `Required` attribute to the following properties:
      - `Id`
      - `FirstName`
      - `LastName`
      - `Description`
      
## What Now?

-----------------------------------------------------------------
PUT SOMETHING HERE
-----------------------------------------------------------------