using Application.Brands.Commands;
using Application.Brands.Queries;
using Application.Orders.Commands;
using Application.Orders.Queries;
using Application.Vendors.Commands;
using Application.Vendors.Queries;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class OrdersController: ApiControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<Order>>> Get()
        {
            return await Mediator.Send(new GetOrdersQueries());
        }


        [HttpPost]
        public async Task<ActionResult<Order>> Create([FromForm] CreateOrderCommand command)
        {
          
            return await Mediator.Send(command);
        }
    }
}
