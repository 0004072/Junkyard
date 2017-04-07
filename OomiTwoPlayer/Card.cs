namespace OomiTwoPlayer
{
    public class Card
    {
        private Suits suit;
        private Numbers number;

        public Suits Suit
        {
            get
            {
                return suit;
            }

            set
            {
                suit = value;
            }
        }

        public Numbers Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        public Card(Suits suit, Numbers number) {
            this.suit = suit;
            this.number = number;
        }

        public override string ToString() {
            return this.suit.ToString() + " : " + this.number;
        }
    }
}