using System;

namespace ConsoleApp3
{
    public class Operations
    {
        public double Division(double a, double b)
        {
            return a / b;
        }
        public double Multiplication(double a, double b)
        {
            return a * b;
        }
        public double Subtraction(double a, double b)
        {
            return a - b;
        }
        public double Plus(double a, double b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Operations obj1 = new Operations();
            Console.WriteLine(obj1.Division(12.6, 4.2));
            Console.WriteLine(obj1.Multiplication(12.6, 4.2));
            Console.WriteLine(obj1.Subtraction(4.4, 12.4));
            Console.WriteLine(obj1.Plus(12.4, 4.4));

        }
    }
}
