using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{

     public class SupplyOrder : BaseAuditableEntity
    {
  
        public string Name { get; set; }
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
        public byte[]? Document { get; set; }
        public List<Item>? SupplyOrderItems { get; set; }
        public List<Part>? SupplyOrderParts { get; set; }
    }
}
