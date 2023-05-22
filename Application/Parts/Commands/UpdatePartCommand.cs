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

namespace Application.Parts.Commands
{
   public record UpdatePartCommand : IRequest<Part>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }

    public class UpdatePartCommandHandler : IRequestHandler<UpdatePartCommand, Part>
    {
        private readonly IApplicationDbContext _context;

        public UpdatePartCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Part> Handle(UpdatePartCommand request, CancellationToken cancellationToken)
        {

           var entity=await _context.Parts.FirstOrDefaultAsync(b=> b.Id == request.Id);
            if (entity == null)
                throw new NotFoundException($"No Brands with {request.Id}");
            entity.Name = request.Name;
            entity.Description = request.Description;
             _context.Parts.Update(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity;
        }
    }

}
