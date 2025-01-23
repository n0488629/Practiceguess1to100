using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
                // Prompt user for their guess
                Console.WriteLine("Please guess the number between 1 and 100");
                // Convert users input to a variable integer
                int guess = Convert.ToInt32(Console.ReadLine());
                // Create random seed
                Random random = new Random();
                // Initialize randomNumber variable for a number between 1 and 100
                int randomNumber = random.Next(1, 101);
                // intialize guess increment counter
                int guesses = 1;

            while (guess != randomNumber) // While loop while the guess is incorrect
            {
                    if (guess < randomNumber) // If guess is less than randomly generated number
                    {
                        // Prompt user for higher number
                        Console.WriteLine("Please guess a higher number");
                        // convert users input and replace old guess with new guess
                        guess = Convert.ToInt32(Console.ReadLine());
                        // increment guesses counter
                        guesses++;
                    }
                    else if (guess > randomNumber) // If guess is higher than randomly generated number
                    {
                        // Prompt user to enter a lower number
                        Console.WriteLine("Please guess a lower number");
                        // convert users input and replace old guess with new guess
                        guess = Convert.ToInt32(Console.ReadLine());
                        // increment guesses counter
                        guesses++;
                    }

}
// Show correct guess and how many guesses it took
Console.WriteLine(guess + " was the correct number, it took you " + guesses + " guesses.");
// Pause screen for user
Console.ReadLine();
        }
    }
}
