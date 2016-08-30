using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace askfullname
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            Console.WriteLine("what is your first name?");
            name += Console.ReadLine();
            Console.WriteLine("what is your last name?");
            name += " " + Console.ReadLine();
            Console.WriteLine("hello "+name+"!");
            Console.ReadLine();
        }
    }
}
