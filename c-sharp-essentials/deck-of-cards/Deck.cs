using System;
using System.Collections.Generic;

namespace deck_of_cards {
    public class Deck {
        public Deck() {
            string[] suits = { "Diamonds", "Hearts", "Clubs", "Spades" };
            int[] vals = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            string[] stringVals = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            List<Card> cards = new List<Card>();
            foreach (string suit in suits) {
                int i = 1;
                foreach (string stringVal in stringVals) {
                    cards.Add(new Card(suit, stringVal, i));
                    i++;
                }
            }
        }
    }
}