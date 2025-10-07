using MyMonkeyApp;

/// <summary>
/// Main program for the Monkey Console Application.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        while (true)
        {
            DisplayMenu();
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ListAllMonkeys();
                    break;
                case "2":
                    GetMonkeyByName();
                    break;
                case "3":
                    GetRandomMonkey();
                    break;
                case "4":
                    Console.WriteLine("\nThanks for visiting the monkey sanctuary! Goodbye! 🐵");
                    return;
                default:
                    Console.WriteLine("\nInvalid option. Please try again.");
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    /// <summary>
    /// Displays the welcome message with ASCII art.
    /// </summary>
    static void DisplayWelcome()
    {
        Console.Clear();
        DisplayRandomAsciiArt();
        Console.WriteLine("===========================================");
        Console.WriteLine("   Welcome to the Monkey Sanctuary! 🐵");
        Console.WriteLine("===========================================\n");
    }

    /// <summary>
    /// Displays the main menu options.
    /// </summary>
    static void DisplayMenu()
    {
        Console.WriteLine("\n--- Main Menu ---");
        Console.WriteLine("1. List all monkeys");
        Console.WriteLine("2. Get details for a specific monkey by name");
        Console.WriteLine("3. Get a random monkey");
        Console.WriteLine("4. Exit app");
        Console.Write("\nEnter your choice (1-4): ");
    }

    /// <summary>
    /// Lists all available monkeys.
    /// </summary>
    static void ListAllMonkeys()
    {
        Console.WriteLine("\n--- All Available Monkeys ---\n");
        var monkeys = MonkeyHelper.GetMonkeys();

        foreach (var monkey in monkeys)
        {
            DisplayMonkeyInfo(monkey);
            Console.WriteLine();
        }

        Console.WriteLine($"Total monkeys: {monkeys.Count}");
    }

    /// <summary>
    /// Gets details for a specific monkey by name.
    /// </summary>
    static void GetMonkeyByName()
    {
        Console.Write("\nEnter the monkey name: ");
        var name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Invalid name. Please try again.");
            return;
        }

        var monkey = MonkeyHelper.GetMonkeyByName(name);

        if (monkey != null)
        {
            Console.WriteLine("\n--- Monkey Details ---\n");
            DisplayMonkeyInfo(monkey);
        }
        else
        {
            Console.WriteLine($"\nMonkey '{name}' not found. Please check the spelling and try again.");
        }
    }

    /// <summary>
    /// Gets a random monkey from the collection.
    /// </summary>
    static void GetRandomMonkey()
    {
        var monkey = MonkeyHelper.GetRandomMonkey();
        var accessCount = MonkeyHelper.GetRandomMonkeyAccessCount();

        Console.WriteLine("\n--- Random Monkey Pick ---\n");
        DisplayMonkeyInfo(monkey);
        Console.WriteLine($"\nRandom monkey has been picked {accessCount} time(s).");
    }

    /// <summary>
    /// Displays detailed information about a monkey.
    /// </summary>
    /// <param name="monkey">The monkey to display.</param>
    static void DisplayMonkeyInfo(Monkey monkey)
    {
        Console.WriteLine($"Name:       {monkey.Name}");
        Console.WriteLine($"Location:   {monkey.Location}");
        Console.WriteLine($"Population: {monkey.Population:N0}");
        Console.WriteLine($"Details:    {monkey.Details}");
        Console.WriteLine($"Image:      {monkey.Image}");
    }

    /// <summary>
    /// Displays random ASCII art for visual appeal.
    /// </summary>
    static void DisplayRandomAsciiArt()
    {
        var random = new Random();
        var artIndex = random.Next(1, 4);

        switch (artIndex)
        {
            case 1:
                Console.WriteLine(@"
      __
  w  c(..)o   (
   \__(-)    __)
       /\   (
      /(_)___)
      w /|
       | \
      m  m
");
                break;
            case 2:
                Console.WriteLine(@"
       .='  '=.
      /      _\
     |  .--. /
     \  '--'
      /'-..-'\
     {/  .= Y =.\}
    `{/  /   |   \ \}
     |  (   |   ) |
     {  ;   |   ; }
      \  ;  |  ;  /
");
                break;
            case 3:
                Console.WriteLine(@"
    .-""-.
   /,..___\
  () {_____}
    (/-@-@-\)
    {`-=^=-'}
    {  `-'  }
     {     }
      `---'
");
                break;
        }
    }
}
