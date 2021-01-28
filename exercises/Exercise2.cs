using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cssbs_ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            //		********************************************PART 1********************************************
            Console.WriteLine("\nPart 1, sum 10 numbers.");
            int sum = SumTenInts(0, 1);
            char letterGrade = 'X';
            Console.WriteLine($"The sum of ten integers is {sum}");
            //		********************************************PART 2********************************************
            Console.WriteLine("\nPart 2, average 10 numbers.");
            double avg = AvgTenInts(0, 1);
            letterGrade = ConvertNumericToLetterGrade(avg);
            Console.WriteLine($"The average of ten integers is { avg} and the letter grade is { letterGrade }");
            //		********************************************PART 3********************************************
            Console.WriteLine("\nPart 3, average user predetermined number of scores .");
            Console.Write("How many scores do you wish to enter? ");
            string noScores = Console.ReadLine();
            int numScores = int.Parse(noScores);
            double avgl = AvgUnkInts(0, 1, numScores);
            letterGrade = ConvertNumericToLetterGrade(avgl);
            Console.WriteLine($"The average of {numScores} integers is {avgl} and the letter grade is { letterGrade }");
            //		********************************************PART 4********************************************
            Console.WriteLine("\nPart 4, average non—predetermined number of scores .");
            double avg2 = AvgAnyInts(0, 1);
            letterGrade = ConvertNumericToLetterGrade(avg2);
            Console.WriteLine($"The average of ten integers is {avg2} and the letter grade is {letterGrade}");
        }

        //	********************************************METHODS********************************************

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

    }
}
