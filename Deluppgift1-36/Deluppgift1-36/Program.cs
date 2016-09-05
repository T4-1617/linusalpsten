using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deluppgift1_36
{
    class Program
    {
        class Card
        {
            public string shape;
            public int value;
            public bool in_deck = true;
            public Card(string shape, int value)
            {
                this.shape = shape;
                this.value = value;
            }
        }
        private static Card[] deck = new Card[52];
        private static int cards_in_deck = 52;
        private static Random rng = new Random();

        public static void Main(string[] args)
        {
            for (int i = 0; i < 13; i++)
            {
                deck[i] = new Card("Heart", i + 1);
            }
            for (int i = 0; i < 13; i++)
            {
                deck[i+13] = new Card("Diamond", i + 1);
            }
            for (int i = 0; i < 13; i++)
            {
                deck[i+26] = new Card("Spade", i + 1);
            }
            for (int i = 0; i < 13; i++)
            {
                deck[i+39] = new Card("Clove", i + 1);
            }
            Card current;
            while (cards_in_deck > 1)
            {
                current = takeCard();
                Console.WriteLine(current.shape+current.value.ToString());
            }
        }
        private static Card takeCard()
        {
            int pos = rng.Next(0, 52);
            while (!deck[pos].in_deck)
            {
                pos = rng.Next(0, 52);
            }
            deck[pos].in_deck = false;
            cards_in_deck -= 1;
            return deck[pos];
        }
    }


}
