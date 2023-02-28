using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Init.Api.Models
{
    public partial class InventoryItem
    {
        [Key]
        public Guid Id { get; set; }
        public string Description { get; set; } = null!;
        public short Quantity { get; set; }
    }
}
