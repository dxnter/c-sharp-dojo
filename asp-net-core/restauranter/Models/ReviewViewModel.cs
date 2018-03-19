using System;
using System.ComponentModel.DataAnnotations;

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
        [DateValid(ErrorMessage = "Dates must be from the past")]
        public DateTime VisitDate { get; set; }

        [Required]
        public int Stars { get; set; }

        public class DateValidAttribute : ValidationAttribute {
            public override bool IsValid(object userdate) {
                return userdate != null && (DateTime) userdate < DateTime.Now;
            }
        }
    }
}