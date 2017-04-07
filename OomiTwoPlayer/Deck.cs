using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;

namespace OomiTwoPlayer
{
    class Deck
    {
        private Dictionary<Suits, Dictionary<Numbers, Card>> deck;
        private byte noOfCards;
        private byte maxNoOfCards; 

        public Deck(byte maxNoOfCards) {
            this.deck = new Dictionary<Suits, Dictionary<Numbers, Card>>();
            this.maxNoOfCards = maxNoOfCards;
        }
        
        public void putCard(Card card) {
            if (this.noOfCards > maxNoOfCards) {
                Console.WriteLine("Hand is full! ");
                return;
            }

            Dictionary<Numbers, Card> cardNum = new Dictionary<Numbers, Card>();
            cardNum.Add(card.Number, card);
            Dictionary<Numbers, Card> suit;
            if (deck.ContainsKey(card.Suit))
            {
                suit = deck[card.Suit];
            }
            else
            {
                suit = new Dictionary<Numbers, Card>();
            }
            suit.Add(card.Number, card);

            //try
            //{
            //    deck.Add(card.Suit, cardNum);
            //}
            //catch (ArgumentException) {
            //    Dictionary<Numbers, Card> suit;
            //    bool found = deck.TryGetValue(card.Suit, out suit);
            //    suit.Add(card.Number, card);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            this.noOfCards++;
        }

        public Card getCard(Suits suit, Numbers number) {
            Card card = null;
            bool suitFound = false;
            bool numberFound = false;
            if (deck.ContainsKey(suit)) {
                suitFound = true;
                Dictionary<Numbers, Card> selectedSuit;
                if (deck.TryGetValue(suit, out selectedSuit)) {
                    numberFound = selectedSuit.TryGetValue(number, out card);
                }                
            }
            if (suitFound)
            {
                if (numberFound)
                {
                    card = deck[suit][number];
                    deck[suit].Remove(number);
                }
                else
                    deck.Remove(suit);
            }
            return card;
        }

        public Card getCard() {
            Random random = new Random();
            int indexOfSuit = random.Next(0, this.deck.Count);
            Dictionary<Numbers, Card> suit = this.deck.ElementAt(indexOfSuit).Value;
            Card card = suit.ElementAt(random.Next(0, suit.Count)).Value;
            this.deck[card.Suit].Remove(card.Number);
            if (this.deck[card.Suit].Count == 0)
                Console.WriteLine(this.deck.Remove(card.Suit));
            return card;
        }

        public void shuffle()
        {
            Random random = new Random();
            this.deck = this.deck.OrderBy(x => random.Next()).ToDictionary(item => item.Key, item => item.Value);
        }

        public bool isFull()
        {
            return noOfCards == maxNoOfCards;
        }

        public bool hasSuit(Suits suit) {
            return this.deck.ContainsKey(suit);
        }

        public Dictionary<Numbers, Card> getSuitsCards(Suits suit) {
            return this.deck[suit];
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<Suits, Dictionary<Numbers, Card>> suit in deck) {
                foreach (KeyValuePair<Numbers, Card> card in suit.Value) {
                    sb.Append(card.Value.ToString()).Append('\n');
                }
            }
            return sb.ToString();
        }
    }
}