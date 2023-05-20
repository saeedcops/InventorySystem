using Application.Common.Interfaces;
using Domain.Entities;
using Domain.Enum;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Items.Commands
{
   public record CreateItemCommand : IRequest<Item>
    {
        public string? SerialNumber { get; set; }
        public string? OracleCode { get; set; }
        public string? WarehouseCode { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string? PartNumber { get; set; }
        public string? Description { get; set; }
        public int ItemTypeId { get; set; }
        public int BrandId { get; set; }
        public int WarehouseId { get; set; }
        public int VendorId { get; set; }
    }

    public class CreateItemCommandHandler : IRequestHandler<CreateItemCommand, Item>
    {
        private readonly IApplicationDbContext _context;

        public CreateItemCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Item> Handle(CreateItemCommand request, CancellationToken cancellationToken)
        {
            var entity = new Item
            {
                Name = request.Name,
                Brand = _context.Brands.FirstOrDefault(b => b.Id == request.BrandId),
                BrandId = request.BrandId,
                Warehouse = _context.Warehouses.FirstOrDefault(b => b.Id == request.WarehouseId),
                WarehouseId = request.WarehouseId,
                Vendor = _context.Vendors.FirstOrDefault(b => b.Id == request.VendorId),
                VendorId = request.VendorId,
                ItemType = _context.ItemTypes.FirstOrDefault(b => b.Id == request.ItemTypeId),
                ItemTypeId = request.ItemTypeId,
                Description = request.Description,
                PartNumber = request.PartNumber,
                Model = request.Model,
                SerialNumber = request.SerialNumber,
                WarehouseCode = request.WarehouseCode,
                OracleCode = request.OracleCode,


            };

            //entity.AddDomainEvent(new TodoItemCreatedEvent(entity));

            _context.Items.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity;
        }
    }

}
