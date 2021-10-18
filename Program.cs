using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runAgain = true;
            
            Console.WriteLine("Hello! What is your name");
            string userName = Console.ReadLine();

            do
            {
                bool invalidNumber = true;
                Console.Write($"{userName}, please enter a whole number between 1 and 100: ");
                int userNum = int.Parse(Console.ReadLine());

                while (invalidNumber == true)
                {
                    if (userNum > 100 || userNum < 1)
                    {
                        Console.WriteLine($"{userName}, we both know that's an invalid Number. Please try again!");
                        userNum = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        invalidNumber = false;
                    }
                }
                if (userNum % 2 == 0 && userNum > 1 && userNum < 25)
                {
                    Console.WriteLine("Even and less than 25");
                }
                else if (userNum % 2 == 0 && userNum > 25)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine($"{userNum} Odd");
                }
                Console.WriteLine($"Do you wish to go again, {userName}? Type No to exit the program. Any other input will run it again.");
                string userInput = Console.ReadLine();

                if (userInput.Trim().ToLower() == "no")
                {
                    runAgain = false;
                }

            } while (runAgain == true);

            Console.WriteLine($"Goodbye {userName}!");
           
        }
    }
}
