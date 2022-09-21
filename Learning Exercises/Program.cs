using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Drawing;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Learning_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a bool variable and declare true!
            bool appRun = true;

            // Do this while the loop is running.
            do
            {

                // if theres an error in the try block of code then catch method will execute below
                try
                {
                    Console.WriteLine(" Here is a list of all your exercises!");
                    Console.WriteLine(" Pick one by typing the exercise number");
                    Console.WriteLine(string.Empty);
                    ExerciseMenu();
                    Console.ForegroundColor = ConsoleColor.Gray;

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Exercise1();
                            break;

                        case "2":
                            Exercise2();
                            break;

                        case "3":
                            Exercise3();
                            break;

                        case "4":
                            Exercise4();
                            break;

                        case "5":
                            Exercise5();
                            break;

                        case "6":
                            Exercise6();

                            break;

                        case "7":
                            Exercise7();

                            break;

                        case "8":
                            Exercise8();

                            break;

                        case "9":
                            Exercise9();

                            break;

                        case "10":
                            Exercise10();

                            break;

                        case "11":
                            Exercise11();

                            break;

                        case "12":
                            Exercise12();

                            break;

                        case "13":
                            Exercise13();

                            break;

                        case "e":
                            appRun = false;

                            break;

                        default:
                            Console.WriteLine("I don't know what you want!");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine(string.Empty);
                    Console.WriteLine("\tHit any key to continue.....");
                    Console.ReadKey();
                    Console.Clear();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }

            while (appRun);
            {

            }

            static void Exercise1()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                string firstName = "Marco";
                string lastName = "Jankovic";
                Console.WriteLine($"\tHello {firstName} {lastName}! I'm glad to inform you that you are the test subject of my very first assignment!");
            }

            static void Exercise2()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                var dateNow = DateTime.Now;
                var dateTomorrow = dateNow.AddDays(1).ToString("yyyy-MM-dd");
                var dateYesterday = dateNow.AddDays(-1).ToString("yyyy-MM-dd");
                Console.WriteLine($"\tTodays date is: {dateNow} \n\tTomorrows date is: {dateTomorrow} \n\tYesterdays date was: {dateYesterday}");
            }

            static void Exercise3()
            {
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.Write($"\tEnter your first name:");
                string? firstName = Console.ReadLine();

                Console.Write($"\tEnter your last name:");
                string? lastName = Console.ReadLine();

                Console.ResetColor();
                Console.WriteLine($"\tYour name is: {firstName} And your last name is: {lastName}");

            }

            static void Exercise4()
            {
                string str = "\tThe quick fox Jumped Over the DOG";
                // Replaces the quick with brown
                str = str.Replace("quick", "brown");
                // Insert at index 30, count from 0 and even whitespace(space) counts as an index.
                str = str.Insert(30, " lazy");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(str.ToLower());
            }

            static void Exercise5()
            {
                string str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
                Console.ForegroundColor = ConsoleColor.Blue;

                string newString = str.Substring(str.IndexOf("["));

                newString = newString.Remove(newString.IndexOf("2"), 4);

                newString = newString.Insert(newString.IndexOf("]"), ",6,7,8,9,10");


                Console.WriteLine($"\t{newString}");


            }

            static void Exercise6()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\tEnter your first number: ");
                double firstNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("\tEnter your second number: ");
                double secondNumber = Convert.ToInt32(Console.ReadLine());


                while (secondNumber == 0)

                {
                    Console.WriteLine("Please enter a number that is not 0:");
                    secondNumber = Convert.ToInt32(Console.ReadLine());
                }

                {
                    Console.WriteLine("");
                }

                switch (firstNumber.CompareTo(secondNumber))
                {
                    case 1:
                        Console.WriteLine("{0} is greater than {1}", firstNumber, secondNumber);
                        break;

                    case 2:
                        Console.WriteLine("{0} is equal than {1}", firstNumber, secondNumber);
                        break;

                    case 3:
                        Console.WriteLine("{0} is greater than {1}", secondNumber, firstNumber);
                        break;
                }


                Console.WriteLine("\t" + firstNumber + " + " + secondNumber + " = " + (firstNumber + secondNumber));
                Console.WriteLine("\t" + firstNumber + " - " + secondNumber + " = " + (firstNumber - secondNumber));
                Console.WriteLine("\t" + firstNumber + " * " + secondNumber + " = " + (firstNumber * secondNumber));
                Console.WriteLine("\t" + firstNumber + " / " + secondNumber + " = " + (firstNumber / secondNumber));
            }

            static void Exercise7()
            {

            }

            static void Exercise8()
            {

            }

            static void Exercise9()
            {

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\tWhat is your name? : "); // ask name
                string? userInput = Console.ReadLine();  // stores user input in variable
                Console.Write($"\tHello: {userInput}, What is your birth year: "); // prints your name and ask for birth
                string? birthYear = (Console.ReadLine()); // store your birthyear in birthyear variable


                int age = int.Parse(birthYear); // parse string into an int and store in age variable

                age = DateTime.Now.Year - age;

                if (age >= 18)
                {
                    Console.WriteLine("\tDo you want to order a beer?");
                    Console.WriteLine("\tY/N");
                    string? order = Console.ReadLine();

                    if (order == "y" || order == "Y")
                    {
                        Console.WriteLine("\tA cold corona it is!");
                    }
                    else if (order == "n" || order == "N")
                    {
                        Console.WriteLine("\tDo you want a coke instead?");
                        Console.WriteLine("\tY/N");
                        string? answer = Console.ReadLine();

                        if (answer == "y" || answer == "Y")
                        {
                            Console.WriteLine("\tA cold coke it is!");
                        }
                        else
                        {
                            Console.WriteLine("\tNo order options are available!");
                        }
                    }
                }
                else if (age < 18)
                {
                    Console.WriteLine("\t Do you want to order a coke?");
                    Console.WriteLine("\tY/N");
                    string? answer = Console.ReadLine();

                    if (answer == "y" || answer == "Y")
                    {
                        Console.WriteLine("\tA cold coke it is!");
                    }
                    else if (answer == "n" || answer == "N")
                    {
                        Console.WriteLine("\tNo order options are available!");
                    }
                }
            }
        }

        static void Exercise10()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\tChoose beetween 1, 2 or 3!");
            int pick = Convert.ToInt32(Console.ReadLine());

            switch (pick)
            {

                case 1:
                    method1();
                    break;

                case 2:
                    Console.Write("\t Error!");
                    break;

                case 3:
                    Console.WriteLine(Console.ForegroundColor.ToString());  //Test foreground color before change

                    if (Console.ForegroundColor == ConsoleColor.Green)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else { Console.ForegroundColor = ConsoleColor.Green; }

                    Console.WriteLine(Console.ForegroundColor.ToString());  //Test foreground color after change
                    break;
            }

            static void method1()
            {
                Console.Write("\tPick your first number: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("\tPick your second number: ");
                int b = Convert.ToInt32(Console.ReadLine());

                if (b == 0)
                {
                    Console.WriteLine("\tCannot divide with 0");
                }
                else if (b != 0)
                {
                    Console.WriteLine("\tThe sum is: " + a / b);
                }
            }
        }

        static void Exercise11()
        {

        }

        static void Exercise12()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 1; i < 10; i++)
            {

                for (int j = 1; j < 10; j++)
                {

                    Console.Write($"{i * j + "\t"}");
                }
                Console.WriteLine();
            }
        }

        static void Exercise13()
        {

        }



        static void ExerciseMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\tExercise 1");
            Console.Write("\tExercise 2");
            Console.Write("\tExercise 3");
            Console.Write("\tExercise 4");
            Console.WriteLine("\tExercise 5");
            Console.Write("\tExercise 6");
            Console.Write("\tExercise 7");
            Console.Write("\tExercise 8");
            Console.Write("\tExercise 9");
            Console.WriteLine("\tExercise 10");
            Console.Write("\tExercise 11");
            Console.Write("\tExercise 12");
            Console.Write("\tExercise 13");
            Console.Write("\tExercise 14");
            Console.WriteLine("\tExercise 15");
            Console.Write("\tExercise 16");
            Console.Write("\tExercise 17");
            Console.Write("\tExercise 18");
            Console.Write("\tExercise 19");
            Console.WriteLine("\tExercise 20");
            Console.Write("\tExercise 21");
            Console.Write("\tExercise 22");
            Console.Write("\tExercise 23");
            Console.Write("\tExercise 24");
            Console.WriteLine("\tExercise 25");
            Console.Write("\tExercise 26");
            Console.Write("\tExercise 27");
            Console.Write("\tExercise 28");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\tPress E to Exit!");
            Console.WriteLine("");
        }
    }
}