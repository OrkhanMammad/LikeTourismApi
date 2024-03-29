﻿using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Order;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class OrderService : IOrderService
    {

        private readonly IOrderRepository _repository;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<OrderDto>> GetAllAsync()
        {
            var result = await _repository.GetAllAsync();

            return _mapper.Map<List<OrderDto>>(result);
        }

        public async Task CreateAsync(OrderDto orderDto)
        {
            var model = _mapper.Map<Order>(orderDto);
            await _repository.CreateAsync(model);
        }
    }
}
