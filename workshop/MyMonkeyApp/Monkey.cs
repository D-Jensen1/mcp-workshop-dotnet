namespace MyMonkeyApp;

/// <summary>
/// Represents a monkey with its characteristics and information.
/// </summary>
public class Monkey
{
    /// <summary>
    /// Gets or sets the name of the monkey.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Gets or sets the location where the monkey is found.
    /// </summary>
    public required string Location { get; set; }

    /// <summary>
    /// Gets or sets detailed information about the monkey.
    /// </summary>
    public required string Details { get; set; }

    /// <summary>
    /// Gets or sets the URL or path to the monkey's image.
    /// </summary>
    public required string Image { get; set; }

    /// <summary>
    /// Gets or sets the population count of the monkey species.
    /// </summary>
    public required int Population { get; set; }
}
