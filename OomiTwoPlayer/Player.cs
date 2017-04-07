using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OomiTwoPlayer
{
    class Player
    {
        private Deck deck;
        private string name;
        private byte setsWon;

        public Player(string name, Deck deck) {
            this.Name = name;
            this.deck = deck;
            SetsWon = 0;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public byte SetsWon
        {
            get
            {
                return setsWon;
            }

            set
            {
                setsWon = value;
            }
        }

        internal Deck Deck
        {
            get
            {
                return deck;
            }
        }

        public Card play() {
            //return a random card
            //TODO :: Implements a logical algorithm
            Card card = this.deck.getCard();
            Console.WriteLine("{0} : {1}", this.Name, card.ToString());
            return card;
        }

        public Card play(Card otherCard) {
            //return a random card which can dominate the other card
            Card card = null;
            if (this.deck.hasSuit(otherCard.Suit))
            {
                Dictionary<Numbers, Card> suitCards = this.deck.getSuitsCards(otherCard.Suit);
                List<Numbers> sortedCardsList = suitCards.Keys.ToList();
                sortedCardsList.Sort();
                if (sortedCardsList.Any(z => z > otherCard.Number))
                {
                    sortedCardsList.RemoveAll(x => x < otherCard.Number);
                }
                
                Numbers numberCardToPlay = sortedCardsList[0];
                card = this.deck.getCard(otherCard.Suit, numberCardToPlay);
            }
            else
            {
                Array suit = Enum.GetValues(typeof(Suits));
                Random random = new Random();
                Suits randomSuit = (Suits)suit.GetValue(random.Next(suit.Length));
                Dictionary<Numbers, Card> suitCards = this.deck.getSuitsCards(randomSuit);
                List<Numbers> sortedCardsList = suitCards.Keys.ToList();
                sortedCardsList.Sort();
                Numbers randomNumber = sortedCardsList[0];

                card = this.deck.getCard(randomSuit, randomNumber);
            }
            Console.WriteLine("{0} : {1}", this.Name, card.ToString());
            return card;
        }

        public void receiveCard(Card card) {
            if (!Deck.isFull()) {
                Deck.putCard(card);
                return;
            }
            Console.WriteLine("Player's hand is already full!");
        }


    }
}
