Vamos recomeçar ?
Vou te passar todo o ultimo código para você se lembrar 

/////////////////////////////////////////////////////////////////////////////////////
// CSharp.Fundamentals - Solution

// CSharp.Fundamentals.Application

namespace CSharp.Fundamentals.Application.DTOs
{
    public class LogicalOperationDto
    {
        public Guid Id { get; set; }
        public bool FirstCondition { get; set; }
        public bool SecondCondition { get; set; }
        public bool AndResult { get; set; }
        public bool OrResult { get; set; }
        public bool NotFirst { get; set; }
        public bool NotSecond { get; set; }
    }
}


using AutoMapper;
using CSharp.Fundamentals.Application.DTOs;
using CSharp.Fundamentals.Domain.Entities;

namespace CSharp.Fundamentals.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ArithmeticOperation, ArithmeticOperationDto>().ReverseMap();
            CreateMap<Investment, InvestmentDto>().ReverseMap();
            CreateMap<LogicalOperation, LogicalOperationDto>().ReverseMap();
            CreateMap<NumericalData, NumericalDataDto>().ReverseMap();
            CreateMap<RelationalOperation, RelationalOperationDto>().ReverseMap();
            CreateMap<TernaryOperation, TernaryOperationDto>().ReverseMap();
            CreateMap<Function, FunctionDto>().ReverseMap();
        }
    }
}



using AutoMapper;
using CSharp.Fundamentals.Application.DTOs;
using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Application.Services
{
    public class LogicalOperationService
    {
        private readonly ILogicalOperationRepository _repository;
        private readonly IMapper _mapper;

        public LogicalOperationService(ILogicalOperationRepository repository, 
                              IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public LogicalOperationDto Create(bool firstCondition, bool secondCondition)
        {
            var operation = new LogicalOperation(firstCondition, secondCondition);
            _repository.Add(operation);

            return _mapper.Map<LogicalOperationDto>(operation);
        }

        public IEnumerable<LogicalOperationDto> GetAll()
        {
            var logicalOperations = _repository.GetAll();

            return _mapper.Map<IEnumerable<LogicalOperationDto>>(logicalOperations);
        }
            

        public LogicalOperationDto? GetById(Guid id)
        {
            var logicalOperation = _repository.GetById(id);

            return logicalOperation != null ? _mapper.Map<LogicalOperationDto>(logicalOperation) : null;

        }  

        public LogicalOperationDto Delete(Guid id)
        {
            var existingOperation = _repository.GetById(id);

            if(existingOperation)
            _repository.Delete(operation);

            return _mapper.Map<LogicalOperationDto>(operation);
        } 
    }
}

// CSharp.Fundamentals.Domain

using CSharp.Fundamentals.Domain.Entities;

namespace CSharp.Fundamentals.Domain.Repositories
{
    public interface ILogicalOperationRepository
    {
        void Add(LogicalOperation operation);
        IEnumerable<LogicalOperation> GetAll();
        LogicalOperation? GetById(Guid id);
        void Delete(Guid id)
    }
}

// CSharp.Fundamentals.Infrastructure

using System.Text.Json;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Infrastructure.Repositories
{
    public class JsonRepository<T> : IJsonRepository<T> where T : class
    {
        private readonly string _filePath;
        private List<T> _entities;

        public JsonRepository(string fileName)
        {
            string solutionDirectory = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.FullName ?? "";
            string basePath = Path.Combine(solutionDirectory, "fundamentos-csharp\\src\\CSharp.Fundamentals.Infrastructure", "Data");
            _filePath = Path.Combine(basePath, fileName);

            _filePath = Path.Combine(basePath, $"{fileName.ToLower()}s.json");

            if (!Directory.Exists(basePath))
                Directory.CreateDirectory(basePath);

            _entities = LoadFromFile();
        }

        public void Add(T entity)
        {
            _entities.Add(entity);
            SaveToFile();
        }

        public IEnumerable<T> GetAll() => _entities;

        public T? GetById(Func<T, bool> predicate) => _entities.FirstOrDefault(predicate);

        private List<T> LoadFromFile()
        {
            if (!File.Exists(_filePath))
                return new List<T>();

            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
        }

        private void SaveToFile()
        {
            var json = JsonSerializer.Serialize(_entities, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
    }
}


using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Infrastructure.Repositories
{
    public class JsonLogicalOperationRepository : JsonRepository<LogicalOperation>, ILogicalOperationRepository
    {
        public JsonLogicalOperationRepository() : base("logical-operation") { }

        public LogicalOperation? GetById(Guid id)
        {
            return GetById(operation => operation.Id == id);
        }
    }
}

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
            services.AddSingleton<ITernaryOperationRepository, JsonTernaryOperationRepository>();
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


// CSharp.Fundamentals.WebAPI
using CSharp.Fundamentals.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CSharp.Fundamentals.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LogicalOperationController : ControllerBase
    {
        private readonly LogicalOperationService _logicalOperationervice;

        public FunctionController(FunctionService functionService)
        {
            _functionService = functionService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] FunctionRequest request)
        {
            var function = _functionService.Create(request.Name, request.Value, request.Status);
            return CreatedAtAction(nameof(GetAll), function);
        }


        [HttpGet("getall")]
        public IActionResult GetAll() => Ok(_functionService.GetAll());

        [HttpGet("getbyid{id}")]
        public async Task<IActionResult> GetById() => Ok(await _functionService.GetById());

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(Guid id) => Ok();
    }
}


// Program.cs
using CSharp.Fundamentals.Application.Mappings;
using CSharp.Fundamentals.Infrastructure;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddAutoMapper(typeof(MappingProfile));
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


builder.Services.AddInfrastructure();

var app = builder.Build();

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


/////////////////////////////////////////////////////////////////
Baseado nesse template preciso que crie um CRUD de investors com os seguintes dados:

    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public InvestmentType Type { get; set; }
        public decimal Amount { get; set; }
        public double InterestRate { get; set; }
        public int DurationInMonths { get; set; }
        public DateTime StartDate { get; set; }
    }

Gerando automaticamente uma lista gigante de investors para futuros testes de carga e utilizando todos os tipos de dados do c#:

Array,List, Stack, Queue, Dictionary<TKey, TValue>, IEnumerable, ICollection,IList, IReadOnlyCollection, IReadOnlyList,     IDictionary<TKey, TValue>


Conforme a nossa documentação



