using Snake;
using Yinyang.Items;

namespace Yinyang.Data;

/// <summary>
/// Represents immutable static data for an item within the game.
/// </summary>
public sealed record ItemData : IKeyed
{
    private readonly YinyangData _yinyangData;

    /// <summary>
    /// Initializes a new instance of this class with the specified properties.
    /// </summary>
    /// <param name="key">The unique identifier of the data.</param>
    /// <param name="name">The display name of the item.</param>
    /// <param name="description">The brief description of the item.</param>
    /// <param name="types">The type(s) of the item.</param>
    /// <param name="price">The price of the item within the game's currency.</param>
    /// <param name="yinyangData"></param>
    public ItemData(string key, string name, string description, ItemTypes types, int price, YinyangData yinyangData)
    {
        ArgumentNullException.ThrowIfNull(key);
        ArgumentNullException.ThrowIfNull(name);
        ArgumentNullException.ThrowIfNull(description);
        ArgumentNullException.ThrowIfNull(yinyangData);

        Key = key;
        Name = name;
        Description = description;
        Types = types;
        Price = price;
        _yinyangData = yinyangData;
    }

    /// <inheritdoc />
    public string Key { get; }

    /// <summary>
    /// Gets the display name of the item.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Gets the brief description of the item.
    /// </summary>
    public string Description { get; }

    /// <summary>
    /// Gets the type(s) of the item.
    /// </summary>
    public ItemTypes Types { get; }

    /// <summary>
    /// Gets the price of the item within the game's currency.
    /// </summary>
    public int Price { get; }
}
