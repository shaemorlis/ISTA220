using System;

namespace CSharp_Quiz5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is CSharp Quiz 05");
            string quiz = "I think, therefore I am";
            Console.WriteLine($"The quiz string [{quiz}].");
            string[] quiz5 = quiz.Split(' ');
            int len = quiz5.Length;
            Console.WriteLine($"Length of string array is {len}");

            for (int i = len - 1; i >= 0; i--)
            {
                Console.WriteLine($"{i} {quiz5[i]}");

            }
            Console.WriteLine("Press any key to continue.");

        }
    }
}
