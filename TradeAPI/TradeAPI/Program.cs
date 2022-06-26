using GraphQL.Mutations;
using GraphQL.Queries;
using GraphQL.Types;
using TradeAPI.DataAccess.DataContext;
using TradeAPI.DataAccess.Repositories.Implementations;
using TradeAPI.DataAccess.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<ApplicationContext>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ISecurityRepository, SecurityRepository>();
builder.Services.AddScoped<ITradeRepository, TradeRepository>();

builder.Services.AddGraphQLServer("security")
    .AddType<SecurityType>()
    .AddQueryType<SecurityQueries>()
    .AddMutationType<SecurityMutations>();

builder.Services.AddGraphQLServer("user")
    .AddType<UserType>()
    .AddQueryType<UserQueries>();

builder.Services.AddGraphQLServer("trade")
    .AddType<TradeType>()
    .AddQueryType<TradeQueries>()
    .AddMutationType<TradeMutations>();

var app = builder.Build();

app.MapGraphQL("/graphql/user", "user");
app.MapGraphQL("/graphql/security", "security");
app.MapGraphQL("/graphql/trade", "trade");

app.Run();
