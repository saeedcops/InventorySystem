using Application.Accounts.Commands;
using Application.Accounts.Queries;
using Application.Brands.Commands;
using Application.Brands.Queries;
using Application.Common.Models;
using Application.Engineers.Commands;
using Application.Engineers.Queries;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class AccountsController: ApiControllerBase
    {

        [HttpPost("Login")]
        public async Task<ActionResult<TokenResponse>> Login(LoginUserQuery login)
        {
            return await Mediator.Send(login);
        }


        [HttpPost("Register")]
        public async Task<ActionResult<Result>> Register([FromForm] RegisterUserCommand command)
        {
          
            return await Mediator.Send(command);
        }

        [HttpPost("Authorize")]
        public async Task<ActionResult<bool>> Authorize([FromForm] GrantAccessCommand command)
        {

            return await Mediator.Send(command);
        }

        [HttpPost("Revoke")]
        public async Task<ActionResult<bool>> Revoke([FromForm] RevokeAccessCommand command)
        {

            return await Mediator.Send(command);
        }
    }
}
