using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi cijenu bez PDV-a:");
            string sD = Console.ReadLine();
            double bezPDV = Convert.ToDouble(sD);
            Console.WriteLine("Unesi cijenu s PDV-om:");
            sD = Console.ReadLine();
            double sPDV = Convert.ToDouble(sD);
            if (sPDV < bezPDV)
                Console.WriteLine("Cijene nisu ispravno unešene");
            else
                Console.WriteLine("PDV iznosi {0} %",
                (sPDV - bezPDV) / bezPDV * 100);
            Console.ReadKey();
        }
    }
}
