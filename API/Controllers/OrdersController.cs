﻿using Application.Brands.Commands;
using Application.Brands.Queries;
using Application.Common.Models;
using Application.Items.Queries;
using Application.Orders.Commands;
using Application.Orders.Queries;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class OrdersController: ApiControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<PaginatedList<OrderDto>>> GetOrdersWithPagination([FromQuery] GetOrdersWithPaginationQuery query)
        {
            return await Mediator.Send(query);
        }

        [HttpPost]
        public async Task<ActionResult<Order>> Create([FromBody] CreateOrderCommand command)
        {
          
            return await Mediator.Send(command);
        }

        [HttpPost("Update")]
        public async Task<ActionResult<Order>> Update([FromForm] UpdateOrderCommand command)
        {

            return await Mediator.Send(command);
        }
    }
}
