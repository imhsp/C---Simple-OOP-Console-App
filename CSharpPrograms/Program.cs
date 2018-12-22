/*using System;

namespace CSharpPrograms
{
    class Program
    {

        static void Main(string[] args)
        {
            String option = "";
            double value;

            while (!option.Equals("4"))
            {
                Console.WriteLine("");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Main Menu");
                Console.WriteLine("1. Square root");
                Console.WriteLine("2. Floor value");
                Console.WriteLine("3. Absolute value");
                Console.WriteLine("4. Exit");

                Console.Write("\nEnter the Operation you want to perform : ");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        value = Input();
                        Console.WriteLine("Square root of {0} is : {1}", value, Math.Sqrt(value));
                        break;
                    case "2":
                        value = Input();
                        Console.WriteLine("Floor value of {0} is : {1}", value, Math.Floor(value));
                        break;
                    case "3":
                        value = Input();
                        Console.WriteLine("Absolute root of {0} is : {1}", value, Math.Abs(value));
                        break;
                    case "4":
                        Console.WriteLine("Program Exited! bye bye");
                        break;
                    default:
                        Console.WriteLine("Wrong option selected, Try Again!");
                        break;
                }

            }
        }
        public static double Input()
        {
            Console.Write("\nEnter a number: ");
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}*/
