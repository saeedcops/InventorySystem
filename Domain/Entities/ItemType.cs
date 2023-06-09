﻿using Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
     public class ItemType : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
