using Application.Common.Interfaces;
using Domain.Entities;
using Domain.Enum;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Orders.Commands
{

  public record CreateOrderCommand : IRequest<Order>
    {
        public int CustomerId { get; set; }
        public int EngineerId { get; set; }
        public int OrderType { get; set; }
        public List<string>? OrderItemsPartNumber { get; set; }
        public List<string>? OrderPartsPartNumber { get; set; }
        public byte[]? Document { get; set; }
    }

    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Order>
    {
        private readonly IApplicationDbContext _context;

        public CreateOrderCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Order> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var items = new List<Item>();
            var Parts = new List<Part>();
            if (request.OrderItemsPartNumber != null)
                foreach (var serial in request.OrderItemsPartNumber)
                {
                    var item = await _context.Items.FirstOrDefaultAsync(x => x.PartNumber.Equals(serial));
                    item.EngneerId = request.EngineerId;
                    item.Engineer = _context.Engineers.FirstOrDefault(b => b.Id == request.EngineerId);
                    item.CustomerId = request.CustomerId;
                    item.ItemStatus = (ItemStatus)request.OrderType;
                     items.Add(item);
                }

            if(request.OrderPartsPartNumber != null)
                foreach (var serial in request.OrderPartsPartNumber)
                {
                    var part = await _context.Parts.FirstOrDefaultAsync(x => x.PartNumber.Equals(serial));
                    part.EngneerId = request.EngineerId;
                    part.Engineer = _context.Engineers.FirstOrDefault(b => b.Id == request.EngineerId);
                    part.CustomerId = request.CustomerId;
                    part.PartStatus = (ItemStatus)request.OrderType;
                    Parts.Add(part);
                }

            var entity = new Order
            {
               // Customer = _context.Customers.FirstOrDefault(b => b.Id == request.CustomerId),
                CustomerId = request.CustomerId,
               // Engineer = _context.Engineers.FirstOrDefault(b => b.Id == request.EngineerId),
                EngineerId = request.EngineerId,
                OrderType =(OrderType) request.OrderType,
                Document = request.Document,
                OrderItems = items,
                OrderParts = Parts,
            };

            entity = _context.Orders.Add(entity).Entity;

            await _context.SaveChangesAsync(cancellationToken);

            return entity;
        }
    }
}
