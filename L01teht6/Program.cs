using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävät6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Montako kilometriä ajoit?: ");
            double dist = double.Parse(Console.ReadLine());
            double kulutus = 7.02;
            double bensa = 1.595;
            double matka = dist / 100 * kulutus;
            double hinta = matka * bensa;
            Console.Write("ajoit ");
            Console.Write(dist);
            Console.Write("Km auto kulutti ");
            Console.Write(matka);
            Console.Write("Litraa. Rahaa bensaan kului ");
            Console.Write(hinta);
            Console.Write("Euroa\n");
        }
    }
}
