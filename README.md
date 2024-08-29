# BlazorServerCleanArchitectureTemplate
Basic template of Blazor Server app in NET 8 following clean architecture principle

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


