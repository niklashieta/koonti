using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava9
{
    class Program
    {
        static void Main(string[] args)
        {
            int heh = 1;
            //int yht = 0;
            int perse = 0;
            while (heh != 0)
            {
                Console.Write("anna kokonais lukuja. ");
                heh = int.Parse(Console.ReadLine());
                perse = (perse + heh);
                //perse + (yht + heh);
                //Console.Write(heh);
                //Console.Write(perse);
                //Console.Write(yht);

            }

            Console.Write("lukujen summa on: ");
            Console.Write(perse);
            Console.Write("\n");
        }
    }
}