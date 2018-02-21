using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number;
            number = new int[5];
            Console.WriteLine("Syota 5 kokonaislukua\n");
            for (int i = 0; i <= 4; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }
            for (int h = 4; h >= 0; h--)
            {
                Console.Write(number[h]);
                Console.Write("\n");
            }
        }
    }
}