using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tehvetuloa kayttamaan Onkyo vahvistinta");
            vahv Onkyo = new vahv();
            Onkyo.vol = -50;
            bool run = true;
            while (run)
            {
                Console.Write("->Volume on: " + Onkyo.vol);
                Console.Write("DB");
                Console.Write("\n->Minka aanen voimakkuuden haluat(-50DB-50DB) > ");
                long number = 0;
                string line = Console.ReadLine();
                bool result = Int64.TryParse(line, out number);
                if (result)
                {
                    // Console.WriteLine("success: " + number);
                }
                else
                {
                    Console.WriteLine("\n\nMITA OIKEIN YRITAT?!?!?");
                    Onkyo.vol = -50;
                    run = false;
                }
                Onkyo.saato(number);
                if (number < -50) { Console.WriteLine("\nLiian pieni volume - MIN volume on -50DB"); }
                if (number > 50) { Console.WriteLine("\nNyt yritat rikkoa jotain - MAX volume on 50DB"); }
            }
        }
    }
}
