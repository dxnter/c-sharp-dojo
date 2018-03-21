using System;
using System.ComponentModel.DataAnnotations;

namespace weddingPlanner.Models {
    public class UserViewModel : BaseEntity {
        [Required(ErrorMessage = "Please enter a name")]
        [MinLength(2, ErrorMessage = "Name must be at least two characters")]
        [RegularExpression(@"^[a-zA-Z\s]*$")]
        public string Name { get; set; }
    }
}