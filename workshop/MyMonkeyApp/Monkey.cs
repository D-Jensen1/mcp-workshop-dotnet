namespace MyMonkeyApp;

// Represents a monkey with its characteristics and information.
public class Monkey
{
    // Gets or sets the name of the monkey.
    public required string Name { get; set; }

    // Gets or sets the location where the monkey is found.
    public required string Location { get; set; }

    // Gets or sets detailed information about the monkey.
    public required string Details { get; set; }

    // Gets or sets the URL or path to the monkey's image.
    public required string Image { get; set; }

    // Gets or sets the population count of the monkey species.
    public required int Population { get; set; }
}
