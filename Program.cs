var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (MinimalApi.DTOs.LoginDTO loginDto) =>
{
    if (loginDto.Email == "user@example.com" && loginDto.Password == "password")
    {
        return Results.Ok("Login successful!");
    }
    return Results.Unauthorized();
});

app.Run();