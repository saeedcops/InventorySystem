using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Vendors.Commands
{
 public record CreateVendorCommand : IRequest<Vendor>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string? Address { get; set; }
    }

    public class CreateVendorCommandHandler : IRequestHandler<CreateVendorCommand, Vendor>
    {
        private readonly IApplicationDbContext _context;

        public CreateVendorCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Vendor> Handle(CreateVendorCommand request, CancellationToken cancellationToken)
        {
            var entity = new Vendor
            {
                Name = request.Name,
                Email = request.Email,
                Phone = request.Phone,
                Address = request.Address
            };

            entity = _context.Vendors.Add(entity).Entity;

            await _context.SaveChangesAsync(cancellationToken);

            return entity;
        }
    }
}
