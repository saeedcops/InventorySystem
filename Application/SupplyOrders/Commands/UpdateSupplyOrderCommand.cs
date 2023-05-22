using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Application.Common.Models;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.SupplyOrders.Commands
{
   public record UpdateSupplyOrdersCommand : IRequest<SupplyOrder>
    {
        public int Id { get; set; }
        public int VendorId { get; set; }
        public string Name { get; set; }
        public List<ItemDto>? SupplyOrderItems { get; set; }
        public byte[]? Document { get; set; }
    }

    public class UpdateSupplyOrdersCommandHandler : IRequestHandler<UpdateSupplyOrdersCommand, SupplyOrder>
    {
        private readonly IApplicationDbContext _context;

        public UpdateSupplyOrdersCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<SupplyOrder> Handle(UpdateSupplyOrdersCommand request, CancellationToken cancellationToken)
        {

           var entity=await _context.SupplyOrders.FirstOrDefaultAsync(b=> b.Id == request.Id);
            if (entity == null)
                throw new NotFoundException($"No SupplyOrder with {request.Id}");

            var items = new List<Item>();
            foreach (var itemDto in request.SupplyOrderItems)
            {
                items.Add(new Item
                {
                    Name = itemDto.Name,
                    VendorId = itemDto.VendorId,
                    Vendor = await _context.Vendors.FirstOrDefaultAsync(v => v.Id == itemDto.VendorId),
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

                });
            }

          
            entity.Name = request.Name;
            entity.Document = request.Document;
            entity.SupplyOrderItems = items;
            entity.Vendor = await _context.Vendors.FirstOrDefaultAsync(v => v.Id == request.VendorId);
            entity.VendorId = request.VendorId;
             _context.SupplyOrders.Update(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity;
        }
    }

}
