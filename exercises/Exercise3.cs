using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cssbs_ex03
{
    class Program
    {

        //	********************************************METHODS********************************************
        static void circumference_and_area_of_circle()
        {

            while (true)
            {

                try
                {
                    Console.Write("Enter an integer for the radius: ");
                    string strradius = Console.ReadLine();
                    int radius = int.Parse(strradius);

                    if (radius <= 0)
                    {
                        Console.WriteLine("Your number is out of range.");
                    }
                    else
                    {
                        double circumference = Math.PI * 2 * radius;
                        Console.WriteLine($"The circumference is {circumference}");
                        double area = Math.PI * (radius * radius);
                        Console.WriteLine($"The area is {area}");
                        break;

                    }
                }
                catch
                {
                    Console.WriteLine("You must enter a valid number.");
                }
                finally
                {
                    Console.WriteLine("Okay.");
                }

            }
        }

        static void volume_of_hemisphere()
        {

            while (true)
            {

                try
                {
                    Console.Write("Enter an integer for the radius: ");
                    string strradius = Console.ReadLine();
                    int radius = int.Parse(strradius);

                    if (radius <= 0)
                    {
                        Console.WriteLine("Your number is out of range.");
                    }
                    else
                    {
                        double volume = (4 * (Math.PI * (radius * radius * radius))) / 3;
                        Console.WriteLine($"The volume is {volume / 2}");
                        break;

                    }
                }
                catch
                {
                    Console.WriteLine("You must enter a valid number.");
                }
                finally
                {
                    Console.WriteLine("Okay.");
                }

            }
        }

        static void area_of_triangle()
        {

            while (true)
            {

                try
                {
                    Console.Write("Enter an integer for the A length: ");
                    string strlengthA = Console.ReadLine();
                    Console.Write("Enter an integer for the B length: ");
                    string strlengthB = Console.ReadLine();
                    Console.Write("Enter an integer for the C length: ");
                    string strlengthC = Console.ReadLine();
                    int lengthA = int.Parse(strlengthA);
                    int lengthB = int.Parse(strlengthB);
                    int lengthC = int.Parse(strlengthC);

                    if (lengthA <= 0)
                    {
                        Console.WriteLine("Your A length is out of range.");
                    }
                    else if (lengthB <= 0)
                    {
                        Console.WriteLine("Your B length is out of range.");
                    }
                    else if (lengthC <= 0)
                    {
                        Console.WriteLine("Your C length is out of range.");
                    }
                    else
                    {

                        double areaTriangle = (lengthA + lengthB + lengthC) / 2;
                        double pValue = Math.Sqrt(areaTriangle * (areaTriangle - lengthA) * (areaTriangle - lengthB) * (areaTriangle - lengthC));
                        Console.WriteLine($"The area is {pValue}");
                        break;

                    }
                }
                catch
                {
                    Console.WriteLine("You must enter a valid number.");
                }
                finally
                {
                    Console.WriteLine("Okay.");
                }

            }
        }

        static void quadratic_equation()
        {

            while (true)
            {

                try
                {
                    Console.Write("Enter a non-negative integer for the coefficientA: ");
                    string coefficientA = Console.ReadLine();
                    Console.Write("Enter a non-negative integer for the coefficientB: ");
                    string coefficientB = Console.ReadLine();
                    Console.Write("Enter a non-negative integer for the coefficientC: ");
                    string coefficientC = Console.ReadLine();
                    int coefficientintA = int.Parse(coefficientA);
                    int coefficientintB = int.Parse(coefficientB);
                    int coefficientintC = int.Parse(coefficientC);

                    if (coefficientintA <= 0)
                    {
                        Console.WriteLine("Your coefficientintA is negetive.");
                    }
                    else if (coefficientintB <= 0)
                    {
                        Console.WriteLine("Your coefficientintB is negetive.");
                    }
                    else if (coefficientintC <= 0)
                    {
                        Console.WriteLine("Your coefficientintC is negetive.");
                    }
                    else
                    {
                        double positive_num = -coefficientintB + Math.Sqrt((coefficientintB * coefficientintB) - 4 * coefficientintA * coefficientintC);
                        double negative_num = -coefficientintB - Math.Sqrt((coefficientintB * coefficientintB) - 4 * coefficientintA * coefficientintC);
                        double denominator = 2 * coefficientintA;
                        Console.WriteLine($"The positive solution is {positive_num / denominator}");
                        Console.WriteLine($"The negative solution is {negative_num / denominator}");
                        break;

                    }
                }
                catch
                {
                    Console.WriteLine("You must enter a valid number.");
                }
                finally
                {
                    Console.WriteLine("Okay.");
                }

            }
        }

        private static char ConvertNumericToLetterGrade(double grade)
        {

            if (grade >= 90)
                return 'A';
            else if (grade >= 80)
                return 'B';
            else if (grade >= 70)
                return 'C';
            else if (grade >= 60)
                return 'D';
            else
                return 'F';
        }

        private static double AvgAnyInts(int sum, int count)
        {
            var input = 0;

            Console.WriteLine("Enter a score between 0 and 100 (use -1 as a stop value): ");
            while (!(int.TryParse(Console.ReadLine(), out input) && input > -2 && input <= 100))    //validating if value is between 0 and 100
            {
                Console.Write("The value must be a number between 0 and 100. Please Enter again: ");
            }
            int input_number = Convert.ToInt32(input);

            if (input_number != -1) // recursive call
            {
                sum += input_number;
                return AvgAnyInts(sum, count + 1);
            }

            if (input_number == -1)
                return (sum / (count - 1));
            else // end case
                return sum;
        }

        private static double AvgUnkInts(int sum, int count, int numScores)
        {
            var input = 0;

            Console.WriteLine("Enter a score between 0 and 100: ");
            while (!(int.TryParse(Console.ReadLine(), out input) && input > 0 && input <= 100))    //validating if value is between 0 and 100
            {
                Console.Write("The value must be a number between 0 and 100. Please Enter again: ");
            }
            sum += input;

            if (count < numScores)      // recursive call
                return AvgUnkInts(sum, count + 1, numScores);
            if (count == numScores)
                return (sum / numScores);
            else                        // end case
                return sum;
        }

        private static double AvgTenInts(int sum, int count)
        {
            var input = 0;

            Console.WriteLine("Enter a score between 0 and 100: ");
            while (!(int.TryParse(Console.ReadLine(), out input) && input > 0 && input <= 100))    //validating if value is between 0 and 100
            {
                Console.Write("The value must be a number between 0 and 100. Please Enter again: ");
            }
            sum += input;

            if (count < 10)             // recursive call
                return AvgTenInts(sum, count + 1);
            if (count == 10)
                return (sum / count);
            else                        // end case
                return sum;
        }

        private static int SumTenInts(int sum, int count)
        {
            var input = 0;

            Console.WriteLine("Enter a score between 0 and 100: ");
            while (!(int.TryParse(Console.ReadLine(), out input) && input > 0 && input <= 100))    //validating if value is between 0 and 100
            {
                Console.Write("The value must be a number between 0 and 100. Please Enter again: ");
            }
            sum += input;

            if (count < 10)             // recursive call
                return SumTenInts(sum, count + 1);
            else                        // end case
                return sum;
        }


        static void Main(string[] args)
        {
            //		********************************************PART 1********************************************
            Console.WriteLine("\nPart 1, circumference and area of a circle.");
            circumference_and_area_of_circle();

            //		********************************************PART 2********************************************
            Console.WriteLine("\nPart 2, volume of a hemisphere.");
            volume_of_hemisphere();

            //		********************************************PART 3********************************************
            Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");
            area_of_triangle();

            //		********************************************PART 4********************************************
            Console.WriteLine("\nPart 4, solving a quadratic equation. ");
            quadratic_equation();

            //		********************************************PART 5********************************************
            char letterGrade = 'X';

            Console.WriteLine("\nPart 5, sum 10 numbers.");
            try
            {
                int sum = SumTenInts(0, 1);
                Console.WriteLine($"The sum of ten integers is {sum}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("You must enter a valid number.");
            }
            finally
            {
                Console.WriteLine("Okay.");
            }


            //		********************************************PART 6********************************************
            Console.WriteLine("\nPart 6, average 10 numbers.");
            try
            {
                double avg = AvgTenInts(0, 1);
                letterGrade = ConvertNumericToLetterGrade(avg);
                Console.WriteLine($"The average of ten integers is { avg} and the letter grade is { letterGrade }");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("You must enter a valid number.");
            }
            finally
            {
                Console.WriteLine("Okay.");
            }


            //		********************************************PART 7********************************************
            Console.WriteLine("\nPart 7, average user predetermined number of scores .");
            try
            {
                Console.Write("How many scores do you wish to enter? ");
                string noScores = Console.ReadLine();
                int numScores = int.Parse(noScores);
                double avgl = AvgUnkInts(0, 1, numScores);
                letterGrade = ConvertNumericToLetterGrade(avgl);
                Console.WriteLine($"The average of {numScores} integers is {avgl} and the letter grade is { letterGrade }");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("You must enter a valid number.");
            }
            finally
            {
                Console.WriteLine("Okay.");
            }


            //		********************************************PART 8********************************************
            Console.WriteLine("\nPart 8, average non—predetermined number of scores .");
            try
            {
                double avg2 = AvgAnyInts(0, 1);
                letterGrade = ConvertNumericToLetterGrade(avg2);
                Console.WriteLine($"The average of ten integers is {avg2} and the letter grade is {letterGrade}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("You must enter a valid number.");
            }
            finally
            {
                Console.WriteLine("Okay.");
            }


        }
    }
}

