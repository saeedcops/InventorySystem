using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Vendors.Queries
{
 
 public record GetVendorsQuery : IRequest<List<Vendor>>
    {
    }

    public class GetVendorsQueryHandler : IRequestHandler<GetVendorsQuery, List<Vendor>>
    {
        private readonly IApplicationDbContext _context;
        //  private readonly IMapper _mapper;

        public GetVendorsQueryHandler(IApplicationDbContext context)
        {
            _context = context;
            // _mapper = mapper;
        }

        public async Task<List<Vendor>> Handle(GetVendorsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Vendors.ToListAsync();
        }
    }
}
