using ServiceLayer.DTOs.Slider;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ISliderService
    {

        Task<List<SliderDto>> GetAllAsync();

        Task<SliderDto> GetAsync(int id);

        Task UpdateAsync(int id, SliderEditDto slider);

        Task DeleteAsync(int id);


        Task InsertAsync(SliderCreateDto slider);


    }
}
