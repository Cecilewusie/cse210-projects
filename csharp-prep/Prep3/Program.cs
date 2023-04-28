using System;

class Program
{
    static void Main(string[] args)
    {    
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);  


        int convertedGuessNumber = 0;

        while (convertedGuessNumber != magicNumber)
        {   
            Console.Write("what is your guess: ");
            string guessNumber = Console.ReadLine();
            convertedGuessNumber = int.Parse(guessNumber);            

            if (convertedGuessNumber < magicNumber)
            {
                Console.WriteLine("guess higher");
            }
            else if (convertedGuessNumber > magicNumber)
            {
                Console.WriteLine("guess lower");
            }
            else
            {
                Console.Write("You guessed it");
            }
        }

    }
}