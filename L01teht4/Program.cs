using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtavat4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Terve! \nSyota ikasi \n>");
            int number1 = int.Parse(Console.ReadLine());
            if (number1 < 18)
            {
                Console.Write("ALAIKABAN!!!\n");
            }
            if (number1 <= 65 && number1 >= 18)
            {
                Console.Write("Aikuinen\n");
            }
            if (number1 > 65)
            {
                Console.Write("Seniori\n");
            }
            if (number1 > 100)
            {
                Console.Write("JUMAL VELEHO\n");
            }
        }
    }
}
