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

namespace Application.Customers.Commands
{
   public record UpdateCustomersCommand : IRequest<Customer>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }

    public class UpdateCustomersCommandHandler : IRequestHandler<UpdateCustomersCommand, Customer>
    {
        private readonly IApplicationDbContext _context;

        public UpdateCustomersCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Customer> Handle(UpdateCustomersCommand request, CancellationToken cancellationToken)
        {

           var entity=await _context.Customers.FirstOrDefaultAsync(b=> b.Id == request.Id);
            if (entity == null)
                throw new NotFoundException($"No Customer with {request.Id}");
            entity.Name = request.Name;
           // entity.Description = request.Description;
             _context.Customers.Update(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity;
        }
    }

}
