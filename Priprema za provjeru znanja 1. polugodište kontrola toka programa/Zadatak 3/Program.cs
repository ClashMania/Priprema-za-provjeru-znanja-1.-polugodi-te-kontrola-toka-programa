using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Unesiti broj:");
            string str = Console.ReadLine();
            int br = Convert.ToInt32(str);
            if (br % 4 == 0 && br % 6 == 0)
                Console.WriteLine("Broj je djeljiv sa 4 i sa 6");
            else if (br % 4 == 0)
                Console.WriteLine("Broj je djeljiv sa 4");
            else if (br % 6 == 0)
                Console.WriteLine("Broj je djeljiv sa 6");
            else
                Console.WriteLine("Broj nije djeljiv sa 4 ni sa 6");
            Console.ReadKey(); 
        }
    }
}
