using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.House;
using ServiceLayer.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class HouseService : IHouseService
    {

        private readonly IHouseRepository _repository;
        private readonly IMapper _mapper;

        public HouseService(IHouseRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task DeleteAsync(int id)
        {
            var house = await _repository.GetAsync(id);
            await _repository.DeleteAsync(house);
        }

        public async Task<List<HouseListDto>> GetAllAsync()
        {
            var result = await _repository.GetAllHouseAsync();
            return _mapper.Map<List<HouseListDto>>(result);
        }

        public async Task<HouseListDto> GetAsync(int id)
        {
            var model = await _repository.GetAsync(id);
            var result = _mapper.Map<HouseListDto>(model);
            return result;
        }

        public async Task InsertAsync(HouseCreateDto house)
        {
            await _repository.CreateAsync(_mapper.Map<House>(house));

        }

        public async Task UpdateAsync(int id, HouseEditDto house)
        {

            var entity = await _repository.GetAsync(id);
            _mapper.Map(house, entity);
            await _repository.UpdateAsync(entity);
        }
    }
}
