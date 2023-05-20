using Application.Common.Interfaces;
using Application.Common.Security;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Brands.Queries
{
    [Authorize(Roles ="Administrator")]
    public record GetBrandsQuery : IRequest<List<Brand>>
    {
    }

    public class GetItemQueryHandler : IRequestHandler<GetBrandsQuery, List<Brand>>
    {
        private readonly IApplicationDbContext _context;
        //  private readonly IMapper _mapper;

        public GetItemQueryHandler(IApplicationDbContext context)
        {
            _context = context;
            // _mapper = mapper;
        }

        public async Task<List<Brand>> Handle(GetBrandsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Brands.ToListAsync();
        }
    }
}
