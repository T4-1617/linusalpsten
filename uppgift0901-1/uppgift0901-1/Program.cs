using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift0901_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ange förnamn och efternamn");
            string[] input = Console.ReadLine().Split(' ');
            string name = input[0] + " " + input[input.Length - 1];
            Console.WriteLine(name.Length.ToString());
            Console.WriteLine(name.Replace(" ",string.Empty).Length.ToString());
            string[] name_array = name.Split(' ');
            Console.WriteLine(string.Format("{0} är {1} tecken långt", name_array[0], name_array[0].Length));
            Console.WriteLine(string.Format("{0} är {1} tecken långt", name_array[1], name_array[1].Length));
            Console.WriteLine(string.Format("{0} {1}", name_array[1], name_array[0]));
            foreach (char chr in name_array[0])
            {
                if(chr == ' ')
                {
                    continue;
                }
                Console.WriteLine(string.Format("----->{0}",char.ToUpper(chr)));
            }
            foreach (char chr in name_array[1])
            {
                Console.WriteLine(string.Format("------->{0}", char.ToUpper(chr)));
            }
            string lc_name_backwards = string.Empty;
            for (int i = name.Length-1; i >= 0; i--)
            {
                lc_name_backwards += char.ToLower(name[i]);
            }
            Console.WriteLine(lc_name_backwards);
            string upr_n_lwr_chars_name = string.Empty;
            for (int i = 0; i < name.Length; i++)
            {
                switch (i%2)
                {
                    case 0:
                        upr_n_lwr_chars_name += char.ToUpper(name[i]);
                        break;
                    case 1:
                        upr_n_lwr_chars_name += char.ToLower(name[i]);
                        break;
                    default:
                        //jag är osäker på hur c# hanterar 0%n
                        //därför sätter jag default till att göra char till uppercase eftersom första bokstaven ska vara det
                        upr_n_lwr_chars_name += char.ToUpper(name[i]);
                        break;
                }
            }
            Console.WriteLine(upr_n_lwr_chars_name);
            Console.WriteLine(name.Replace('e', '3').Replace('a', '4').Replace('l', '1').Replace('t', '7'));
            Dictionary<char, int> characters = new Dictionary<char, int>();
            string nospace_name = name.Replace(" ", "");
            foreach (char chr in nospace_name)
            {
                if (characters.ContainsKey(chr))
                {
                    characters[chr] += 1;
                }
                else
                {
                    characters.Add(chr, 1);
                }
            }
            foreach (char key in characters.Keys)
            {
                Console.WriteLine(string.Format("{0}={1}",key.ToString(),characters[key].ToString()));
            }
            foreach (char key in characters.Keys)
            {
                Console.WriteLine(key);
            }
            char[] test = characters.Keys.ToArray();
            Array.Sort(test);
            foreach (char key in test)
            {
                Console.WriteLine(key);
            }
        }
    }
}
