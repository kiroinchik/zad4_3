using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class Product
    {
        public int PId { get; set; }
        public int CategoryId { get; set; }
        public string PName { get; set; } = null!;
        public string PDesc { get; set; } = null!;
        public double Price { get; set; }
        public bool IsInShop { get; set; }
        public string Color { get; set; } = null!;
        public string PType { get; set; } = null!;
        public bool IsOnSale { get; set; }
        public bool Shiny { get; set; }
    }
}
