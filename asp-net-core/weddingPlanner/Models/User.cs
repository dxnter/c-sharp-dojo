using System;
using System.Collections.Generic;

namespace weddingPlanner.Models {
    public class User : BaseEntity {
        public int UserId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}