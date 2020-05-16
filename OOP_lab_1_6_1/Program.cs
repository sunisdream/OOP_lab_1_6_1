using System;

namespace OOP_lab_1_6_1
{
    public class Program
    {
        public static double Volume (double r, double h)
        {
            return Math.Round(Math.PI * r * r * h, 2);
        }

        public static double Square(double r, double h)
        {
            return Math.Round(2 * Math.PI * r * h, 2);
        }

        static void Main(string[] args)
        {
            double R = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine("V = {0}, S = {1}", Volume(R, h), Square(R, h));
        }
    }
}
