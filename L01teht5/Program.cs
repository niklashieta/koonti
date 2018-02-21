using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtavat5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Annappas sekuntteja\n>");
            int seconds = int.Parse(Console.ReadLine());
            Console.Write("hh.mm.ss\n");
            TimeSpan t = TimeSpan.FromSeconds(seconds);
            Console.WriteLine(t.ToString());

        }
    }
}
