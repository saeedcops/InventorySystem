using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Engineers.Commands
{
   public record UpdateEngineersCommand : IRequest<Engineer>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }

    public class UpdateEngineersCommandHandler : IRequestHandler<UpdateEngineersCommand, Engineer>
    {
        private readonly IApplicationDbContext _context;

        public UpdateEngineersCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Engineer> Handle(UpdateEngineersCommand request, CancellationToken cancellationToken)
        {

           var entity=await _context.Engineers.FirstOrDefaultAsync(b=> b.Id == request.Id);
            if (entity == null)
                throw new NotFoundException($"No Brands with {request.Id}");
            entity.Name = request.Name;
            //entity.Description = request.Description;
             _context.Engineers.Update(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity;
        }
    }

}
