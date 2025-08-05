using System;


/*
Program 1:
Write a C# Program to read 10 numbers as user input and find the following:
    a.	Sum of the numbers,
    b.	Average of the numbers,
    c.	Largest number, and 
    d.	Smallest number
    
    Without using arrays!

    Example:
    Enter 10 numbers: 1 2 3 4 5 6 7 8 9 10
    Sum = 55
    Average = 5.5
    Largest number = 10
    Smallest number = 1

    Hint:
    Read the numbers in a loop!

    ** Please Check the complete code and the test cases in order to 
       understand the control flow before trying to solve the questions
*/

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassTuorials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[10];
            int sum = 0;
            int maxNum = int.MinValue;
            int minNum = int.MaxValue;

            Console.WriteLine("Enter 10 numbers: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter number{i+1}: ");
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                sum += number;
                if (number > maxNum)
                {
                    maxNum = number;
                }
                if (number < minNum)
                {
                    minNum = number;
                }

            }
            float ave = sum / 10.0f;
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Largest Number:: {maxNum}");
            Console.WriteLine($"Smallest number: {minNum}");
            Console.WriteLine($"Average: {ave:F1}");


        }
    }
}



// namespace Week3LabProgram
// {
//     class Program1
//     {
//         static void Main(string[] args)
//         {
//             // Variable declaration
//             // int for numbers, string for user input and float for average
//             int ;
//             string ;
//             float ;

//             // Initialize flags to assign the first value to the variables
//             bool initializedSmallestNumber = false, initializedLargestNumber = false;

//             // Input 10 numbers from user in a loop and
//             // compute the sum, largest and smallest number
//             Console.WriteLine(""); // Enter the code here

//             // Write the code initialize the for loop
//             for (; ; )
//             {
//                 //Display message to user to enter a number
//                 // Complete the code
//                 Console.Write("Enter number {0}: ", );

//                 // Write the code Read the user input as string
//                 inputNumber = ;

//                 //Convert user input from string to integer
//                 // Hint: use Convert.ToInt32()
//                 number = ;

//                 // Initial the variable to track largest and smallest number to the first value entered by user
//                 if (!(initializedLargestNumber && initializedSmallestNumber))
//                 {
//                     // Write the code below
//                     largestNumber = ;
//                     smallestNumber = ;

//                     // Change the bool variable to true
//                     initializedSmallestNumber = initializedLargestNumber = ;
//                 }

//                 // Write the code to Add all the numbers
//                 sum = ;

//                 // Write the code to Check for largest number
//                 if ()
//                 {
//                     largestNumber = ;
//                 }
//                 // Write the code to Check for smallest number
//                 if ()
//                 {
//                     smallestNumber = ;
//                 }
//             }

//             //Write the code to compute average
//             average = ;

//             // Complete the code to Display result
//             Console.WriteLine("\nSum = {0}", );
//             Console.WriteLine("Average: {0}", );
//             Console.WriteLine("Largest Number: {0}", );
//             Console.WriteLine("Smallest number: {0}", );


//             //Write the code to Accept a key entry from user

//         }
//     }
// }


/*
Test case:

    Enter 10 numbers:
    Enter number 1: 5
    Enter number 2: 6
    Enter number 3: 9
    Enter number 4: 8
    Enter number 5: 4
    Enter number 6: 5
    Enter number 7: 32
    Enter number 8: 1
    Enter number 9: 5
    Enter number 10: 2

    Sum = 77
    Largest Number: 32
    Smallest number: 1
    Average: 7.7


*/
