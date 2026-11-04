var builder = WebApplication.CreateBuilder(args);

var dbConnection = builder.Configuration.GetConnectionString("PostgresConnection");

if (!string.IsNullOrWhiteSpace(dbConnection))
{
    builder.Services.AddHealthChecks().AddNpgSql(dbConnection);      

    var app = builder.Build();

    app.MapHealthChecks("/health");

    app.Run();
}
