using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06teht5
{
    class Program
    {
        static void Main(string[] args)
        {
            terroristi tero = new terroristi();
            poliisi ct = new poliisi();
            tero.aseet = "Ak-47";
            tero.rahat = 4200;
            tero.alase = "Clock-18";
            tero.vari = "hiekkaneekeri";
            ct.aseet = "M4A1";
            ct.rahat = 5123;
            ct.alase = "USP-s";
            ct.vari = "sinertava poliisi";
            string ehto;
            Console.WriteLine("Tervetuloa pelaamaan CS.1.8");
            Console.WriteLine("ensiksi valitset puolesi: CT=ct, T=terot");
            ehto = Console.ReadLine();
            Console.WriteLine(ehto);
            if (ehto == "CT")
            {
                Console.WriteLine("Olet nyt Poliisi =) ");
                Console.WriteLine("Sinulla on hallussasi " + ct.aseet + " ja " + ct.alase);
                Console.WriteLine("naiden lisaksi " + ct.rahat + "dollaria ja varisi on " + ct.vari);
            }
            if (ehto == "T")
            {
                Console.WriteLine("Olet nyt Terroristi =) ");
                Console.WriteLine("Sinulla on hallussasi " + tero.aseet + " ja " + tero.alase);
                Console.WriteLine("naiden lisaksi " + tero.rahat + "dollaria ja varisi on " + tero.vari);
            }

        }
    }
}