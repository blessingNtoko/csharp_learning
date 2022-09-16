namespace WhilingAbout
{
    class Whiling
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int index = random.Next(0, 10);
            int guessedNum = -1;


            for (int i = 5; guessedNum != index; i--)
            {
                Console.WriteLine($"Guesses left: {i}");
                if (i == 0)
                {
                    Console.WriteLine("You are out of guesses");
                    return;
                }

                Console.Write("Guess the number: ");
                guessedNum = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Well done :D");
        }
    }
}