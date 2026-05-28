namespace Krokodillespillet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int points = 0;
            bool isRunning = true;

            Console.WriteLine("Welcome to the Crocodile Game!");
            Console.WriteLine("Type > if the first number is larger than the second number.");
            Console.WriteLine("Type < if the second number is larger than the first number.");
            Console.WriteLine("Type = if they are equal.");
            Console.WriteLine("Type anything else to stop the game.");
            Console.WriteLine("\nPress Enter to start the game...");
            Console.ReadLine();

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine($"Points: {points}");

                int number1 = rand.Next(1, 12);
                int number2 = rand.Next(1, 12);

                Console.WriteLine($"\n{number1} _ {number2}");
                string answer = Console.ReadLine();

                if (answer != ">" && answer != "<" && answer != "=")
                {
                    isRunning = false;
                    Console.Clear();
                    Console.WriteLine($"Game over! You ended with {points} points.");
                }
                else if ((number1 > number2 && answer == ">") ||
                         (number1 < number2 && answer == "<") ||
                         (number1 == number2 && answer == "="))
                {
                    points++;
                    Console.WriteLine("\nCorrect answer! :D");
                    Thread.Sleep(1000);
                }
                else
                {
                    points--;
                    Console.WriteLine("\nWrong answer. :(");
                    Thread.Sleep(1000);
                }
            }
        }
    }
}