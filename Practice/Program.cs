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
            Console.WriteLine("Please guess the number between 1 and 100");
            int guess = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            int guesses = 1;

            while (guess != randomNumber)
            {
                if (guess < randomNumber)
                {
                    Console.WriteLine("Please guess a higher number");
                    guess = Convert.ToInt32(Console.ReadLine());
                    guesses++;
                }
                else if (guess > randomNumber) 
                {
                
                    Console.WriteLine("Please guess a lower number");
                    guess = Convert.ToInt32(Console.ReadLine());
                    guesses++;
                }

            }
            Console.WriteLine(guess + " was the correct number, it took you " + guesses + " guesses.");
            Console.ReadLine();
        }
    }
}
