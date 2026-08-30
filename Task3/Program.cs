using System;
using System.Text;

namespace Task03
{
    class Program
    {
        static void Main()
        {
            #region Problem 1: Parse and Convert
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            try
            {
                int num1 = int.Parse(input);
                int num2 = Convert.ToInt32(input);
                Console.WriteLine("Converted successfully!");
            }
            catch
            {
                Console.WriteLine("Exception caught! Invalid input for Parse/Convert.");
            }
            #endregion

            #region Problem 2: TryParse
            Console.WriteLine("Enter a number:");
            string inputNum = Console.ReadLine();
            if (int.TryParse(inputNum, out int res))
            {
                Console.WriteLine($"Valid number: {res}");
            }
            else
            {
                Console.WriteLine("Error: Invalid number");
            }
            #endregion

            #region Problem 3: Object and GetHashCode
            object obj = 5;
            Console.WriteLine($"Hash for int (5): {obj.GetHashCode()}");

            obj = "Hello";
            Console.WriteLine($"Hash for string (Hello): {obj.GetHashCode()}");

            obj = 5.5;
            Console.WriteLine($"Hash for double (5.5): {obj.GetHashCode()}");
            #endregion

            #region Problem 4: Reference Equality
            int[] arr1 = { 10 };
            int[] arr2 = arr1;
            arr1[0] = 20;
            Console.WriteLine($"Value from arr2: {arr2[0]}");
            #endregion

            #region Problem 5: String Immutability
            string s = "Hi ";
            Console.WriteLine($"String Hash before: {s.GetHashCode()}");
            s += "Willy";
            Console.WriteLine($"String Hash after: {s.GetHashCode()}");
            #endregion

            #region Problem 6: StringBuilder Efficiency
            StringBuilder sb = new StringBuilder("Hi ");
            Console.WriteLine($"StringBuilder Hash before: {sb.GetHashCode()}");
            sb.Append("Willy");
            Console.WriteLine($"StringBuilder Hash after: {sb.GetHashCode()}");
            #endregion

            #region Problem 7: String Formatting Methods
            int input1 = 3, input2 = 4;
            Console.WriteLine("Sum is " + (input1 + input2)); 
            Console.WriteLine(string.Format("Sum is {0}", input1 + input2)); 
            Console.WriteLine($"Sum is {input1 + input2}"); 
            #endregion

            #region Problem 8: StringBuilder Operations
            StringBuilder sb2 = new StringBuilder("Text");
            sb2.Append(" added"); 
            sb2.Replace("added", "changed"); 
            sb2.Insert(0, "Start "); 
            sb2.Remove(0, 6); 
            Console.WriteLine($"Final StringBuilder output: {sb2.ToString()}");
            #endregion
        }
    }
}