using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace weddingPlanner.Models {
    public class User : BaseEntity {
        public int UserId { get; set; }
        public string name { get; set; }
    }
}