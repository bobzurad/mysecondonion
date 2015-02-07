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
