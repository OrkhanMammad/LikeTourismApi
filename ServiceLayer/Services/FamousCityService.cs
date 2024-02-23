using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.FamousCity;
using ServiceLayer.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class FamousCityService : IFamousCityService
    {
        private readonly IFamousCityRepository _repository;
        private readonly IMapper _mapper;

        public FamousCityService(IFamousCityRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task DeleteAsync(int id)
        {
            var famousCity = await _repository.GetAsync(id);
            await _repository.DeleteAsync(famousCity);

        }

        public async Task<List<FamousCityListDto>> GetAllAsync()
        {
            var model = await _repository.GetAllAsync();
            return _mapper.Map<List<FamousCityListDto>>(model);
        }

        public async Task<FamousCityListDto> GetAsync(int id)
        {
            var model = await _repository.GetAsync(id);
            var result = _mapper.Map<FamousCityListDto>(model);
            return result;
        }

        public async Task<IEnumerable<FamousCityDto>> GetCityNameAsync(string search)
        {

            return _mapper.Map<IEnumerable<FamousCityDto>>(await _repository.FindAllAsync(m => m.Name.Contains(search)));
        }

        public async Task InsertAsync(FamousCityCreateDto famousCity)
        {
            await _repository.CreateAsync(_mapper.Map<FamousCity>(famousCity));
        }
        public async Task UpdateAsync(int id, FamousCityEditDto famousCity)
        {
            var entity = await _repository.GetAsync(id);
            _mapper.Map(famousCity, entity);
            await _repository.UpdateAsync(entity);
        }
    }
}
