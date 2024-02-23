using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.HouseImages;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class HouseImagesService : IHouseImagesService
    {

        private readonly IHouseImagesRepository _repository;
        private readonly IMapper _mapper;

        public HouseImagesService(IHouseImagesRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task DeleteAsync(int id)
        {
            var hotel = await _repository.GetAsync(id);
            await _repository.DeleteAsync(hotel);
        }

        public async Task<List<HouseImagesDto>> GetAllAsync(int id)
        {
            var result = await _repository.FindAsync(m => m.HouseId == id);

            return _mapper.Map<List<HouseImagesDto>>(result);
        }

        public async Task<HouseImagesDto> GetAsync(int id)
        {
            var model = await _repository.GetAsync(id);
            var result = _mapper.Map<HouseImagesDto>(model);
            return result;
        }

        public async Task InsertAsync(HouseImagesCreateDto house)
        {
            await _repository.CreateAsync(_mapper.Map<HouseImages>(house));
        }
    }
}
