using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.HouseRoom;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class HouseRoomController : ControllerBase
    {
        private readonly IHouseRoomService _service;
        public HouseRoomController(IHouseRoomService service)
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
        public async Task<IActionResult> Create([FromBody] HouseRoomCreateDto houseRoom)
        {
            await _service.InsertAsync(houseRoom);
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

        [HttpPut]
        [Route("Edit/{id}")]
        public async Task<IActionResult> Edit([FromRoute] int id, [FromBody] HouseRoomEditDto houseRoom)
        {
            await _service.UpdateAsync(id, houseRoom);
            return Ok();
        }
    }
}
