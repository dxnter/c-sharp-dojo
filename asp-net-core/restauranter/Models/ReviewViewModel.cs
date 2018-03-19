using System.ComponentModel.DataAnnotations;
using System;

namespace restauranter.Models {
    public class ReviewViewModel : BaseEntity {
        [Required]
        [MinLength(2)]
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string Name { get; set; }

        [Required]
        [MinLength(2)]
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string Restaurant { get; set; }

        [Required]
        [MinLength(10)]
        public string ReviewText { get; set; }

        [Required]
        public DateTime VisitDate { get; set; }

        [Required]
        public int Stars { get; set; }
    }
}