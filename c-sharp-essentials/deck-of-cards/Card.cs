using System;

namespace deck_of_cards {
    public class Card {
        public string stringVal;
        public string suit;
        public int val;
        public Card(string s, string sv, int v) {
            suit = s;
            stringVal = sv;
            val = v;
        }

    }
}