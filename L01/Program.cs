using System;


namespace tehtavat1
{
    class Program
    {


        static void Main(string[] args)
        {

            Console.Write("Anna numero > ");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1: Console.WriteLine("numero on yksi"); break;
                case 2: Console.WriteLine("numero on kaksi"); break;
                case 3: Console.WriteLine("numero on kolme"); break;

            }
            if (number > 3)
            {
                Console.WriteLine("Joku muu luku");
            }
            if (number < 1)
            {
                Console.WriteLine("joku muu luku");
            }

        }
    }
}