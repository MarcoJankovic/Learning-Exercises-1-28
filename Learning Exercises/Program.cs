using Microsoft.VisualBasic;
using System;
using System.Drawing;
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


                            break;

                        case "25":
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
                
            }

            static void Exercise6()
            {

            }

            static void ExerciseMenu()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tExercise 1");
                Console.WriteLine("\tExercise 2");
                Console.WriteLine("\tExercise 3");
                Console.WriteLine("\tExercise 4");
                Console.WriteLine("\tExercise 5");
                Console.WriteLine("\tExercise 6");
                Console.WriteLine("\tExercise 7");
                Console.WriteLine("\tExercise 8");
                Console.WriteLine("\tExercise 9");
                Console.WriteLine("\tExercise 10");
            }
        }
    }
}