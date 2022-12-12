using System;

namespace Genrics
{
    class program
    {
        public static void toPrint(int[] inputArray)
        {
            foreach (int element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-----------------------");
        }



        public static void toPrint(double[] inputArray)
        {
            foreach (double element in inputArray)
            {
                Console.WriteLine(element);

            }
            Console.WriteLine("-----------------------");
        }
        public static void toPrint(char[] inputArray)
        {
            foreach (char element in inputArray)
            {
                Console.WriteLine(element);

            }
            Console.WriteLine("-----------------------");
        }
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 2.1, 2.2, 9.3, 4.7 };
            char[] charArray = { 'a', 'b', 'c', 'd', 'e' };
            program.toPrint(intArray);
            program.toPrint(doubleArray);
            program.toPrint(charArray);
        }
    }
}