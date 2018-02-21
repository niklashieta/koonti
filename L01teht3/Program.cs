using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtavat3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syota kolme numeroa. \nOhjelma laskee lukujen keskiarvon \n> ");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            int number4 = number1 + number2 + number3;
            int number5 = number4 / 3;
            Console.Write("lukujen keskiarvo on: ");
            Console.Write(number5);
            Console.Write("\n");

        }
    }
}
