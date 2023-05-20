using Domain.Entities;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Models
{
    public class ItemDto
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
        public int? SupplyOrderId { get; set; }
        public int WarehouseId { get; set; }
        public int VendorId { get; set; }
        public byte[]? Image { get; set; }
    }
}
