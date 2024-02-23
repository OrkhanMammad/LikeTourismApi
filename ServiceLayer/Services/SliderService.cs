using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Slider;
using ServiceLayer.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class SliderService : ISliderService
    {
        private readonly ISliderRepository _repository;
        private readonly IMapper _mapper;

        public SliderService(ISliderRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task DeleteAsync(int id)
        {
            var slider = await _repository.GetAsync(id);
            await _repository.DeleteAsync(slider);
        }

        public async Task<List<SliderDto>> GetAllAsync()
        {
            var result = await _repository.GetAllAsync();

            return _mapper.Map<List<SliderDto>>(result);
        }

        public async Task<SliderDto> GetAsync(int id)
        {
            var model = await _repository.GetAsync(id);
            var result = _mapper.Map<SliderDto>(model);
            return result;
        }

        public async Task InsertAsync(SliderCreateDto slider)
        {
            await _repository.CreateAsync(_mapper.Map<Slider>(slider));

        }

        public async Task UpdateAsync(int id, SliderEditDto slider)
        {
            var entity = await _repository.GetAsync(id);
            _mapper.Map(slider, entity);
            await _repository.UpdateAsync(entity);
        }
    }
}
