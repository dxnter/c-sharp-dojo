using System.ComponentModel.DataAnnotations;

namespace form_submission.Models {
    public class User {

        [Required(ErrorMessage = "First name must be more than 3 characters")]
        [MinLength(4)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name must be more than 3 characters")]
        [MinLength(4)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Age must be between 1 - 100")]
        [Range(1, 100)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password must be at least 8 characters")]
        [MinLength(8)]
        public string Password { get; set; }
    }
}