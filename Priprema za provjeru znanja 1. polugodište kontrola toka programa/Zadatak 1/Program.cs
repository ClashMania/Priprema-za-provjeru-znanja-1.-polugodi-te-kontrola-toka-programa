using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringNiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1;

            Console.WriteLine("Upišite Rečenicu: ");
            s1 = Console.ReadLine();

            if (s1.Length <= 5)
            {
                Console.WriteLine(s1);
            }
            else
            {
                Console.WriteLine(s1.Substring(2, s1.Length - 4));
            }

            Console.ReadKey();
        }
    }
}