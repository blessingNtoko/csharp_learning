namespace Array2D
{
    class Array2D
    {
        static void Main(string[] args)
        {
            int[,] numberGrid =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
            };

            Console.WriteLine(numberGrid[0,0]);
        }
    }
} 