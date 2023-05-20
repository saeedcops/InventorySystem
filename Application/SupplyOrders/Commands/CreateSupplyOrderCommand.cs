using Application.Common.Interfaces;
using Application.Common.Models;
using Domain.Entities;
using Domain.Enum;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.SupplyOrders.Commands
{
  public record CreateSupplyOrderCommand : IRequest<SupplyOrder>
    {
        public int VendorId { get; set; }
        public string Name { get; set; }
        public List<ItemDto>? SupplyOrderItems { get; set; }
        public byte[]? Document { get; set; }
    }

    public class CreateSupplyOrderCommandHandler : IRequestHandler<CreateSupplyOrderCommand, SupplyOrder>
    {
        private readonly IApplicationDbContext _context;

        public CreateSupplyOrderCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<SupplyOrder> Handle(CreateSupplyOrderCommand request, CancellationToken cancellationToken)
        {
            var items = new List<Item>();
            foreach (var itemDto in request.SupplyOrderItems)
            {
                items.Add(new Item
                {
                    Name = itemDto.Name,
                    VendorId = itemDto.VendorId,
                    Vendor =await _context.Vendors.FirstOrDefaultAsync(v => v.Id == itemDto.VendorId),
                    Description = itemDto.Description,
                    Image = itemDto.Image,
                    ItemTypeId = itemDto.ItemTypeId,
                    ItemType = await _context.ItemTypes.FirstOrDefaultAsync(v => v.Id == itemDto.ItemTypeId),
                    Model = itemDto.Model,
                    OracleCode = itemDto.OracleCode,
                    SerialNumber = itemDto.SerialNumber,
                    WarehouseCode = itemDto.WarehouseCode,
                    WarehouseId = itemDto.WarehouseId,
                    Warehouse = await _context.Warehouses.FirstOrDefaultAsync(v => v.Id == itemDto.WarehouseId),
                    BrandId = itemDto.BrandId,
                    Brand = await _context.Brands.FirstOrDefaultAsync(v => v.Id == itemDto.BrandId),
                    PartNumber = itemDto.PartNumber,

                });
            }

            var entity = new SupplyOrder
            {
                Vendor =await _context.Vendors.FirstOrDefaultAsync(b => b.Id == request.VendorId),
                VendorId = request.VendorId,
                Name = request.Name,
                Document = request.Document,
                SupplyOrderItems = items,

            };


            entity = _context.SupplyOrders.Add(entity).Entity;

            await _context.SaveChangesAsync(cancellationToken);

            return entity;
        }
    }
}
