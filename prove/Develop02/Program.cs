using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Welcome to myJournal Made Easy");
        Console.WriteLine("<< Please choose an action");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("Enter just the number of the action.");
        string userEntry = Console.ReadLine();
        int userEntryConverted = int.Parse(userEntry);

        if (userEntryConverted == 1)
        {   
            //Creating a list and adding the promp questions to the list
            List<string> promptQuestion = new List<string>();
            promptQuestion.Add("Who was the most interesting person I interacted with today?");
            promptQuestion.Add("What was the best part of my day?");
            promptQuestion.Add("How did I see the hand of the Lord in my life today?");
            promptQuestion.Add("What was the strongest emotion I felt today?");
            promptQuestion.Add("If I had one thing I could do over today, what would it be?");

            //Creating a new object for the random class
            Random randomQuestionGenerator = new Random();

            //counting the number of items in the promptQuestion list(python would have been len())
            int countedItems = promptQuestion.Count;

            //getting a random index from the list
            int index = randomQuestionGenerator.Next(countedItems);

            //calling the promptQuestion list and using the index to pull out the question and displaying them to the terminal window
            Console.WriteLine(promptQuestion[index]);

            //getting the users reply
            string prompAnswer = Console.ReadLine();


            Entry getEntry = new Entry();
            getEntry._write = prompAnswer;
        }

        else if (userEntryConverted == 2)
        {
            Console.WriteLine("Yiee you chose two as an answer");
        }
    }
}