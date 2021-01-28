using System;

namespace RecursionLab
{
    class Program
    {
        static void Main(string[] args)
        {
            long sumofNumbers = SumMethod(0, 0, 10);
            Console.WriteLine(sumofNumbers);
            long factorial = CalcFactorial(1, 1, 10);
            Console.WriteLine(factorial);
        }

        private static long CalcFactorial(long fac, int start, int end)
        {
            Console.WriteLine($"Calling CalcFactorial ({fac}), {start}, {end})");
            if (start == end)
                return fac;
            else
                return CalcFactorial(fac * start, start + 1, end); 
        }

        private static long SumMethod(int long sum, int start, int end)
        {
            Console.WriteLine($"Calling SumMethod ({sum}), {start}, {end})");
            if (start > end)
                return sum;
            return SumMethod(sum + start, start + 1, end);
        }
    }
}
