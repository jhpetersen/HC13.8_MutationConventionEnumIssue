using TestHC138bug;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddMutationConventions(applyToAllMutations: true)
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .InitializeOnStartup();

var app = builder.Build();

app.MapGraphQL();

app.Run();
