using System;
using System.Collections.Generic;
using System.Linq;

namespace deck_of_cards {
    public class Deck {
        public string[] suits = { "Diamonds", "Hearts", "Clubs", "Spades" };
        public string[] stringVals = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        List<Card> cards = new List<Card>();

        public Deck() {
            foreach (string suit in suits) {
                int i = 1;
                foreach (string stringVal in stringVals) {
                    cards.Add(new Card(suit, stringVal, i));
                    System.Console.WriteLine($"{stringVal} of {suit}");
                    i++;
                }
            }
            System.Console.WriteLine("====Deck Generated====\n");
        }

        public Deck Deal() {
            Card firstCard = cards[0];
            cards.Remove(firstCard);
            System.Console.WriteLine($"Dealt a {firstCard.stringVal} of {firstCard.suit}");
            return this;
        }

        public Deck Reset() {
            this.cards = new List<Card>();
            foreach (string suit in suits) {
                int i = 1;
                foreach (string stringVal in stringVals) {
                    cards.Add(new Card(suit, stringVal, i));
                    i++;
                }
            }
            System.Console.WriteLine("\n====Deck Reset====\n");
            return this;
        }

        public Deck Shuffle() {
            Random rnd = new Random();
            cards = cards.OrderBy(x => rnd.Next()).ToList();
            System.Console.WriteLine("\n====Deck Shuffled====\n");
            return this;
        }
    }
}