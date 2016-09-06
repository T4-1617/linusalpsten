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
                deck[i] = new Card("Hearts", i + 1);
            }
            for (int i = 0; i < 13; i++)
            {
                deck[i+13] = new Card("Diamonds", i + 1);
            }
            for (int i = 0; i < 13; i++)
            {
                deck[i+26] = new Card("Spades", i + 1);
            }
            for (int i = 0; i < 13; i++)
            {
                deck[i+39] = new Card("Cloves", i + 1);
            }
            Card current_card;
            int card_counter = 0;
            while (cards_in_deck > 0)
            {
                Console.WriteLine("Press ENTER for a card");
                Console.ReadLine();
                current_card = takeCard();
                string cvalue;
                switch (current_card.value)
                {
                    case 1:
                        cvalue = "Ace";
                        break;
                    case 11:
                        cvalue = "Jack";
                        break;
                    case 12:
                        cvalue = "Queen";
                        break;
                    case 13:
                        cvalue = "King";
                        break;
                    default:
                        cvalue = current_card.value.ToString();
                        break;
                }
                card_counter++;
                Console.WriteLine("Your card nr {2} is {1} of {0} and there is {3} cards left", current_card.shape, cvalue, card_counter, 52-card_counter);
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
