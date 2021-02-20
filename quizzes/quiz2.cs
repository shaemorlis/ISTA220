using System;

namespace CSharpQuiz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C Sharp Quiz 2");
            Console.WriteLine("Calculating phi using a recursive method by the Fibonacci series");
            Console.WriteLine("Calling CalcPhi(1, 1, 0, 90)");
            double phi = CalcPhi(1, 1, 0, 40);
            Console.WriteLine($"The number phi is equal to {phi}");
        }
        private static double CalcPhi(long first, long next, int place, int target)
        {
            if (place == target)
                return (double)next / (double)first;
            else
                return CalcPhi(next, first + next, place + 1, target);
        }
    }
}

