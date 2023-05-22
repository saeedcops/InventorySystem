using Application.Common.Interfaces;
using Application.Common.Security;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Parts.Queries
{
   
    public record GetPartQuery : IRequest<Part>
    {
        public int Id { get; init; }
    }

    public class GetPartQueryHandler : IRequestHandler<GetPartQuery, Part>
    {
        private readonly IApplicationDbContext _context;
      //  private readonly IMapper _mapper;

        public GetPartQueryHandler(IApplicationDbContext context)
        {
            _context = context;
           // _mapper = mapper;
        }

        public async Task<Part> Handle(GetPartQuery request, CancellationToken cancellationToken)
        {
            return await _context.Parts.FirstOrDefaultAsync(i => i.Id == request.Id);
        }
    }
}
