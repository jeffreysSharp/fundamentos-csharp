using CSharp.Fundamentals.Application.Services;
using CSharp.Fundamentals.Domain.Repositories;
using CSharp.Fundamentals.Infrastructure.Repositories;
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

builder.Services.AddSingleton<IProductRepository, JsonProductRepository>();
builder.Services.AddSingleton<IInvestmentRepository, JsonInvestmentRepository>();
builder.Services.AddSingleton<INumericDataRepository, JsonNumericDataRepository>();
builder.Services.AddSingleton<IRelationalRepository, JsonRelationalRepository>();
builder.Services.AddSingleton<IArithmeticRepository, JsonArithmeticRepository>();
builder.Services.AddSingleton<ILogicalRepository, JsonLogicalRepository>();


builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<InvestmentService>();
builder.Services.AddScoped<InvestmentCalculatorService>();
builder.Services.AddScoped<NumericDataService>();
builder.Services.AddScoped<NumericCalculatorService>();
builder.Services.AddScoped<ArithmeticService>();
builder.Services.AddScoped<RelationalService>();
builder.Services.AddScoped<LogicalService>();



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
