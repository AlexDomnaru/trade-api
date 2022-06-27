The project is a GraphQL API that features 4 endpoints, providing a few simple CRUD operations on Users, Trades, Securities and Portfolios.

Supported operations:
  - graphql/user:
    - GetAllUsers | query -> fetches all users
  - graphql/security:
    - GetAllSecurities | query -> fetches all securities
    - UpdateSecurityMarketPrice | mutation -> updates the price of a security
  - graphql/trade:
    - GetAllTrades | query -> fetches all trades
    - GetTradesByUserId | query -> fetches all trades for a given user
    - CreateTrade | mutation -> creates a new trade for a given user id and security id, with a specified quantity
    - DeleteTrade | mutation -> deletes a trade with a given id
  - graphql/portfolio:
    - GetAllPortfolios | query -> computes the portfolios of all users and returns the results
    

The project uses the CQRS pattern in combination with the Mediator pattern (using MediatR nuget package), and HotChocolate for the GraphQL implementation.
The CQRS commands/queries contain the business logic (could be seen as the service layer), and I make use of it to keep the data access layer, as well as the business logic, separated from the GraphQL API. I believe this approach suits a project of this scale, as it keeps operations defined clearly and the code is easily readable.

When it comes to the business logic, I chose to handle data using dictionary as such operations involve many list lookups, therefore handling data using dictionaries makes accessing it more time efficient.

The data access layer is a simple in memory "database" held in a singleton class, with repositories written for each data model providing a few CRUD operations (only the ones required for this assignment).

Unfortunately, due to time constraints, I didn't manage to do error handling and unit testing, as my focus was implementing a functional API.
In regards to error handling, I'd have written validations in the mediator (or create a service that handles data validation, e.g. validate security market price updates wouldn't update to negative price numbers, validate user exists for GetTradesByUserId, etc.)
In regards to unit testing, I'd have written unit tests for the MediatR handlers (and if I had implemented them, the validation services), mocking the repositories and the application context class using Moq.
