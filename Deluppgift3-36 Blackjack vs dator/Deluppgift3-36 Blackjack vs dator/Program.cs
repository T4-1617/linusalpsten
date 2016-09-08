using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deluppgift3_36_Blackjack_vs_dator
{
    class Program
    {
        private static Card[] deck = new Card[208];
        private static Card empty = new Card("", 0);
        private static int cards_left = 208;
        private static Random rng = new Random();
        private static int player_score = 0;

        static void Main(string[] args)
        {
            create_deck(4); // skapar en kortlek
            empty.is_a_card = false;

            while (cards_left > 0)
            {
                start_new_hand();
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
                for (int j = 0; j < 13; j++) //skapar ett kort av varje färg/form för varje valör
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
        private static Card take_random_card() // tar ut ett slumpmässigt kort
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



        private static int dealers_hand;
        private static int players_hand;
        private static bool players_turn = true;
        private static void start_new_hand()
        {
            dealers_hand = 0;
            players_hand = 0;
            current_card = take_random_card();
            if (current_card.value > 10) //ökar poängen med 10 om valören är över 10
            {
                dealers_hand += 10;
            }
            else if (current_card.value == 1) //ökar poängen med 1 eller 11 (beroende på vad programmet anser vara bäst) om valören är 1
            {
                if (dealers_hand + 11 <= 21)
                {
                    dealers_hand += 11;
                }
                else
                {
                    dealers_hand += 1;
                }
            }
            else //ökar poängen med valören om 1<valör<11
            {
                dealers_hand += current_card.value;
            }
            Console.WriteLine("I have {0} of {1}, for a total value of {2}", current_card.value, current_card.shape, dealers_hand);

            players_turn = true;
            while (cards_left > 0 && players_turn)
            {
                Console.WriteLine("Do you want a card (Y/N)?");
                switch (Console.ReadLine().ToUpper()) // läser spelarens input
                {
                    case "Y":
                        current_card = take_random_card(); //tar ett kort om input är "Y"
                        players_hand += card_value(current_card, players_hand);
                        //skriver ut kortet och nuvarande poängen
                        Console.WriteLine("Your card is {0} of {1} and your score is {2}", current_card.value, current_card.shape, players_hand);
                        break;
                    case "N":
                        players_turn = false;
                        break;
                    default:
                        break;
                }
                if (players_hand == 21)
                {
                    Console.WriteLine("Blackjack! +3 points");
                    player_score += 3;
                    return;
                }
                else if (players_hand > 21)
                {
                    Console.WriteLine("Bust! -1 point");
                    player_score -= 1;
                    return;
                }
            }

            while (dealers_hand <= players_hand && cards_left > 0)
            {
                current_card = take_random_card();

                dealers_hand += card_value(current_card, dealers_hand);
                
                Console.WriteLine("I drew {0} of {1}, my score is {2}", current_card.value, current_card.shape, dealers_hand);

                if (dealers_hand > 21)
                {
                    Console.WriteLine("Dealer busts! you get +1 point");
                    player_score += 1;
                    return;
                }
                else if (dealers_hand > players_hand)
                {
                    Console.WriteLine("Dealer wins! you get -1 point");
                    player_score -= 1;
                    return;
                }
            }
        }


        private static int card_value(Card card, int ref_score)
        {
            if (card.value > 10) //ökar poängen med 10 om valören är över 10
            {
                return 10;
            }
            else if (card.value == 1) //ökar poängen med 1 eller 11 (beroende på vad programmet anser vara bäst) om valören är 1
            {
                if (ref_score + 11 <= 21)
                {
                    return 11;
                }
                else
                {
                    return 1;
                }
            }
            else //ökar poängen med valören om 1<valör<11
            {
                return card.value;
            }
        }
    }
}
