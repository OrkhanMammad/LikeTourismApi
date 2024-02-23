using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Villa;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class VillaService : IVillaService
    {
        private readonly IVillaRepository _repository;
        private readonly IMapper _mapper;

        public VillaService(IVillaRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task DeleteAsync(int id)
        {
            var villa = await _repository.GetAsync(id);
            await _repository.DeleteAsync(villa);
        }

        public async Task<List<VillasDto>> GetAllAsync()
        {
            var result = await _repository.GetAllAsync();
            return _mapper.Map<List<VillasDto>>(result);

        }

        public async Task InsertAsync(VillaCreateDto villa)
        {
            await _repository.CreateAsync(_mapper.Map<Villa>(villa));
        }
    }
}
