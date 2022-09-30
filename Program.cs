using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string for current day that will take the currentday from the system and parsing it to a string. 
            string currentDay = DateTime.Today.DayOfWeek.ToString();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Please enter day of week: ");
            // Input variable for input
            string userInput = Console.ReadLine();

            // if statement that will see if the UserInput variable data matches the currentDay string data
            // There is a much better method, perhaps using a boolean to see if it matches currentDay
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
