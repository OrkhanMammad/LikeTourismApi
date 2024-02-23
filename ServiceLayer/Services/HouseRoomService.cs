using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.HouseRoom;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class HouseRoomService : IHouseRoomService
    {

        private readonly IHouseRoomRepository _repository;
        private readonly IMapper _mapper;

        public HouseRoomService(IHouseRoomRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task DeleteAsync(int id)
        {

            var houseRoom = await _repository.GetAsync(id);
            await _repository.DeleteAsync(houseRoom);
        }

        public async Task<List<HouseRoomDto>> GetAllAsync(int id)
        {
            var result = await _repository.FindAsync(m => m.HouseId == id);

            return _mapper.Map<List<HouseRoomDto>>(result);
        }

        public async Task<HouseRoomDto> GetAsync(int id)
        {
            var model = await _repository.GetReservationAsync(id);
            var result = _mapper.Map<HouseRoomDto>(model);
            return result;
        }

        public async Task InsertAsync(HouseRoomCreateDto houseRoom)
        {
            await _repository.CreateAsync(_mapper.Map<HouseRoom>(houseRoom));
        }

        public async Task UpdateAsync(int id, HouseRoomEditDto houseRoom)
        {
            var entity = await _repository.GetAsync(id);
            _mapper.Map(houseRoom, entity);
            await _repository.UpdateAsync(entity);
        }
    }
}
