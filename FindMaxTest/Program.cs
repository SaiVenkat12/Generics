using System;
namespace FindMaxTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int Maximum = FindMax.num(29, 43, 81);
            float Fmax = FindMaxFloat.num(38.9f, 27.6f, 16.4f);

            Console.Write(Maximum);
            Console.WriteLine(" is the Maximum Number");
            Console.Write(Fmax);
            Console.Write(" is the Maximum Float Number");
        }
    }
}