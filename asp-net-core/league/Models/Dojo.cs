using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace league.Models {
    public class Dojo: BaseEntity {
        public Dojo() {
            ninjas = new List<Ninja>();
        }

        [Key]
        public long id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string location { get; set; }

        [Required]
        public string information { get; set; }

        public ICollection<Ninja> ninjas { get; set; }
    }
}