mysecondonion
=============
My second example of Onion Architecture. Here we use the Generic Repository and Unit of Work patterns implemented using ASP.NET MVC, Entity Framework, Autofac, and Moq.

This started out as the example found [here](http://techbrij.com/generic-repository-unit-testing-ioc-di-asp-net-mvc)

I've since made the following additions/changes:
* EF configuration is code based, rather than using attributes on models
* All interfaces (with the exception of ISampleArchContext) live in the Domain
* Minor changes involved with using latest nuget packages
