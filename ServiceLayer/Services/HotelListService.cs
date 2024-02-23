using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.HotelList;
using ServiceLayer.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class HotelListService : IHotelListService
    {


        private readonly IHotelListRepository _repository;
        private readonly IMapper _mapper;

        public HotelListService(IHotelListRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task DeleteAsync(int id)
        {
            var hotel = await _repository.GetHotelsListAsync(id);
            await _repository.DeleteAsync(hotel);
        }

        public async Task<List<HotelListDto>> GetAllAsync(int id)
        {
            var result = await _repository.FindAllAsync(m => m.FamousCityId == id);

            return _mapper.Map<List<HotelListDto>>(result);
        }
        public async Task<HotelListDto> GetAsync(int id)
        {
            var model = await _repository.GetHotelListAsync(id);
            var result = _mapper.Map<HotelListDto>(model);
            return result;
        }

        public async Task InsertAsync(HotelListCreateDto hotelList)
        {
            await _repository.CreateAsync(_mapper.Map<HotelList>(hotelList));

        }

        public async Task UpdateAsync(int id, HotelListEditDto hotelList)
        {
            var entity = await _repository.GetAsync(id);
            _mapper.Map(hotelList, entity);
            await _repository.UpdateAsync(entity);
        }

        public async Task<IEnumerable<HotelListDto>> GetAllNameAsync(string search)
        {
            return _mapper.Map<IEnumerable<HotelListDto>>(await _repository.FindAllAsync(m => m.Name.Contains(search)));
        }
    }
}
