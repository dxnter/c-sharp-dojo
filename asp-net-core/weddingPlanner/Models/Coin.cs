using System;
using System.Collections.Generic;

namespace weddingPlanner.Models {
    public class Coin : BaseEntity {
        public int CoinID { get; set; }
        public string Name { get; set; }
        public string Ticker { get; set; }
        public int Price { get; set; }
        public int Supply { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}