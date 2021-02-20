using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseNo5
{
     class Program
     {
          static void Main(string[] args)
          {
               //Initialiating Arrays
               int[] ArrayA = { 0, 2, 4, 6, 8, 10 };
               int[] ArrayB = { 1, 3, 5, 7, 9 };
               int[] ArrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

               System.Console.WriteLine("*************** Arrays Before Operations ***************");
               System.Console.Write("\n");

               System.Console.WriteLine("Array A:");
               for (int i = 0; i < ArrayA.Length; i++) 
               {
                    Console.Write("{0}  ", ArrayA[i]);//Displaying Array A 
               }

               System.Console.Write("\n\n");

               System.Console.WriteLine("Array B:");
               for (int i = 0; i < ArrayB.Length; i++)
               {
                    Console.Write("{0}  ", ArrayB[i]);//Displaying Array B 
               }

               System.Console.Write("\n\n");

               System.Console.WriteLine("Array C:");
               for (int i = 0; i < ArrayC.Length; i++)
               {
                    Console.Write("{0}  ", ArrayC[i]);//Displaying Array C 
               }

               System.Console.Write("\n\n");

               //Function calling and displaying arrays after Mean
               System.Console.WriteLine("*************** Arrays After Mean ***************");
               Console.Write("\n");               
               System.Console.WriteLine($"Mean of Array A: {CalculateMean(ArrayA)}");
               System.Console.WriteLine($"Mean of Array B: {CalculateMean(ArrayB)}");
               System.Console.WriteLine($"Mean of Array C: {CalculateMean(ArrayC)}");

               Console.Write("\n");

               //Function calling and displaying arrays after reverse
               System.Console.WriteLine("*************** Arrays After Reverse ***************");
               Console.Write("\n");
               System.Console.WriteLine("Reversed Array:A");
               ReverseAnArray(ArrayA);
               Console.Write("\n");
               System.Console.WriteLine("Reversed Array:B");
               ReverseAnArray(ArrayB);
               Console.Write("\n");
               System.Console.WriteLine("Reversed Array:C");
               ReverseAnArray(ArrayC);

               Console.Write("\n");

               //Function calling and displaying arrays after rotation
               System.Console.WriteLine("*************** Arrays after Rotation ***************");
               Console.Write("\n");
               System.Console.WriteLine("After rotating array A by two places to the left.");
               RotateAnArray(ArrayA, 2, "left");
               Console.Write("\n\n");
               System.Console.WriteLine("After rotating array B by two places to the right.");
               RotateAnArray(ArrayB, 2, "right");
               Console.Write("\n\n");
               System.Console.WriteLine("After rotating array C by four places to the left.");
               RotateAnArray(ArrayC, 4, "left");

               Console.Write("\n\n");

               //Function calling and displaying arrays after sorting
               System.Console.WriteLine("*************** Arrays after Sorting ***************");
               Console.Write("\n");
               System.Console.WriteLine("Array A:");
               SortAnArray(ArrayA);
               Console.Write("\n\n");
               System.Console.WriteLine("Array B:");
               SortAnArray(ArrayB);
               Console.Write("\n\n");
               System.Console.WriteLine("Array C:");
               SortAnArray(ArrayC);

               System.Console.ReadLine();//reading input
          }
          //Function to calculate mean of given array
          public static double CalculateMean(int[] array)
          {
               double count = array.Length;//taking array length
               double totalSum = 0;
               for (int i = 0; i < count; i++)
                    totalSum += array[i];//taking sum
               return totalSum/count;//taking average and return
          }

          //Function to Reverse the given array 
          public static void ReverseAnArray(int[] array)
          {
               for (int i = array.Length - 1; i >= 0; i--)
               {
                    Console.Write("{0}  ", array[i]);//Displaying resulted array
               }
               Console.Write("\n");
          }

          //Function to Rotate the given array
          public static void RotateAnArray(int[] array, int noOfPlaces, string direction)
          {
               if (direction == "right")//condition to rotate right  
               {
                    for (int i = 0; i < noOfPlaces; i++)
                    {
                         int j, last;
                         //Stores the last element of array  
                         last = array[array.Length - 1];

                         for (j = array.Length - 1; j > 0; j--)
                         {
                              //Shift element of array by one  
                              array[j] = array[j - 1];
                         }
                         //Last element of array will be added to the start of array.  
                         array[0] = last;
                    }

                    for (int i = 0; i < array.Length; i++)
                    {
                         Console.Write("{0}  ", array[i]);//Displaying resulted array
                    }
               }
               else if (direction == "left")//condition to rotate left 
               {
                    for (int i = 0; i < noOfPlaces; i++)
                    {
                         int j, first;
                         //Stores the first element of array  
                         first = array[0];

                         for (j = 0; j < array.Length - 1; j++)
                         {
                              //Shift element of array by one  
                              array[j] = array[j + 1];
                         }
                         //first element of array will be added to the index  
                         array[array.Length - 1] = first;
                    }

                    for (int i = 0; i < array.Length; i++)
                    {
                         Console.Write("{0}  ", array[i]);//Displaying resulted array
                    }
               }
               else //condition for invalid direction 
               {
                    Console.WriteLine("Enter valid direction!");
                    return;
               }
          }

          //Function to Sort the given array
          public static void SortAnArray(int[] array)
          {
               int size = array.Length;//taking array length
               int temp = 0;
               for (int i = 0; i < size; i++)
               {
                    for (int j = i + 1; j < size; j++)
                    {
                         if (array[j] < array[i])
                         {
                              //swapping the element
                              temp = array[i];
                              array[i] = array[j];
                              array[j] = temp;
                         }
                    }
               }

               for (int i = 0; i < size; i++)
               {
                    Console.Write("{0}  ", array[i]);//Displaying resulted array
               }               
          }          
     }
}
