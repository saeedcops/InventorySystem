using Application.Common.Interfaces;
using Application.Common.Security;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Items.Queries
{
   // [Authorize(Roles ="AddItem")]
    public record GetItemsQuery : IRequest<List< Item>>
    {
    }

    public class GetItemsQueryHandler : IRequestHandler<GetItemsQuery, List<Item>>
    {
        private readonly IApplicationDbContext _context;

        public GetItemsQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Item>> Handle(GetItemsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Items
                .Include(i => i.Brand)
                .Include(i => i.Customer)
                .Include(i => i.Engineer)
                .Include(i => i.Warehouse)
                .ToListAsync();
        }
    }
}
