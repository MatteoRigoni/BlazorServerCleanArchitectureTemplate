# BlazorServerCleanArchitectureTemplate
Basic template of Blazor Server app in NET 8 following clean architecture principle, using EF as persistance.

![image](https://github.com/user-attachments/assets/3d584558-4201-4843-aff6-59fdc1b59d4b)


List of projects:
- BlazorServerCleanArchitecture.Application
- BlazorServerCleanArchitecture.Domain
- BlazorServerCleanArchitecture.Persistance
- BlazorServerCleanArchitecture.WebUII

### Domain
The domain layer is the core component of clean architecture and it usually includes domain entities, aggregates, value objects, etc. This layer represents the domain and use-case-independent business logic of the system and has no dependency on any technology, third-party library, or frameworks.

![image](https://github.com/user-attachments/assets/e1e3e003-e156-42e4-b5aa-2ac0ed93b078)

### Application
The application layer depends on the Domain layer and acts as a bridge between the Domain layer and external layers such as Persistence or Presentations layer. This layer contains business services, DTOs, Commands, Queries, etc.

The Repositories folder contains interfaces such as IUnitOfWork, IGenericRepository, and other domain-specific interfaces such as IStadiumRepository, etc. These interfaces define methods to read and update data.

About features, each feature folder can contain subfolders such as Queries and Commands which can contain CQRS commands and queries

### Infrastructure
This layer contains the implementation of the interfaces defined in the Application layer. The project(s) defined in this layer communicate with external systems and technologies, such as databases, APIs, or cloud services. This layer should only interact with the domain layer through the application layer and should not contain any business logic or domain knowledge. The main goal of the infrastructure layer is to encapsulate the technical details of the application so that they can be easily changed or replaced without affecting the rest of the application.

### Presentation
The presentation layer is the out most layer of the clean architecture and this is where we decide if we are going to build a Web API, an ASP.NET MVC web application, or a Blazor Server app. The presentation layer should not contain business logic or domain knowledge and should only interact with the rest of the application through the application layer.


