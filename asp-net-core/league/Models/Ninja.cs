using System.ComponentModel.DataAnnotations;

namespace league.Models {
    public abstract class BaseEntity { }
    public class Ninja : BaseEntity {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "Please enter a name!")]
        public string name { get; set; }

        public int level { get; set; }

        public string description { get; set; }

        public Dojo dojo { get; set; }
    }
}