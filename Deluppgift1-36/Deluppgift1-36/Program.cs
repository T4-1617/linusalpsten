using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deluppgift1_36
{
    class Program
    {
        class Card //skapar en klass som representerar ett spelkort
        {
            public string shape;
            public int value;
            public bool in_deck = true; //jag utgår ifrån att kortet alltid börjar i en kortlek
            public Card(string shape, int value)//tar färg/form och valör som argument när man skapar ett nytt kort
            {
                this.shape = shape;
                this.value = value;
            }
        }
        private static Card[] deck = new Card[52]; //skapar en ny tom kortlek
        private static int cards_in_deck = 52; /*skapar en integer för att holla koll på hur många kort som finns kvar i kortleken 
        eftersom jag aldrig helt tar ut ett kort ur*/

        public static void Main(string[] args)
        {
            //härifrån
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
            //till hit så skapar jag nya unika kort och lägger in dem i kortleken
            Card current_card;
            int card_counter = 0; // holler koll på hur många kort som har "tagits" ut ur leken
            int sum = 0; //holler koll på summan av alla valörer på korten som "tagits" ut
            while (cards_in_deck > 0) //så länge det finns kort kvar i leken:
            {
                Console.WriteLine("Press ENTER for a card");
                Console.ReadLine(); //väntar på att användaren ska trycka på ENTER
                current_card = takeCard(); //returnerar ett slumpat kort från kortleken
                string card_value;
                switch (current_card.value)//om valören är 13-11 eller 1 så skriva att det är kung-knekt eller ess
                {
                    case 1:
                        card_value = "Ace";
                        break;
                    case 11:
                        card_value = "Jack";
                        break;
                    case 12:
                        card_value = "Queen";
                        break;
                    case 13:
                        card_value = "King";
                        break;
                    default:
                        card_value = current_card.value.ToString();
                        break;
                }
                sum += current_card.value; //adderar valören på det aktuella kortet
                card_counter++; //inkrementerar card_counter för att veta att ett /(?:till)?/i kort har tagits från kortleken

                //skriver ut vilket kort som nyss togs ut, hur många kort som tagits ut, hur många kort som är kvar och spelarens nuvarande poäng
                Console.WriteLine("Your card nr {2} is {1} of {0} and there is {3} cards left", current_card.shape, card_value, card_counter, 52-card_counter);
                Console.WriteLine("Your current score is {0}", sum);
            }
        }

        private static Random rng = new Random(); //skapar rng variabeln utanför funktionen så att man inte behöver skapa flera variabler i onödan
        private static int pos; //samma som kommentaren ovan

        private static Card takeCard()
        {
            pos = rng.Next(0, 52);
            while (!deck[pos].in_deck) //så länge kortet man försöker ta inte finns i kortleken:
            {
                pos = rng.Next(0, 52); //kolla vid en annan position
            }
            //när man lyckats hitta ett kort som finns i kortleken
            deck[pos].in_deck = false; //markera att kortet man tagit ut inte finns kvar i kortleken längre
            cards_in_deck--; //markera att det finns ett mindre kort i kortleken
            return deck[pos]; //returnera kortet man tog ut
        }
    }


}
