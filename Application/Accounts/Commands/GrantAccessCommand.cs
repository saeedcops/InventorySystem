using Application.Common.Interfaces;
using Application.Common.Models;
using Application.Common.Security;
using MediatR;

namespace Application.Accounts.Commands
{
    [Authorize(Roles ="Administrator")]
    public record GrantAccessCommand : IRequest<bool>
    {
        public string Email { get; set; }
        public string Role { get; set; }
    }

    public class GrantAccessCommandHandler : IRequestHandler<GrantAccessCommand, bool>
    {
        private readonly IIdentityService _context;

        public GrantAccessCommandHandler(IIdentityService context)
        {
            _context = context;

        }

        public async Task<bool> Handle(GrantAccessCommand request, CancellationToken cancellationToken)
        {

            return await _context.AuthorizeAsync(request.Email, request.Role);
        }
    }
}
