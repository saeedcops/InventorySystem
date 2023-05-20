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
        public List<string>? OrderItemSerialNumber { get; set; }
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
            foreach (var serial in request.OrderItemSerialNumber)
            {
                 items.Add(await _context.Items.FirstOrDefaultAsync(x => x.SerialNumber.Equals(serial)));
            }
          
            var entity = new Order
            {
                Customer = _context.Customers.FirstOrDefault(b => b.Id == request.CustomerId),
                CustomerId = request.CustomerId,
                Engineer = _context.Engineers.FirstOrDefault(b => b.Id == request.EngineerId),
                EngneerId = request.EngineerId,
                OrderType =(OrderType) request.OrderType,
                Document = request.Document,
                OrderItems = items,

            };

            entity = _context.Orders.Add(entity).Entity;

            await _context.SaveChangesAsync(cancellationToken);

            return entity;
        }
    }
}
