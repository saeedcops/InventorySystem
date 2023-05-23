using Application.Common.Security;
using Application.Items.Commands;
using Application.Items.Queries;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    
    public class ItemsController: ApiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Item>>> Get()
        {
            return await Mediator.Send(new GetItemsQuery ());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Item>> Get(int id)
        {
            return await Mediator.Send(new GetItemQuery { Id = id });
        }


        [HttpPost]
        public async Task<ActionResult<Item>> Create([FromForm] CreateItemCommand command)
        {
          
            return await Mediator.Send(command);
        }

        [HttpPost("Update")]
        public async Task<ActionResult<Item>> Update([FromForm] UpdateItemsCommand command)
        {

            return await Mediator.Send(command);
        }
    }
}
