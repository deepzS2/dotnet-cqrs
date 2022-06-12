<h1 align="center">CQRS with Mediator</h1>
<p align="center">Simple shop API made with .NET 6 using the concepts of <b>CQRS</b> and <b>Mediator pattern</b></p>

&nbsp;

## CQRS Explained
**CQRS** (Command Query Responsibility Segregation) is a pattern which separates the operations of read and update from a database. The implementation of this pattern can maximize the performance, scalability and security of the application. [Martin Fowler](https://martinfowler.com/bliki/CQRS.html)

## Mediator Pattern Explained
**Mediator** defines an object that encapsulates how a set of objects interact. This pattern is considered to be a behavioral pattern due to the way it can alter the program's running behaviour. [🌐 Wikipedia](https://en.wikipedia.org/wiki/Mediator_pattern)

## How it works?
The application uses [Entity Framework Core](https://docs.microsoft.com/pt-br/ef/core/) for running migrations and database connection, which we use in the **Commands** and **Queries** of the application, and we use [MediatR](https://github.com/jbogard/MediatR) for the Mediator Pattern implementation.
The controllers have a MediatR reference which we use the to execute the Queries and Commands, after that the Handlers execute your logic.

## Show your support
Give this project a ⭐ if you like to support me to make more projects like this!
