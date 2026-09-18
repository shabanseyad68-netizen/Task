using System;
using System.Collections.Generic;

namespace Task08_Submission
{
    #region Part01 - IVehicle
    public interface IVehicle
    {
        void StartEngine();
        void StopEngine();
    }

    public class Car : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Car engine is starting now...");
        }

        public void StopEngine()
        {
            Console.WriteLine("Car engine stopped.");
        }
    }

    public class Bike : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Bike engine started.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Bike engine stopped.");
        }
    }
    #endregion

    #region Part01 - Shape Abstract Class
    public abstract class ShapeBase
    {
        public abstract double GetArea();

        public void Display()
        {
            // using normal concatenation 
            Console.WriteLine("The area = " + GetArea());
        }
    }

    public class RectangleShape : ShapeBase
    {
        public double width { get; set; }
        public double height { get; set; }

        public override double GetArea()
        {
            return width * height;
        }
    }

    public class CircleShape : ShapeBase
    {
        public double radius { get; set; }

        public override double GetArea()
        {
            return 3.14 * radius * radius; // using 3.14 instead of Math.PI
        }
    }
    #endregion

    #region Part01 - Product IComparable
    public class Product : IComparable<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public int CompareTo(Product other)
        {
            // beginner way to compare
            if (this.Price > other.Price)
            {
                return 1;
            }
            else if (this.Price < other.Price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return Name + " - Price: " + Price;
        }
    }
    #endregion

    #region Part01 - Student Copy Constructor
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Grade { get; set; }

        // normal constructor
        public Student()
        {
        }

        // copy constructor for deep copy
        public Student(Student s)
        {
            this.Id = s.Id;
            this.Name = s.Name;
            this.Grade = s.Grade;
        }
    }
    #endregion

    #region Part01 - IWalkable
    public interface IWalkable
    {
        void Walk();
    }

    public class Robot : IWalkable
    {
        public void Walk()
        {
            Console.WriteLine("Robot walking normal");
        }

        // explicit implementation
        void IWalkable.Walk()
        {
            Console.WriteLine("Robot walking from interface");
        }
    }
    #endregion

    #region Part01 - Account Struct
    public struct Account
    {
        private int accountId;
        private string accountHolder;
        private double balance;

        public int AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }
        public string AccountHolder
        {
            get { return accountHolder; }
            set { accountHolder = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }
    #endregion

    #region Part01 - ILogger
    public interface ILogger
    {
        // default method in interface
        public void Log()
        {
            Console.WriteLine("Default log message");
        }
    }

    public class ConsoleLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Console logger message");
        }
    }
    #endregion

    #region Part01 - Book Constructor Overloading
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book()
        {
        }

        public Book(string t)
        {
            Title = t;
        }

        public Book(string t, string a)
        {
            Title = t;
            Author = a;
        }
    }
    #endregion

    #region Part02 - Shape Series
    public interface IShapeSeries
    {
        int CurrentShapeArea { get; set; }
        void GetNextArea();
        void ResetSeries();
    }

    public class SquareSeries : IShapeSeries
    {
        public int side = 1;
        public int CurrentShapeArea { get; set; }

        public void GetNextArea()
        {
            CurrentShapeArea = side * side;
            side++; // increment by 1
        }

        public void ResetSeries()
        {
            side = 1;
            CurrentShapeArea = 0;
        }
    }

    public class CircleSeries : IShapeSeries
    {
        public int radius = 1;
        public int CurrentShapeArea { get; set; }

        public void GetNextArea()
        {
            CurrentShapeArea = (int)(Math.PI * radius * radius);
            radius++;
        }

        public void ResetSeries()
        {
            radius = 1;
            CurrentShapeArea = 0;
        }
    }
    #endregion

    #region Part02 - Implement Sorting for Shapes
    public class Shape : IComparable<Shape>
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public int CompareTo(Shape other)
        {
            if (this.Area > other.Area) return 1;
            if (this.Area < other.Area) return -1;
            return 0;
        }
    }
    #endregion

    #region Part02 - Extend the Shape Hierarchy
    public abstract class GeometricShape
    {
        public double Dimension1 { get; set; }
        public double Dimension2 { get; set; }

        public abstract double CalculateArea();
        public abstract double Perimeter { get; }
    }

    public class Triangle : GeometricShape
    {
        public override double CalculateArea()
        {
            return 0.5 * Dimension1 * Dimension2;
        }

        public override double Perimeter
        {
            get
            {
                // simple perimeter calc
                return Dimension1 + Dimension2 + Math.Sqrt((Dimension1 * Dimension1) + (Dimension2 * Dimension2));
            }
        }
    }

    public class RectangleClass : GeometricShape
    {
        public override double CalculateArea()
        {
            return Dimension1 * Dimension2;
        }

        public override double Perimeter
        {
            get
            {
                return 2 * (Dimension1 + Dimension2);
            }
        }
    }
    #endregion

    #region Part02 - Factory Pattern
    public class ShapeFactory
    {
        public GeometricShape CreateShape(string shapeType, double d1, double d2)
        {
            if (shapeType == "Rectangle")
            {
                RectangleClass r = new RectangleClass();
                r.Dimension1 = d1;
                r.Dimension2 = d2;
                return r;
            }
            else if (shapeType == "Triangle")
            {
                Triangle t = new Triangle();
                t.Dimension1 = d1;
                t.Dimension2 = d2;
                return t;
            }
            else
            {
                return null; // instead of throwing advanced exceptions
            }
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            // testing the series
            SquareSeries sq = new SquareSeries();
            PrintTenShapes(sq);

            Console.WriteLine("----------------");

            // testing selection sort
            int[] arr = { 40, 10, 50, 20, 30 };
            SelectionSort(arr);

            Console.WriteLine("Array after sorting:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadLine(); // to keep console open
        }

        #region Part02 - Methods
        public static void PrintTenShapes(IShapeSeries series)
        {
            series.ResetSeries();
            for (int i = 1; i <= 10; i++)
            {
                series.GetNextArea();
                Console.WriteLine("Area " + i + ": " + series.CurrentShapeArea);
            }
        }

        public static void SelectionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[min_idx])
                    {
                        min_idx = j;
                    }
                }

                // swap
                int temp = numbers[min_idx];
                numbers[min_idx] = numbers[i];
                numbers[i] = temp;
            }
        }
        #endregion
    }
}