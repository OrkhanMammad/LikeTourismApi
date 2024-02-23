using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.HouseRoomImages;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class HouseRoomImagesService : IHouseRoomImagesService
    {

        private readonly IHouseRoomImagesRepository _repository;
        private readonly IMapper _mapper;

        public HouseRoomImagesService(IHouseRoomImagesRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<HouseRoomImagesDto>> GetAllAsync(int id)
        {
            var result = await _repository.FindAsync(m => m.HouseRoomId == id);

            return _mapper.Map<List<HouseRoomImagesDto>>(result);
        }

        public async Task<HouseRoomImagesDto> GetAsync(int id)
        {
            var model = await _repository.GetAsync(id);
            var result = _mapper.Map<HouseRoomImagesDto>(model);
            return result;
        }

        public async Task InsertAsync(CreateHouseRoomImagesDto houseRoomImagesDto)
        {
            await _repository.CreateAsync(_mapper.Map<HouseRoomImages>(houseRoomImagesDto));

        }

        public async Task DeleteAsync(int id)
        {
            var hotel = await _repository.GetAsync(id);
            await _repository.DeleteAsync(hotel);
        }
    }
}
