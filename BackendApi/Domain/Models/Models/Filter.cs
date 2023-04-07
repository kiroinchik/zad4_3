using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class Filter
    {
        public int CategoryId { get; set; }
        public int PId { get; set; }
        public string Color { get; set; } = null!;
        public string PType { get; set; } = null!;
        public bool IsOnSale { get; set; }
        public bool Shiny { get; set; }
        public int Price { get; set; }
    }
}
