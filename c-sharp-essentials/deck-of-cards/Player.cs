using System;
using System.Collections.Generic;

namespace deck_of_cards {
    public class Player {
        public string name;
        List<Card> hand = new List<Card>();
        public Player(string n) {
            name = n;
        }

        public Card Draw(Deck deck) {
            Card cardDrawn = deck.Deal();
            hand.Add(cardDrawn);
            return cardDrawn;
        }

        public void ShowHand() {
            System.Console.WriteLine($"===={name}'s Hand====");
            foreach (Card card in hand) {
                System.Console.WriteLine($"   → {card.stringVal} of {card.suit}");
            }
            System.Console.WriteLine("================");
        }
    }
}