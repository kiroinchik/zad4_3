using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class Booking
    {
        public int UId { get; set; }
        public int BId { get; set; }
        public int CId { get; set; }
        public double TotalPrice { get; set; }
        public bool BStatus { get; set; }
        public bool? Delivery { get; set; }
        public bool? Pickup { get; set; }
        public string? Adress { get; set; }
    }
}
