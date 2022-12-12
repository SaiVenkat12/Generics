using System;
using System.Collections.Generic;

namespace Generics
{
    class program
    {
        public static void toPrint<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("----------------------------");
        }
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, };
            double[] doubleArray = { 2.1, 2.2, 9.3, 4.7 };
            char[] charArray = { 'a', 'b', 'c', 'd' };

            program.toPrint<int>(intArray);
            program.toPrint<double>(doubleArray);
            program.toPrint<char>(charArray);


        }
    }
}