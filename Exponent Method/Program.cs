namespace ExponentMethod
{
    class ExponentMethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetPow(6, 3));
        }

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result *= baseNum;
            }

            return result;
        }
    }
}