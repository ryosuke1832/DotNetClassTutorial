using System;
/*
Write a program to create a Shape Class and derive two child class, Rectangle and Circle, based 
the specification given in the Tutorial instructions.
 The Base class implementation is provided.
 */
namespace Week6LabProgram
{
    // Base Class Shape
    public class Shape
    {
        // Data members/properties
        public int NumberOfSides { get; set; }
        public double areaVal;

        // Constructor
        public Shape(int NoSides)
        {
            NumberOfSides = NoSides;
        }

        // Virtual method Area() to be overidden by Child class
        public virtual void Area()
        {
            Console.WriteLine("I am from Shape Class");
        }
        // Virtual method Display() to be overidden by Child class
        public virtual void Display()
        {
            Console.WriteLine("The Number of Sides are: {0}", NumberOfSides);
        }
    }

    // Create the Child class Circle derived from Shape
    public class Circle : Shape
    {
        // Write the code for Data member/properties
        public double Radius { get; set; }
        public const double pi = 3.14;

        // Write the code for Constructor
        public Circle(double radius) : base(0)
        {
            Radius = radius;
        }

        // Write the code to override the base class Area() method
        public override void Area() 
        {
            areaVal = Radius * Radius * pi;
                
        }
        // Write the code to override the base class Display() method
        public override void Display()
        {
            Console.WriteLine("\nThe Number of sides of a Circle is : {0}", NumberOfSides);
            Console.WriteLine("The Radius of the Circle is: {0}", Radius);
            Console.WriteLine("The Area of Circle is : {0}", areaVal);
        }
    }

    // Create the child class Rectangle derived from Shape
    public class Rectangle : Shape
    {
        // Write the code for Data member/properties
        public double Length { get; set; }
        public double Breadth { get; set; }

        // Write the code for Constructor
        public Rectangle(double length, double breadth) : base(4)
        {
            Length = length;
            Breadth = breadth;
        }
        // Write the code to override the base class Area() method
        public override void Area()
        {
            areaVal = Length * Breadth;
        }
        // Write the code to override the base class Display() method
        public override void Display()
        {
            Console.WriteLine("\nThe Number of sides of a Rectangle is : {0}", NumberOfSides);
            Console.WriteLine("The Length and Breadth of the Rectangle is: {0}, {1}", Length, Breadth);
            Console.WriteLine("The Area of Rectangle is : {0}", areaVal);
            //  hint: Check the Display method of the Circle class to complete the code.
        }
    }
    class Week6Program2
    {
        static void Main(string[] args)
        {
            // Create Circle and Rectangle Objects
            Circle C1 = new Circle(4);
            Rectangle R1 = new Rectangle(5, 4);

            // Calculate the area
            C1.Area();
            R1.Area();

            // Display the dimensions and area of Circle and Rectangle
            C1.Display();
            R1.Display();

            Console.ReadKey();
            
        }
    }
}

/*
  Test Case:
    The Number of sides of a Circle is : 1
    The Radius of the Circle is: 4
    The Area of Circle is : 50.272

    The Number of sides of a Rectangle is : 4
    The Length and Breadth of the Rectangle is: 5, 4
    The Area of Rectangle is : 20
  
 */
