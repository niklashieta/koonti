using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car por = new Car();
            por.Merkki = "Porsche";
            por.Malli = "911";
            Console.WriteLine("Created a new vehicle " + por.Merkki + " model " + por.Malli);
            por.Name = "Continental";
            por.Model = "Cr8";
            por.TyreSize = "265/35R18";
            Console.WriteLine("Tyre " + por.Name + " added to cehicle " + por.Merkki);
            Console.WriteLine("Tyre " + por.Name + " added to cehicle " + por.Merkki);
            Console.WriteLine("Tyre " + por.Name + " added to cehicle " + por.Merkki);
            Console.WriteLine("Tyre " + por.Name + " added to cehicle " + por.Merkki);
            Console.WriteLine("Vechicle name: " + por.Merkki + " model " + por.Malli);
            Console.WriteLine("Tyres:");
            Console.WriteLine("name: " + por.Name + " model " + por.Model + " TyreSize " + por.TyreSize);
            Console.WriteLine("name: " + por.Name + " model " + por.Model + " TyreSize " + por.TyreSize);
            Console.WriteLine("name: " + por.Name + " model " + por.Model + " TyreSize " + por.TyreSize);
            Console.WriteLine("name: " + por.Name + " model " + por.Model + " TyreSize " + por.TyreSize);

            Car bi = new Car();
            bi.Merkki = "Yamaha";
            bi.Malli = "R9";
            Console.WriteLine("Created a new vehicle " + bi.Merkki + " model " + bi.Malli);
            bi.Name = "Bridgetstone";
            bi.Model = "Zr16";
            bi.TyreSize = "190/40R17";
            Console.WriteLine("Tyre " + bi.Name + " added to cehicle " + bi.Merkki);
            Console.WriteLine("Vechicle name: " + bi.Merkki + " model " + bi.Malli);
            Console.WriteLine("Tyres:");
            Console.WriteLine("name: " + bi.Name + " model " + bi.Model + " TyreSize 165/40R17");
            Console.WriteLine("name: " + bi.Name + " model " + bi.Model + " TyreSize " + bi.TyreSize);

        }
    }
}