using System;
namespace FindMaxTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int Maximum = FindMax.num(25, 43, 91);

            float Fmax = FindMaxFloat.num(81.9f, 27.6f, 16.4f);

            string str = FindMaxString.fruit("Apple", "Peach", "Banana");

            Console.Write(Maximum);
            Console.WriteLine(" is the Maximum Number");

            Console.Write(Fmax);
            Console.WriteLine(" is the Maximum Float Number");

            Console.WriteLine(str);
        }
    }
}