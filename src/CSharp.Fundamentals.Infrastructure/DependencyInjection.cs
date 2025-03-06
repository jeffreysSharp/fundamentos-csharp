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
            services.AddSingleton<INumericalDataRepository, JsonNumericalDataRepository>();
            services.AddSingleton<IRelationalOperationRepository, JsonRelationalOperationRepository>();
            services.AddSingleton<ILogicalOperationRepository, JsonLogicalOperationRepository>();
            services.AddSingleton<ITernaryRepository, JsonTernaryOperationRepository>();
            services.AddSingleton<IArithmeticRepository, JsonArithmeticOperationRepository>();
            services.AddSingleton<IFunctionRepository, JsonFunctionRepository>();

            services.AddScoped<InvestmentService>();
            services.AddScoped<InvestmentCalculatorService>();
            services.AddScoped<NumericalDataService>();
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
