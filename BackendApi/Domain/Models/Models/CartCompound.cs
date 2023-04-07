using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class CartCompound
    {
        public int CId { get; set; }
        public int PId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
