using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Vendors.Commands
{
   public record UpdateVendorCommand : IRequest<Vendor>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string? Address { get; set; }
    }

    public class UpdateVendorCommandHandler : IRequestHandler<UpdateVendorCommand, Vendor>
    {
        private readonly IApplicationDbContext _context;

        public UpdateVendorCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Vendor> Handle(UpdateVendorCommand request, CancellationToken cancellationToken)
        {

           var entity=await _context.Vendors.FirstOrDefaultAsync(b=> b.Id == request.Id);
            if (entity == null)
                throw new NotFoundException($"No Vendors with {request.Id}");

            entity.Name = request.Name;
            entity.Email = request.Email;
            entity.Phone = request.Phone;
            entity.Address = request.Address;
             _context.Vendors.Update(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity;
        }
    }

}
