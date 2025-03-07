using AutoMapper;
using CSharp.Fundamentals.Application.DTOs;
using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;

namespace CSharp.Fundamentals.Application.Services
{
    public class DataStructureService
    {
        private readonly IDataStructureRepository _repository;
        private readonly IMapper _mapper;

        private Investor[] _array;
        private List<Investor> _list;
        private Stack<Investor> _stack;
        private Queue<Investor> _queue;
        private Dictionary<Guid, Investor> _dictionary;
        private IEnumerable<Investor> _enumerable;
        private ICollection<Investor> _collection;
        private IList<Investor> _ilist;
        private IReadOnlyCollection<Investor> _readonlyCollection;
        private IReadOnlyList<Investor> _readonlyList;
        private IDictionary<Guid, Investor> _idictionary;

        public Investor[] GetInvestorsArray() => _array;

        public List<Investor> GetInvestorsList() => _list;

        public Stack<Investor> GetInvestorsStack() => new Stack<Investor>(_stack);

        public Queue<Investor> GetInvestorsQueue() => new Queue<Investor>(_queue);

        public Dictionary<Guid, Investor> GetInvestorsDictionary() => new Dictionary<Guid, Investor>(_dictionary);

        public IEnumerable<Investor> GetInvestorsEnumerable() => _enumerable;

        public ICollection<Investor> GetInvestorsCollection() => _collection;

        public IList<Investor> GetInvestorsIList() => _ilist;

        public IReadOnlyCollection<Investor> GetInvestorsReadOnlyCollection() => _readonlyCollection;

        public IReadOnlyList<Investor> GetInvestorsReadOnlyList() => _readonlyList;

        public IDictionary<Guid, Investor> GetInvestorsIDictionary() => new Dictionary<Guid, Investor>(_idictionary);


        public DataStructureService(IDataStructureRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

            _list = _repository.GetAll().ToList();
            _array = _list.ToArray();
            _stack = new Stack<Investor>(_list);
            _queue = new Queue<Investor>(_list);
            _dictionary = _list.ToDictionary(i => i.Id);
            _enumerable = _list.AsEnumerable();
            _collection = _list;
            _ilist = _list;
            _readonlyCollection = _list.AsReadOnly();
            _readonlyList = _list.AsReadOnly();
            _idictionary = new Dictionary<Guid, Investor>(_dictionary);
        }

        public void GenerateLargeInvestorList(int size)
        {
            _list.Clear();

            for (int i = 0; i < size; i++)
            {
                var investor = new Investor($"Investor {i + 1}", (InvestmentType)(i % 3), new Random().Next(1000, 100000), new Random().NextDouble() * 15, new Random().Next(6, 60));
                _list.Add(investor);
            }
            _repository.SaveAll(_list);
        }

        public IEnumerable<InvestorDto> GetAllInvestors() => _mapper.Map<IEnumerable<InvestorDto>>(_list);
    }
}