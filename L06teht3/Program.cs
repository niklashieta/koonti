using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hellurei ja hellat utareet! Terve tuloa radioon");
            Radio r = new Radio();
            Console.WriteLine("Radio ei ole kaynnissa :(");
            Console.ReadLine();
            r.Sta = true;
            Console.WriteLine("Radio on nyt kaynnissa :)");
            while (r.Sta)
            {
                Console.WriteLine("Radion volume on-->" + r.Vol);
                Console.Write("Volume--> "); r.Vol = int.Parse(Console.ReadLine());
                if (r.Vol < 0) { Console.WriteLine("Volume ei voi olla negatiivinen luku"); r.Vol = 0; }
                if (r.Vol > 9) { Console.WriteLine("MAX volume on 9"); r.Vol = 9; }
                Console.WriteLine("Radion volume on-->" + r.Vol);
                Console.WriteLine("Radion taajuus on-->" + r.Taa + "Hz");
                Console.Write("Taajuus--> "); r.Taa = long.Parse(Console.ReadLine());
                if (r.Taa < 2000) { Console.WriteLine("minimi taajuus 2000.0Hz"); r.Taa = 2000; }
                if (r.Taa > 26000) { Console.WriteLine("MAX taajuus on 26000Hz"); r.Taa = 26000; }
                Console.WriteLine("Radion taajuus on-->" + r.Taa + "Hz");
                Console.WriteLine("Sammutetaanko radio? \nFalse sammuuttaa \nTrue jatkaa kayttoa"); r.Sta = bool.Parse(Console.ReadLine());
            }
        }
    }
}