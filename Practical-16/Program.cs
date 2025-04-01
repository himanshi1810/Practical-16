var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Dependency Injection
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// Simple endpoint with logging
app.MapGet("/hello", (ILogger<Program> logger) =>
{
    logger.LogInformation("Hello endpoint was called");
    return "Hello World!";
});

// Log application start
app.Logger.LogInformation("Application starting...");//Middleware Components
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
