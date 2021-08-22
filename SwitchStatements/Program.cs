using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What is your favorite school subject?");
            string userAnswer = Console.ReadLine();

            switch (userAnswer)
            {
                case "Math":
                    Console.WriteLine("Math is rad");
                    break;
                case "English":
                    Console.WriteLine("English is cool");
                    break;
                case "Recess":
                    Console.WriteLine("Recess is the best subject");
                    break;
                case "Lunch":
                    Console.WriteLine("Lunch is second best");
                    break;
                case "History":
                    Console.WriteLine("History is awesome");
                    break;
                default:
                    Console.WriteLine("Pick a school subject");
                    break; 
            }

        }
    }
}
