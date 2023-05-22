using Application.Common.Interfaces;
using Domain.Entities;
using Domain.Enum;
using MediatR;

namespace Application.Parts.Commands
{
   public record CreatePartCommand : IRequest<Part>
    {
        public string PartNumber { get; set; }
        public string? OracleCode { get; set; }
        public string? WarehouseCode { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string? Description { get; set; }
        public int ItemTypeId { get; set; }
        public int BrandId { get; set; }
        public int WarehouseId { get; set; }
        public int VendorId { get; set; }
    }

    public class CreatePartCommandHandler : IRequestHandler<CreatePartCommand, Part>
    {
        private readonly IApplicationDbContext _context;

        public CreatePartCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Part> Handle(CreatePartCommand request, CancellationToken cancellationToken)
        {
            var entity = new Part
            {
                Name = request.Name,
                Brand = _context.Brands.FirstOrDefault(b => b.Id == request.BrandId),
                BrandId = request.BrandId,
                Warehouse = _context.Warehouses.FirstOrDefault(b => b.Id == request.WarehouseId),
                WarehouseId = request.WarehouseId,
                Vendor = _context.Vendors.FirstOrDefault(b => b.Id == request.VendorId),
                VendorId = request.VendorId,
                Description = request.Description,
                Model = request.Model,
                PartNumber = request.PartNumber,
                WarehouseCode = request.WarehouseCode,
                OracleCode = request.OracleCode,


            };

            //entity.AddDomainEvent(new TodoItemCreatedEvent(entity));

            _context.Parts.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity;
        }
    }

}
