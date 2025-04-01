# Practical-16
# Hello World API with ASP.NET Core

## Project Structure
```
HelloWorldApi/
├── Controllers/
│ └── HelloWorldController.cs # Contains API endpoints
├── Properties/
│ └── launchSettings.json # Environment configurations
├── appsettings.json # Configuration settings
├── appsettings.Development.json # Development-specific settings
└── Program.cs # Application entry point
```
## Key Features

### 1. Environment Configuration
Different settings for development vs production in:
- `appsettings.json` (base configuration)
- `appsettings.Development.json` (development overrides)

### 2. Request Pipeline & Middleware
Configured in `Program.cs` with:
```csharp
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
```
### 3. Dependency Injection
We have built in dependency injection 
```csharp
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
```

### 4. Controller Routing in the Controller Folder
```csharp
[ApiController]
[Route("[controller]")]
public class HelloWorldController : ControllerBase
```

### 5.  Built in Logging with the help of Logger
```charp
_logger.LogInformation("HelloWorldController.Get was called");
```

