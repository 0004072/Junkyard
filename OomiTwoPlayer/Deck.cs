using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;

namespace OomiTwoPlayer
{
    class Deck
    {
        private Dictionary<Suits, Dictionary<Numbers, Card>> cards;
        private byte noOfCards;
        private byte maxNoOfCards; 

        public Deck(byte maxNoOfCards) {
            this.cards = new Dictionary<Suits, Dictionary<Numbers, Card>>();
            this.maxNoOfCards = maxNoOfCards;
        }
        
        public void putCard(Card card) {
            if (this.noOfCards > maxNoOfCards) {
                Console.WriteLine("Hand is full! ");
                return;
            }

            Dictionary<Numbers, Card> cardNum = new Dictionary<Numbers, Card>();
            cardNum.Add(card.Number, card);

            try
            {
                cards.Add(card.Suit, cardNum);
            }
            catch (ArgumentException)
            {
                Dictionary<Numbers, Card> suit;
                bool found = cards.TryGetValue(card.Suit, out suit);
                suit.Add(card.Number, card);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            ++this.noOfCards;
        }

        public Card getCard(Suits suit, Numbers number) {
            Card card = null;
            bool suitFound = false;
            bool numberFound = false;
            if (cards.ContainsKey(suit)) {
                suitFound = true;
                Dictionary<Numbers, Card> selectedSuit;
                if (cards.TryGetValue(suit, out selectedSuit)) {
                    numberFound = selectedSuit.TryGetValue(number, out card);
                }                
            }
            if (suitFound)
            {
                if (numberFound)
                {
                    card = cards[suit][number];
                    this.cards[suit].Remove(number);
                }
                if(this.cards[suit].Count == 0)
                    this.cards.Remove(suit);
            }
            --this.noOfCards;
            return card;
        }

        public Card getCard() {
            Random random = new Random();
            int indexOfSuit = random.Next(0, this.cards.Count);
            Dictionary<Numbers, Card> suit = this.cards.ElementAt(indexOfSuit).Value;
            Card card = suit.ElementAt(random.Next(0, suit.Count)).Value;
            this.cards[card.Suit].Remove(card.Number);
            if (this.cards[card.Suit].Count == 0)
            {
                this.cards.Remove(card.Suit);
            }
            --this.noOfCards;
            return card;
        }

        public Suits[] getAvailableSuits() {
            return this.cards.Keys.ToArray();
        }

        public void shuffle()
        {
            Random random = new Random();
            this.cards = this.cards.OrderBy(x => random.Next()).ToDictionary(item => item.Key, item => item.Value);
        }

        public bool isFull()
        {
            return noOfCards == maxNoOfCards;
        }

        public bool hasSuit(Suits suit) {
            return this.cards.ContainsKey(suit);
        }

        public Dictionary<Numbers, Card> getSuitsCards(Suits suit) {
            return this.cards[suit];
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<Suits, Dictionary<Numbers, Card>> suit in cards) {
                foreach (KeyValuePair<Numbers, Card> card in suit.Value) {
                    sb.Append(card.Value.ToString()).Append('\n');
                }
            }
            return sb.ToString();
        }
    }
}