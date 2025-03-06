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

            services.AddSingleton<IInvestmentRepository, JsonInvestmentRepository>();
            services.AddSingleton<INumericDataRepository, JsonNumericDataRepository>();
            services.AddSingleton<IRelationalRepository, JsonRelationalOperationRepository>();
            services.AddSingleton<ILogicalRepository, JsonLogicalOperationRepository>();
            services.AddSingleton<ITernaryRepository, JsonTernaryOperationRepository>();
            services.AddSingleton<IArithmeticRepository, JsonArithmeticOperationRepository>();
            services.AddSingleton<IFunctionRepository, JsonFunctionRepository>();

            services.AddScoped<InvestmentService>();
            services.AddScoped<InvestmentCalculatorService>();
            services.AddScoped<NumericDataService>();
            services.AddScoped<NumericCalculatorService>();
            services.AddScoped<ArithmeticOperationService>();
            services.AddScoped<RelationalOperationService>();
            services.AddScoped<LogicalOperationService>();
            services.AddScoped<TernaryOperationService>();
            services.AddScoped<FunctionService>();

            return services;
        }
    }
}
