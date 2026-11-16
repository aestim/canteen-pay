// 1. Register the parts the app needs (dependency injection container).
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();

var app = builder.Build();

// 2. Connect URLs to code (endpoints).
if (app.Environment.IsDevelopment())
{
    // API description generated from the code: GET /openapi/v1.json
    app.MapOpenApi();
}

app.MapGet("/health", () => new HealthResponse("ok"));

// 3. Start listening for HTTP requests.
app.Run();

// Shape of the JSON response: {"status":"ok"}
public record HealthResponse(string Status);

// Makes the start-up class visible to the test project.
public partial class Program;
