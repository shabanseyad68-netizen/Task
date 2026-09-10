using System;

namespace Task6
{
    #region Problem 1: Point Struct (Basic)
    struct Point_Q1
    {
        public int x;
        public int y;

        public Point_Q1()
        {
            x = 0;
            y = 0;
        }

        public Point_Q1(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }
    }
    #endregion

    #region Problem 2: TypeA Access Modifiers
    class TypeA
    {
        private int F;
        internal int G;
        public int H;

        public void SetF(int value)
        {
            F = value;
            Console.WriteLine("Private F = " + F);
        }
    }
    #endregion

    #region Problem 3: Employee Encapsulation
    struct Employee
    {
        private int EmpId;
        private string Name;
        private double Salary;

        public void SetName(string n)
        {
            Name = n;
        }
        public string GetName()
        {
            return Name;
        }

        public int EmployeeId
        {
            get { return EmpId; }
            set { EmpId = value; }
        }

        public double EmployeeSalary
        {
            get { return Salary; }
            set { Salary = value; }
        }
    }
    #endregion

    #region Problem 4 & 5: Point Struct (Overloading & Custom Formatting)
    struct Point_Q4_Q5
    {
        public int x;
        public int y;

        public Point_Q4_Q5(int _x)
        {
            x = _x;
            y = 0;
        }

        public Point_Q4_Q5(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public override string ToString()
        {
            return "Point Coordinates => X: " + x + " | Y: " + y;
        }
    }
    #endregion

    #region Problem 6: Struct vs Class (Value vs Reference)
    struct StructPoint
    {
        public int x;
    }

    class ClassEmployee
    {
        public string Name;
    }
    #endregion

    class Program
    {
        #region Problem 6 Methods
        static void ModifyStruct(StructPoint p)
        {
            p.x = 100;
        }

        static void ModifyClass(ClassEmployee emp)
        {
            emp.Name = "Ziad";
        }
        #endregion

        static void Main(string[] args)
        {
            #region Problem 1 Test
            Console.WriteLine("--- Problem 1 ---");
            Point_Q1 p1 = new Point_Q1();
            Point_Q1 p2 = new Point_Q1(5, 10);
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            #endregion

            #region Problem 2 Test
            Console.WriteLine("\n--- Problem 2 ---");
            TypeA obj = new TypeA();
            obj.SetF(10);
            obj.G = 20;
            Console.WriteLine("Internal G = " + obj.G);
            obj.H = 30;
            Console.WriteLine("Public H = " + obj.H);
            #endregion

            #region Problem 3 Test
            Console.WriteLine("\n--- Problem 3 ---");
            Employee emp = new Employee();
            emp.EmployeeId = 1;
            emp.SetName("Shaaban");
            emp.EmployeeSalary = 5000.50;
            Console.WriteLine("ID: " + emp.EmployeeId);
            Console.WriteLine("Name: " + emp.GetName());
            Console.WriteLine("Salary: " + emp.EmployeeSalary);
            #endregion

            #region Problem 4 & 5 Test
            Console.WriteLine("\n--- Problem 4 & 5 ---");
            Point_Q4_Q5 pa1 = new Point_Q4_Q5(7);
            Point_Q4_Q5 pa2 = new Point_Q4_Q5(10, 20);
            Console.WriteLine(pa1.ToString());
            Console.WriteLine(pa2.ToString());
            #endregion

            #region Problem 6 Test
            Console.WriteLine("\n--- Problem 6 ---");
            StructPoint myPoint = new StructPoint();
            myPoint.x = 10;
            ModifyStruct(myPoint);
            Console.WriteLine("Struct Value after method: " + myPoint.x);

            ClassEmployee myEmployee = new ClassEmployee();
            myEmployee.Name = "Shaaban";
            ModifyClass(myEmployee);
            Console.WriteLine("Class Value after method: " + myEmployee.Name);
            #endregion
        }
    }
}