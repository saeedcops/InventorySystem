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

namespace Application.Items.Commands
{
   public record UpdateItemsCommand : IRequest<Item>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }

    public class UpdateItemsCommandHandler : IRequestHandler<UpdateItemsCommand, Item>
    {
        private readonly IApplicationDbContext _context;

        public UpdateItemsCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Item> Handle(UpdateItemsCommand request, CancellationToken cancellationToken)
        {

           var entity=await _context.Items.FirstOrDefaultAsync(b=> b.Id == request.Id);
            if (entity == null)
                throw new NotFoundException($"No Items with {request.Id}");
            entity.Name = request.Name;
            entity.Description = request.Description;
             _context.Items.Update(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity;
        }
    }

}
