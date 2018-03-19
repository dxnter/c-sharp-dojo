using System;

namespace restauranter.Models {
    public abstract class BaseEntity {}
    public class Review : BaseEntity {
        public int ReviewId { get; set; }
        public string Name { get; set; }
        public string Restaurant { get; set; }
        public string ReviewText { get; set; }
        public DateTime VisitDate { get; set; }
        public int Stars { get; set; }
    }
}