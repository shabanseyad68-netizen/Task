
namespace Task4
    {
        enum DayOfWeek
        {
            Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }

        class Program
        {
            static void Main(string[] args)
            {
                #region  Problem 1
                int[] arr1 = new int[3];
                arr1[0] = 10;
                arr1[1] = 20;
                arr1[2] = 30;

                int[] arr2 = new int[3] { 40, 50, 60 };

                int[] arr3 = { 70, 80, 90 };

                Console.WriteLine($"{arr3[0]}, {arr3[1]}, {arr3[2]}");

                try
                {
                    Console.WriteLine(arr3[5]);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                #endregion

                #region  Problem 2
                int[] original = { 1, 2, 3 };

                int[] shallowCopy = original;
                shallowCopy[0] = 99;
                Console.WriteLine(original[0]);

                int[] deepCopy = (int[])original.Clone();
                deepCopy[0] = 500;
                Console.WriteLine(original[0]);
                #endregion

                #region  Problem 3
                int[,] grades = new int[3, 3];

                for (int i = 0; i < grades.GetLength(0); i++)
                {
                    for (int j = 0; j < grades.GetLength(1); j++)
                    {
                        Console.Write($"Enter grade for Student {i + 1}, Subject {j + 1}: ");
                        grades[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                for (int i = 0; i < grades.GetLength(0); i++)
                {
                    Console.Write($"Student {i + 1} Grades: ");
                    for (int j = 0; j < grades.GetLength(1); j++)
                    {
                        Console.Write(grades[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                #endregion

                #region  Problem 4
                int[] numbers = { 50, 20, 40, 10, 30 };

                Array.Sort(numbers);
                Array.Reverse(numbers);
                int index = Array.IndexOf(numbers, 40);

                int[] copiedArray = new int[5];
                Array.Copy(numbers, copiedArray, 3);
                Array.Clear(numbers, 0, numbers.Length);
                #endregion

                #region Problem 5
                int[] printArr = { 1, 2, 3, 4, 5 };

                for (int i = 0; i < printArr.Length; i++)
                {
                    Console.Write(printArr[i] + " ");
                }

                Console.WriteLine();

                foreach (int item in printArr)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine();

                int counter = printArr.Length - 1;
                while (counter >= 0)
                {
                    Console.Write(printArr[counter] + " ");
                    counter--;
                }
                Console.WriteLine();
                #endregion

                #region  Problem 6
                int oddNum;
                bool isValid;

                do
                {
                    Console.Write("Enter a positive odd number: ");
                    string input = Console.ReadLine();
                    isValid = int.TryParse(input, out oddNum) && oddNum > 0 && oddNum % 2 != 0;
                } while (!isValid);
                #endregion

                #region  Problem 7
                int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                #endregion

                #region  Problem 8
                Console.Write("Enter month number (1-12): ");
                if (int.TryParse(Console.ReadLine(), out int month))
                {
                    string monthNameIf = "";
                    if (month == 1) monthNameIf = "January";
                    else if (month == 2) monthNameIf = "February";
                    else if (month == 3) monthNameIf = "March";

                    string monthNameSwitch = month switch
                    {
                        1 => "January",
                        2 => "February",
                        3 => "March",
                        _ => "Unknown"
                    };
                }
                #endregion

                #region  Problem 9
                int[] searchArr = { 5, 2, 8, 2, 9 };
                Array.Sort(searchArr);

                Console.WriteLine(Array.IndexOf(searchArr, 2));
                Console.WriteLine(Array.LastIndexOf(searchArr, 2));
                #endregion

                #region  Problem 10
                int[] sumArr = { 10, 20, 30 };
                int forSum = 0;
                int foreachSum = 0;

                for (int i = 0; i < sumArr.Length; i++)
                {
                    forSum += sumArr[i];
                }

                foreach (int num in sumArr)
                {
                    foreachSum += num;
                }
                #endregion

                #region  Problem 2 - 3
                Console.Write("Enter a day number (1-7): ");
                if (int.TryParse(Console.ReadLine(), out int dayNumber))
                {
                    if (Enum.IsDefined(typeof(DayOfWeek), dayNumber))
                    {
                        DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), dayNumber.ToString());
                        Console.WriteLine(day);
                    }
                    else
                    {
                        Console.WriteLine("Value is outside the range of 1 to 7.");
                    }
                }
                #endregion
            }
        }
    }
