using System;

class Program
{
    static void Main()
    {
        var scriptures = new List<Scripture>
        {
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.")
        };

        // Creativity: This version adds a progress counter and lets the user practice multiple scriptures in one run.
        foreach (Scripture scripture in scriptures)
        {
            RunScripture(scripture);

            Console.WriteLine();
            Console.WriteLine("Press Enter to continue to the next scripture or type 'quit' to exit.");
            string? input = Console.ReadLine();
            if (input != null && input.Trim().ToLower() == "quit")
            {
                break;
            }
        }
    }

    static void RunScripture(Scripture scripture)
    {
        Console.Clear();
        Console.WriteLine("Press Enter to hide the next word. Type 'quit' to exit.");
        Console.WriteLine();

        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine($"Progress: {scripture.GetProgress()}");
            Console.WriteLine();

            string? input = Console.ReadLine();
            if (input != null && input.Trim().ToLower() == "quit")
            {
                return;
            }

            scripture.HideNextWord();
            Console.Clear();
        }

        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("All words are hidden. Great job!");
        Console.WriteLine();
        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
    }
}
