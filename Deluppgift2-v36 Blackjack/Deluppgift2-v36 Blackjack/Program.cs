using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deluppgift2_v36_Blackjack
{
    class Program
    {
        private static Card[] deck = new Card[104];
        private static Card empty = new Card("", 0);
        private static int cards_left = 104;
        private static Random rng = new Random();

        static void Main(string[] args)
        {
            create_deck(2);
            empty.is_a_card = false;
            Card players_card = empty;
            for (int i = 0; i < deck.Length; i++)
            {
                players_card = take_random_card();
                Console.WriteLine(players_card.shape+players_card.value.ToString());
            }
        }
        class Card
        {
            public string shape;
            public int value;
            public bool is_a_card = true;
            public Card(string shape, int value)
            {
                this.shape = shape;
                this.value = value;
            }
        }
        private static void create_deck(int deck_size)
        {
            for (int i = 0; i < deck_size; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    deck[j * 4 + 0 + i * 52] = new Card("Hearts", j + 1);
                    deck[j * 4 + 1 + i * 52] = new Card("Diamonds", j + 1);
                    deck[j * 4 + 2 + i * 52] = new Card("Spades", j + 1);
                    deck[j * 4 + 3 + i * 52] = new Card("Cloves", j + 1);
                }
            }
        }

        private static int pos = 0;
        private static Card current_card;
        private static Card take_random_card()
        {
            pos = rng.Next(0, deck.Length);
            while (deck[pos].is_a_card == false)
            {
                pos = rng.Next(0, deck.Length);
            }
            current_card = deck[pos];
            deck[pos] = empty;
            cards_left--;
            return current_card;
        }
    }
}
