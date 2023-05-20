using Application.Brands.Commands;
using Application.Brands.Queries;
using Application.SupplyOrders.Commands;
using Application.SupplyOrders.Queries;
using Application.Vendors.Commands;
using Application.Vendors.Queries;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class SupplyOrdersController: ApiControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<SupplyOrder>>> Get()
        {
            return await Mediator.Send(new GetSupplyOrdersQuery());
        }


        [HttpPost]
        public async Task<ActionResult<SupplyOrder>> Create([FromForm] CreateSupplyOrderCommand command)
        {
          
            return await Mediator.Send(command);
        }
    }
}
