using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OomiTwoPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Deck deck = new Deck(52);
            foreach (Suits suit in Enum.GetValues(typeof(Suits))) {
                foreach (Numbers i in Enum.GetValues(typeof(Numbers))) {;
                    deck.putCard(new Card(suit, i));
                }
            }

            Player player1 = new Player("Player1", new Deck(10));
            Player player2 = new Player("Player2", new Deck(10));

            //Game Play
            while (true) {
                for (int i = 1; i <= 10; i++)
                {
                    player1.receiveCard(deck.getCard());
                    player2.receiveCard(deck.getCard());
                }

                Player lastSetWinner = player1;
                Player otherPlayer = player2;

                for (int i = 1; i <= 10; i++) {
                    Card cardLastSetWinner = lastSetWinner.play();
                    Card cardOtherPlayer = otherPlayer.play(cardLastSetWinner);
                    if (cardLastSetWinner.Suit.Equals(cardOtherPlayer.Suit))
                    {
                        if (cardLastSetWinner.Number < cardOtherPlayer.Number)
                        {
                            Player temp = lastSetWinner;
                            lastSetWinner = otherPlayer;
                            otherPlayer = temp;
                        }

                    }
                    Console.WriteLine("{0} WINS!\n", lastSetWinner.Name);
                    deck.putCard(cardLastSetWinner);
                    deck.putCard(cardOtherPlayer);
                    lastSetWinner.SetsWon++;
                }

                Player winner = player1.SetsWon > player2.SetsWon ? player1 : player1.SetsWon == player2.SetsWon ? new Player("None", null) : player2;

                Console.WriteLine("--- GAME STATS --- \nPlayer 1 : {0}\nPlayer 2 : {1}\nWinner : {2}\n--- END ---\n", player1.SetsWon, player2.SetsWon, winner.Name);
                
                Console.Write("Would you like to play again? (Y/n): ");
                ConsoleKeyInfo newGame = Console.ReadKey();
                Console.WriteLine("\n");
                player1.SetsWon = 0;
                player2.SetsWon = 0;
                if (newGame.Key != ConsoleKey.Y)
                    goto end_gameplay;
            }
            end_gameplay:

            Console.ReadKey();
        }
    }
}
