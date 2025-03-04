using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddSwaggerGen(
    c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo()
        {
            Title = "C# Fundamentals API",
            Description = "This API is responsible for course C# Fundamentals.",
            Contact = new OpenApiContact() { Name = "Jeferson Almeida", Email = "jeffreys.sharp@outlook.com" },
            License = new OpenApiLicense() { Name = "MIT", Url = new Uri("https://opensource.org/license/mit") }
        });

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
