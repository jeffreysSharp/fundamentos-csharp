using CSharp.Fundamentals.Application.Mappings;
using CSharp.Fundamentals.Application.Services;
using CSharp.Fundamentals.Domain.Repositories;
using CSharp.Fundamentals.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CSharp.Fundamentals.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));

            services.AddSingleton<IProductRepository, JsonProductRepository>();
            services.AddSingleton<IInvestmentRepository, JsonInvestmentRepository>();
            services.AddSingleton<INumericDataRepository, JsonNumericDataRepository>();
            services.AddSingleton<IRelationalRepository, JsonRelationalRepository>();
            services.AddSingleton<ILogicalRepository, JsonLogicalRepository>();
            services.AddSingleton<ITernaryRepository, JsonTernaryRepository>();
            services.AddSingleton<IArithmeticRepository, JsonArithmeticRepository>();

            services.AddScoped<ProductService>();
            services.AddScoped<InvestmentService>();
            services.AddScoped<InvestmentCalculatorService>();
            services.AddScoped<NumericCalculatorService>();
            services.AddScoped<ArithmeticService>();
            services.AddScoped<RelationalService>();
            services.AddScoped<LogicalService>();
            services.AddScoped<TernaryService>();

            return services;
        }
    }
}
