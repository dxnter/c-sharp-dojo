using System.ComponentModel.DataAnnotations;

namespace lost_in_the_woods.Models {

    public abstract class BaseEntity { }
    public class Trail : BaseEntity {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a trail name")]
        public string TrailName { get; set; }

        [Required(ErrorMessage = "Please enter a description")]
        [MinLength(10, ErrorMessage = "Description must be longer than 10 characters")]
        public string Description { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid number")]
        public int TrailLength { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid number")]
        public int Elevation { get; set; }
    }
}