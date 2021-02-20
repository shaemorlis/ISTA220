using System;

namespace ParamsArray
{
    class Program
    {
        static void doWork()
        {
            //Console.WriteLine(Util.Sum(null));
            //Console.WriteLine(Util.Sum());
            Console.WriteLine(Util.Sum(10, 9, 8, 7, 6, 5, 4, 3, 2, 1));
            Console.WriteLine(Util.Sum(50));
            Console.WriteLine(Util.Sum(25, 100));
            Console.WriteLine(Util.Sum(56, 84, 79));
            Console.WriteLine(Util.Sum(44, 26, 98, 35));
            Console.WriteLine(Util.Sum(75, 56, 31, 95, 66));
            Console.WriteLine(Util.Sum(1, 2, 3, 4, 5, 6));

        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
namespace ParamsArray
{
    class Util
    {
        public static int Sum(params int[] paramList)
        {
            Console.WriteLine("Using parameter list");
            if (paramList == null)
                throw new ArgumentException("Util.Sum: null parameter list");
            if (paramList.Length == 0)
                throw new ArgumentException("Util.Sum: empty parameter list");
            int sumTotal = 0;
            foreach (int i in paramList)
                sumTotal += i;
            return sumTotal;

        }
        public static int Sum(int param1 = 0, int param2 = 0, int param3 = 0, int param4 = 0)
        {
            Console.WriteLine("Using optional parameters");
            int sumTotal = param1 + param2 + param3 + param4;
            return sumTotal;
        }
    }
}
