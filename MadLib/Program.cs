class MadLib
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a color: ");
        string color = Console.ReadLine();

        Console.Write("Please enter a plural noun: ");
        string pluralNoun = Console.ReadLine();

        Console.Write("Please enter a noun: ");
        string noun = Console.ReadLine();

        Console.Write("Please enter a pronoun: ");
        string pronoun = Console.ReadLine();

        Console.Write("Please enter an adverb: ");
        string adverb = Console.ReadLine();

        Console.Write("Please enter another noun: ");
        string noun2 = Console.ReadLine();

        Console.Write("Please enter another pronoun: ");
        string pronoun2 = Console.ReadLine();

        Console.WriteLine($"Roses are {color}");
        Console.WriteLine($"{pluralNoun} are blue");
        Console.WriteLine($"They {noun}");
        Console.WriteLine($"So {pronoun} {adverb} {noun2} {pronoun2}");
    }
}