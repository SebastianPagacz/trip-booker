var builder = WebApplication.CreateBuilder(args);

string dbConnection = builder.Configuration.GetConnectionString("PostgresConnection") ?? "default";

using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
ILogger logger = factory.CreateLogger("Program");
logger.LogInformation(dbConnection);

builder.Services.AddHealthChecks().AddNpgSql(dbConnection);      

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapHealthChecks("/health");

app.Run();
