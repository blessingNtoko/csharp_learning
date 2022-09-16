namespace Methods
{
    class Methodical
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            SayHi(Console.ReadLine());
        }

        static void SayHi(string name = "User")
        {
            Console.WriteLine($"Hello {name}");

        }

        static double cubeNum(double num)
        {
            return Math.Pow(num, 3);
        }
    }
}