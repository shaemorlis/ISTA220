using System;

namespace CSharp_exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPart 1, circumference and area of a circle.");
            Console.Write("Enter an integer for the radius: ");
            string strradius = Console.ReadLine();
            int radius = int.Parse(strradius);
            double circumference = Math.PI * 2 * radius;
            Console.WriteLine($"The circumference is {circumference}");
            double area = Math.PI * (radius * radius);
            Console.WriteLine($"The area is {area}");

            Console.WriteLine("\nPart 2, volume of a hemisphere.");
            Console.Write("Enter an integer for the radius: ");
            string hemi = Console.ReadLine();
            int intHemi = int.Parse(hemi);
            double volume = (4 * (Math.PI * (radius * radius * radius)))/3;
            Console.WriteLine($"The volume is {volume/2}");

            Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");
            Console.Write("Enter an integer for the A length: ");
            string strlengthA = Console.ReadLine();
            Console.Write("Enter an integer for the B length: ");
            string strlengthB = Console.ReadLine();
            Console.Write("Enter an integer for the C length: ");
            string strlengthC = Console.ReadLine();
            int lengthA = int.Parse(strlengthA);
            int lengthB = int.Parse(strlengthB);
            int lengthC = int.Parse(strlengthC);
            double areaTriangle = (lengthA + lengthB + lengthC) / 2;
            double pValue = Math.Sqrt(areaTriangle * (areaTriangle - lengthA) * (areaTriangle - lengthB) * (areaTriangle - lengthC)); 
            Console.WriteLine($"The area is {pValue}");

            Console.WriteLine("\nPart 4, solving a quadratic equation. ");
            Console.Write("Enter an non-negative integer for the coefficientA");
            string coefficientA = Console.ReadLine();
            Console.Write("Enter an non-negative integer for the coefficientB");
            string coefficientB = Console.ReadLine();
            Console.Write("Enter an non-negative integer for the coefficientC");
            string coefficientC = Console.ReadLine();
            int coefficientintA = int.Parse(coefficientA);
            int coefficientintB = int.Parse(coefficientB);
            int coefficientintC = int.Parse(coefficientC);
            double positive_num = -coefficientintB + Math.Sqrt((coefficientintB * coefficientintB) - 4 * coefficientintA * coefficientintC);
            double negative_num = -coefficientintB - Math.Sqrt((coefficientintB * coefficientintB) - 4 * coefficientintA * coefficientintC);
            double denominator = 2 * coefficientintA;
            Console.WriteLine($"The positive solution is {positive_num / denominator}");
            Console.WriteLine($"The negative solution is {negative_num / denominator}"); 

        }
    }
}
