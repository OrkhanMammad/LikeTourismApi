using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.HotelListImages;
using ServiceLayer.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class HotelListImagesService : IHotelListImagesService
    {

        private readonly IHotelListImagesRepository _repository;
        private readonly IMapper _mapper;

        public HotelListImagesService(IHotelListImagesRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task DeleteAsync(int id)
        {
            var hotel = await _repository.GetAsync(id);
            await _repository.DeleteAsync(hotel);
        }

        public async Task<List<HotelListImagesDto>> GetAllAsync(int id)
        {
            var result = await _repository.FindAsync(m => m.HotelListId == id);

            return _mapper.Map<List<HotelListImagesDto>>(result);
        }

        public async Task<HotelListImagesDto> GetAsync(int id)
        {
            var model = await _repository.GetAsync(id);
            var result = _mapper.Map<HotelListImagesDto>(model);
            return result;
        }

        public async Task InsertAsync(CreateHotelListImagesDto createHotel)
        {
            await _repository.CreateAsync(_mapper.Map<HotelListImages>(createHotel));

        }

        public async Task UpdateAsync(int id, HotelListImagesEditDto hotelList)
        {
            var entity = await _repository.GetAsync(id);
            _mapper.Map(hotelList, entity);
            await _repository.UpdateAsync(entity);
        }
    }
}
