using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtavat7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna vuosi:");
            int vuosi = int.Parse(Console.ReadLine());
            if (vuosi % 4 == 0)
            {
                if (vuosi % 100 == 0)
                {
                    if (vuosi % 400 == 0)
                    {
                        Console.Write("On karkausvuosi.");
                    }
                    else
                    {
                        Console.Write("Ei ole karkausvuosi.");
                    }
                }
                else
                {
                    Console.Write("On karkausvuosi.");
                }
            }
            else
            {
                Console.Write("Ei ole karkausvuosi.");
            }
        }
    }
}
