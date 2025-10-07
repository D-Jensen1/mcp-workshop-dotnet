namespace MyMonkeyApp;

/// <summary>
/// Static helper class for managing monkey data and operations.
/// </summary>
public static class MonkeyHelper
{
    private static int _randomMonkeyAccessCount = 0;
    private static readonly List<Monkey> _monkeys = new()
    {
        new Monkey
        {
            Name = "Baboon",
            Location = "Africa & Asia",
            Details = "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/baboon.jpg",
            Population = 10000
        },
        new Monkey
        {
            Name = "Capuchin Monkey",
            Location = "Central & South America",
            Details = "The capuchin monkeys are New World monkeys of the subfamily Cebinae. They are readily identified as the 'organ grinder' monkey.",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/capuchin.jpg",
            Population = 23000
        },
        new Monkey
        {
            Name = "Blue Monkey",
            Location = "Central and East Africa",
            Details = "The blue monkey or diademed monkey is a species of Old World monkey native to Central and East Africa.",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/blue.jpg",
            Population = 12000
        },
        new Monkey
        {
            Name = "Squirrel Monkey",
            Location = "Central & South America",
            Details = "The squirrel monkeys are the New World monkeys of the genus Saimiri. They are the only genus in the subfamily Saimiriinae.",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/squirrel.jpg",
            Population = 11000
        },
        new Monkey
        {
            Name = "Golden Lion Tamarin",
            Location = "Brazil",
            Details = "The golden lion tamarin, also known as the golden marmoset, is a small New World monkey of the family Callitrichidae.",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/golden.jpg",
            Population = 1000
        },
        new Monkey
        {
            Name = "Howler Monkey",
            Location = "South America",
            Details = "Howler monkeys are among the largest of the New World monkeys. They are famous for their loud howls, which can travel three miles through dense forest.",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/howler.jpg",
            Population = 8000
        },
        new Monkey
        {
            Name = "Japanese Macaque",
            Location = "Japan",
            Details = "The Japanese macaque, also known as the snow monkey, is a terrestrial Old World monkey species that is native to Japan.",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/japanese.jpg",
            Population = 114000
        },
        new Monkey
        {
            Name = "Mandrill",
            Location = "Southern Cameroon, Gabon, Equatorial Guinea, and Congo",
            Details = "The mandrill is a primate of the Old World monkey family. It is one of two species assigned to the genus Mandrillus.",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/mandrill.jpg",
            Population = 7000
        },
        new Monkey
        {
            Name = "Proboscis Monkey",
            Location = "Borneo",
            Details = "The proboscis monkey is a reddish-brown arboreal Old World monkey with an unusually large nose.",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/proboscis.jpg",
            Population = 7000
        },
        new Monkey
        {
            Name = "Red-shanked douc",
            Location = "Vietnam",
            Details = "The red-shanked douc is a species of Old World monkey, among the most colourful of all primates.",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/douc.jpg",
            Population = 1300
        }
    };

    /// <summary>
    /// Gets all available monkeys.
    /// </summary>
    /// <returns>A read-only list of all monkeys.</returns>
    public static IReadOnlyList<Monkey> GetMonkeys()
    {
        return _monkeys.AsReadOnly();
    }

    /// <summary>
    /// Finds a monkey by its name (case-insensitive).
    /// </summary>
    /// <param name="name">The name of the monkey to find.</param>
    /// <returns>The monkey if found; otherwise, null.</returns>
    public static Monkey? GetMonkeyByName(string name)
    {
        return _monkeys.FirstOrDefault(m => 
            m.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// Gets a random monkey from the collection and increments the access count.
    /// </summary>
    /// <returns>A randomly selected monkey.</returns>
    public static Monkey GetRandomMonkey()
    {
        _randomMonkeyAccessCount++;
        var random = new Random();
        var index = random.Next(_monkeys.Count);
        return _monkeys[index];
    }

    /// <summary>
    /// Gets the number of times a random monkey has been picked.
    /// </summary>
    /// <returns>The access count for random monkey picks.</returns>
    public static int GetRandomMonkeyAccessCount()
    {
        return _randomMonkeyAccessCount;
    }
}
