using System;

namespace Operator.Exc
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            if (a == 17 && b == 4) ;
            Console.WriteLine($"17/4 is {quotient} remainder {remainder}");

            //Area of Circle

            double pi = 3.14;

            Console.WriteLine("What is the radius of your circle?");
            int radius = int.Parse(Console.ReadLine());
            double product = 3.14 * radius;

            Console.WriteLine($"The area of a circle with a radius of {radius} is {product}");

            




        }
    }
}
