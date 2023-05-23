using Application.Brands.Commands;
using Application.Brands.Queries;
using Application.ItemTypes.Commands;
using Application.ItemTypes.Queries;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ItemTypesController: ApiControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<ItemType>>> Get()
        {
            return await Mediator.Send(new GetItemTypesQuery());
        }


        [HttpPost]
        public async Task<ActionResult<ItemType>> Create([FromForm] CreateItemTypeCommand command)
        {
          
            return await Mediator.Send(command);
        }

        [HttpPost("Update")]
        public async Task<ActionResult<ItemType>> Update([FromForm] UpdateItemTypesCommand command)
        {

            return await Mediator.Send(command);
        }
    }
}
