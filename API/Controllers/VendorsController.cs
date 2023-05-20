using Application.Brands.Commands;
using Application.Brands.Queries;
using Application.Vendors.Commands;
using Application.Vendors.Queries;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class VendorsController: ApiControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<Vendor>>> Get()
        {
            return await Mediator.Send(new GetVendorsQuery ());
        }


        [HttpPost]
        public async Task<ActionResult<Vendor>> Create([FromForm] CreateVendorCommand command)
        {
          
            return await Mediator.Send(command);
        }
    }
}
