using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.Order;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _service;
        private readonly IEmailService _emailService;
        public OrderController(IOrderService service, IEmailService emailService)
        {
            _service = service;
            _emailService = emailService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpPost]
        [Route("CreateOrder")]
        public async Task<IActionResult> Create([FromBody] OrderMailDto orderMailDto)
        {
            OrderDto orderDto = new OrderDto();
            orderDto.ReservationId = orderMailDto.ReservationId;
            orderDto.HotelListId = orderMailDto.HotelListId;
            orderDto.Email = orderMailDto.Email;
            orderDto.PhoneNumber = orderMailDto.PhoneNumber;
            orderDto.FullName = orderMailDto.FullName;





            await _service.CreateAsync(orderDto);
            _emailService.OrderCreate(orderMailDto.Email, orderMailDto.FullName,  orderMailDto.ReservationName, orderMailDto.PhoneNumber);
            return Ok();
        }
    }
}
