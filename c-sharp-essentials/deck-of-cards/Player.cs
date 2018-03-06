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

        public Card Discard(int index) {
            if (hand.Count > index && hand[index] != null) {
                Card card = hand[index];
                hand.Remove(card);
                System.Console.WriteLine($"\n☑️   Removed {card.stringVal} of {card.suit} from {name}'s hand");
                return card;
            }
            System.Console.WriteLine("❗❗❗  CARD NOT IN HAND ❗❗❗");
            return null;
        }

        public void ShowHand() {
            System.Console.WriteLine($"\n■■■■ {name}'s ✋  ■■■■");
            foreach (Card card in hand) {
                System.Console.WriteLine($"→ {card.stringVal} of {card.suit}");
            }
            System.Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■");
        }
    }
}