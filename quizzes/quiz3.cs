using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cssbs_quiz03
    {
        public class NegativeNumberException : Exception
        {
            public NegativeNumberException()
            {
            }

            public NegativeNumberException(string message)
                : base(message)
            {
            }

            public NegativeNumberException(string message, System.Exception innerException)
                : base(message, innerException)
            {
            }
        }

        public class ZeroNumberException : Exception
        {
            public ZeroNumberException()
            {
            }

            public ZeroNumberException(string message)
                : base(message)
            {
            }

            public ZeroNumberException(string message, System.Exception innerException)
                : base(message, innerException)
            {
            }
        }

        class Program
        {
            static void reciprocal()
            {

                while (true)
                {
                    try
                    {
                        Console.Write("To calculate the reciprocal of an integer, Enter a positive integer: ");
                        string integer = Console.ReadLine();
                        double pos_integer = double.Parse(integer);

                        if (pos_integer < 0)
                        {
                            throw new NegativeNumberException("Your number must be a positive number");
                        }
                        else if (pos_integer == 0)
                        {
                            throw new ZeroNumberException("Attempted to divide by zero.");
                        }
                        else
                        {
                            double reciprocal = 1 / pos_integer;
                            Console.WriteLine($"The reciprocal is {reciprocal}");

                            break;

                        }
                    }
                    catch (NegativeNumberException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (ZeroNumberException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Input string was not in a correct format.");
                    }
                }
            }

            static void Main(string[] args)
            {
                Console.WriteLine("This is C Sharp quiz 3.\n");
                reciprocal();

                Console.ReadLine();

            }
        }
    }
