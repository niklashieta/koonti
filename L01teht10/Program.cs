using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers;
            numbers = new int[9];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 33;
            numbers[3] = 44;
            numbers[4] = 55;
            numbers[5] = 68;
            numbers[6] = 77;
            numbers[7] = 96;
            numbers[8] = 100;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
                Console.Write("\n");
                if (numbers[i] % 2 == 0)
                {
                    Console.Write("-HEP\n");
                }
            }
        }
    }
}