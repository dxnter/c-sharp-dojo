using System;

namespace deck_of_cards {
    class Program {
        static void Main(string[] args) {
            Deck deck = new Deck();
            deck.Deal();
            deck.Deal();
            deck.Deal();
            deck.Reset();
            deck.Deal();
            deck.Shuffle();
            deck.Deal();
            deck.Deal();
            deck.Deal();

            Player danny = new Player("Danny");
            danny.Draw(deck);
            danny.Draw(deck);
            danny.Draw(deck);

            danny.ShowHand();
        }
    }
}