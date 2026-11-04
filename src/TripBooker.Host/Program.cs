var builder = WebApplication.CreateBuilder(args);

string dbConnection = builder.Configuration.GetConnectionString("PostgresConnection") ?? "default";

builder.Services.AddHealthChecks().AddNpgSql(dbConnection);      

var app = builder.Build();

app.MapHealthChecks("/health");

app.Run();
