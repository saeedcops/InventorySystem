using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Orders.Queries
{
    public record GetOrdersQueries : IRequest<List<Order>>
    {
    }

    public class GetOrdersQueriesHandler : IRequestHandler<GetOrdersQueries, List<Order>>
    {
        private readonly IApplicationDbContext _context;
        //  private readonly IMapper _mapper;

        public GetOrdersQueriesHandler(IApplicationDbContext context)
        {
            _context = context;
            // _mapper = mapper;
        }

        public async Task<List<Order>> Handle(GetOrdersQueries request, CancellationToken cancellationToken)
        {
            return await _context.Orders
                .Include(o=>o.OrderItems)
                .Include(o=>o.Customer)
                .Include(o=>o.Engineer).ToListAsync();
        }
    }
}
