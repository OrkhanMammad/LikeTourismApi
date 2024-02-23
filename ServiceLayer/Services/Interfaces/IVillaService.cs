using ServiceLayer.DTOs.Villa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IVillaService
    {
        Task<List<VillasDto>> GetAllAsync();
        Task InsertAsync(VillaCreateDto villa);
        Task DeleteAsync(int id);


    }
}
