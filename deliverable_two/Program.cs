using System;

namespace deliverable_two
{
    class Program
    {
        static void Main(string[] args)
        {
            int HelloCount = 0;
            int SupCount = 0;
            int HelloThereCount = 0;
            string Answer = "";

            while (Answer.ToLower() != "bye")
            {
                Console.WriteLine("What would you like to say to the bot? ");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "hello")
                {
                    if (HelloCount < 1)
                    {
                        Console.WriteLine("Hi, good to see you.");
                    }
                    HelloCount++;
                }
                else if (userInput.ToLower() == "sup")
                {
                    if (SupCount < 1)
                    {
                        Console.WriteLine("I am good.");
                    }
                    SupCount++;

                }
                else if (userInput.ToLower() == "hello there")
                {
                    if (HelloThereCount < 1)
                    {
                        Console.WriteLine("General Kenobi");
                    }
                    HelloThereCount++;

                }

                else if (userInput.ToLower() == "bye")
                {
                    Console.WriteLine("Good Bye!");
                    Answer = "bye";
                }


                if (HelloCount > 1 || SupCount > 1 || HelloThereCount > 1)
                {
                    if (Answer != "bye")
                    {
                     Console.WriteLine("I'm sorry but you have already said that.");
                    }
                
                }
            }
        }
    }
}