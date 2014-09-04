using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_That_Number_
{
    class Program
    {
        //Call the variables in BEFORE the main funtion so the work continuously throughout the loop
        public static int numGuesses = 0;
        //Generate a random number before the main function so it doesn't choose a new number for every loop
        public static Random rng = new Random();
        //pick a random number between 1-100
        public static int comNum = rng.Next(1, 101);

        static void Main(string[] args)
        {
            //call the function
            Console.WriteLine("Guess A Number!");
            //Do readline so the user can guess a number
            string input = Console.ReadLine();

            //use parse to change the users string into a intagerr
            GuessThatNumber(comNum, int.Parse(input));
            Console.ReadKey();
        }

        static void GuessThatNumber(int comNum, int number)
        {
            //Create a While Loop; while the user has not guessed the random number, allow the user to keep guessing
            bool guess = false;

            //Run this loop while the guess is false
            while (guess == false)
            {
                if (number == comNum)
                {
                    //Every time the user guesses a number add one to the number of guesses
                    numGuesses++;
                    //Write congrats to the if the user guesses the write number
                    Console.WriteLine("Congratulations!! You've Guessed The Correct Number!");
                    //tell the user how many guesses it took them
                    Console.WriteLine("It took you " + numGuesses + " guesses to guess the correct number!");
                    guess = true;
                    //change the boolean to true i the user guessed it write
                    break;
                }
                else if (number < comNum)
                {
                    //add the total number of guesses
                    numGuesses++;
                    //tell the user to try again
                    Console.WriteLine("I'm Sorry!! You've Guessed Too Low! Try Again!");
                    GuessThatNumber(comNum, int.Parse(Console.ReadLine()));
                    break;
                }
                else
                {
                    //count the number of guesses
                    numGuesses++;
                    //tell the user to guess again
                    Console.WriteLine("I'm Sorry!! You've guessed Too High! Try Again!");
                    GuessThatNumber(comNum, int.Parse(Console.ReadLine()));
                    break;
                }

            }
        }
    }
}
