using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class User
    {
        public int UId { get; set; }
        public string UName { get; set; } = null!;
        public string UEmail { get; set; } = null!;
        public string URole { get; set; } = null!;
        public string? UPhNumber { get; set; }
        public string UPassword { get; set; } = null!;
    }
}
