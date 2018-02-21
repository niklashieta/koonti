using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtavat8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("anna kolme kokonaislukua\n>");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            if (number1 > number2)
            {
                if (number1 > number3)
                {
                    Console.Write("Suurin luku on");
                    Console.Write(number1);
                }
                else
                {
                    Console.Write("Suurin luku on");
                    Console.Write(number3);
                }
            }
            else
            {
                if (number2 > number3)
                {
                    Console.Write("Suurin luku on");
                    Console.Write(number2);
                }
                else
                {
                    Console.Write("Suurin luku on");
                    Console.Write(number3);
                }
            }
        }
    }
}