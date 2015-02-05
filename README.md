mysecondonion
=============
My second example of Onion Architecture. Here we use the Generic Repository and Unit of Work patterns implemented with ASP.NET MVC, Entity Framework, Autofac, and Moq.

Inspired by http://techbrij.com/generic-repository-unit-testing-ioc-di-asp-net-mvc

Things I've changed, or what I'm doing differently:
* Repository project is named Data
* Model project is named Domain
* EF configuration is code based, rather than using attributes on models
* All interfaces (with the exception of ISampleArchContext) live in the Domain

