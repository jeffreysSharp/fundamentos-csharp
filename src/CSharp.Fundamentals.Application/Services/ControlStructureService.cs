using AutoMapper;
using CSharp.Fundamentals.Domain.Entities;
using CSharp.Fundamentals.Domain.Repositories;
using CSharp.Fundamentals.Application.DTOs;

namespace CSharp.Fundamentals.Application.Services
{
    public class ControlStructureService
    {
        private readonly IControlStructureRepository _repository;
        private readonly IMapper _mapper;

        public ControlStructureService(IControlStructureRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public ControlStructureDto Create(int inputValue)
        {
            var controlStructure = new ControlStructure(inputValue);
            _repository.Add(controlStructure);
            return _mapper.Map<ControlStructureDto>(controlStructure);
        }

        public IEnumerable<ControlStructureDto> GetAll()
        {
            var structures = _repository.GetAll();
            return _mapper.Map<IEnumerable<ControlStructureDto>>(structures);
        }

        public ControlStructureDto? GetById(Guid id)
        {
            var structure = _repository.GetById(id);
            return structure != null ? _mapper.Map<ControlStructureDto>(structure) : null;
        }

        public bool Delete(Guid id)
        {
            var structure = _repository.GetById(id);
            if (structure != null)
            {
                _repository.Delete(id);
                return true;
            }
            return false;
        }
    }
}