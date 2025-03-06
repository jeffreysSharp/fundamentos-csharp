using AutoMapper;
using CSharp.Fundamentals.Application.DTOs;
using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Application.Services
{
    public class FunctionService
    {
        private readonly IFunctionRepository _repository;
        private readonly IMapper _mapper;

        public FunctionService(IFunctionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // Function with return
        public int Add(int a, int b) => a + b;

        // Function without return (void)
        public void DisplayMessage(string message) => Console.WriteLine(message);

        // Static Function
        public static int Multiply(int a, int b) => a * b;

        // Asynchronous Function
        public async Task<string> GetDataAsync()
        {
            await Task.Delay(2000);
            return "Data loaded!";
        }

        // Anonymous Function (Lambda)
        public Func<int, int, int> AddLambda = (a, b) => a + b;

        // Function Overloading
        public double Calculate(double a, double b) => a + b;
        public double Calculate(double a, double b, double c) => a + b + c;

        // Creating and storing an entity
        public FunctionDto CreateFunction(int value)
        {
            var example = new Function(value);
            _repository.Add(example);
            return _mapper.Map<FunctionDto>(example);
        }

        public IEnumerable<FunctionDto> GetAll()
        {
            var examples = _repository.GetAll();
            return _mapper.Map<IEnumerable<FunctionDto>>(examples);
        }
    }
}
