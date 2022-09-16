class LearnArrays
{
    static void Main(string[] args)
    {
        int[] luckyNumbers = { 5, 6, 3, 9, 1, 4, 34, 65, 10, 98 };

        Console.WriteLine(luckyNumbers[3]);

        for (int i = 0; i < luckyNumbers.Length; i++)
        {
            luckyNumbers[i] += 1;
            Console.WriteLine(luckyNumbers[i]);
        }

        string[] friends = new string[11];
         
    }
}