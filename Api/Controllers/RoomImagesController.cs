using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.RoomImages;
using ServiceLayer.Services.Interfaces;
using System.Threading.Tasks;

namespace Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class RoomImagesController : ControllerBase
    {
        private readonly IRoomImagesService _service;
        public RoomImagesController(IRoomImagesService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("GetAll/{id}")]
        public async Task<IActionResult> GetAll([FromRoute] int id)
        {
            return Ok(await _service.GetAllAsync(id));
        }


        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create([FromBody] CreateRoomImageDto roomImageDto)
        {
            await _service.InsertAsync(roomImageDto);
            return Ok();
        }

        [HttpGet]
        [Route("GetById/{id}")]

        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var result = await _service.GetAsync(id);
            return Ok(result);
        }



        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await _service.DeleteAsync(id);
            return Ok();
        }
    }
}
