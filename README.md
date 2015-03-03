mysecondonion
=============
My second example of Onion Architecture. 

This is a simple ASP.NET MVC web application that shows how to get a simple web app up and running that follows the Generic Repository and Unit of Work patterns implemented using ASP.NET MVC, Entity Framework, and Autofac. Moq is used for unit testing. The Test project also demonstrates how to run integration tests that targets a separete test database, so that your integration tests don't interfere with the same data that the application uses. 

This project started out as the example found [here](http://techbrij.com/generic-repository-unit-testing-ioc-di-asp-net-mvc)

I've since made the following additions/changes:
* EF configuration uses code based configuration, rather than using attributes on models
* All interfaces (with the exception of ISampleArchContext) live in the Domain
* Minor changes involved with using latest nuget packages
* TODO: use AutoMapper to demonstrate mapping Domain models to separate models in the web application

###Copying and Renaming this project
Copying and renaming a Visual Studio solution is not the easiest thing to do. If you'd like to copy and rename this solution, here are steps I took:
* Clone the solution
* On your local file system, copy everything except the hidden .git folder to a different location
* Open the solution in Visual Studio
* In Solution Explorer, right-click on the solution and rename it.
* In Solution Explorer, right-click on each project and rename it.
* In Solution Explorer, right-click on each project, click Properties, and rename the Assembly Name and Default Namespace
* Search all files in the solution for "SampleArch" and replace it with your new name.
* Rename ISampleArchContext.cs and SampleArchContext.cs in the Data project.
* Close Visual Studio
* On your local file system, rename the project folders.
* Open the .sln file with a text editor and replace instances of "SampleArch" with your new name.
* Go through each project folder and delete the bin and debug folders.
* Open the solution in Visual Studio and run the Web project.
* Execute all tests.
* You are now free to add this to source control.
* Note that .gitignore prevents the packages folder from being checked in.
