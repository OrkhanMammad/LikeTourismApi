using ServiceLayer.DTOs.Category;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<List<CategoryDto>> GetAllAsync();

        Task InsertAsync(CategoryCreateDto category);

    }
}
