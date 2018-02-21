using System;


namespace tehtavat1
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.Write("Give point limit > ");
            int number = int.Parse(Console.ReadLine());
            if (number == 0 || number == 1)
            {
                Console.WriteLine("School number is 0");
            }
            if (number == 2 || number == 3)
            {
                Console.WriteLine("School number is 1");
            }
            if (number == 4 || number == 5)
            {
                Console.WriteLine("School number is 2");
            }
            if (number == 6 || number == 7)
            {
                Console.WriteLine("School number is 3");
            }
            if (number == 8 || number == 9)
            {
                Console.WriteLine("School number is 4");
            }
            if (number == 10 || number == 11 || number == 12)
            {
                Console.WriteLine("School number is 5");
            }
            if (number > 12)
            {
                Console.WriteLine("et osaa");
            }
            if (number < 0)
            {
                Console.WriteLine("et osaa");
            }
        }
    }
}
