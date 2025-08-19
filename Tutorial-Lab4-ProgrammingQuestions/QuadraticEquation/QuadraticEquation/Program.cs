﻿using System;
/*
 Write a program to Create a QuadraticEquation class as per the below specification
The equation form is:
-------------------------------------------------------
|QuadraticEquation                                    |
-------------------------------------------------------
| - a, b, c : double                                  |
| - real_val: double                                  |
| - img_val : double                                  |
-------------------------------------------------------
| + QuadraticEquation()                               |
| + QuadraticEquation (double a, double b, double c)  |
| + solveEquation() :void                             |
| + DisplayEquation(): void                           |
| + DisplayResult() :void                             |
-------------------------------------------------------
                   
    1.	Contructor accepts the three coefficients according to the quadratic equation form
    2.	Default Constructor: Initializes the coefficients to using user inputs.
    3.	Solve(): Solves the quadratic equation for given coefficients using the formula. 
    4.	DisplayEquation(): Displays the equation
    5.	DisplayResult(): Displays the results

    In the Main() method:
    1. Create an Object of the QuadraticEquation class
    2. Call the QuadraticEquation (double a, double b, double c) constructor for initializing the coefficients.
    3. Call solveEquation() to solve the equation
    4. Call DisplayEquation() and the DisplayResult()

    **** Before solving the question please check the instructions given in the tutorial question sheet ****
 */


namespace Week5LabProgram
{
    // Create the class
    class QuadraticEquation
    {
        // /*Complete the code Declare the data variables
        private double a, b, c;
        private double[] real_val = new double[2];
        private double[] img_val = new double[2];

        // Complete the code for Default Constructor
        public QuadraticEquation()
        {
            Console.Write("\nEnter the Coefficient Values for Cofficient a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nEnter the Coefficient Values for Cofficient b:");
            b = Convert.ToDouble(Console.ReadLine());/*Complete the code*/;
            Console.Write("\nEnter the Coefficient Values for Cofficient c:");
            c = Convert.ToDouble(Console.ReadLine());/*Complete the code*/;
        }
        // Complete the code for Overloaded Constrcutor
        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        // /*Complete the code Method to solve the equation
        public void SolveEquation()
        {
            // Calculate the b^2 - 4ac part
            double sqrtpart = Math.Pow(b, 2) - 4 * a * c;

            // Check if b^2 -4ac >0
            if (sqrtpart > 0)
            {
                real_val[0] = (-b + Math.Sqrt(sqrtpart)) / (2 * a);
                real_val[1] = (-b - Math.Sqrt(sqrtpart)) / (2 * a);
                img_val[0] = 0;
                img_val[1] = 0;
            }
            // Check if b^2 -4ac <0
            if (sqrtpart < 0)
            {
                real_val[0] = -b / (2 * a);
                real_val[1] = -b / (2 * a);
                img_val[0] = Math.Sqrt(-sqrtpart) / (2 * a);
                img_val[1] = -Math.Sqrt(-sqrtpart) / (2 * a);
            }
            // Check if b^2 -4ac ==0
            if (sqrtpart == 0)
            {
                real_val[0] = -b / (2.0 * a);
                real_val[1] = -b / (2.0 * a);
                img_val[0] = 0;
                img_val[1] = 0;
            }
        }
        // Display the equation in ax^2 + bx +c = 0 form
        public void DisplayEquation()
        {
            /*Complete the code*/
            Console.WriteLine("\nThe Equation is: {0}x^2 + {1}x + {2} = 0 \n ", a, b, c);
        }

        // Display the result based on the value of b^2 -4ac
        public void DisplayResult()
        {
            if (img_val[0] == 0)
            {
                if (real_val[0] == real_val[1])
                {
                    Console.WriteLine("The Result is: x = {0}", real_val[0]);
                }
                else  
                {
                    Console.WriteLine("The Result is: x = {0}, {1}", real_val[0], real_val[1]);
                }
            }
            else  
            {
                Console.WriteLine("The Result is: x = {0}+{1}i, {2}+{3}i", 
                    real_val[0], img_val[0], real_val[1], img_val[1]);
            }
        }
    }

    // Class for the main()
    class QuadraticEquationTest
    {
        static void Main(string[] args)
        {
            // Create an equation from user input
            QuadraticEquation eq1 = new QuadraticEquation() /*Complete the code*/;
            // Solve the equation
            eq1.SolveEquation()/*Complete the code*/;
            // Display the equation
            eq1.DisplayEquation()/*Complete the code*/;
            // Display the result
            eq1.DisplayResult()/*Complete the code*/;

            // Accept key press from user.
            Console.ReadKey();
        }
    }
}

/*
 Test Case: 

Enter the Coeffient Values for Cofficient a: 2

Enter the Coeffient Values for Cofficient b: 2

Enter the Coeffient Values for Cofficient c: 1

The Equation is:
 2x^2 + 2x + 1 = 0

The Result is: x= -0.5, 0.5
 */
