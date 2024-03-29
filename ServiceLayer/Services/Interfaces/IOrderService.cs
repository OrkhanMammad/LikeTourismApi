﻿using ServiceLayer.DTOs.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IOrderService
    {
        Task<List<OrderDto>> GetAllAsync();

        Task CreateAsync(OrderDto orderDto);

    }
}
