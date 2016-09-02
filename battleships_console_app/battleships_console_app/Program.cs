using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleships_console_app
{
    class Program
    {
        public static bool[,] GameField = new bool[5, 7]; // skapa spelplanen

        public static void Main(string[] args)
        {
            Random x = new Random();
            Random y = new Random();
            Random generate_ships = new Random();
            int amount_of_ships = generate_ships.Next(3, 6); //generera slumpmässigt från 3 till 5 skepp
            int shoot_attempts = 0;
            for (int i = 0; i < amount_of_ships; i++) //för varje skepp som ska genereras:
            {
                bool success = place_ship(y.Next(0, 5), x.Next(0, 7)); //generera ett skepp på spelplanen
                while (!success) // tills plaseringen lyckas:
                {
                    success = place_ship(y.Next(0, 5), x.Next(0, 7)); // försök igen
                }
            }
            int ships_left = amount_of_ships;
            while (ships_left > 0) // så länge det finns skepp kvar
            {
                Console.WriteLine("{0} skepp kvar", amount_of_ships);
                if (shoot()) // om det är en träff
                {
                    amount_of_ships--; //"sänk" ett skepp
                }
                shoot_attempts++;
            }
            Console.WriteLine("Inga skepp kvar");
            Console.WriteLine("Score: {0} (högre är bättre)",(100*Math.Exp(0.1*(-shoot_attempts+amount_of_ships)))); //det bästa man kan få är 100 poäng
        }


        private static bool place_ship(int y, int x)
        {
            if (!GameField[y, x]) //om det inte finns en båt vid y,x
            {
                GameField[y, x] = true; //"plasera" en båt där
                return true; //returnera att plaseringen lyckades
            }
            return false; //om det redan finns en båt vid y,x: returnera att plaseringen misslyckades
        }


        private static int get_valit_coordinate_from_user(int max, char coordinate_to_ask_for)
        {
            string coordinate = Console.ReadLine(); //tar kordinaten som en sträng
            int coordinate_value;
            if (int.TryParse(coordinate, out coordinate_value) && coordinate_value < max) //om det kordinaten är giltig
            {
                return coordinate_value;
            }
            Console.WriteLine("Kordinaten är inte giltig, försök igen");
            return get_valit_coordinate_from_user(max, coordinate_to_ask_for); //om kordinaten inte är giltig, försök igen

        }


        private static bool shoot()
        {
            Console.WriteLine("Ange en {0}-kordinat mellan från 0 till {1} som du vill skuta på", 'x', 6);
            int xc = get_valit_coordinate_from_user(7, 'x'); //hämtar en giltig x kordinat
            Console.WriteLine("Ange en {0}-kordinat mellan från 0 till {1} som du vill skuta på", 'y', 4);
            int yc = get_valit_coordinate_from_user(5, 'y'); //hämtar en giltig y kordinat

            if (GameField[yc, xc]) // om det finns ett skepp vid kordinaterna
            {
                Console.WriteLine("Träff vid {0}, {1}", xc, yc);
                GameField[yc, xc] = false;
                return true; // returnerar att det var en träff
            }
            Console.WriteLine("miss, försök igen");
            return false; // returnerar att det var en miss
        }
    }
}
