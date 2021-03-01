using System;

/* We have studied ternary operators and their usage so here is a small challenge for you. Let's create a small application that takes a temperature value as input and checks if the input is an integer or not.

If the input value is not an integer value, it should print to the console "Not a valid Temperature".

And if the input value is the valid integer then it should work as mentioned below.

If input temperature value is <=15 it should write "it is too cold here" to the console.

If input temperature value is >= 16 and is <=28 it should write "it is ok" to the console.

If the input temperature value is > 28 it should write "it is hot here" to the console.

Make sure to use ternary operators and not if statements to check for the three conditions, however you can use if statement for the other conditions like to check if the entered value is a valid integer or not. */
 

namespace TernaryChallenge
{
    class Program
    {
        static int temperature;
        static void Main(string[] args)
        {
            TakeUserInput();
            Console.WriteLine(temperature <= 15 ? "It is too cold here." : temperature > 28 ? "It is hot here." : "It is ok.");
        }

        public static void TakeUserInput()
        {
            Console.WriteLine("Please enter the temperature:");
            string userInput = Console.ReadLine();
            bool success = int.TryParse(userInput, out temperature);
            if (success)
            {
                Console.WriteLine("The temperature is {0} degrees.", temperature);
            }
            else
            {
                Console.WriteLine("Please enter a valid temperature.");
                TakeUserInput();
            }
        }
    }
}
