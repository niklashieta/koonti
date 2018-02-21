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
            his his = new his();
            while (true)
            {
                Console.WriteLine("Hissi on kerroksessa: " + his.kerros);
                Console.Write("Mihin kerrokseen haluat (1-5) > ");
                long number = 0;
                string line = Console.ReadLine();
                bool result = Int64.TryParse(line, out number);
                if (result)
                {
                    // Console.WriteLine("success: " + number);
                }
                else
                {
                    Console.WriteLine("NAN!");
                }
                his.ylos(number);
            }
        }
    }
}