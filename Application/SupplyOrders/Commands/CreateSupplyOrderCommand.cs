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
        public string Name { get; set; }
        public List<ItemDto>? SupplyOrderItems { get; set; }
        public List<PartDto>? SupplyOrderParts { get; set; }
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
            if(request.SupplyOrderItems != null)
                foreach (var itemDto in request.SupplyOrderItems)
                {
                    var item= new Item
                    {
                        Description = itemDto.Description,
                        Image = itemDto.Image,
                        ItemTypeId = itemDto.ItemTypeId,
                       // ItemType = await _context.ItemTypes.FirstOrDefaultAsync(v => v.Id == itemDto.ItemTypeId),
                        Model = itemDto.Model,
                        OracleCode = itemDto.OracleCode,
                        PartNumber = itemDto.PartNumber,
                        WarehouseId = itemDto.WarehouseId,
                       // Warehouse = await _context.Warehouses.FirstOrDefaultAsync(v => v.Id == itemDto.WarehouseId),
                        BrandId = itemDto.BrandId,
                        //Brand = await _context.Brands.FirstOrDefaultAsync(v => v.Id == itemDto.BrandId),

                    };
                    await _context.Items.AddAsync(item);
                    await _context.SaveChangesAsync(cancellationToken);
                    items.Add(item);
                }
            var parts = new List<Part>();
            if (request.SupplyOrderParts != null)
                foreach (var itemDto in request.SupplyOrderParts)
                {
                    var part=new Part
                    {
                        Description = itemDto.Description,
                        Image = itemDto.Image,
                        // ItemType = await _context.ItemTypes.FirstOrDefaultAsync(v => v.Id == itemDto.ItemTypeId),
                        Model = itemDto.Model,
                        OracleCode = itemDto.OracleCode,
                        PartNumber = itemDto.PartNumber,
                        WarehouseId = itemDto.WarehouseId,
                        // Warehouse = await _context.Warehouses.FirstOrDefaultAsync(v => v.Id == itemDto.WarehouseId),
                        BrandId = itemDto.BrandId,
                        //Brand = await _context.Brands.FirstOrDefaultAsync(v => v.Id == itemDto.BrandId),

                    };
                    await _context.Parts.AddAsync(part);
                    await _context.SaveChangesAsync(cancellationToken);
                    parts.Add(part);
                }

            var entity = new SupplyOrder
            {
                Name = request.Name,
                Document = request.Document,
                SupplyOrderItems = items,
                SupplyOrderParts = parts

            };


            entity = _context.SupplyOrders.Add(entity).Entity;

            await _context.SaveChangesAsync(cancellationToken);

            return entity;
        }
    }
}
