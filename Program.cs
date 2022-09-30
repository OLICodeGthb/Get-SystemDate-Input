using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string for current day that will take the currentday from the system and parsing it to a string. 
            // Tostring was the only thing that kept me from completing this faster until I saw it on msft docs link
            string currentDay = DateTime.Today.DayOfWeek.ToString();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Please enter day of week: ");
            // Input variable for input
            string userInput = Console.ReadLine();

            // if statement that will see if the UserInput variable data matches the currentDay string data
            if (userInput == currentDay)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"The day of the week is correct, it is {currentDay}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"You have entered the wrong day of the week, you said {userInput} but it is actually {currentDay}");
            }
        }
    }   
}