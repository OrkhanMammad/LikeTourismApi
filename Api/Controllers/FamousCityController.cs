using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.FamousCity;
using ServiceLayer.Services.Interfaces;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FamousCityController : ControllerBase
    {
        private readonly IFamousCityService _service;
        public FamousCityController(IFamousCityService service)
        {
            _service = service;
        }


        [HttpGet]
        [Route("GetAll")]

        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpGet]
        [Route("GetById/{id}")]

        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var result = await _service.GetAsync(id);
            return Ok(result);
        }


        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create([FromBody] FamousCityCreateDto famousCity)
        {
            await _service.InsertAsync(famousCity);
            return Ok();
        }


        [HttpPut]
        [Route("Edit/{id}")]
        public async Task<IActionResult> Edit([FromRoute] int id, [FromBody] FamousCityEditDto famousCity)
        {
            await _service.UpdateAsync(id, famousCity);
            return Ok();
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await _service.DeleteAsync(id);
            return Ok();
        }

        [HttpGet]
        [Route("GetAllByName/{txt}")]
        public async Task<IActionResult> GetAllByName([FromRoute] string txt)
        {
            return Ok(await _service.GetCityNameAsync(txt));
        }
    }
}
