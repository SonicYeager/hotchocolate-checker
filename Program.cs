using HotChocolate.Checker.Persistence;
using HotChocolate.Checker.Worker;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("Checker");
if (string.IsNullOrWhiteSpace(connectionString))
    throw new InvalidOperationException("ConnectionString cannot be null!");

builder.Services.AddDatabase(connectionString);
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddHostedService<Seeder>();

builder.Services
    .AddGraphQLServer()
    .AddCheckerTypes()
    .AddSorting()
    .AddFiltering()
    .AddProjections()
    .AllowIntrospection(true)
    .RegisterDbContext<CheckerDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGraphQL();

app.Run();